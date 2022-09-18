﻿// <copyright file="FhirElement.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

using Microsoft.Health.Fhir.CodeGenCommon.Extensions;

namespace Microsoft.Health.Fhir.CodeGenCommon.Models;

/// <summary>A FHIR element.</summary>
public class FhirElement : FhirTypeBase
{
    private readonly Dictionary<string, FhirSlicing> _slicing;
    private Dictionary<string, FhirElementType> _elementTypes;
    private bool _inDifferential;
    private List<string> _codes;
    private List<PropertyRepresentationCodes> _representations;

    /// <summary>
    /// Initializes a new instance of the <see cref="FhirElement"/> class.
    /// </summary>
    /// <param name="id">               Id for this element.</param>
    /// <param name="path">             Dot notation path for this element.</param>
    /// <param name="explicitName">     Explicit name of this element, if present.</param>
    /// <param name="url">              URL of this element (if present).</param>
    /// <param name="fieldOrder">       The field order.</param>
    /// <param name="shortDescription"> Information describing the short.</param>
    /// <param name="purpose">          The purpose of this element.</param>
    /// <param name="comment">          The comment.</param>
    /// <param name="validationRegEx">  The validation RegEx.</param>
    /// <param name="baseTypeName">     Name of the base type.</param>
    /// <param name="elementTypes">     Types and associated profiles.</param>
    /// <param name="cardinalityMin">   The cardinality minimum.</param>
    /// <param name="cardinalityMax">   The cardinality maximum.</param>
    /// <param name="isModifier">       If this element modifies the meaning of its parent.</param>
    /// <param name="isModifierReason"> Reason this element is a modifier.</param>
    /// <param name="isSummary">        If this element should be included in summaries.</param>
    /// <param name="isMustSupport">    If this element is marked as 'must support'.</param>
    /// <param name="isSimple">         If this element is a 'simple' element (no extended props).</param>
    /// <param name="defaultFieldName"> Name of a default field, e.g., defaultUri, defaultCode.</param>
    /// <param name="defaultFieldValue">Value of a default field.</param>
    /// <param name="fixedFieldName">   Name of a fixed field, e.g., fixedUri, fixedCode.</param>
    /// <param name="fixedFieldValue">  Value of a fixed field.</param>
    /// <param name="patternFieldName">   Name of a pattern field, e.g., fixedUri, fixedCode.</param>
    /// <param name="patternFieldValue">  Value of a pattern field.</param>
    /// <param name="isInherited">      If this element is inherited from somewhere else.</param>
    /// <param name="modifiesParent">   If this element hides a field of its parent.</param>
    /// <param name="bindingStrength">  Strength of binding: required|extensible|preferred|example.</param>
    /// <param name="valueSet">         URL of the value set bound to this element.</param>
    /// <param name="fiveWs">           Five 'Ws' mapping value.</param>
    /// <param name="representation">   Codes that define how this element is represented in instances, when the deviation varies from the normal case.</param>
    public FhirElement(
        string id,
        string path,
        string explicitName,
        Uri url,
        int fieldOrder,
        string shortDescription,
        string purpose,
        string comment,
        string validationRegEx,
        string baseTypeName,
        Dictionary<string, FhirElementType> elementTypes,
        int cardinalityMin,
        string cardinalityMax,
        bool? isModifier,
        string isModifierReason,
        bool? isSummary,
        bool? isMustSupport,
        bool isSimple,
        string defaultFieldName,
        object defaultFieldValue,
        string fixedFieldName,
        object fixedFieldValue,
        string patternFieldName,
        object patternFieldValue,
        bool isInherited,
        bool modifiesParent,
        string bindingStrength,
        string valueSet,
        string fiveWs,
        List<PropertyRepresentationCodes> representations)
        : base(
            id,
            path,
            url,
            string.Empty,
            string.Empty,
            null,
            false,
            shortDescription,
            purpose,
            comment,
            validationRegEx,
            baseTypeName,
            string.Empty)
    {
        FieldOrder = fieldOrder;
        _elementTypes = elementTypes;

        _codes = null;
        if ((baseTypeName == "code") ||
            ((elementTypes != null) && elementTypes.Any((e) => { return e.Key == "code"; })))
        {
            if (shortDescription == "formats supported (xml | json | mime type)")
            {
                _codes = new List<string>()
                {
                    "xml",
                    "json",
                    "MIME Type",
                };
            }
            else if (shortDescription == "formats supported (xml | json | ttl | mime type)")
            {
                _codes = new List<string>()
                {
                    "xml",
                    "json",
                    "ttl",
                    "MIME Type",
                };
            }
            else if ((!string.IsNullOrEmpty(shortDescription)) &&
                shortDescription.Contains('|', StringComparison.Ordinal))
            {
                _codes = new List<string>();
                string[] codeValues = shortDescription.Split('|');
                foreach (string code in codeValues)
                {
                    string clean = code.Trim();
                    if (clean.Contains(" ", StringComparison.Ordinal))
                    {
                        clean = clean.Substring(0, clean.IndexOf(" ", StringComparison.Ordinal));
                    }

                    _codes.Add(clean.Trim());
                }
            }
        }

        _representations = new();
        if ((representations != null) && representations.Any())
        {
            _representations.AddRange(representations);
        }

        ExplicitName = explicitName;

        CardinalityMin = cardinalityMin;
        CardinalityMax = MaxCardinality(cardinalityMax);

        if (cardinalityMax == "0")
        {
            HidesParent = true;
        }
        else
        {
            HidesParent = false;
        }

        IsModifier = isModifier == true;
        IsModifierReason = isModifierReason;
        IsSummary = isSummary == true;
        IsMustSupport = isMustSupport == true;
        _inDifferential = false;
        IsSimple = isSimple;

        DefaultFieldName = defaultFieldName;
        DefaultFieldValue = defaultFieldValue;

        _slicing = new Dictionary<string, FhirSlicing>();

        FixedFieldName = fixedFieldName;
        FixedFieldValue = fixedFieldValue;

        PatternFieldName = patternFieldName;
        PatternFieldValue = patternFieldValue;

        IsInherited = isInherited;
        ModifiesParent = modifiesParent;

        BindingStrength = bindingStrength;
        ValueSet = valueSet;

        if (string.IsNullOrEmpty(bindingStrength))
        {
            ValueSetBindingStrength = null;
        }
        else
        {
            ValueSetBindingStrength = bindingStrength.ToFhirEnum<ElementDefinitionBindingStrength>();
        }

        FiveWs = fiveWs;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FhirElement"/> class.
    /// </summary>
    [System.Text.Json.Serialization.JsonConstructor]
    public FhirElement(
        string id,
        string path,
        string explicitName,
        Uri url,
        int fieldOrder,
        string shortDescription,
        string purpose,
        string comment,
        string validationRegEx,
        string baseTypeName,
        int cardinalityMin,
        int cardinalityMax,
        bool isInherited,
        bool modifiesParent,
        bool hidesParent,
        bool isModifier,
        string isModifierReason,
        bool isSummary,
        bool isMustSupport,
        bool isSimple,
        string codesName,
        List<string> codes,
        string valueSet,
        string bindingStrength,
        ElementDefinitionBindingStrength? valueSetBindingStrength,
        Dictionary<string, FhirElementType> elementTypes,
        string defaultFieldName,
        object defaultFieldValue,
        Dictionary<string, FhirSlicing> slicing,
        string fixedFieldName,
        object fixedFieldValue,
        string patternFieldName,
        object patternFieldValue,
        string fiveWs,
        bool inDifferential)
        : base(
            id,
            path,
            url,
            string.Empty,
            string.Empty,
            null,
            false,
            shortDescription,
            purpose,
            comment,
            validationRegEx,
            baseTypeName,
            string.Empty)
    {
        ExplicitName = explicitName;
        FieldOrder = fieldOrder;
        CardinalityMin = cardinalityMin;
        CardinalityMax = cardinalityMax;
        IsInherited = isInherited;
        ModifiesParent = modifiesParent;
        HidesParent = hidesParent;
        IsModifier = isModifier;
        IsModifierReason = isModifierReason;
        IsSummary = isSummary;
        IsMustSupport = isMustSupport;
        IsSimple = isSimple;
        CodesName = codesName;
        _codes = codes ?? new();
        ValueSet = valueSet;
        BindingStrength = bindingStrength;
        ValueSetBindingStrength = valueSetBindingStrength;
        _elementTypes = elementTypes ?? new();
        DefaultFieldName = defaultFieldName;
        DefaultFieldValue = defaultFieldValue;
        _slicing = slicing ?? new();
        FixedFieldName = fixedFieldName;
        FixedFieldValue = fixedFieldValue;
        PatternFieldName = patternFieldName;
        PatternFieldValue = patternFieldValue;
        FiveWs = fiveWs;
        _inDifferential = inDifferential;
    }

    /// <summary>Values that represent element definition binding strengths.</summary>
    public enum ElementDefinitionBindingStrength : int
    {
        /// <summary>To be conformant, the concept in this element SHALL be from the specified value set.</summary>
        [FhirLiteral("required")]
        Required = 1,

        /// <summary>To be conformant, the concept in this element SHALL be from the specified value set if any of the codes within the value set can apply to the concept being communicated. If the value set does not cover the concept (based on human review), alternate codings (or, data type allowing, text) may be included instead.</summary>
        [FhirLiteral("extensible")]
        Extensible,

        /// <summary>Instances are encouraged to draw from the specified codes for interoperability purposes but are not required to do so to be considered conformant.</summary>
        [FhirLiteral("preferred")]
        Preferred,

        /// <summary>Instances are not expected or even encouraged to draw from the specified value set. The value set merely provides examples of the types of concepts intended to be included.</summary>
        [FhirLiteral("example")]
        Example,
    }

    /// <summary>How a property is represented when serialized.</summary>
    public enum PropertyRepresentationCodes : int
    {
        /// <summary>In XML, this property is represented as an attribute not an element.</summary>
        [FhirLiteral("xmlAttr")]
        xmlAttr = 1,

        /// <summary>This element is represented using the XML text attribute (primitives only).</summary>
        [FhirLiteral("xmlText")]
        xmlText,

        /// <summary>The type of this element is indicated using xsi:type.</summary>
        [FhirLiteral("typeAttr")]
        typeAttr,

        /// <summary>Use CDA narrative instead of XHTML.</summary>
        [FhirLiteral("cdaText")]
        cdaText,

        /// <summary>The property is represented using XHTML.</summary>
        [FhirLiteral("xhtml")]
        xhtml,
    }

    /// <summary>Gets the explicit name of this element, if one was specified.</summary>
    public string ExplicitName { get; }

    /// <summary>Gets the cardinality minimum.</summary>
    public int CardinalityMin { get; }

    /// <summary>Gets the cardinality maximum, -1 for unbounded (e.g., *).</summary>
    /// <value>The cardinality maximum.</value>
    public int CardinalityMax { get; }

    /// <summary>Gets the cardinality maximum string.</summary>
    /// <value>The cardinality maximum string.</value>
    public string CardinalityMaxString
    {
        get
        {
            if (CardinalityMax == -1)
            {
                return "*";
            }

            return $"{CardinalityMax}";
        }
    }

    /// <summary>Gets the FHIR cardinality string: min..max.</summary>
    public string FhirCardinality => $"{CardinalityMin}..{CardinalityMaxString}";

    /// <summary>Gets a value indicating whether this object is inherited.</summary>
    public bool IsInherited { get; }

    /// <summary>Gets a value indicating whether the modifies parent.</summary>
    public bool ModifiesParent { get; }

    /// <summary>Gets a value indicating whether this field hides a parent field.</summary>
    public bool HidesParent { get; }

    /// <summary>Gets a value indicating whether this object is modifier.</summary>
    public bool IsModifier { get; }

    /// <summary>Gets the is modifier reason.</summary>
    public string IsModifierReason { get; }

    /// <summary>Gets a value indicating whether this object is summary.</summary>
    public bool IsSummary { get; }

    /// <summary>Gets a value indicating whether this object is must support.</summary>
    public bool IsMustSupport { get; }

    /// <summary>Gets a value indicating whether this object is simple (no extended properties).</summary>
    public bool IsSimple { get; }

    /// <summary>Gets the field order.</summary>
    public int FieldOrder { get; }

    /// <summary>Gets or sets Code Values allowed for this property.</summary>
    public string CodesName { get; set; }

    /// <summary>Gets the codes.</summary>
    public List<string> Codes => _codes;

    /// <summary>Gets the representation codes.</summary>
    public List<PropertyRepresentationCodes> Representations => _representations;

    /// <summary>Gets the value set this element is bound to.</summary>
    public string ValueSet { get; }

    /// <summary>Gets the binding strength for a value set binding to this element.</summary>
    public string BindingStrength { get; }

    /// <summary>Gets the element binding strength.</summary>
    public ElementDefinitionBindingStrength? ValueSetBindingStrength { get; }

    /// <summary>Gets types and their associated profiles for this element.</summary>
    /// <value>Types and their associated profiles for this element.</value>
    public Dictionary<string, FhirElementType> ElementTypes { get => _elementTypes; }

    /// <summary>Gets the name of the default field.</summary>
    public string DefaultFieldName { get; }

    /// <summary>Gets the default field value.</summary>
    public object DefaultFieldValue { get; }

    /// <summary>Gets the slicing information.</summary>
    public Dictionary<string, FhirSlicing> Slicing => _slicing;

    /// <summary>Gets the name of the fixed field.</summary>
    public string FixedFieldName { get; }

    /// <summary>Gets the fixed field value.</summary>
    public object FixedFieldValue { get; }

    /// <summary>Gets the name of the pattern field.</summary>
    public string PatternFieldName { get; }

    /// <summary>Gets the pattern field value.</summary>
    public object PatternFieldValue { get; }

    /// <summary>Gets a value indicating whether this property is an array.</summary>
    public bool IsArray => (CardinalityMax == -1) || (CardinalityMax > 1);

    /// <summary>Gets a value indicating whether this object is optional.</summary>
    public bool IsOptional => CardinalityMin == 0;

    /// <summary>Gets the five Ws mapping list for the current element.</summary>
    public string FiveWs { get; }

    /// <summary>True if this element appears in the differential.</summary>
    public bool InDifferential => _inDifferential;

    /// <summary>Sets in differential.</summary>
    public void SetInDifferential()
    {
        _inDifferential = true;
    }

    /// <summary>Maximum cardinality.</summary>
    /// <param name="max">The maximum.</param>
    /// <returns>-1 for unbounded cardinality, value for a specific maximum.</returns>
    private static int MaxCardinality(string max)
    {
        if (string.IsNullOrEmpty(max))
        {
            return -1;
        }

        if (max.Equals("*", StringComparison.Ordinal))
        {
            return -1;
        }

        if (int.TryParse(max, out int parsed))
        {
            return parsed;
        }

        return -1;
    }

    /// <summary>Adds a slicing.</summary>
    /// <param name="slicing">Slicing information for this element, if present.</param>
    public void AddSlicing(FhirSlicing slicing)
    {
        string url = slicing.DefinedByUrl.ToString();

        if (!_slicing.ContainsKey(url))
        {
            _slicing.Add(url, slicing);
        }
    }

    /// <summary>Adds a component from an element.</summary>
    /// <param name="url">      URL of this element (if present).</param>
    /// <param name="sliceName">Name of the element.</param>
    /// <returns>True if it succeeds, false if it fails.</returns>
    public bool AddSlice(string url, string sliceName)
    {
        if (!_slicing.ContainsKey(url))
        {
            return false;
        }

        if (_slicing[url].HasSlice(sliceName))
        {
            return false;
        }

        FhirComplex slice = new FhirComplex(
                Id,
                Path,
                ExplicitName,
                BaseTypeName,
                BaseTypeCanonical,
                URL,
                PublicationStatus,
                StandardStatus,
                FhirMaturityLevel,
                false,
                ShortDescription,
                Purpose,
                Comment,
                ValidationRegEx);
        slice.SliceName = sliceName;

        // create a new complex type from the property
        _slicing[url].AddSlice(
            sliceName,
            slice);

        return true;
    }

    /// <summary>FHIR representation codes to enum.</summary>
    /// <param name="codes">The codes.</param>
    /// <returns>A List&lt;PropertyRepresentationCodes&gt;</returns>
    public static List<PropertyRepresentationCodes> ConvertFhirRepresentations(IEnumerable<string> codes)
    {
        if ((codes == null) || (!codes.Any()))
        {
            return new();
        }

        List<PropertyRepresentationCodes> enums = new();

        foreach (string val in codes)
        {
            enums.Add(val.ToFhirEnum<PropertyRepresentationCodes>());
        }

        return enums;
    }

    /// <summary>Deep copy.</summary>
    /// <param name="primitiveTypeMap">   The primitive type map.</param>
    /// <param name="copySlicing">        True to copy slicing.</param>
    /// <param name="canHideParentFields">True if can hide parent fields, false if not.</param>
    /// <param name="valueSetReferences"> [in,out] Value Set URLs and lists of FHIR paths that
    ///  reference them.</param>
    /// <returns>A FhirElement.</returns>
    public FhirElement DeepCopy(
        Dictionary<string, string> primitiveTypeMap,
        bool copySlicing,
        bool canHideParentFields,
        Dictionary<string, ValueSetReferenceInfo> valueSetReferences)
    {
        // copy the element types
        Dictionary<string, FhirElementType> elementTypes = null;

        if (_elementTypes != null)
        {
            elementTypes = new Dictionary<string, FhirElementType>();

            foreach (KeyValuePair<string, FhirElementType> kvp in _elementTypes)
            {
                elementTypes.Add(kvp.Key, kvp.Value.DeepCopy(primitiveTypeMap));
            }
        }

        // generate our copy
        FhirElement element = new FhirElement(
            Id,
            Path,
            ExplicitName,
            URL,
            FieldOrder,
            ShortDescription,
            Purpose,
            Comment,
            ValidationRegEx,
            BaseTypeName,
            elementTypes,
            CardinalityMin,
            CardinalityMax == -1 ? "*" : $"{CardinalityMax}",
            IsModifier,
            IsModifierReason,
            IsSummary,
            IsMustSupport,
            IsSimple,
            DefaultFieldName,
            DefaultFieldValue,
            FixedFieldName,
            FixedFieldValue,
            PatternFieldName,
            PatternFieldValue,
            IsInherited,
            ModifiesParent,
            BindingStrength,
            ValueSet,
            FiveWs,
            _representations);

        // check for base type name
        if (!string.IsNullOrEmpty(BaseTypeName))
        {
            if ((primitiveTypeMap != null) && primitiveTypeMap.ContainsKey(BaseTypeName))
            {
                element.BaseTypeName = primitiveTypeMap[BaseTypeName];
            }
            else
            {
                element.BaseTypeName = BaseTypeName;
            }
        }

        // add slices
        if (copySlicing)
        {
            foreach (KeyValuePair<string, FhirSlicing> kvp in _slicing)
            {
                FhirSlicing slicing = kvp.Value.DeepCopy(
                        primitiveTypeMap,
                        copySlicing,
                        canHideParentFields,
                        valueSetReferences);

                element.AddSlicing(slicing);
            }
        }

        // check for referenced value sets
        if (((!IsInherited) || ModifiesParent) &&
            (valueSetReferences != null) &&
            (!string.IsNullOrEmpty(ValueSet)))
        {
            string url;
            int barIndex = ValueSet.IndexOf('|', StringComparison.Ordinal);

            if (barIndex > 0)
            {
                url = ValueSet.Substring(0, barIndex);
            }
            else
            {
                url = ValueSet;
            }

            if (!valueSetReferences.ContainsKey(url))
            {
                valueSetReferences.Add(url, new ValueSetReferenceInfo());
            }

            if (ValueSetBindingStrength != null)
            {
                //valueSetReferences[url].AddPath(Path, elementTypes.Keys, (ElementDefinitionBindingStrength)ValueSetBindingStrength!);
                valueSetReferences[url].AddPath(this);
            }
        }

        return element;
    }

    /// <summary>Information about the expanded element.</summary>
    public readonly record struct ExpandedElementRec(
        string ProperyName,
        string ExportFhirType,
        string BaseFhirType);

    /// <summary>Names and types for export.</summary>
    /// <param name="rootExportName">        [out] Export name of the root element.</param>
    /// <param name="nameConvention">        The name convention.</param>
    /// <param name="typeConvention">        The convention.</param>
    /// <param name="concatenatePath">       (Optional) True to concatenate path.</param>
    /// <param name="concatenationDelimiter">(Optional) The concatenation delimiter.</param>
    /// <param name="isComponent">           (Optional) True if is component, false if not.</param>
    /// <returns>
    /// A Dictionary of field names (e.g., ValueBoolean) and types (e.g., boolean).
    /// </returns>
    public List<ExpandedElementRec> ExpandNamesAndTypes(
        out string rootExportName,
        NamingConvention nameConvention,
        NamingConvention typeConvention,
        bool concatenatePath = false,
        string concatenationDelimiter = "",
        bool isComponent = false)
    {
        HashSet<string> usedNames = new();
        List<ExpandedElementRec> values = new();

        string baseName = Name;
        bool isChoice = false;

        if (isComponent)
        {
            values.Add(
                new (
                    FhirUtils.ToConvention(Name, Path, nameConvention, concatenatePath, concatenationDelimiter),
                    FhirUtils.ToConvention(Path, string.Empty, typeConvention),
                    Name));

            rootExportName = values[0].ProperyName;
            return values;
        }

        if ((_elementTypes != null) && (_elementTypes.Count > 0))
        {
            if (baseName.Contains("[x]", StringComparison.OrdinalIgnoreCase))
            {
                baseName = baseName.Replace("[x]", string.Empty, StringComparison.OrdinalIgnoreCase);
                isChoice = true;
            }

            if (isChoice)
            {
                foreach (FhirElementType elementType in _elementTypes.Values)
                {
                    string name = FhirUtils.ToConvention(baseName, Path, nameConvention, concatenatePath, concatenationDelimiter);
                    string type = FhirUtils.ToConvention(elementType.Name, string.Empty, typeConvention);

                    string combined = $"{name}{type}";

                    if (!usedNames.Contains(combined))
                    {
                        usedNames.Add(combined);
                        values.Add(new(combined, elementType.Type, elementType.Name));
                    }
                }
            }
            else
            {
                string types = string.Empty;
                string fhirTypeName = baseName;

                foreach (FhirElementType elementType in _elementTypes.Values)
                {
                    if (!string.IsNullOrEmpty(elementType.Name))
                    {
                        fhirTypeName = elementType.Name;
                    }

                    string type = elementType.Type;

                    if (string.IsNullOrEmpty(types))
                    {
                        types = type;
                    }
                    else
                    {
                        types = $"{types}|{type}";
                    }
                }

                string cased = FhirUtils.ToConvention(baseName, string.Empty, nameConvention, concatenatePath, concatenationDelimiter);

                if (!usedNames.Contains(cased))
                {
                    usedNames.Add(cased);
                    values.Add(new(cased, types, fhirTypeName));
                }
            }

            rootExportName = baseName;
            return values;
        }

        values.Add(new(
            FhirUtils.ToConvention(Name, Path, nameConvention, concatenatePath, concatenationDelimiter),
            FhirUtils.ToConvention(BaseTypeName, string.Empty, typeConvention),
            BaseTypeName));

        rootExportName = values[0].ProperyName;
        return values;
    }

    /// <summary>Names and types for export.</summary>
    /// <param name="nameConvention">        The name convention.</param>
    /// <param name="typeConvention">        The convention.</param>
    /// <param name="concatenatePath">       (Optional) True to concatenate path.</param>
    /// <param name="concatenationDelimiter">(Optional) The concatenation delimiter.</param>
    /// <param name="isComponent">           (Optional) True if is component, false if not.</param>
    /// <returns>A Dictionary of field names (e.g., ValueBoolean) and types (e.g., boolean).</returns>
    public Dictionary<string, string> NamesAndTypesForExport(
        NamingConvention nameConvention,
        NamingConvention typeConvention,
        bool concatenatePath = false,
        string concatenationDelimiter = "",
        bool isComponent = false)
    {
        Dictionary<string, string> values = new Dictionary<string, string>();

        string baseName = Name;
        bool isChoice = false;

        if (isComponent)
        {
            values.Add(
                FhirUtils.ToConvention(Name, Path, nameConvention, concatenatePath, concatenationDelimiter),
                FhirUtils.ToConvention(Path, string.Empty, typeConvention));

            return values;
        }

        if ((_elementTypes != null) && (_elementTypes.Count > 0))
        {
            if (baseName.Contains("[x]", StringComparison.OrdinalIgnoreCase))
            {
                baseName = baseName.Replace("[x]", string.Empty, StringComparison.OrdinalIgnoreCase);
                isChoice = true;
            }

            if (isChoice)
            {
                foreach (FhirElementType elementType in _elementTypes.Values)
                {
                    string name = FhirUtils.ToConvention(baseName, Path, nameConvention, concatenatePath, concatenationDelimiter);
                    string type = FhirUtils.ToConvention(elementType.Name, string.Empty, typeConvention);

                    string combined = $"{name}{type}";

                    if (!values.ContainsKey(combined))
                    {
                        values.Add(combined, elementType.Type);
                    }
                }
            }
            else
            {
                string types = string.Empty;

                foreach (FhirElementType elementType in _elementTypes.Values)
                {
                    string type = elementType.Type;

                    if (string.IsNullOrEmpty(types))
                    {
                        types = type;
                    }
                    else
                    {
                        types = $"{types}|{type}";
                    }
                }

                string cased = FhirUtils.ToConvention(baseName, string.Empty, nameConvention, concatenatePath, concatenationDelimiter);

                if (!values.ContainsKey(cased))
                {
                    values.Add(cased, types);
                }
            }

            return values;
        }

        values.Add(
            FhirUtils.ToConvention(Name, Path, nameConvention, concatenatePath, concatenationDelimiter),
            FhirUtils.ToConvention(BaseTypeName, string.Empty, typeConvention));

        return values;
    }
}
