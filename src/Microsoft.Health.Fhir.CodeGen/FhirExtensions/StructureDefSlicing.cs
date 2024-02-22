﻿// <copyright file="StructureDefSlicing.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

using System.Collections.Generic;
using Hl7.Fhir.Model;
using Hl7.Fhir.Utility;
using Hl7.FhirPath.Sprache;
using Microsoft.Health.Fhir.CodeGen.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Microsoft.Health.Fhir.CodeGen.FhirExtensions;

public static class StructureDefSlicing
{
    /// <summary>Enumerates cg elements for slice in this collection.</summary>
    /// <param name="sd">         The SD to act on.</param>
    /// <param name="slicingEd">  The slicing ed.</param>
    /// <param name="sliceName">  Name of the slice.</param>
    /// <param name="includeRoot">(Optional) True to include, false to exclude the root.</param>
    /// <returns>
    /// An enumerator that allows foreach to be used to process cg elements for slice in this
    /// collection.
    /// </returns>
    public static IEnumerable<ElementDefinition> cgElementsForSlice(
        this StructureDefinition sd,
        ElementDefinition slicingEd,
        string sliceName,
        bool includeRoot = true)
    {
        string sliceId = $"{slicingEd.Path}:{sliceName}";
        return (sd.Snapshot?.Element.Any() ?? false)
            ? sd.Snapshot.Element.Where(e => e.ElementId.StartsWith(sliceId, StringComparison.Ordinal)).Skip(includeRoot ? 0 : 1)
            : sd.Differential.Element.Where(e => e.ElementId.StartsWith(sliceId, StringComparison.Ordinal)).Skip(includeRoot ? 0 : 1);
    }

    /// <summary>Enumerates cg discriminated values in this collection.</summary>
    /// <param name="sd">           The SD to act on.</param>
    /// <param name="slicingEd">    The slicing ed.</param>
    /// <param name="sliceName">    Name of the slice.</param>
    /// <param name="sliceElements">The slice elements.</param>
    /// <returns>
    /// An enumerator that allows foreach to be used to process cg discriminated values in this
    /// collection.
    /// </returns>
    public static IEnumerable<SliceDiscriminator> cgDiscriminatedValues(
        this StructureDefinition sd,
        DefinitionCollection dc,
        ElementDefinition slicingEd,
        string sliceName,
        IEnumerable<ElementDefinition> sliceElements)
    {
        List<SliceDiscriminator> result = new();

        if ((slicingEd.Slicing == null) ||
            (!slicingEd.Slicing.Discriminator.Any()))
        {
            return result;
        }

        // TODO(ginoc): I am not sure if I need to work about multiple sub-slices on a slice or not.  Should test.

        foreach (ElementDefinition.DiscriminatorComponent discriminator in slicingEd.Slicing.Discriminator)
        {
            //if (discriminator.Path.Contains("resolve()", StringComparison.Ordinal))
            //{
            //    Console.Write("");
            //}

            switch (discriminator.Type)
            {
                // pattern is the deprecated name for value
                case ElementDefinition.DiscriminatorType.Value:
                case ElementDefinition.DiscriminatorType.Pattern:
                    result.AddRange(SlicesForValue(dc, discriminator, slicingEd, sliceName, sliceElements));
                    break;

                case ElementDefinition.DiscriminatorType.Profile:
                    result.AddRange(SlicesForProfile(dc, discriminator, slicingEd, sliceName, sliceElements));
                    break;

                case ElementDefinition.DiscriminatorType.Type:
                    result.AddRange(SlicesForType(dc, discriminator, slicingEd, sliceName, sliceElements));
                    break;

                //default:
                //    break;
            }
        }

        return result;
    }

