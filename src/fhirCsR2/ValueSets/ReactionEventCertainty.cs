// <auto-generated />
// Built from: hl7.fhir.r2.core version: 1.0.2
  // Option: "NAMESPACE" = "fhirCsR2"

using fhirCsR2.Models;

namespace fhirCsR2.ValueSets
{
  /// <summary>
  /// Statement about the degree of clinical certainty that a Specific Substance was the cause of the Manifestation in an reaction event.
  /// </summary>
  public static class ReactionEventCertaintyCodes
  {
    /// <summary>
    /// There is a very high level of clinical certainty that the reaction was due to the identified Substance, which may include clinical evidence by testing or rechallenge.
    /// </summary>
    public static readonly Coding Confirmed = new Coding
    {
      Code = "confirmed",
      Display = "Confirmed",
      System = "http://hl7.org/fhir/reaction-event-certainty"
    };
    /// <summary>
    /// There is a high level of clinical certainty that the reaction was caused by the identified Substance.
    /// </summary>
    public static readonly Coding Likely = new Coding
    {
      Code = "likely",
      Display = "Likely",
      System = "http://hl7.org/fhir/reaction-event-certainty"
    };
    /// <summary>
    /// There is a low level of clinical certainty that the reaction was caused by the identified Substance.
    /// </summary>
    public static readonly Coding Unlikely = new Coding
    {
      Code = "unlikely",
      Display = "Unlikely",
      System = "http://hl7.org/fhir/reaction-event-certainty"
    };

    /// <summary>
    /// Literal for code: Confirmed
    /// </summary>
    public const string LiteralConfirmed = "confirmed";

    /// <summary>
    /// Literal for code: Likely
    /// </summary>
    public const string LiteralLikely = "likely";

    /// <summary>
    /// Literal for code: Unlikely
    /// </summary>
    public const string LiteralUnlikely = "unlikely";
  };
}