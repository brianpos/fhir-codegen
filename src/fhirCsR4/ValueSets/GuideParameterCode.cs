// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Code of parameter that is input to the guide.
  /// </summary>
  public static class GuideParameterCodeCodes
  {
    /// <summary>
    /// If the value of this string 0..* parameter is one of the metadata fields then all conformance resources will have any specified [Resource].[field] overwritten with the ImplementationGuide.[field], where field is one of: version, date, status, publisher, contact, copyright, experimental, jurisdiction, useContext.
    /// </summary>
    public static readonly Coding ApplyMetadataValue = new Coding
    {
      Code = "apply",
      Display = "Apply Metadata Value",
      System = "http://hl7.org/fhir/guide-parameter-code"
    };
    /// <summary>
    /// The value of this string 0..* parameter is a parameter (name=value) when expanding value sets for this implementation guide. This is particularly used to specify the versions of published terminologies such as SNOMED CT.
    /// </summary>
    public static readonly Coding ExpansionProfile = new Coding
    {
      Code = "expansion-parameter",
      Display = "Expansion Profile",
      System = "http://hl7.org/fhir/guide-parameter-code"
    };
    /// <summary>
    /// The value of this boolean 0..1 parameter specifies whether the IG publisher creates examples in JSON format. If not present, the Publication Tool decides whether to generate JSON.
    /// </summary>
    public static readonly Coding GenerateJSON = new Coding
    {
      Code = "generate-json",
      Display = "Generate JSON",
      System = "http://hl7.org/fhir/guide-parameter-code"
    };
    /// <summary>
    /// The value of this boolean 0..1 parameter specifies whether the IG publisher creates examples in Turtle format. If not present, the Publication Tool decides whether to generate Turtle.
    /// </summary>
    public static readonly Coding GenerateTurtle = new Coding
    {
      Code = "generate-turtle",
      Display = "Generate Turtle",
      System = "http://hl7.org/fhir/guide-parameter-code"
    };
    /// <summary>
    /// The value of this boolean 0..1 parameter specifies whether the IG publisher creates examples in XML format. If not present, the Publication Tool decides whether to generate XML.
    /// </summary>
    public static readonly Coding GenerateXML = new Coding
    {
      Code = "generate-xml",
      Display = "Generate XML",
      System = "http://hl7.org/fhir/guide-parameter-code"
    };
    /// <summary>
    /// The value of this string singleton parameter is the name of the file to use as the builder template for each generated page (see templating).
    /// </summary>
    public static readonly Coding HTMLTemplate = new Coding
    {
      Code = "html-template",
      Display = "HTML Template",
      System = "http://hl7.org/fhir/guide-parameter-code"
    };
    /// <summary>
    /// The value of this string 0..1 parameter is a subfolder of the build context's location that contains files that are part of the html content processed by the builder.
    /// </summary>
    public static readonly Coding PagesPath = new Coding
    {
      Code = "path-pages",
      Display = "Pages Path",
      System = "http://hl7.org/fhir/guide-parameter-code"
    };
    /// <summary>
    /// The value of this string 0..* parameter is a subfolder of the build context's location that is to be scanned to load resources. Scope is (if present) a particular resource type.
    /// </summary>
    public static readonly Coding ResourcePath = new Coding
    {
      Code = "path-resource",
      Display = "Resource Path",
      System = "http://hl7.org/fhir/guide-parameter-code"
    };
    /// <summary>
    /// The value of this string 0..1 parameter is a subfolder of the build context's location that is used as the terminology cache. If this is not present, the terminology cache is on the local system, not under version control.
    /// </summary>
    public static readonly Coding TerminologyCachePath = new Coding
    {
      Code = "path-tx-cache",
      Display = "Terminology Cache Path",
      System = "http://hl7.org/fhir/guide-parameter-code"
    };
    /// <summary>
    /// The value of this string 0..1 parameter is either "warning" or "error" (default = "error"). If the value is "warning" then IG build tools allow the IG to be considered successfully build even when there is no internal broken links.
    /// </summary>
    public static readonly Coding BrokenLinksRule = new Coding
    {
      Code = "rule-broken-links",
      Display = "Broken Links Rule",
      System = "http://hl7.org/fhir/guide-parameter-code"
    };

    /// <summary>
    /// Literal for code: ApplyMetadataValue
    /// </summary>
    public const string LiteralApplyMetadataValue = "apply";

    /// <summary>
    /// Literal for code: ExpansionProfile
    /// </summary>
    public const string LiteralExpansionProfile = "expansion-parameter";

    /// <summary>
    /// Literal for code: GenerateJSON
    /// </summary>
    public const string LiteralGenerateJSON = "generate-json";

    /// <summary>
    /// Literal for code: GenerateTurtle
    /// </summary>
    public const string LiteralGenerateTurtle = "generate-turtle";

    /// <summary>
    /// Literal for code: GenerateXML
    /// </summary>
    public const string LiteralGenerateXML = "generate-xml";

    /// <summary>
    /// Literal for code: HTMLTemplate
    /// </summary>
    public const string LiteralHTMLTemplate = "html-template";

    /// <summary>
    /// Literal for code: PagesPath
    /// </summary>
    public const string LiteralPagesPath = "path-pages";

    /// <summary>
    /// Literal for code: ResourcePath
    /// </summary>
    public const string LiteralResourcePath = "path-resource";

    /// <summary>
    /// Literal for code: TerminologyCachePath
    /// </summary>
    public const string LiteralTerminologyCachePath = "path-tx-cache";

    /// <summary>
    /// Literal for code: BrokenLinksRule
    /// </summary>
    public const string LiteralBrokenLinksRule = "rule-broken-links";
  };
}