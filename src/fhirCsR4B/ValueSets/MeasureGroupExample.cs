// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Example Measure Groups for the Measure Resource.
  /// </summary>
  public static class MeasureGroupExampleCodes
  {
    /// <summary>
    /// Primary Measure Group.
    /// </summary>
    public static readonly Coding PrimaryRate = new Coding
    {
      Code = "primary-rate",
      Display = "Primary Rate",
      System = "http://terminology.hl7.org/CodeSystem/measure-group-example"
    };
    /// <summary>
    /// Secondary Measure Group
    /// </summary>
    public static readonly Coding SecondaryRate = new Coding
    {
      Code = "secondary-rate",
      Display = "Secondary Rate",
      System = "http://terminology.hl7.org/CodeSystem/measure-group-example"
    };

    /// <summary>
    /// Literal for code: PrimaryRate
    /// </summary>
    public const string LiteralPrimaryRate = "primary-rate";

    /// <summary>
    /// Literal for code: SecondaryRate
    /// </summary>
    public const string LiteralSecondaryRate = "secondary-rate";
  };
}