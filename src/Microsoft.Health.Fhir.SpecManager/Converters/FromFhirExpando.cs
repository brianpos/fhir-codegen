﻿// <copyright file="FromFhirObject.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

using System.IO;
using System.Text.Json;
using Microsoft.Health.Fhir.SpecManager.Manager;
using Microsoft.Health.Fhir.SpecManager.Models;
using static Microsoft.Health.Fhir.CodeGenCommon.Models.FhirImplementationGuide;

namespace Microsoft.Health.Fhir.SpecManager.Converters;

/// <summary>Load models from a core package. This class cannot be inherited.</summary>
public sealed class FromFhirExpando : IFhirConverter
{
    private const string ExtensionComment = "There can be no stigma associated with the use of extensions by any application, project, or standard - regardless of the institution or jurisdiction that uses or defines the extensions.  The use of extensions is what allows the FHIR specification to retain a core level of simplicity for everyone.";
    private const string ExtensionDefinition = "May be used to represent additional information that is not part of the basic definition of the element. To make the use of extensions safe and manageable, there is a strict set of governance  applied to the definition and use of extensions. Though any implementer can define an extension, there is a set of requirements that SHALL be met as part of the definition of the extension.";
    private const string ExtensionShort = "Additional content defined by implementations";

    /// <summary>The errors.</summary>
    private static List<string> _errors;

    /// <summary>The warnings.</summary>
    private static List<string> _warnings;

    /// <summary>Values that represent read type codes.</summary>
    private enum ReadTypeCodes
    {
        ByteArray,
        Boolean,
        Decimal,
        String,
        StringArray,
        Integer,
        Long,
        Nested,
        NestedArray,
    }

    /// <summary>Information about the element choice.</summary>
    /// <param name="Literal"> The literal.</param>
    /// <param name="ReadType">Type of the read.</param>
    /// <param name="NestKey"> The nest key.</param>
    private record struct ElementChoiceInfo(
        string Literal,
        ReadTypeCodes ReadType);

    /// <summary>(Immutable) The open type choices.</summary>
    private static readonly ElementChoiceInfo[] _openTypeChoices = new[]
    {
        // Primitive Types
        new ElementChoiceInfo("Base64Binary", ReadTypeCodes.ByteArray),
        new ElementChoiceInfo("Boolean", ReadTypeCodes.Boolean),
        new ElementChoiceInfo("Canonical", ReadTypeCodes.String),
        new ElementChoiceInfo("Code", ReadTypeCodes.String),
        new ElementChoiceInfo("Date", ReadTypeCodes.String),
        new ElementChoiceInfo("DateTime", ReadTypeCodes.String),
        new ElementChoiceInfo("Decimal", ReadTypeCodes.Decimal),
        new ElementChoiceInfo("Id", ReadTypeCodes.String),
        new ElementChoiceInfo("Instant", ReadTypeCodes.String),
        new ElementChoiceInfo("Integer", ReadTypeCodes.Integer),
        new ElementChoiceInfo("Integer64", ReadTypeCodes.Long),
        new ElementChoiceInfo("Markdown", ReadTypeCodes.String),
        new ElementChoiceInfo("Oid", ReadTypeCodes.String),
        new ElementChoiceInfo("PositiveInt", ReadTypeCodes.Integer),
        new ElementChoiceInfo("String", ReadTypeCodes.String),
        new ElementChoiceInfo("Time", ReadTypeCodes.String),
        new ElementChoiceInfo("UnsignedInt", ReadTypeCodes.Integer),
        new ElementChoiceInfo("Uri", ReadTypeCodes.String),
        new ElementChoiceInfo("Url", ReadTypeCodes.String),
        new ElementChoiceInfo("Uuid", ReadTypeCodes.String),

        // Datatypes (complex types)
        new ElementChoiceInfo("Address", ReadTypeCodes.Nested),
        new ElementChoiceInfo("Age", ReadTypeCodes.Nested),
        new ElementChoiceInfo("Annotation", ReadTypeCodes.Nested),
        new ElementChoiceInfo("Attachment", ReadTypeCodes.Nested),
        new ElementChoiceInfo("CodeableConcept", ReadTypeCodes.Nested),
        new ElementChoiceInfo("CodeableReference", ReadTypeCodes.Nested),
        new ElementChoiceInfo("Coding", ReadTypeCodes.Nested),
        new ElementChoiceInfo("ContactPoint", ReadTypeCodes.Nested),
        new ElementChoiceInfo("Count", ReadTypeCodes.Nested),
        new ElementChoiceInfo("Distance", ReadTypeCodes.Nested),
        new ElementChoiceInfo("Duration", ReadTypeCodes.Nested),
        new ElementChoiceInfo("HumanName", ReadTypeCodes.Nested),
        new ElementChoiceInfo("Identifier", ReadTypeCodes.Nested),
        new ElementChoiceInfo("Money", ReadTypeCodes.Nested),
        new ElementChoiceInfo("Period", ReadTypeCodes.Nested),
        new ElementChoiceInfo("Quantity", ReadTypeCodes.Nested),
        new ElementChoiceInfo("Range", ReadTypeCodes.Nested),
        new ElementChoiceInfo("Ratio", ReadTypeCodes.Nested),
        new ElementChoiceInfo("RatioRange", ReadTypeCodes.Nested),
        new ElementChoiceInfo("Reference", ReadTypeCodes.Nested),
        new ElementChoiceInfo("SampledData", ReadTypeCodes.Nested),
        new ElementChoiceInfo("SimpleQuantity", ReadTypeCodes.Nested),
        new ElementChoiceInfo("Signature", ReadTypeCodes.Nested),
        new ElementChoiceInfo("Timing", ReadTypeCodes.Nested),

        // MetaData Types
        new ElementChoiceInfo("ContactDetail", ReadTypeCodes.Nested),
        new ElementChoiceInfo("DataRequirement", ReadTypeCodes.Nested),
        new ElementChoiceInfo("Expression", ReadTypeCodes.Nested),
        new ElementChoiceInfo("ParameterDefinition", ReadTypeCodes.Nested),
        new ElementChoiceInfo("RelatedArtifact", ReadTypeCodes.Nested),
        new ElementChoiceInfo("TriggerDefinition", ReadTypeCodes.Nested),
        new ElementChoiceInfo("UsageContext", ReadTypeCodes.Nested),
        new ElementChoiceInfo("Availability", ReadTypeCodes.Nested),
        new ElementChoiceInfo("ExtendedContactDetail", ReadTypeCodes.Nested),

        // Special Types
        new ElementChoiceInfo("Dosage", ReadTypeCodes.Nested),
        new ElementChoiceInfo("Meta", ReadTypeCodes.Nested),
    };

    /// <summary>
    /// Initializes a new instance of the <see cref="FromFhirExpando"/> class.
    /// </summary>
    public FromFhirExpando()
    {
        _errors = new();
        _warnings = new();
    }

    /// <summary>Process the code system.</summary>
    /// <param name="cs">             The create struct.</param>
    /// <param name="fhirVersionInfo">FHIR Version information.</param>
    private void ProcessCodeSystem(
        FhirExpando cs,
        IPackageImportable fhirVersionInfo)
    {
        string publicationStatus = cs.GetString("status") ?? string.Empty;
        string csName = cs.GetString("name") ?? string.Empty;
        string csId = cs.GetString("id") ?? string.Empty;

        if (string.IsNullOrEmpty(publicationStatus))
        {
            publicationStatus = "unknown";
            _errors.Add($"CodeSystem {csName} ({csId}): Status field missing");
        }

        // ignore retired
        if (publicationStatus.Equals("retired", StringComparison.Ordinal))
        {
            return;
        }

        Dictionary<string, FhirCodeSystem.FilterDefinition> filters = new();

        if (cs["filter"] != null)
        {
            foreach (FhirExpando filter in cs.GetExpandoEnumerable("filter"))
            {
                string filterCode = filter.GetString("code");

                if (string.IsNullOrEmpty(filterCode))
                {
                    continue;
                }

                filters.Add(
                    filterCode,
                    new(
                        filterCode,
                        filter.GetString("description") ?? string.Empty,
                        filter.GetStringArray("operator") ?? Array.Empty<string>(),
                        filter.GetString("value") ?? string.Empty));
            }
        }

        Dictionary<string, FhirCodeSystem.PropertyDefinition> properties = new();

        if (cs["property"] != null)
        {
            foreach (FhirExpando prop in cs.GetExpandoEnumerable("property"))
            {
                string propCode = prop.GetString("code");

                if (string.IsNullOrEmpty(propCode))
                {
                    continue;
                }

                if (properties.ContainsKey(propCode))
                {
                    _warnings.Add($"CodeSystem {csName} ({csId}): Duplicate proprety found: {propCode}");
                    continue;
                }

                properties.Add(
                    propCode,
                    new(
                        propCode,
                        prop.GetString("uri") ?? string.Empty,
                        prop.GetString("description") ?? string.Empty,
                        FhirCodeSystem.PropertyTypeFromValue(prop.GetString("type") ?? string.Empty)));
            }
        }

        Dictionary<string, FhirConceptTreeNode> nodeLookup = new Dictionary<string, FhirConceptTreeNode>();
        FhirConceptTreeNode root = new FhirConceptTreeNode(null, null);

        if (cs["concept"] != null)
        {
            AddConceptTree(
                cs.GetString("url") ?? string.Empty,
                cs.GetString("id") ?? string.Empty,
                cs.GetExpandoEnumerable("concept"),
                root,
                nodeLookup,
                properties);
        }

        string standardStatus =
            cs.GetExtension("http://hl7.org/fhir/StructureDefinition/structuredefinition-standards-status")
                ?.GetString("valueCode");

        int? fmmLevel =
            cs.GetExtension("http://hl7.org/fhir/StructureDefinition/structuredefinition-fmm")
                ?.GetInt("valueInteger");

        FhirCodeSystem codeSystem = new FhirCodeSystem(
            cs.GetString("name"),
            cs.GetString("id"),
            cs.GetString("version") ?? string.Empty,
            cs.GetString("title") ?? string.Empty,
            cs.GetString("url") ?? string.Empty,
            publicationStatus,
            standardStatus,
            fmmLevel,
            cs.GetString("description") ?? string.Empty,
            cs.GetString("content"),
            root,
            nodeLookup,
            filters,
            properties);

        // add our code system
        fhirVersionInfo.AddCodeSystem(codeSystem);
    }