    /// <summary>Gets relative path.</summary>
    /// <param name="discriminatorPath">Full pathname of the discriminator file.</param>
    /// <returns>The relative path.</returns>
    private static string GetRelativePath(string discriminatorPath, out string postResolve)
    {
        if (discriminatorPath.Equals("$this", StringComparison.Ordinal))
        {
            postResolve = string.Empty;
            return string.Empty;
        }

        string path = discriminatorPath;
        postResolve = string.Empty;

        if (path.StartsWith("$this.", StringComparison.Ordinal))
        {
            path = discriminatorPath.Substring(5);
        }

        int resolveIndex = path.IndexOf("resolve()", StringComparison.Ordinal);

        if (resolveIndex != -1)
        {
            postResolve = path.Substring(resolveIndex + 9);

            if (postResolve.StartsWith('.'))
            {
                postResolve = postResolve.Substring(1);
            }

            path = path.Substring(0, resolveIndex);
        }

        if (string.IsNullOrEmpty(path) || path.Equals(".", StringComparison.Ordinal))
        {
            return string.Empty;
        }

        if (path.StartsWith('.'))
        {
            return path;
        }

        return "." + path;
    }

    /// <summary>Slices for type.</summary>
    /// <param name="dc">           The device-context.</param>
    /// <param name="discriminator">The discriminator.</param>
    /// <param name="slicingEd">    The slicing ed.</param>
    /// <param name="sliceName">    Name of the slice.</param>
    /// <param name="sliceElements">The slice elements.</param>
    /// <returns>A List&lt;SliceDiscriminator&gt;</returns>
    private static List<SliceDiscriminator> SlicesForType(
        DefinitionCollection dc,
        ElementDefinition.DiscriminatorComponent discriminator,
        ElementDefinition slicingEd,
        string sliceName,
        IEnumerable<ElementDefinition> sliceElements)
    {
        List<SliceDiscriminator> result = new();
        string relativePath = GetRelativePath(discriminator.Path, out string postResolve);

        string id = $"{slicingEd.Path}:{sliceName}{relativePath}";
        string path = $"{slicingEd.Path}{relativePath}";

        foreach (ElementDefinition ed in sliceElements.Where(e => e.Path.Equals(path, StringComparison.Ordinal)))
        {
            foreach (ElementDefinition.TypeRefComponent et in ed.Type ?? Enumerable.Empty<ElementDefinition.TypeRefComponent>())
            {
                result.Add(new()
                {
                    DiscriminatorType = (ElementDefinition.DiscriminatorType)discriminator.Type!,
                    Type = discriminator.Type.GetLiteral()!,
                    Path = ed.Path,
                    PostResovlePath = postResolve,
                    Id = ed.ElementId,
                    Value = new FhirString(et.Code),
                });
            }
        }

        if (result.Any())
        {
            return result;
        }

        if (!string.IsNullOrEmpty(relativePath))
        {
            // check for the last component of the path being a type
            id = $"{slicingEd.Path}:{sliceName}{relativePath}";
            string eType = id.Substring(id.LastIndexOf('.') + 1);
            id = id.Substring(0, id.LastIndexOf('.'));
            path = path.Substring(0, path.LastIndexOf('.'));

            foreach (ElementDefinition ed in sliceElements.Where(e => e.Path.Equals(path, StringComparison.Ordinal)))
            {
                bool found = false;

                if (ed.Type == null)
                {
                    continue;
                }

                foreach (ElementDefinition.TypeRefComponent t in ed.Type.Where(t => t.Code.Equals(eType)))
                {
                    result.Add(new()
                    {
                        DiscriminatorType = (ElementDefinition.DiscriminatorType)discriminator.Type!,
                        Type = discriminator.Type.GetLiteral()!,
                        Path = ed.Path,
                        PostResovlePath = postResolve,
                        Id = ed.ElementId,
                        Value = new FhirString(t.Code),
                    });
                    found = true;
                }

                if (found) { continue; }

                // TODO: not quite right - need to check for transitive slicing (see above)
                // if not found, check for 'commonly misused' types
                foreach (ElementDefinition.TypeRefComponent t in ed.Type.Where(t => (t.Code.Equals("BackboneElement", StringComparison.Ordinal) || t.Code.Equals("Element", StringComparison.Ordinal))))
                {
                    result.Add(new()
                    {
                        DiscriminatorType = (ElementDefinition.DiscriminatorType)discriminator.Type!,
                        Type = discriminator.Type.GetLiteral()!,
                        Path = ed.Path,
                        PostResovlePath = postResolve,
                        Id = ed.ElementId,
                        Value = new FhirString(t.Code),
                    });
                    found = true;
                }
            }
        }

        return result;
    }

