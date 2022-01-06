// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// Details of how a designation would be used
  /// </summary>
  public static class DesignationUseCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding FullySpecifiedName = new Coding
    {
      Code = "900000000000003001",
      Display = "Fully specified name",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Synonym = new Coding
    {
      Code = "900000000000013009",
      Display = "Synonym",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Definition = new Coding
    {
      Code = "900000000000550004",
      Display = "Definition",
      System = "http://snomed.info/sct"
    };

    /// <summary>
    /// Literal for code: FullySpecifiedName
    /// </summary>
    public const string LiteralFullySpecifiedName = "900000000000003001";

    /// <summary>
    /// Literal for code: Synonym
    /// </summary>
    public const string LiteralSynonym = "900000000000013009";

    /// <summary>
    /// Literal for code: Definition
    /// </summary>
    public const string LiteralDefinition = "900000000000550004";
  };
}