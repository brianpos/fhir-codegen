// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Structure Definition Use Codes / Keywords
  /// </summary>
  public static class DefinitionUseCodes
  {
    /// <summary>
    /// Domain Analysis Model
    /// </summary>
    public static readonly Coding DomainAnalysisModel = new Coding
    {
      Code = "archetype",
      Display = "Domain Analysis Model",
      System = "http://terminology.hl7.org/CodeSystem/definition-use"
    };
    /// <summary>
    /// Custom Resource
    /// </summary>
    public static readonly Coding CustomResource = new Coding
    {
      Code = "custom-resource",
      Display = "Custom Resource",
      System = "http://terminology.hl7.org/CodeSystem/definition-use"
    };
    /// <summary>
    /// Domain Analysis Model
    /// </summary>
    public static readonly Coding DomainAnalysisModel_2 = new Coding
    {
      Code = "dam",
      Display = "Domain Analysis Model",
      System = "http://terminology.hl7.org/CodeSystem/definition-use"
    };
    /// <summary>
    /// FHIR Structure
    /// </summary>
    public static readonly Coding FHIRStructure = new Coding
    {
      Code = "fhir-structure",
      Display = "FHIR Structure",
      System = "http://terminology.hl7.org/CodeSystem/definition-use"
    };
    /// <summary>
    /// Template
    /// </summary>
    public static readonly Coding Template = new Coding
    {
      Code = "template",
      Display = "Template",
      System = "http://terminology.hl7.org/CodeSystem/definition-use"
    };
    /// <summary>
    /// Wire Format
    /// </summary>
    public static readonly Coding WireFormat = new Coding
    {
      Code = "wire-format",
      Display = "Wire Format",
      System = "http://terminology.hl7.org/CodeSystem/definition-use"
    };

    /// <summary>
    /// Literal for code: DomainAnalysisModel
    /// </summary>
    public const string LiteralDomainAnalysisModel = "archetype";

    /// <summary>
    /// Literal for code: DefinitionUseDomainAnalysisModel
    /// </summary>
    public const string LiteralDefinitionUseDomainAnalysisModel = "http://terminology.hl7.org/CodeSystem/definition-use#archetype";

    /// <summary>
    /// Literal for code: CustomResource
    /// </summary>
    public const string LiteralCustomResource = "custom-resource";

    /// <summary>
    /// Literal for code: DefinitionUseCustomResource
    /// </summary>
    public const string LiteralDefinitionUseCustomResource = "http://terminology.hl7.org/CodeSystem/definition-use#custom-resource";

    /// <summary>
    /// Literal for code: DomainAnalysisModel_2
    /// </summary>
    public const string LiteralDomainAnalysisModel_2 = "dam";

    /// <summary>
    /// Literal for code: DefinitionUseDomainAnalysisModel_2
    /// </summary>
    public const string LiteralDefinitionUseDomainAnalysisModel_2 = "http://terminology.hl7.org/CodeSystem/definition-use#dam";

    /// <summary>
    /// Literal for code: FHIRStructure
    /// </summary>
    public const string LiteralFHIRStructure = "fhir-structure";

    /// <summary>
    /// Literal for code: DefinitionUseFHIRStructure
    /// </summary>
    public const string LiteralDefinitionUseFHIRStructure = "http://terminology.hl7.org/CodeSystem/definition-use#fhir-structure";

    /// <summary>
    /// Literal for code: Template
    /// </summary>
    public const string LiteralTemplate = "template";

    /// <summary>
    /// Literal for code: DefinitionUseTemplate
    /// </summary>
    public const string LiteralDefinitionUseTemplate = "http://terminology.hl7.org/CodeSystem/definition-use#template";

    /// <summary>
    /// Literal for code: WireFormat
    /// </summary>
    public const string LiteralWireFormat = "wire-format";

    /// <summary>
    /// Literal for code: DefinitionUseWireFormat
    /// </summary>
    public const string LiteralDefinitionUseWireFormat = "http://terminology.hl7.org/CodeSystem/definition-use#wire-format";

    /// <summary>
    /// Dictionary for looking up DefinitionUse Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "archetype", DomainAnalysisModel }, 
      { "http://terminology.hl7.org/CodeSystem/definition-use#archetype", DomainAnalysisModel }, 
      { "custom-resource", CustomResource }, 
      { "http://terminology.hl7.org/CodeSystem/definition-use#custom-resource", CustomResource }, 
      { "dam", DomainAnalysisModel_2 }, 
      { "http://terminology.hl7.org/CodeSystem/definition-use#dam", DomainAnalysisModel_2 }, 
      { "fhir-structure", FHIRStructure }, 
      { "http://terminology.hl7.org/CodeSystem/definition-use#fhir-structure", FHIRStructure }, 
      { "template", Template }, 
      { "http://terminology.hl7.org/CodeSystem/definition-use#template", Template }, 
      { "wire-format", WireFormat }, 
      { "http://terminology.hl7.org/CodeSystem/definition-use#wire-format", WireFormat }, 
    };
  };
}