    /// <summary>Adds a concept tree to 'concepts'.</summary>
    /// <param name="codeSystemUrl">      URL of the code system.</param>
    /// <param name="codeSystemId">       Id of the code system.</param>
    /// <param name="concepts">           The concept.</param>
    /// <param name="parent">             The parent.</param>
    /// <param name="nodeLookup">         The node lookup.</param>
    /// <param name="propertyDefinitions">The property definitions.</param>
    private void AddConceptTree(
        string codeSystemUrl,
        string codeSystemId,
        IEnumerable<FhirExpando> concepts,
        FhirConceptTreeNode parent,
        Dictionary<string, FhirConceptTreeNode> nodeLookup,
        Dictionary<string, FhirCodeSystem.PropertyDefinition> propertyDefinitions)
    {
        if ((concepts == null) ||
            (!concepts.Any()) ||
            (parent == null))
        {
            return;
        }

        List<KeyValuePair<string, string>> properties = new List<KeyValuePair<string, string>>();

        foreach (FhirExpando concept in concepts)
        {
            if (TryBuildInternalConceptFromFhir(
                    codeSystemUrl,
                    codeSystemId,
                    concept,
                    propertyDefinitions,
                    out FhirConcept fhirConcept,
                    nodeLookup))
            {
                FhirConceptTreeNode node = parent.AddChild(fhirConcept);

                if (concept["concept"] != null)
                {
                    AddConceptTree(
                        codeSystemUrl,
                        codeSystemId,
                        concept.GetExpandoEnumerable("concept"),
                        node,
                        nodeLookup,
                        propertyDefinitions);
                }

                string conceptCode = concept.GetString("code");

                // codes may be referenced multiple times depending on nesting structure
                if (!nodeLookup.ContainsKey(conceptCode))
                {
                    nodeLookup.Add(conceptCode, node);
                }
            }
        }
    }

    /// <summary>Attempts to build internal concept from FHIR.</summary>
    /// <param name="codeSystemUrl">      URL of the code system.</param>
    /// <param name="codeSystemId">       Id of the code system.</param>
    /// <param name="concept">            The concept.</param>
    /// <param name="propertyDefinitions">The property definitions.</param>
    /// <param name="fhirConcept">        [out] The FHIR concept.</param>
    /// <param name="nodeLookup">         (Optional) The node lookup.</param>
    /// <returns>True if it succeeds, false if it fails.</returns>
    private bool TryBuildInternalConceptFromFhir(
        string codeSystemUrl,
        string codeSystemId,
        FhirExpando concept,
        Dictionary<string, FhirCodeSystem.PropertyDefinition> propertyDefinitions,
        out FhirConcept fhirConcept,
        Dictionary<string, FhirConceptTreeNode> nodeLookup = null)
    {
        string code = concept.GetString("code");

        if (string.IsNullOrEmpty(code))
        {
            fhirConcept = null;
            return false;
        }

        if ((nodeLookup != null) &&
            nodeLookup.ContainsKey(code))
        {
            fhirConcept = null;
            return false;
        }

        fhirConcept = new FhirConcept(
            codeSystemUrl,
            code,
            concept.GetString("display") ?? string.Empty,
            string.Empty,
            concept.GetString("definition") ?? string.Empty,
            codeSystemId);

        if (concept["property"] != null)
        {
            foreach (FhirExpando prop in concept.GetExpandoEnumerable("property"))
            {
                string propCode = prop.GetString("code");

                if (string.IsNullOrEmpty(propCode) ||
                    (!propertyDefinitions.ContainsKey(propCode)))
                {
                    continue;
                }

                if ((propCode == "status") && (prop.GetString("valueCode") == "deprecated"))
                {
                    fhirConcept = null;
                    return false;
                }

                switch (propertyDefinitions[propCode].PropType)
                {
                    case FhirCodeSystem.PropertyTypeEnum.Code:
                        fhirConcept.AddProperty(
                            propCode,
                            prop.GetString("valueCode"),
                            prop.GetString("valueCode"));
                        break;

                    case FhirCodeSystem.PropertyTypeEnum.Coding:
                        {
                            FhirExpando vc = prop.GetExpando("valueCoding");

                            if (vc != null)
                            {
                                string codingSystem = vc.GetString("system") ?? string.Empty;
                                string codingCode = vc.GetString("code") ?? string.Empty;
                                string codingVersion = vc.GetString("version") ?? string.Empty;

                                fhirConcept.AddProperty(
                                    propCode,
                                    (system: codingSystem, code: codingCode, version: codingVersion),
                                    FhirConcept.GetCanonical(
                                        codingSystem,
                                        codingCode,
                                        codingVersion));
                            }
                        }

                        break;

                    case FhirCodeSystem.PropertyTypeEnum.String:
                        fhirConcept.AddProperty(
                            propCode,
                            prop.GetString("valueString") ?? null,
                            prop.GetString("valueString") ?? string.Empty);
                        break;

                    case FhirCodeSystem.PropertyTypeEnum.Integer:
                        fhirConcept.AddProperty(
                            propCode,
                            prop.GetInt("valueInteger") ?? null,
                            prop.GetInt("valueInteger")?.ToString() ?? string.Empty);
                        break;

                    case FhirCodeSystem.PropertyTypeEnum.Boolean:
                        fhirConcept.AddProperty(
                            propCode,
                            prop.GetBool("valueBoolean") ?? null,
                            prop.GetBool("valueBoolean")?.ToString() ?? string.Empty);
                        break;

                    case FhirCodeSystem.PropertyTypeEnum.DateTime:
                        fhirConcept.AddProperty(
                            propCode,
                            prop.GetString("valueDateTime") ?? null,
                            prop.GetString("valueDateTime") ?? string.Empty);
                        break;

                    case FhirCodeSystem.PropertyTypeEnum.Decimal:
                        fhirConcept.AddProperty(
                            propCode,
                            prop.GetDecimal("valueDecimal") ?? null,
                            prop.GetDecimal("valueDecimal")?.ToString() ?? string.Empty);
                        break;
                }
            }
        }

        return true;
    }

    /// <summary>Process the operation.</summary>
    /// <param name="op">             The operation.</param>
    /// <param name="fhirVersionInfo">FHIR Version information.</param>
    private void ProcessOperation(
        FhirExpando op,
        IPackageImportable fhirVersionInfo)
    {
        string publicationStatus = op.GetString("status") ?? "unknown";

        // ignore retired
        if (publicationStatus.Equals("retired", StringComparison.Ordinal))
        {
            return;
        }

        List<FhirParameter> parameters = new List<FhirParameter>();

        if (op["parameter"] != null)
        {
            foreach (FhirExpando opParam in op.GetExpandoEnumerable("parameter"))
            {
                parameters.Add(new FhirParameter(
                    opParam.GetString("name"),
                    opParam.GetString("use"),
                    opParam.GetStringArray("scope") ?? null,
                    opParam.GetInt("min") ?? 0,
                    opParam.GetString("max"),
                    opParam.GetString("documentation"),
                    opParam.GetString("type"),
                    opParam.GetStringArray("allowedType") ?? null,
                    opParam.GetStringArray("targetProfile") ?? null,
                    opParam.GetString("searchType"),
                    parameters.Count));
            }
        }

        string opBase;

        if (op["base"] == null)
        {
            opBase = null;
        }
        else if (op["base"].GetType() == typeof(string))
        {
            // R4 and higher, base is a 'canonical'
            opBase = op.GetString("base");
        }
        else
        {
            // R3 and lower, base is a reference
            opBase = op.GetString("base", "reference");
        }

        string standardStatus =
            op.GetExtension("http://hl7.org/fhir/StructureDefinition/structuredefinition-standards-status")
                ?.GetString("valueCode");

        int? fmmLevel =
            op.GetExtension("http://hl7.org/fhir/StructureDefinition/structuredefinition-fmm")
                ?.GetInt("valueInteger");

        // create the operation
        FhirOperation operation = new FhirOperation(
            op.GetString("id"),
            new Uri(op.GetString("url")),
            op.GetString("version"),
            op.GetString("name"),
            op.GetString("description"),
            publicationStatus,
            standardStatus,
            fmmLevel,
            op.GetBool("affectsState"),
            op.GetBool("system") ?? false,
            op.GetBool("type") ?? false,
            op.GetBool("instance") ?? false,
            op.GetString("code"),
            op.GetString("comment"),
            opBase,
            op.GetStringList("resource") ?? null,
            parameters,
            op.GetBool("experimental") == true);

        // add our operation
        fhirVersionInfo.AddOperation(operation);
    }

