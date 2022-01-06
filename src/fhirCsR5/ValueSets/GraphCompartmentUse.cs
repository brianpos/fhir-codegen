// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Defines how a compartment rule is used.
  /// </summary>
  public static class GraphCompartmentUseCodes
  {
    /// <summary>
    /// This compartment rule is a condition for whether the rule applies.
    /// </summary>
    public static readonly Coding Condition = new Coding
    {
      Code = "condition",
      Display = "Condition",
      System = "http://hl7.org/fhir/graph-compartment-use"
    };
    /// <summary>
    /// This compartment rule is enforced on any relationships that meet the conditions.
    /// </summary>
    public static readonly Coding Requirement = new Coding
    {
      Code = "requirement",
      Display = "Requirement",
      System = "http://hl7.org/fhir/graph-compartment-use"
    };

    /// <summary>
    /// Literal for code: Condition
    /// </summary>
    public const string LiteralCondition = "condition";

    /// <summary>
    /// Literal for code: Requirement
    /// </summary>
    public const string LiteralRequirement = "requirement";
  };
}