    /// <summary>Slices for profile.</summary>
    /// <param name="dc">           The device-context.</param>
    /// <param name="discriminator">The discriminator.</param>
    /// <param name="slicingEd">    The slicing ed.</param>
    /// <param name="sliceName">    Name of the slice.</param>
    /// <param name="sliceElements">The slice elements.</param>
    /// <returns>A List&lt;SliceDiscriminator&gt;</returns>
    private static List<SliceDiscriminator> SlicesForProfile(
        DefinitionCollection dc,
        ElementDefinition.DiscriminatorComponent discriminator,
        ElementDefinition slicingEd,
        string sliceName,
        IEnumerable<ElementDefinition> sliceElements)
    {
        List<SliceDiscriminator> result = new();
        string relativePath = GetRelativePath(discriminator.Path, out string postResolve);

        string id = $"{slicingEd.Path}:{sliceName}{relativePath}";
        string path = $"{slicingEd.Path}{relativePath}";

        foreach (ElementDefinition ed in sliceElements.Where(e => e.Path.Equals(path, StringComparison.Ordinal)))
        //foreach (ElementDefinition ed in sliceElements.Where(e => e.ElementId.Equals(id, StringComparison.Ordinal)))
        {
            foreach (string profile in ed.Type?.SelectMany(t => t.Profile) ?? Enumerable.Empty<string>())
            {
                result.Add(new()
                {
                    DiscriminatorType = (ElementDefinition.DiscriminatorType)discriminator.Type!,
                    Type = discriminator.Type.GetLiteral()!,
                    Path = ed.Path,
                    PostResovlePath = postResolve,
                    Id = ed.ElementId,
                    Value = new FhirString(profile),
                });
                continue;
            }
        }

        if (result.Any())
        {
            return result;
        }

        if (!string.IsNullOrEmpty(relativePath))
        {
            // check for the last component of the path being a type
            id = $"{slicingEd.Path}:{sliceName}{relativePath}";
            string eType = id.Substring(id.LastIndexOf('.') + 1);
            id = id.Substring(0, id.LastIndexOf('.'));
            path = path.Substring(0, path.LastIndexOf('.'));

            foreach (ElementDefinition ed in sliceElements.Where(e => e.Path.Equals(path, StringComparison.Ordinal)))
            //foreach (ElementDefinition ed in sliceElements.Where(e => e.ElementId.Equals(id, StringComparison.Ordinal)))
            {
                bool found = false;

                if (ed.Type == null)
                {
                    continue;
                }

                foreach (ElementDefinition.TypeRefComponent t in ed.Type.Where(t => t.Code.Equals(eType) && t.Profile.Any()))
                {
                    result.Add(new()
                    {
                        DiscriminatorType = (ElementDefinition.DiscriminatorType)discriminator.Type!,
                        Type = discriminator.Type.GetLiteral()!,
                        Path = ed.Path,
                        PostResovlePath = postResolve,
                        Id = ed.ElementId,
                        Value = new FhirString(t.Profile.First()),
                    });
                    found = true;
                }

                if (found) { continue; }

                Console.Write("");

                // TODO: not quite right - need to check for transitive slicing (see above)
                result.AddRange(CheckTransitiveForValue(
                    dc,
                    ed.Type!.Where(t => t.Code.Equals("BackboneElement", StringComparison.Ordinal) || t.Code.Equals("Element", StringComparison.Ordinal)),
                    discriminator,
                    id,
                    relativePath,
                    slicingEd,
                    sliceName,
                    postResolve));

                //foreach (ElementDefinition.TypeRefComponent t in ed.Type.Where(t => (t.Code.Equals("BackboneElement", StringComparison.Ordinal) || t.Code.Equals("Element", StringComparison.Ordinal)) && t.Profile.Any()))
                //{
                //    result.Add(new()
                //    {
                //        Type = discriminator.Type.GetLiteral()!,
                //        Path = ed.Path,
                //        Id = ed.ElementId,
                //        Value = new FhirString(t.Profile.First()),
                //    });
                //}
            }
        }

        return result;
    }