    /// <summary>Process the search parameter.</summary>
    /// <param name="sp">             The search parameter.</param>
    /// <param name="fhirVersionInfo">FHIR Version information.</param>
    private void ProcessSearchParam(
        FhirExpando sp,
        IPackageImportable fhirVersionInfo)
    {
        string publicationStatus = sp.GetString("status") ?? "unknown";

        // ignore retired
        if (publicationStatus.Equals("retired", StringComparison.Ordinal))
        {
            return;
        }

        List<string> resources = sp.GetStringList("base");

        // check for parameters with no base resource
        if (resources == null)
        {
            resources = new();

            // see if we can determine the resource based on id
            string[] components = sp.GetString("id").Split('-');

            foreach (string component in components)
            {
                if (fhirVersionInfo.Resources.ContainsKey(component))
                {
                    resources.Add(component);
                }
            }

            // don't know where to put this, could try parsing XPath in the future
            if (resources.Count == 0)
            {
                return;
            }
        }

        string standardStatus =
            sp.GetExtension("http://hl7.org/fhir/StructureDefinition/structuredefinition-standards-status")
                ?.GetString("valueCode");

        int? fmmLevel =
            sp.GetExtension("http://hl7.org/fhir/StructureDefinition/structuredefinition-fmm")
                ?.GetInt("valueInteger");

        // create the search parameter
        FhirSearchParam param = new FhirSearchParam(
            sp.GetString("id"),
            new Uri(sp.GetString("url")),
            sp.GetString("version"),
            sp.GetString("name"),
            sp.GetString("description"),
            sp.GetString("purpose"),
            sp.GetString("code"),
            resources,
            sp.GetStringList("target"),
            sp.GetString("type"),
            publicationStatus,
            standardStatus,
            fmmLevel,
            sp.GetBool("experimental") == true,
            sp.GetString("xpath") ?? string.Empty,
            sp.GetString("processingMode") ?? sp.GetString("xpathUsage") ?? string.Empty,
            sp.GetString("expression"));

        // add our parameter
        fhirVersionInfo.AddSearchParameter(param);
    }

    /// <summary>Process the value set.</summary>
    /// <param name="vs">             The value set.</param>
    /// <param name="fhirVersionInfo">FHIR Version information.</param>
    private static void ProcessValueSet(
        FhirExpando vs,
        IPackageImportable fhirVersionInfo)
    {
        string publicationStatus = vs.GetString("status") ?? "unknown";
        string vsId = vs.GetString("id") ?? string.Empty;
        string vsName = vs.GetString("name") ?? string.Empty;
        string vsUrl = vs.GetString("url") ?? string.Empty;
        string vsVersion = vs.GetString("version") ?? string.Empty;

        // ignore retired
        if (publicationStatus.Equals("retired", StringComparison.Ordinal))
        {
            return;
        }

        if (string.IsNullOrEmpty(vsUrl))
        {
            _errors.Add($"ValueSet {vsName} ({vsId}): Cannot be indexed - missing URL");
            return;
        }

        // do not process a value set if we have already loaded it
        if (fhirVersionInfo.HasValueSet(vsUrl))
        {
            return;
        }

        if (string.IsNullOrEmpty(vsVersion))
        {
            _warnings.Add($"ValueSet {vsName} ({vsId}): No Version present");
            vsVersion = fhirVersionInfo.VersionString;
        }

        switch (vsVersion)
        {
            case "5.0.0-ballot":
            case "5.0.0-cibuild":
                switch (vsName)
                {
                    case "FHIRTypes":
                        vsName = "FHIRAllTypes";
                        _warnings.Add("ValueSet FHIRTypes renamed to FHIRAllTypes");
                        break;

                    case "ResourceTypes":
                        vsName = "ResourceType";
                        _warnings.Add("ValueSet ResourceTypes renamed to ResourceType");
                        break;
                }
                break;
        }

        List<FhirValueSetComposition> includes = null;
        List<FhirValueSetComposition> excludes = null;
        FhirValueSetExpansion expansion = null;

        if ((vs["compose"] != null) &&
            (vs["compose", "include"] != null))
        {
            includes = new List<FhirValueSetComposition>();

            foreach (FhirExpando compose in vs.GetExpandoEnumerable("compose", "include"))
            {
                includes.Add(BuildComposition(compose));
            }
        }

        if ((vs["compose"] != null) &&
            (vs["compose", "exclude"] != null))
        {
            excludes = new List<FhirValueSetComposition>();

            foreach (FhirExpando compose in vs.GetExpandoEnumerable("compose", "exclude"))
            {
                excludes.Add(BuildComposition(compose));
            }
        }

        if (vs["expansion"] != null)
        {
            Dictionary<string, dynamic> parameters = null;

            if (vs["expansion", "parameter"] != null)
            {
                parameters = new Dictionary<string, dynamic>();

                foreach (FhirExpando param in vs.GetExpandoEnumerable("expansion","parameter"))
                {
                    string paramName = param.GetString("name");
                    if (string.IsNullOrEmpty(paramName) || parameters.ContainsKey(paramName))
                    {
                        continue;
                    }

                    foreach (string childName in param.Keys)
                    {
                        if (childName == "name")
                        {
                            continue;
                        }

                        parameters.Add(paramName, param[childName]);
                    }
                }
            }

            List<FhirConcept> expansionContains = null;

            if (vs["expansion", "contains"] != null)
            {
                foreach (FhirExpando contains in vs.GetExpandoEnumerable("expansion", "contains"))
                {
                    AddContains(ref expansionContains, contains);
                }
            }

            expansion = new FhirValueSetExpansion(
                vs.GetString("expansion", "id") ?? string.Empty,
                vs.GetString("expansion", "timestamp") ?? string.Empty,
                vs.GetInt("expansion", "total"),
                vs.GetInt("expansion", "offset"),
                parameters,
                expansionContains);
        }

        string standardStatus =
            vs.GetExtension("http://hl7.org/fhir/StructureDefinition/structuredefinition-standards-status")
                ?.GetString("valueCode");

        int? fmmLevel =
            vs.GetExtension("http://hl7.org/fhir/StructureDefinition/structuredefinition-fmm")
                ?.GetInt("valueInteger");

        FhirValueSet valueSet = new FhirValueSet(
            vsName,
            vsId,
            vsVersion,
            vs.GetString("title") ?? vsName,
            vsUrl,
            publicationStatus,
            standardStatus,
            fmmLevel,
            vs.GetString("description") ?? vsName,
            includes,
            excludes,
            expansion);

        // add our code system
        fhirVersionInfo.AddValueSet(valueSet);
    }

