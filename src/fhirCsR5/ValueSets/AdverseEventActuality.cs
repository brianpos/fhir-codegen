// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Overall nature of the adverse event, e.g. real or potential.
  /// </summary>
  public static class AdverseEventActualityCodes
  {
    /// <summary>
    /// The adverse event actually happened regardless of whether anyone was affected or harmed.
    /// </summary>
    public static readonly Coding AdverseEvent = new Coding
    {
      Code = "actual",
      Display = "Adverse Event",
      System = "http://hl7.org/fhir/adverse-event-actuality"
    };
    /// <summary>
    /// A potential adverse event.
    /// </summary>
    public static readonly Coding PotentialAdverseEvent = new Coding
    {
      Code = "potential",
      Display = "Potential Adverse Event",
      System = "http://hl7.org/fhir/adverse-event-actuality"
    };

    /// <summary>
    /// Literal for code: AdverseEvent
    /// </summary>
    public const string LiteralAdverseEvent = "actual";

    /// <summary>
    /// Literal for code: PotentialAdverseEvent
    /// </summary>
    public const string LiteralPotentialAdverseEvent = "potential";
  };
}