    /// <summary>Discriminators for value.</summary>
    /// <param name="dc">           The device-context.</param>
    /// <param name="discriminator">The discriminator.</param>
    /// <param name="slicingEd">    The slicing ed.</param>
    /// <param name="sliceName">    Name of the slice.</param>
    /// <param name="sliceElements">The slice elements.</param>
    /// <returns>A List&lt;SliceDiscriminator&gt;</returns>
    private static List<SliceDiscriminator> SlicesForValue(
        DefinitionCollection dc,
        ElementDefinition.DiscriminatorComponent discriminator,
        ElementDefinition slicingEd,
        string sliceName,
        IEnumerable<ElementDefinition> sliceElements)
    {
        List<SliceDiscriminator> result = new();
        string relativePath = GetRelativePath(discriminator.Path, out string postResolve);

        string id = $"{slicingEd.Path}:{sliceName}{relativePath}";
        string path = $"{slicingEd.Path}{relativePath}";

        foreach (ElementDefinition ed in sliceElements.Where(e => e.Path.Equals(path, StringComparison.Ordinal)))
        //foreach (ElementDefinition ed in sliceElements.Where(e => e.ElementId.Equals(id, StringComparison.Ordinal)))
        {
            if (ed.Fixed != null)
            {
                result.Add(new()
                {
                    DiscriminatorType = (ElementDefinition.DiscriminatorType)discriminator.Type!,
                    Type = discriminator.Type.GetLiteral()!,
                    Path = ed.Path,
                    PostResovlePath = postResolve,
                    Id = ed.ElementId,
                    Value = ed.Fixed,
                });
                continue;
            }

            if (ed.Pattern != null)
            {
                result.Add(new()
                {
                    DiscriminatorType = (ElementDefinition.DiscriminatorType)discriminator.Type!,
                    Type = discriminator.Type.GetLiteral()!,
                    Path = ed.Path,
                    PostResovlePath = postResolve,
                    Id = ed.ElementId,
                    Value = ed.Pattern,
                });

                continue;
            }

            // check for references that cross resolve boundaries
            if (!string.IsNullOrEmpty(postResolve) && ed.Type.Any(t => t.Code.Equals("Reference", StringComparison.Ordinal)))
            {
                List<SliceDiscriminator> resolvedSlices = CheckResolvedTarget(
                    dc,
                    ed.Type!.Where(t => t.Code.Equals("Reference", StringComparison.Ordinal)),
                    discriminator,
                    postResolve,
                    ed.Path);

                if (resolvedSlices.Any())
                {
                    result.AddRange(resolvedSlices);
                    continue;
                }
            }
        }

        if (result.Any())
        {
            return result;
        }

        // check for extension URL, it is represented oddly
        if (discriminator.Path.Equals("url", StringComparison.Ordinal))
        {
            id = $"{slicingEd.Path}:{sliceName}";

            foreach (ElementDefinition ed in sliceElements.Where(e => e.ElementId.Equals(id, StringComparison.Ordinal)))
            {
                foreach (string profile in ed.Type?.Where(t => t.Code.Equals("Extension", StringComparison.Ordinal)).SelectMany(t => t.Profile) ?? Enumerable.Empty<string>())
                {
                    result.Add(new()
                    {
                        DiscriminatorType = (ElementDefinition.DiscriminatorType)discriminator.Type!,
                        Type = discriminator.Type.GetLiteral()!,
                        Path = ed.Path + ".url",
                        PostResovlePath = postResolve,
                        Id = ed.ElementId,
                        Value = new FhirString(profile),
                    });

                    continue;
                }
            }
        }

        if (result.Any())
        {
            return result;
        }

        if (!string.IsNullOrEmpty(relativePath))
        {
            // check for the last component of the path being a type
            id = $"{slicingEd.Path}:{sliceName}{relativePath}";
            string eType = id.Substring(id.LastIndexOf('.') + 1);
            id = id.Substring(0, id.LastIndexOf('.'));
            path = path.Substring(0, path.LastIndexOf('.'));

            foreach (ElementDefinition ed in sliceElements.Where(e => (e.Type != null) && e.Path.Equals(path, StringComparison.Ordinal)))
            //foreach (ElementDefinition ed in sliceElements.Where(e => (e.Type != null) && e.ElementId.Equals(id, StringComparison.Ordinal)))
            {
                bool found = false;

                // check for the specified type
                foreach (ElementDefinition.TypeRefComponent tr in ed.Type!.Where(t => t.Code.Equals(eType, StringComparison.Ordinal)))
                {
                    if (tr.Profile.Any())
                    {
                        result.Add(new()
                        {
                            DiscriminatorType = (ElementDefinition.DiscriminatorType)discriminator.Type!,
                            Type = discriminator.Type.GetLiteral()!,
                            Path = ed.Path,
                            PostResovlePath = postResolve,
                            Id = ed.ElementId,
                            Value = new FhirString(tr.Profile.First()),
                        });

                        continue;
                    }
                }

                if (found) { continue; }

                // check for a transitive slicing definition
                result.AddRange(CheckTransitiveForValue(
                    dc,
                    ed.Type!.Where(t => t.Code.Equals("BackboneElement", StringComparison.Ordinal) || t.Code.Equals("Element", StringComparison.Ordinal)),
                    discriminator,
                    id,
                    relativePath,
                    slicingEd,
                    sliceName,
                    postResolve));
            }
        }

        return result;
    }