    /// <summary>Adds a set of contains clauses to a value set expansion.</summary>
    /// <param name="contains">[in,out] The contains.</param>
    /// <param name="ec">      The ec.</param>
    private static void AddContains(ref List<FhirConcept> contains, FhirExpando ec)
    {
        if (contains == null)
        {
            contains = new List<FhirConcept>();
        }

        FhirConcept fhirConcept = new FhirConcept(
            ec.GetString("system"),
            ec.GetString("code"),
            ec.GetString("display"),
            ec.GetString("version"),
            string.Empty,
            string.Empty);

        if (ec["property"] != null)
        {
            foreach (FhirExpando prop in ec.GetExpandoEnumerable("property"))
            {
                string propCode = prop.GetString("code");

                if (string.IsNullOrEmpty(propCode))
                {
                    continue;
                }

                foreach (string propKey in prop.Keys)
                {
                    switch (propKey)
                    {
                        case "code":
                            // do nothing
                            break;

                        case "valueCoding":
                            {
                                string codingSystem = prop.GetString("valueCoding", "system") ?? string.Empty;
                                string codingCode = prop.GetString("valueCoding", "code") ?? string.Empty;
                                string codingVersion = prop.GetString("valueCoding", "version") ?? string.Empty;

                                fhirConcept.AddProperty(
                                    propCode,
                                    (system: codingSystem, code: codingCode, version: codingVersion),
                                    FhirConcept.GetCanonical(
                                        codingSystem,
                                        codingCode,
                                        codingVersion));
                            }

                            break;

                        case "valueCode":
                        case "valueString":
                        case "valueDateTime":
                            fhirConcept.AddProperty(
                                propCode,
                                prop.GetString(propKey),
                                prop.GetString(propKey));
                            break;

                        case "valueInteger":
                            fhirConcept.AddProperty(
                                propCode,
                                prop.GetInt(propKey),
                                prop.GetInt(propKey)?.ToString() ?? string.Empty);
                            break;

                        case "valueDecimal":
                            fhirConcept.AddProperty(
                                propCode,
                                prop.GetDecimal(propKey),
                                prop.GetDecimal(propKey)?.ToString() ?? string.Empty);
                            break;

                        default:
                            fhirConcept.AddProperty(
                                propCode,
                                prop[propKey],
                                prop[propKey].ToString() ?? string.Empty);
                            break;
                    }
                }
            }
        }

        // TODO: Determine if the Inactive flag needs to be checked
        if ((!string.IsNullOrEmpty(ec.GetString("system"))) ||
            (!string.IsNullOrEmpty(ec.GetString("code"))))
        {
            contains.Add(fhirConcept);
        }

        if (ec["contains"] != null)
        {
            foreach (FhirExpando subContains in ec.GetExpandoEnumerable("contains"))
            {
                AddContains(ref contains, subContains);
            }
        }
    }

    /// <summary>Builds a composition.</summary>
    /// <param name="compose">The compose.</param>
    /// <returns>A FhirValueSetComposition.</returns>
    private static FhirValueSetComposition BuildComposition(FhirExpando compose)
    {
        if (compose == null)
        {
            return null;
        }

        List<FhirConcept> concepts = null;
        List<FhirValueSetFilter> filters = null;
        List<string> linkedValueSets = null;

        if (compose["concept"] != null)
        {
            concepts = new List<FhirConcept>();

            foreach (FhirExpando concept in compose.GetExpandoEnumerable("concept"))
            {
                concepts.Add(new FhirConcept(
                    compose.GetString("system"),
                    concept.GetString("code"),
                    concept.GetString("display")));
            }
        }

        if (compose["filter"] != null)
        {
            filters = new List<FhirValueSetFilter>();

            foreach (FhirExpando filter in compose.GetExpandoEnumerable("filter"))
            {
                filters.Add(new FhirValueSetFilter(
                    filter.GetString("property"),
                    filter.GetString("op"),
                    filter.GetString("value")));
            }
        }

        if (compose["valueSet"] != null)
        {
            linkedValueSets = compose.GetStringList("valueSet") ?? new();
        }

        return new FhirValueSetComposition(
            compose.GetString("system"),
            compose.GetString("version"),
            concepts,
            filters,
            linkedValueSets);
    }

    /// <summary>Process the structure definition.</summary>
    /// <param name="sd">             The structure definition we are parsing.</param>
    /// <param name="fhirVersionInfo">FHIR Version information.</param>
    private void ProcessStructureDef(
        FhirExpando sd,
        IPackageImportable fhirVersionInfo)
    {
        string publicationStatus = sd.GetString("status") ?? "unknown";

        // ignore retired
        if (publicationStatus == "retired")
        {
            return;
        }

        string sdKind = sd.GetString("kind") ?? string.Empty;

        // act depending on kind
        switch (sdKind)
        {
            case "primitive-type":
                ProcessDataTypePrimitive(sd, fhirVersionInfo);
                break;

            case "logical":
                ProcessComplex(sd, fhirVersionInfo, FhirArtifactClassEnum.LogicalModel);
                break;

            case "resource":
            case "complex-type":
                if (sd.GetString("derivation") == "constraint")
                {
                    if (sd.GetString("type") == "Extension")
                    {
                        ProcessComplex(sd, fhirVersionInfo, FhirArtifactClassEnum.Extension);
                    }
                    else
                    {
                        ProcessComplex(sd, fhirVersionInfo, FhirArtifactClassEnum.Profile);
                    }
                }
                else
                {
                    ProcessComplex(
                        sd,
                        fhirVersionInfo,
                        sdKind == "complex-type" ? FhirArtifactClassEnum.ComplexType : FhirArtifactClassEnum.Resource);
                }

                break;
        }
    }

    /// <summary>Process a structure definition for a Primitive data type.</summary>
    /// <param name="sd">             The structure definition.</param>
    /// <param name="fhirVersionInfo">FHIR Version information.</param>
    private static void ProcessDataTypePrimitive(
        FhirExpando sd,
        IPackageImportable fhirVersionInfo)
    {
        string sdId = sd.GetString("id") ?? string.Empty;
        string sdName = sd.GetString("name") ?? string.Empty;
        string publicationStatus = sd.GetString("status") ?? "unknown";

        string regex = string.Empty;
        string descriptionShort = sd.GetString("description") ?? string.Empty;
        string definition = sd.GetString("purpose") ?? string.Empty;
        string comment = string.Empty;
        string baseTypeName = string.Empty;

        // right now, differential is generally 'more correct' than snapshot for primitives, see FHIR-37465
        if ((sd["differential"] != null) &&
            (sd["differential", "element"] != null))
        {
            foreach (FhirExpando element in sd.GetExpandoEnumerable("differential", "element"))
            {
                string elementId = element.GetString("id");

                if (elementId == sdId)
                {
                    descriptionShort = element.GetString("short") ?? descriptionShort;
                    definition = element.GetString("definition") ?? definition;
                    comment = element.GetString("comment") ?? comment;
                    continue;
                }

                if (elementId != $"{sdId}.value")
                {
                    continue;
                }

                if (element["type"] == null)
                {
                    continue;
                }

                foreach (FhirExpando type in element.GetExpandoEnumerable("type"))
                {
                    string typeCode = type.GetString("code") ?? string.Empty;

                    if (!string.IsNullOrEmpty(typeCode))
                    {
                        if (FhirElementType.IsFhirPathType(typeCode, out string fhirType))
                        {
                            baseTypeName = fhirType;
                        }
                        else if (FhirElementType.IsXmlBaseType(typeCode, out string xmlFhirType))
                        {
                            baseTypeName = xmlFhirType;
                        }
                    }

                    if (type["extension"] == null)
                    {
                        continue;
                    }

                    foreach (FhirExpando ext in type.GetExpandoEnumerable("extension"))
                    {
                        string extUrl = ext.GetString("url");

                        if ((extUrl == "http://hl7.org/fhir/StructureDefinition/regex") ||
                            (extUrl == "http://hl7.org/fhir/StructureDefinition/structuredefinition-regex"))
                        {
                            regex = ext.GetString("valueString");
                            break;
                        }
                    }
                }
            }
        }

        if (string.IsNullOrEmpty(baseTypeName))
        {
            baseTypeName = sdName;
        }

        string standardStatus =
            sd.GetExtension("http://hl7.org/fhir/StructureDefinition/structuredefinition-standards-status")
                ?.GetString("valueCode");

        int? fmmLevel =
            sd.GetExtension("http://hl7.org/fhir/StructureDefinition/structuredefinition-fmm")
                ?.GetInt("valueInteger");

        // create a new primitive type object
        FhirPrimitive primitive = new FhirPrimitive(
            sdId,
            sdName,
            baseTypeName,
            new Uri(sd.GetString("url") ?? string.Empty),
            publicationStatus,
            standardStatus,
            fmmLevel,
            sd.GetBool("experimental") == true,
            descriptionShort,
            definition,
            comment,
            regex);

        // add to our dictionary of primitive types
        fhirVersionInfo.AddPrimitive(primitive);
    }

