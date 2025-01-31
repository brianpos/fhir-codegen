// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Used to distinguish different roles a resource can play within a set of linked resources.
  /// </summary>
  public static class LinkageTypeCodes
  {
    /// <summary>
    /// The resource represents an alternative view of the underlying event/condition/etc.  The resource may still be actively maintained, even though it is not considered to be the source of truth.
    /// </summary>
    public static readonly Coding AlternateRecord = new Coding
    {
      Code = "alternate",
      Display = "Alternate Record",
      System = "http://hl7.org/fhir/linkage-type"
    };
    /// <summary>
    /// The resource represents an obsolete record of the underlying event/condition/etc.  It is not expected to be actively maintained.
    /// </summary>
    public static readonly Coding HistoricalObsoleteRecord = new Coding
    {
      Code = "historical",
      Display = "Historical/Obsolete Record",
      System = "http://hl7.org/fhir/linkage-type"
    };
    /// <summary>
    /// The resource represents the "source of truth" (from the perspective of this Linkage resource) for the underlying event/condition/etc.
    /// </summary>
    public static readonly Coding SourceOfTruth = new Coding
    {
      Code = "source",
      Display = "Source of Truth",
      System = "http://hl7.org/fhir/linkage-type"
    };

    /// <summary>
    /// Literal for code: AlternateRecord
    /// </summary>
    public const string LiteralAlternateRecord = "alternate";

    /// <summary>
    /// Literal for code: LinkageTypeAlternateRecord
    /// </summary>
    public const string LiteralLinkageTypeAlternateRecord = "http://hl7.org/fhir/linkage-type#alternate";

    /// <summary>
    /// Literal for code: HistoricalObsoleteRecord
    /// </summary>
    public const string LiteralHistoricalObsoleteRecord = "historical";

    /// <summary>
    /// Literal for code: LinkageTypeHistoricalObsoleteRecord
    /// </summary>
    public const string LiteralLinkageTypeHistoricalObsoleteRecord = "http://hl7.org/fhir/linkage-type#historical";

    /// <summary>
    /// Literal for code: SourceOfTruth
    /// </summary>
    public const string LiteralSourceOfTruth = "source";

    /// <summary>
    /// Literal for code: LinkageTypeSourceOfTruth
    /// </summary>
    public const string LiteralLinkageTypeSourceOfTruth = "http://hl7.org/fhir/linkage-type#source";

    /// <summary>
    /// Dictionary for looking up LinkageType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "alternate", AlternateRecord }, 
      { "http://hl7.org/fhir/linkage-type#alternate", AlternateRecord }, 
      { "historical", HistoricalObsoleteRecord }, 
      { "http://hl7.org/fhir/linkage-type#historical", HistoricalObsoleteRecord }, 
      { "source", SourceOfTruth }, 
      { "http://hl7.org/fhir/linkage-type#source", SourceOfTruth }, 
    };
  };
}