    /// <summary>Check transitive.</summary>
    /// <param name="dc">            The device-context.</param>
    /// <param name="typeComponents">The type components.</param>
    /// <param name="discriminator"> The discriminator.</param>
    /// <param name="id">            The identifier.</param>
    /// <param name="relativePath">  Full pathname of the relative file.</param>
    /// <param name="slicingEd">     The slicing ed.</param>
    /// <param name="sliceName">     Name of the slice.</param>
    /// <returns>A List&lt;SliceDiscriminator&gt;</returns>
    private static List<SliceDiscriminator> CheckTransitiveForValue(
        DefinitionCollection dc,
        IEnumerable<ElementDefinition.TypeRefComponent> typeComponents,
        ElementDefinition.DiscriminatorComponent discriminator,
        string id,
        string relativePath,
        ElementDefinition slicingEd,
        string sliceName,
        string postResolve)
    {
        List<SliceDiscriminator> result = new();

        foreach (ElementDefinition.TypeRefComponent tr in typeComponents)
        {
            if (!tr.ProfileElement.Any())
            {
                continue;
            }

            foreach (Canonical? pe in tr.ProfileElement)
            {
                string? peName = pe?.GetExtensionValue<FhirString>(CommonDefinitions.ExtUrlEdProfileElement)?.Value ?? string.Empty;

                if (string.IsNullOrEmpty(peName))
                {
                    continue;
                }

                string profileUrl = pe?.Value ?? string.Empty;

                if (string.IsNullOrEmpty(profileUrl))
                {
                    continue;
                }

                // check to see if we can resolve the profile URL
                if ((!dc.ProfilesByUrl.TryGetValue(profileUrl, out StructureDefinition? transitive)) ||
                    (transitive == null))
                {
                    continue;
                }

                // see if we can find a matching element there
                string tId = $"{slicingEd.Path}:{sliceName}{relativePath}";
                if (transitive.cgTryGetElementById(tId, out ElementDefinition? tEd) && (tEd != null))
                {
                    if (tEd.Fixed != null)
                    {
                        result.Add(new()
                        {
                            DiscriminatorType = (ElementDefinition.DiscriminatorType)discriminator.Type!,
                            Type = discriminator.Type.GetLiteral()!,
                            Path = tEd.Path,
                            PostResovlePath = postResolve,
                            Id = tEd.ElementId,
                            Value = tEd.Fixed,
                        });
                        continue;
                    }

                    if (tEd.Pattern != null)
                    {
                        result.Add(new()
                        {
                            DiscriminatorType = (ElementDefinition.DiscriminatorType)discriminator.Type!,
                            Type = discriminator.Type.GetLiteral()!,
                            Path = tEd.Path,
                            PostResovlePath = postResolve,
                            Id = tEd.ElementId,
                            Value = tEd.Pattern,
                        });
                        continue;
                    }
                }

                // check for the last component of the path being a type
                string teType = tId.Substring(tId.LastIndexOf('.') + 1);
                tId = tId.Substring(0, tId.LastIndexOf('.'));

                if (transitive.cgTryGetElementById(tId, out tEd) && (tEd != null))
                {
                    // check for the specified type
                    foreach (ElementDefinition.TypeRefComponent tTr in tEd.Type!.Where(t => t.Code.Equals(teType, StringComparison.Ordinal)))
                    {
                        if (tTr.Profile.Any())
                        {
                            result.Add(new()
                            {
                                DiscriminatorType = (ElementDefinition.DiscriminatorType)discriminator.Type!,
                                Type = discriminator.Type.GetLiteral()!,
                                Path = tEd.Path,
                                PostResovlePath = postResolve,
                                Id = tEd.ElementId,
                                Value = new FhirString(tTr.Profile.First()),
                            });
                            continue;
                        }
                    }
                }
            }
        }

        return result;
    }

