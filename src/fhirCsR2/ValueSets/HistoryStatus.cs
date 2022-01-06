// <auto-generated />
// Built from: hl7.fhir.r2.core version: 1.0.2
  // Option: "NAMESPACE" = "fhirCsR2"

using fhirCsR2.Models;

namespace fhirCsR2.ValueSets
{
  /// <summary>
  /// A code that identifies the status of the family history record.
  /// </summary>
  public static class HistoryStatusCodes
  {
    /// <summary>
    /// All relevant health information is known and captured.
    /// </summary>
    public static readonly Coding Completed = new Coding
    {
      Code = "completed",
      Display = "Completed",
      System = "http://hl7.org/fhir/history-status"
    };
    /// <summary>
    /// This instance should not have been part of this patient's medical record.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in error",
      System = "http://hl7.org/fhir/history-status"
    };
    /// <summary>
    /// Health information for this individual is unavailable/unknown.
    /// </summary>
    public static readonly Coding HealthUnknown = new Coding
    {
      Code = "health-unknown",
      Display = "Health unknown",
      System = "http://hl7.org/fhir/history-status"
    };
    /// <summary>
    /// Some health information is known and captured, but not complete - see notes for details.
    /// </summary>
    public static readonly Coding Partial = new Coding
    {
      Code = "partial",
      Display = "Partial",
      System = "http://hl7.org/fhir/history-status"
    };

    /// <summary>
    /// Literal for code: Completed
    /// </summary>
    public const string LiteralCompleted = "completed";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: HealthUnknown
    /// </summary>
    public const string LiteralHealthUnknown = "health-unknown";

    /// <summary>
    /// Literal for code: Partial
    /// </summary>
    public const string LiteralPartial = "partial";
  };
}