    /// <summary>Process a complex structure (Complex Type or Resource).</summary>
    /// <exception cref="InvalidDataException">Thrown when an Invalid Data error condition occurs.</exception>
    /// <param name="sd">             The structure definition to parse.</param>
    /// <param name="fhirVersionInfo">FHIR Version information.</param>
    /// <param name="artifactClass">  Type of structure definition we are parsing.</param>
    private static void ProcessComplex(
        FhirExpando sd,
        IPackageImportable fhirVersionInfo,
        FhirArtifactClassEnum artifactClass)
    {
        if ((sd["snapshot"] == null) || (sd["snapshot", "element"] == null))
        {
            return;
        }

        string sdId = sd.GetString("id") ?? string.Empty;
        string sdName = sd.GetString("name") ?? string.Empty;
        string publicationStatus = sd.GetString("status") ?? "unknown";
        string sdType = sd.GetString("type") ?? sdName;
        string sdUrl = sd.GetString("url") ?? string.Empty;

        string descriptionShort = sd.GetString("description") ?? string.Empty;
        string definition = sd.GetString("purpose") ?? string.Empty;
        //string regex = string.Empty;
        //string comment = string.Empty;
        //string baseTypeName = string.Empty;

        try
        {
            List<string> contextElements = new List<string>();
            if (sd["context"] != null)
            {
                foreach (object context in (IEnumerable<object>)sd["context"])
                {
                    switch (context)
                    {
                        // R3 and lower, context is a simple value
                        case string contextString:
                            contextElements.Add((string)context);
                            break;

                        // R4 and higher, context is a backbone element
                        case FhirExpando ctx:
                            if (ctx.GetString("type") != "element")
                            {
                                // throw new ArgumentException($"Invalid extension context type: {context.Type}");
                                _errors.Add($"StructureDefinition {sdName} ({sdId}) unhandled context type: {ctx.GetString("type")}");
                                return;
                            }
                            contextElements.Add(ctx.GetString("expression"));
                            break;
                    }
                }
            }

            if ((sd["snapshot", "element"] != null) &&
                sd.GetExpandoEnumerable("snapshot", "element").Any())
            {
                FhirExpando element0 = sd.GetExpandoEnumerable("snapshot", "element").First();

                descriptionShort = element0.GetString("short") ?? descriptionShort;
                definition = element0.GetString("definition") ?? definition;
            }

            string standardStatus =
                sd.GetExtension("http://hl7.org/fhir/StructureDefinition/structuredefinition-standards-status")
                    ?.GetString("valueCode");

            int? fmmLevel =
                sd.GetExtension("http://hl7.org/fhir/StructureDefinition/structuredefinition-fmm")
                    ?.GetInt("valueInteger");

            // create a new complex type object for this type or resource
            FhirComplex complex = new FhirComplex(
                sdId,
                sdName,
                string.Empty,
                string.Empty,
                sdType,
                new Uri(sdUrl),
                publicationStatus,
                standardStatus,
                fmmLevel,
                sd.GetBool("experimental") == true,
                descriptionShort,
                definition,
                string.Empty,
                null,
                contextElements,
                sd.GetBool("abstract") ?? false);

            // check for a base definition
            if (sd["baseDefinition"] != null)
            {
                string bd = sd.GetString("baseDefinition");
                complex.BaseTypeName = bd.Substring(bd.LastIndexOf('/') + 1);
                complex.BaseTypeCanonical = bd;
            }
            else
            {
                if (!TryGetTypeFromElements(
                        sdName,
                        sd.GetExpandoEnumerable("snapshot", "element"),
                        out Dictionary<string, FhirElementType> baseTypes,
                        out string _,
                        out bool _))
                {
                    throw new InvalidDataException($"Could not determine base type for {sdName}");
                }

                if (baseTypes.Count == 0)
                {
                    throw new InvalidDataException($"Could not determine base type for {sdName}");
                }

                if (baseTypes.Count > 1)
                {
                    throw new InvalidDataException($"Too many types for {sdName}: {baseTypes.Count}");
                }

                complex.BaseTypeName = baseTypes.ElementAt(0).Value.Name;
            }

            // look for properties on this type
            foreach (FhirExpando element in sd.GetExpandoEnumerable("snapshot", "element"))
            {
                string elementId = element.GetString("id") ?? element.GetString("path") ?? string.Empty;
                string elementPath = element.GetString("path") ?? element.GetString("id") ?? string.Empty;

                try
                {
                    Dictionary<string, FhirElementType> elementTypes = null;
                    string elementType = string.Empty;
                    string regex = string.Empty;
                    bool isRootElement = false;
                    bool isSimple = false;

                    // split the id into component parts
                    string[] idComponents = elementId.Split('.');
                    string[] pathComponents = elementPath.Split('.');

                    // base definition, already processed
                    if (pathComponents.Length < 2)
                    {
                        // check for this component being different from primar
                        if ((pathComponents[0] != sdName) && (contextElements.Count == 0))
                        {
                            // add to our context
                            complex.AddContextElement(pathComponents[0]);
                        }

                        // parse as root element
                        isRootElement = true;
                    }

                    // get the parent container and our field name
                    if (!complex.GetParentAndFieldName(
                            sdUrl,
                            idComponents,
                            pathComponents,
                            out FhirComplex parent,
                            out string field,
                            out string sliceName))
                    {
                        if (isRootElement)
                        {
                            parent = complex;
                            field = string.Empty;
                            sliceName = string.Empty;
                        }
                        else
                        {
                            // throw new InvalidDataException($"Could not find parent for {element.Path}!");
                            // should load later
                            // TODO: figure out a way to verify all dependencies loaded
                            continue;
                        }
                    }

                    // check for needing to add a slice to an element
                    if (!string.IsNullOrEmpty(sliceName))
                    {
                        // check for extension (implicit slicing in differentials)
                        if ((!parent.Elements.ContainsKey(elementPath)) && (field == "extension"))
                        {
                            // grab the extension definition
                            parent.Elements.Add(
                                elementPath,
                                new FhirElement(
                                    elementPath,
                                    elementPath,
                                    string.Empty,
                                    null,
                                    parent.Elements.Count,
                                    ExtensionShort,
                                    ExtensionDefinition,
                                    ExtensionComment,
                                    string.Empty,
                                    "Extension",
                                    null,
                                    0,
                                    "*",
                                    element.GetBool("isModifier"),
                                    element.GetString("isModifierReason"),
                                    element.GetBool("isSummary"),
                                    element.GetBool("mustSupport"),
                                    false,
                                    string.Empty,
                                    null,
                                    string.Empty,
                                    null,
                                    string.Empty,
                                    null,
                                    true,
                                    true,
                                    string.Empty,
                                    string.Empty,
                                    null,
                                    null));
                        }

                        // check for implicit slicing definition
                        if (parent.Elements.ContainsKey(elementPath) &&
                            (!parent.Elements[elementPath].Slicing.ContainsKey(sdUrl)))
                        {
                            List<FhirSliceDiscriminatorRule> discriminatorRules = new List<FhirSliceDiscriminatorRule>()
                                {
                                    new FhirSliceDiscriminatorRule(
                                        "value",
                                        "url"),
                                };

                            // create our slicing
                            parent.Elements[elementPath].AddSlicing(
                                new FhirSlicing(
                                    sdId,
                                    new Uri(sdUrl),
                                    "Extensions are always sliced by (at least) url",
                                    null,
                                    "open",
                                    discriminatorRules));
                        }

                        // check for invalid slicing definition (composition-catalog)
                        if (parent.Elements.ContainsKey(elementPath))
                        {
                            // add this slice to the field
                            parent.Elements[elementPath].AddSlice(sdUrl, sliceName);
                        }

                        // only slice parent has slice name
                        continue;
                    }

                    // if we can't find a type, assume Element
                    if (!TryGetTypeFromElement(parent.Name, element, out elementTypes, out regex, out isSimple))
                    {
                        if ((field == "Extension") || (field == "extension"))
                        {
                            elementType = "Extension";
                        }
                        else
                        {
                            elementType = "Element";
                        }
                    }

                    string elementContentReference = element.GetString("contentReference") ?? string.Empty;

                    // determine if there is type expansion
                    if (field.Contains("[x]", StringComparison.Ordinal))
                    {
                        // fix the field and path names
                        elementId = elementId.Replace("[x]", string.Empty, StringComparison.Ordinal);
                        field = field.Replace("[x]", string.Empty, StringComparison.Ordinal);

                        // force no base type
                        elementType = string.Empty;
                    }
                    else if (!string.IsNullOrEmpty(elementContentReference))
                    {
                        if (elementContentReference.StartsWith("http://hl7.org/fhir/StructureDefinition/", StringComparison.OrdinalIgnoreCase))
                        {
                            int loc = elementContentReference.IndexOf('#', StringComparison.Ordinal);
                            elementType = elementContentReference.Substring(loc + 1);
                        }
                        else if (elementContentReference[0] == '#')
                        {
                            // use the local reference
                            elementType = elementContentReference.Substring(1);
                        }
                        else
                        {
                            throw new InvalidDataException($"Could not resolve ContentReference {elementContentReference} in {sdName} field {elementPath}");
                        }
                    }

                    // get default values (if present)
                    GetValueIfPresent(element, "defaultValue", out string defaultName, out object defaultValue);

                    // get fixed values (if present)
                    GetValueIfPresent(element, "fixed", out string fixedName, out object fixedValue);

                    // get pattern values (if present)
                    GetValueIfPresent(element, "pattern", out string patternName, out object patternValue);

                    // determine if this element is inherited
                    bool isInherited = false;
                    bool modifiesParent = true;

                    if (!elementPath.StartsWith(complex.Name, StringComparison.Ordinal))
                    {
                        isInherited = true;
                    }

                    if (element["base"] != null)
                    {
                        if (element.GetString("base", "path") != elementPath)
                        {
                            isInherited = true;
                        }

                        if ((element.GetInt("base", "min") == element.GetInt("min")) &&
                            (element.GetString("base", "max") == element.GetString("max")) &&
                            (element["slicing"] == null))
                        {
                            modifiesParent = false;
                        }
                    }

                    string bindingStrength = string.Empty;
                    string valueSet = string.Empty;

                    if (element["binding"] != null)
                    {
                        bindingStrength = element.GetString("binding", "strength");

                        // R4 and later use 'valueSet' as canonical
                        // R3 uses 'valueSet[x]', uri or reference
                        valueSet = element.GetString("binding", "valueSet")
                            ?? element.GetString("binding", "valueSetUri");

                        if (string.IsNullOrEmpty(valueSet) &&
                            (element["binding", "valueSetReference"] != null))
                        {
                            valueSet = element.GetString("binding", "valueSetReference", "reference");
                        }
                    }

                    string explicitName = string.Empty;
                    if (element["extension"] != null)
                    {
                        foreach (FhirExpando ext in element.GetExpandoEnumerable("extension"))
                        {
                            string extUrl = ext.GetString("url");

                            if (extUrl == "http://hl7.org/fhir/StructureDefinition/structuredefinition-explicit-type-name")
                            {
                                explicitName = ext.GetString("valueString");
                            }
                        }
                    }

                    List<string> fwMapping;

                    fwMapping = element.GetExpandoEnumerable("mapping")?.Where(x =>
                        (x != null) &&
                        x.GetString("identity").Equals("w5", StringComparison.OrdinalIgnoreCase) &&
                        x.GetString("map").StartsWith("FiveWs", StringComparison.Ordinal) &&
                        (!x.GetString("map").Equals("FiveWs.subject[x]", StringComparison.Ordinal)))?
                            .Select(x => x.GetString("map")).ToList();

                    string fiveWs = ((fwMapping != null) && fwMapping.Any()) ? fwMapping[0] : string.Empty;

                    if (parent.Elements.ContainsKey(elementPath))
                    {
                        _errors.Add($"Complex {sdName} snapshot error ({elementPath}): Repeated snapshot: {parent.Elements[elementPath].Id} & {elementId}");
                        continue;
                    }

                    FhirElement fhirElement = new FhirElement(
                        elementId,
                        elementPath,
                        explicitName,
                        null,
                        parent.Elements.Count,
                        element.GetString("short") ?? string.Empty,
                        element.GetString("definition") ?? string.Empty,
                        element.GetString("comment") ?? string.Empty,
                        regex,
                        elementType,
                        elementTypes,
                        element.GetInt("min") ?? 0,
                        element.GetString("max") ?? string.Empty,
                        element.GetBool("isModifier"),
                        element.GetString("isModifierReason") ?? string.Empty,
                        element.GetBool("isSummary"),
                        element.GetBool("mustSupport"),
                        isSimple,
                        defaultName,
                        defaultValue,
                        fixedName,
                        fixedValue,
                        patternName,
                        patternValue,
                        isInherited,
                        modifiesParent,
                        bindingStrength,
                        valueSet,
                        fiveWs,
                        FhirElement.ConvertFhirRepresentations(element.GetStringArray("representation")));

                    if (isRootElement)
                    {
                        parent.AddRootElement(fhirElement);
                    }
                    else
                    {
                        // add this field to the parent type
                        parent.Elements.Add(elementPath, fhirElement);
                    }

                    if (element["slicing"] != null)
                    {
                        List<FhirSliceDiscriminatorRule> discriminatorRules = new List<FhirSliceDiscriminatorRule>();

                        if (element["slicing", "discriminator"] == null)
                        {
                            throw new InvalidDataException($"Missing slicing discriminator: {sdName} - {elementPath}");
                        }

                        foreach (FhirExpando discriminator in element.GetExpandoEnumerable("slicing", "discriminator"))
                        {
                            discriminatorRules.Add(new FhirSliceDiscriminatorRule(
                                discriminator.GetString("type"),
                                discriminator.GetString("path")));
                        }

                        // create our slicing
                        parent.Elements[elementPath].AddSlicing(
                            new FhirSlicing(
                                sdId,
                                new Uri(sdUrl),
                                element.GetString("slicing", "description"),
                                element.GetBool("slicing", "ordered"),
                                element.GetString("slicing", "rules"),
                                discriminatorRules));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(string.Empty);
                    Console.WriteLine($"FromR5.ProcessComplex <<< element: {elementPath} ({elementId}) - exception: {ex.Message}");
                    throw;
                }
            }

            if ((sd["differential"] != null) &&
                (sd["differential", "element"] != null) &&
                sd.GetExpandoEnumerable("differential", "element").Any())
            {
                FhirExpando element0 = sd.GetExpandoEnumerable("differential", "element").First();

                // look for additional constraints
                if ((element0["constraint"] != null) &&
                    element0.GetExpandoEnumerable("constraint").Any())
                {
                    foreach (FhirExpando con in element0.GetExpandoEnumerable("constraint"))
                    {
                        bool isBestPractice = false;
                        string explanation = string.Empty;

                        if (con["extension"] != null)
                        {
                            foreach (FhirExpando ext in con.GetExpandoEnumerable("extension"))
                            {
                                string extUrl = ext.GetString("url");

                                switch (extUrl)
                                {
                                    case "http://hl7.org/fhir/StructureDefinition/elementdefinition-bestpractice":
                                        isBestPractice = ext.GetBool("valueBoolean") == true;
                                        break;

                                    case "http://hl7.org/fhir/StructureDefinition/elementdefinition-bestpractice-explanation":
                                        if (ext["valueMarkdown"] != null)
                                        {
                                            explanation = ext.GetString("valueMarkdown");
                                        }
                                        else
                                        {
                                            explanation = ext.GetString("valueString");
                                        }

                                        break;
                                }
                            }
                        }

                        complex.AddConstraint(new FhirConstraint(
                            con.GetString("key"),
                            con.GetString("severity"),
                            con.GetString("human"),
                            con.GetString("expression") ?? string.Empty,
                            con.GetString("xpath") ?? string.Empty,
                            isBestPractice,
                            explanation));
                    }
                }

                // traverse all elements to flag proper 'differential' tags on elements
                foreach (FhirExpando dif in sd.GetExpandoEnumerable("differential", "element"))
                {
                    string difPath = dif.GetString("path");
                    string difSliceName = dif.GetString("sliceName") ?? string.Empty;

                    if (complex.Elements.ContainsKey(difPath))
                    {
                        complex.Elements[difPath].SetInDifferential();

                        if ((!string.IsNullOrEmpty(difSliceName)) &&
                            (complex.Elements[difPath].Slicing != null) &&
                            complex.Elements[difPath].Slicing.ContainsKey(sdUrl) &&
                            complex.Elements[difPath].Slicing[sdUrl].HasSlice(difSliceName))
                        {
                            complex.Elements[difPath].Slicing[sdUrl].SetInDifferential(difSliceName);
                        }
                    }
                }
            }

            switch (artifactClass)
            {
                case FhirArtifactClassEnum.ComplexType:
                    fhirVersionInfo.AddComplexType(complex);
                    break;
                case FhirArtifactClassEnum.Resource:
                    fhirVersionInfo.AddResource(complex);
                    break;
                case FhirArtifactClassEnum.Extension:
                    fhirVersionInfo.AddExtension(complex);
                    break;
                case FhirArtifactClassEnum.Profile:
                    fhirVersionInfo.AddProfile(complex);
                    break;
                case FhirArtifactClassEnum.LogicalModel:
                    fhirVersionInfo.AddLogicalModel(complex);
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(string.Empty);
            Console.WriteLine($"FromR5.ProcessComplex <<< SD: {sdName} ({sdId}) - exception: {ex.Message}");
            throw;
        }
    }

    /// <summary>Gets default value if present.</summary>
    /// <param name="element">The element.</param>
    /// <param name="prefix"> The prefix (e.g., defaultValue, fixedValue, minValue, value).</param>
    /// <param name="name">   [out] The default name.</param>
    /// <param name="value">  [out] The default value.</param>
    private static void GetValueIfPresent(
        FhirExpando element,
        string prefix,
        out string name,
        out object value)
    {
        foreach (ElementChoiceInfo e in _openTypeChoices)
        {
            if (element[prefix + e.Literal] != null)
            {
                name = prefix + e.Literal;

                switch (e.ReadType)
                {
                    case ReadTypeCodes.ByteArray:
                        value = element.GetByteArray(name);
                        break;
                    case ReadTypeCodes.Boolean:
                        value = element.GetBool(name);
                        break;
                    case ReadTypeCodes.Decimal:
                        value = element.GetDecimal(name);
                        break;
                    case ReadTypeCodes.String:
                        value = element.GetString(name);
                        break;
                    case ReadTypeCodes.StringArray:
                        value = element.GetStringArray(name);
                        break;
                    case ReadTypeCodes.Integer:
                        value = element.GetInt(name);
                        break;
                    case ReadTypeCodes.Long:
                        value = element.GetLong(name);
                        break;
                    case ReadTypeCodes.Nested:
                    case ReadTypeCodes.NestedArray:
                    default:
                        value = element[name];
                        break;
                }

                return;
            }
        }

        name = string.Empty;
        value = null;
    }

    /// <summary>Attempts to get type from elements.</summary>
    /// <param name="structureName">Name of the structure.</param>
    /// <param name="elements">     The elements node.</param>
    /// <param name="elementTypes"> [out] Type of the element.</param>
    /// <param name="regex">        [out] The RegEx.</param>
    /// <param name="isSimple">     [out] True if is simple, false if not.</param>
    /// <returns>True if it succeeds, false if it fails.</returns>
    private static bool TryGetTypeFromElements(
        string structureName,
        IEnumerable<FhirExpando> elements,
        out Dictionary<string, FhirElementType> elementTypes,
        out string regex,
        out bool isSimple)
    {
        elementTypes = null;
        regex = string.Empty;
        isSimple = false;

        foreach (FhirExpando element in elements)
        {
            // split the path
            string[] components = element.GetString("path").Split('.');

            // check for base path having a type
            if (components.Length == 1)
            {
                if (TryGetTypeFromElement(structureName, element, out elementTypes, out regex, out isSimple))
                {
                    // done searching
                    return true;
                }
            }

            // check for path {type}.value having a type
            if ((components.Length == 2) &&
                components[1].Equals("value", StringComparison.Ordinal))
            {
                if (TryGetTypeFromElement(structureName, element, out elementTypes, out regex, out isSimple))
                {
                    // keep looking in case we find a better option
                    continue;
                }
            }
        }

        if (elementTypes != null)
        {
            return true;
        }

        return false;
    }

    /// <summary>Gets type from element.</summary>
    /// <param name="structureName">Name of the structure.</param>
    /// <param name="element">      The element.</param>
    /// <param name="elementTypes"> [out] Type of the element.</param>
    /// <param name="regex">        [out] The RegEx.</param>
    /// <param name="isSimple">     [out] True if is simple, false if not.</param>
    /// <returns>True if it succeeds, false if it fails.</returns>
    private static bool TryGetTypeFromElement(
        string structureName,
        FhirExpando element,
        out Dictionary<string, FhirElementType> elementTypes,
        out string regex,
        out bool isSimple)
    {
        string elementId = element.GetString("id") ?? string.Empty;
        string elementPath = element.GetString("path");

        elementTypes = new Dictionary<string, FhirElementType>();
        regex = string.Empty;
        isSimple = false;

        // TODO(ginoc): 5.0.0-snapshot1 needs these fixed
        switch (elementPath)
        {
            case "ArtifactAssessment.approvalDate":
            case "ArtifactAssessment.lastReviewDate":
                {
                    FhirExpando tc = element.GetExpandoEnumerable("type").First();

                    if (tc != null)
                    {
                        if (tc.GetString("code") != "date")
                        {
                            elementTypes.Add("date", new FhirElementType("date"));
                            _warnings.Add($"StructureDefinition - {structureName} coerced {elementId} to type 'date'");
                            return true;
                        }
                    }
                }

                break;
        }

        // check for declared type
        if (element["type"] != null)
        {
            string fType;
            IEnumerable<string> elementTargets;
            IEnumerable<string> elementProfiles;

            foreach (FhirExpando edType in element.GetExpandoEnumerable("type"))
            {
                if (edType["extension"] == null)
                {
                    regex = string.Empty;
                    fType = string.Empty;
                }
                else
                {
                    regex = edType.GetExpandoEnumerable("extension")
                        .FirstOrDefault((ext) => ext.GetString("url")?.Equals("http://hl7.org/fhir/StructureDefinition/regex", StringComparison.Ordinal) ?? false, null)
                        ?.GetString("valueString") ?? string.Empty;

                    FhirExpando typeNode = edType.GetExpandoEnumerable("extension")
                        .FirstOrDefault((ext) => ext.GetString("url")?.Equals("http://hl7.org/fhir/StructureDefinition/structuredefinition-fhir-type", StringComparison.Ordinal) ?? false, null);

                    fType =
                        typeNode?.GetString("valueUrl")
                        ?? typeNode?.GetString("valueString")
                        ?? string.Empty;
                }

                elementTargets =
                    edType.GetStringArray("targetProfile", "reference")     // R3 targetProfile is a reference (datatype)
                    ?? edType.GetStringArray("targetProfile")               // R4+ targetProfile is a canonical (string value)
                    ?? Array.Empty<string>();

                elementProfiles =
                    edType.GetStringArray("profile", "reference")           // R3 profile is a reference (datatype)
                    ?? edType.GetStringArray("profile")                     // R4+ profile is a canonical (string value)
                    ?? Array.Empty<string>();

                if (!string.IsNullOrEmpty(fType))
                {
                    // create a type for this code
                    FhirElementType elementType = new FhirElementType(
                        fType,
                        elementTargets,
                        elementProfiles);

                    isSimple = true;

                    // add to our dictionary
                    elementTypes.Add(elementType.Name, elementType);
                }
                else if (!string.IsNullOrEmpty(edType.GetString("code")))
                {
                    // create a type for this code
                    FhirElementType elementType = new FhirElementType(
                        edType.GetString("code"),
                        elementTargets,
                        elementProfiles);

                    if (elementTypes.ContainsKey(elementType.Name))
                    {
                        // R3 and earlier add profiles/targets by repeating elements, but will only have a single value in the array
                        if (elementTargets.Any())
                        {
                            elementTypes[elementType.Name].AddProfile(elementTargets.First());
                        }

                        if (elementProfiles.Any())
                        {
                            elementTypes[elementType.Name].AddTypeProfile(elementProfiles.First());
                        }
                    }
                    else
                    {
                        // add to our dictionary
                        elementTypes.Add(elementType.Name, elementType);
                    }
                }
            }
        }

        if (elementTypes.Count > 0)
        {
            return true;
        }

        // check for base derived type
        if (string.IsNullOrEmpty(elementId) ||
            elementId.Equals(structureName, StringComparison.Ordinal))
        {
            // base type is here
            FhirElementType elementType = new FhirElementType(elementPath);

            // add to our dictionary
            elementTypes.Add(elementType.Name, elementType);

            // done searching
            return true;
        }

        // no discovered type
        elementTypes = null;
        return false;
    }

    /// <summary>Process the code system.</summary>
    /// <param name="ig">             The ImplementationGuide.</param>
    /// <param name="fhirVersionInfo">FHIR Version information.</param>
    private void ProcessImplementationGuide(
        FhirExpando ig,
        IPackageImportable fhirVersionInfo)
    {
        string publicationStatus = ig.GetString("status") ?? string.Empty;
        string csName = ig.GetString("name") ?? string.Empty;
        string csId = ig.GetString("id") ?? string.Empty;

        if (string.IsNullOrEmpty(publicationStatus))
        {
            publicationStatus = "unknown";
            _errors.Add($"CodeSystem {csName} ({csId}): Status field missing");
        }

        // ignore retired
        if (publicationStatus.Equals("retired", StringComparison.Ordinal))
        {
            return;
        }


        string standardStatus =
            ig.GetExtension("http://hl7.org/fhir/StructureDefinition/structuredefinition-standards-status")
                ?.GetString("valueCode");

        int? fmmLevel =
            ig.GetExtension("http://hl7.org/fhir/StructureDefinition/structuredefinition-fmm")
                ?.GetInt("valueInteger");

        Dictionary<string, IgDependsOn> dependsOn = new();

        if (ig["dependsOn"] != null)
        {
            foreach (FhirExpando dep in ig.GetExpandoEnumerable("dependsOn"))
            {
                string depUri = dep.GetString("uri");

                if (string.IsNullOrEmpty(depUri))
                {
                    continue;
                }

                dependsOn.Add(depUri, new IgDependsOn(depUri, dep.GetString("packageId"), dep.GetString("version")));
            }
        }

        FhirImplementationGuide implementationGuide = new FhirImplementationGuide(
            ig.GetString("name"),
            ig.GetString("id"),
            new Uri(ig.GetString("url") ?? string.Empty),
            ig.GetString("version") ?? string.Empty,
            publicationStatus,
            standardStatus,
            fmmLevel,
            (ig.GetBool("experimental") == true),
            ig.GetString("title") ?? string.Empty,
            string.Empty,
            ig.GetString("description") ?? string.Empty,
            ig.GetString("packageId"),
            ig.GetString("fhirVersion"),
            dependsOn);

        // add our code system
        fhirVersionInfo.AddImplementationGuide(implementationGuide);
    }

    /// <summary>Displays the issues.</summary>
    void IFhirConverter.DisplayIssues()
    {
#pragma warning disable CA1303 // Do not pass literals as localized parameters
        Console.WriteLine("Errors (only able to pass with manual code changes)");

        foreach (string value in _errors)
        {
            Console.WriteLine($" - {value}");
        }

        Console.WriteLine("Warnings (able to pass, but should be reviewed)");

        foreach (string value in _warnings)
        {
            Console.WriteLine($" - {value}");
        }
#pragma warning restore CA1303 // Do not pass literals as localized parameters
    }

    /// <summary>Query if 'errorCount' has issues.</summary>
    /// <param name="errorCount">  [out] Number of errors.</param>
    /// <param name="warningCount">[out] Number of warnings.</param>
    /// <returns>True if issues, false if not.</returns>
    bool IFhirConverter.HasIssues(out int errorCount, out int warningCount)
    {
        errorCount = _errors.Count;
        warningCount = _warnings.Count;

        return (errorCount > 0) || (warningCount > 0);
    }

    /// <summary>Parses resource an object from the given string.</summary>
    /// <param name="json">The JSON.</param>
    /// <returns>A typed Resource object.</returns>
    object IFhirConverter.ParseResource(string json)
    {
        try
        {
            // try to parse this JSON
            return JsonSerializer.Deserialize<FhirExpando>(json);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"FromFhirExpando.ParseResource <<< failed to parse:\n{ex}\n------------------------------------");
            throw;
        }
    }

    /// <summary>Attempts to process resource.</summary>
    /// <param name="resourceToParse">The resource object.</param>
    /// <param name="fhirVersionInfo">Information describing the FHIR version.</param>
    void IFhirConverter.ProcessResource(object resourceToParse, IPackageImportable fhirVersionInfo)
    {
        switch ((resourceToParse as FhirExpando)["resourceType"] ?? string.Empty)
        {
            case "CodeSystem":
                ProcessCodeSystem(resourceToParse as FhirExpando, fhirVersionInfo);
                break;

            case "OperationDefinition":
                ProcessOperation(resourceToParse as FhirExpando, fhirVersionInfo);
                break;

            case "SearchParameter":
                ProcessSearchParam(resourceToParse as FhirExpando, fhirVersionInfo);
                break;

            case "ValueSet":
                ProcessValueSet(resourceToParse as FhirExpando, fhirVersionInfo);
                break;

            case "StructureDefinition":
                ProcessStructureDef(resourceToParse as FhirExpando, fhirVersionInfo);
                break;

            case "ImplementationGuide":
                ProcessImplementationGuide(resourceToParse as FhirExpando, fhirVersionInfo);
                break;
        }
    }

    /// <summary>Process a FHIR metadata resource into Server Information.</summary>
    /// <param name="metadata">  The metadata resource object (e.g., r4.CapabilitiesStatement).</param>
    /// <param name="serverUrl"> URL of the server.</param>
    /// <param name="serverInfo">[out] Information describing the server.</param>
    void IFhirConverter.ProcessMetadata(
        object metadata,
        string serverUrl,
        out FhirServerInfo serverInfo)
    {
        if (metadata == null)
        {
            serverInfo = null;
            return;
        }

        FhirExpando caps = metadata as FhirExpando;

        string swName = caps.GetString("software", "name") ?? string.Empty;
        string swVersion = caps.GetString("software", "version") ?? string.Empty;
        string swReleaseDate = caps.GetString("software", "releaseDate") ?? string.Empty;

        string impDescription = caps.GetString("implementation", "description") ?? string.Empty;
        string impUrl = caps.GetString("implementation", "url") ?? string.Empty;

        List<string> serverInteractions = new List<string>();
        Dictionary<string, FhirServerResourceInfo> resourceInteractions = new Dictionary<string, FhirServerResourceInfo>();
        Dictionary<string, FhirServerSearchParam> serverSearchParams = new Dictionary<string, FhirServerSearchParam>();
        Dictionary<string, FhirServerOperation> serverOperations = new Dictionary<string, FhirServerOperation>();

        if (caps["rest"] != null)
        {
            FhirExpando rest = caps.GetExpandoEnumerable("rest").First();

            if (rest == null)
            {
                serverInfo = null;
                return;
            }

            if (rest["interaction"] != null)
            {
                foreach (FhirExpando interaction in rest.GetExpandoEnumerable("interaction"))
                {
                    string code = interaction.GetString("code");

                    if (string.IsNullOrEmpty(code))
                    {
                        continue;
                    }

                    serverInteractions.Add(code);
                }
            }

            if (rest["searchParam"] != null)
            {
                foreach (FhirExpando sp in rest.GetExpandoEnumerable("searchParam"))
                {
                    string spName = sp.GetString("name");

                    if (string.IsNullOrEmpty(spName) || serverSearchParams.ContainsKey(spName))
                    {
                        continue;
                    }

                    serverSearchParams.Add(
                        spName,
                        new FhirServerSearchParam(
                            spName,
                            sp.GetString("definition"),
                            sp.GetString("type"),
                            sp.GetString("documentation")));
                }
            }

            if (rest["operation"] != null)
            {
                foreach (FhirExpando operation in rest.GetExpandoEnumerable("operation"))
                {
                    string operationName = operation.GetString("name");

                    if (string.IsNullOrEmpty(operationName))
                    {
                        continue;
                    }

                    if (serverOperations.ContainsKey(operationName))
                    {
                        serverOperations[operationName].AddDefinition(operation.GetString("definition"));
                        continue;
                    }

                    serverOperations.Add(
                        operationName,
                        new FhirServerOperation(
                            operationName,
                            operation.GetString("definition"),
                            operation.GetString("documentation")));
                }
            }

            if (rest["resource"] != null)
            {
                foreach (FhirExpando resource in rest.GetExpandoEnumerable("resource"))
                {
                    FhirServerResourceInfo resourceInfo = ParseServerRestResource(resource);

                    if (resourceInteractions.ContainsKey(resourceInfo.ResourceType))
                    {
                        continue;
                    }

                    resourceInteractions.Add(
                        resourceInfo.ResourceType,
                        resourceInfo);
                }
            }
        }

        serverInfo = new FhirServerInfo(
            serverInteractions,
            serverUrl,
            caps.GetString("fhirVersion"),
            swName,
            swVersion,
            swReleaseDate,
            impDescription,
            impUrl,
            caps.GetStringArray("instantiates"),
            caps.GetStringArray("implementationGuide"),
            resourceInteractions,
            serverSearchParams,
            serverOperations);
    }

    /// <summary>Parse server REST resource.</summary>
    /// <param name="resource">The resource.</param>
    /// <returns>A FhirServerResourceInfo.</returns>
    private static FhirServerResourceInfo ParseServerRestResource(
        FhirExpando resource)
    {
        List<string> interactions = new List<string>();
        Dictionary<string, FhirServerSearchParam> searchParams = new Dictionary<string, FhirServerSearchParam>();
        Dictionary<string, FhirServerOperation> operations = new Dictionary<string, FhirServerOperation>();

        if (resource["interaction"] != null)
        {
            foreach (FhirExpando interaction in resource.GetExpandoEnumerable("interaction"))
            {
                string code = interaction.GetString("code");

                if (string.IsNullOrEmpty(code))
                {
                    continue;
                }

                interactions.Add(code);
            }
        }

        if (resource["searchParam"] != null)
        {
            foreach (FhirExpando sp in resource.GetExpandoEnumerable("searchParam"))
            {
                string spName = sp.GetString("name");

                if (string.IsNullOrEmpty(spName) || searchParams.ContainsKey(spName))
                {
                    continue;
                }

                searchParams.Add(
                    spName,
                    new FhirServerSearchParam(
                        spName,
                        sp.GetString("definition"),
                        sp.GetString("type"),
                        sp.GetString("documentation")));
            }
        }

        if (resource["operation"] != null)
        {
            foreach (FhirExpando operation in resource.GetExpandoEnumerable("operation"))
            {
                string operationName = operation.GetString("name");

                if (string.IsNullOrEmpty(operationName))
                {
                    continue;
                }

                if (operations.ContainsKey(operationName))
                {
                    operations[operationName].AddDefinition(operation.GetString("definition"));
                    continue;
                }

                operations.Add(
                    operationName,
                    new FhirServerOperation(
                        operationName,
                        operation.GetString("definition"),
                        operation.GetString("documentation")));
            }
        }

        return new FhirServerResourceInfo(
            interactions,
            resource.GetString("type"),
            resource.GetStringList("supportedProfile"),
            resource.GetString("versioning"),
            resource.GetBool("readHistory"),
            resource.GetBool("updateCreate"),
            resource.GetBool("conditionalCreate"),
            resource.GetString("conditionalRead"),
            resource.GetBool("conditionalUpdate"),
            resource.GetString("conditionalDelete"),
            resource.GetStringList("referencePolicy"),
            resource.GetStringList("searchInclude"),
            resource.GetStringList("searchRevInclude"),
            searchParams,
            operations);
    }
}
