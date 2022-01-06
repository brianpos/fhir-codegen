// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value set includes Example Coverage Financial Exception Codes.
  /// </summary>
  public static class CoverageFinancialExceptionCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding FosterChild = new Coding
    {
      Code = "foster",
      Display = "Foster child",
      System = "http://terminology.hl7.org/CodeSystem/ex-coverage-financial-exception"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Retired = new Coding
    {
      Code = "retired",
      Display = "Retired",
      System = "http://terminology.hl7.org/CodeSystem/ex-coverage-financial-exception"
    };

    /// <summary>
    /// Literal for code: FosterChild
    /// </summary>
    public const string LiteralFosterChild = "foster";

    /// <summary>
    /// Literal for code: Retired
    /// </summary>
    public const string LiteralRetired = "retired";
  };
}