    /// <summary>Check resolved target.</summary>
    /// <param name="dc">            The device-context.</param>
    /// <param name="typeComponents">The type components.</param>
    /// <param name="discriminator"> The discriminator.</param>
    /// <param name="postResolve">   The post resolve.</param>
    /// <param name="sourcePath">    Full pathname of the source file.</param>
    /// <returns>A List&lt;SliceDiscriminator&gt;</returns>
    private static List<SliceDiscriminator> CheckResolvedTarget(
        DefinitionCollection dc,
        IEnumerable<ElementDefinition.TypeRefComponent> typeComponents,
        ElementDefinition.DiscriminatorComponent discriminator,
        string postResolve,
        string sourcePath)
    {
        List<SliceDiscriminator> result = new();

        foreach (ElementDefinition.TypeRefComponent tr in typeComponents)
        {
            if (!tr.TargetProfile.Any())
            {
                continue;
            }

            foreach (string tp in tr.TargetProfile)
            {
                // check to see if we can resolve the profile URL
                if ((!dc.ProfilesByUrl.TryGetValue(tp, out StructureDefinition? transitive)) ||
                    (transitive == null))
                {
                    continue;
                }

                // see if we can find a matching element there
                string tId = string.Join('.', transitive.Type, postResolve);
                if (transitive.cgTryGetElementById(tId, out ElementDefinition? tEd) && (tEd != null))
                {
                    if (tEd.Fixed != null)
                    {
                        result.Add(new()
                        {
                            DiscriminatorType = (ElementDefinition.DiscriminatorType)discriminator.Type!,
                            Type = discriminator.Type.GetLiteral()!,
                            Path = sourcePath,
                            PostResovlePath = postResolve,
                            Id = tEd.ElementId,
                            Value = tEd.Fixed,
                        });
                        continue;
                    }

                    if (tEd.Pattern != null)
                    {
                        result.Add(new()
                        {
                            DiscriminatorType = (ElementDefinition.DiscriminatorType)discriminator.Type!,
                            Type = discriminator.Type.GetLiteral()!,
                            Path = sourcePath,
                            PostResovlePath = postResolve,
                            Id = tEd.ElementId,
                            Value = tEd.Pattern,
                        });
                        continue;
                    }
                }

                // check for the last component of the path being a type
                string teType = tId.Substring(tId.LastIndexOf('.') + 1);
                tId = tId.Substring(0, tId.LastIndexOf('.'));

                if (transitive.cgTryGetElementById(tId, out tEd) && (tEd != null))
                {
                    // check for the specified type
                    foreach (ElementDefinition.TypeRefComponent tTr in tEd.Type!.Where(t => t.Code.Equals(teType, StringComparison.Ordinal)))
                    {
                        if (tTr.Profile.Any())
                        {
                            result.Add(new()
                            {
                                DiscriminatorType = (ElementDefinition.DiscriminatorType)discriminator.Type!,
                                Type = discriminator.Type.GetLiteral()!,
                                Path = sourcePath,
                                PostResovlePath = postResolve.Substring(0, postResolve.LastIndexOf('.')),
                                Id = tEd.ElementId,
                                Value = new FhirString(tTr.Profile.First()),
                            });
                            continue;
                        }
                    }
                }
            }
        }

        return result;
    }
}