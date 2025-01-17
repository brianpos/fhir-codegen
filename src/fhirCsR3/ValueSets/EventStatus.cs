// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// Codes identifying the stage lifecycle stage of a event
  /// </summary>
  public static class EventStatusCodes
  {
    /// <summary>
    /// The event was  prior to the full completion of the intended actions
    /// </summary>
    public static readonly Coding Aborted = new Coding
    {
      Code = "aborted",
      Display = "Aborted",
      System = "http://hl7.org/fhir/event-status"
    };
    /// <summary>
    /// The event has now concluded
    /// </summary>
    public static readonly Coding Completed = new Coding
    {
      Code = "completed",
      Display = "Completed",
      System = "http://hl7.org/fhir/event-status"
    };
    /// <summary>
    /// This electronic record should never have existed, though it is possible that real-world decisions were based on it.  (If real-world activity has occurred, the status should be "cancelled" rather than "entered-in-error".)
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://hl7.org/fhir/event-status"
    };
    /// <summary>
    /// The event is currently occurring
    /// </summary>
    public static readonly Coding InProgress = new Coding
    {
      Code = "in-progress",
      Display = "In Progress",
      System = "http://hl7.org/fhir/event-status"
    };
    /// <summary>
    /// The core event has not started yet, but some staging activities have begun (e.g. surgical suite preparation).  Preparation stages may be tracked for billing purposes.
    /// </summary>
    public static readonly Coding Preparation = new Coding
    {
      Code = "preparation",
      Display = "Preparation",
      System = "http://hl7.org/fhir/event-status"
    };
    /// <summary>
    /// The event has been temporarily stopped but is expected to resume in the future
    /// </summary>
    public static readonly Coding Suspended = new Coding
    {
      Code = "suspended",
      Display = "Suspended",
      System = "http://hl7.org/fhir/event-status"
    };
    /// <summary>
    /// The authoring system does not know which of the status values currently applies for this request.  Note: This concept is not to be used for "other" - one of the listed statuses is presumed to apply, it's just not known which one.
    /// </summary>
    public static readonly Coding Unknown = new Coding
    {
      Code = "unknown",
      Display = "Unknown",
      System = "http://hl7.org/fhir/event-status"
    };

    /// <summary>
    /// Literal for code: Aborted
    /// </summary>
    public const string LiteralAborted = "aborted";

    /// <summary>
    /// Literal for code: EventStatusAborted
    /// </summary>
    public const string LiteralEventStatusAborted = "http://hl7.org/fhir/event-status#aborted";

    /// <summary>
    /// Literal for code: Completed
    /// </summary>
    public const string LiteralCompleted = "completed";

    /// <summary>
    /// Literal for code: EventStatusCompleted
    /// </summary>
    public const string LiteralEventStatusCompleted = "http://hl7.org/fhir/event-status#completed";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: EventStatusEnteredInError
    /// </summary>
    public const string LiteralEventStatusEnteredInError = "http://hl7.org/fhir/event-status#entered-in-error";

    /// <summary>
    /// Literal for code: InProgress
    /// </summary>
    public const string LiteralInProgress = "in-progress";

    /// <summary>
    /// Literal for code: EventStatusInProgress
    /// </summary>
    public const string LiteralEventStatusInProgress = "http://hl7.org/fhir/event-status#in-progress";

    /// <summary>
    /// Literal for code: Preparation
    /// </summary>
    public const string LiteralPreparation = "preparation";

    /// <summary>
    /// Literal for code: EventStatusPreparation
    /// </summary>
    public const string LiteralEventStatusPreparation = "http://hl7.org/fhir/event-status#preparation";

    /// <summary>
    /// Literal for code: Suspended
    /// </summary>
    public const string LiteralSuspended = "suspended";

    /// <summary>
    /// Literal for code: EventStatusSuspended
    /// </summary>
    public const string LiteralEventStatusSuspended = "http://hl7.org/fhir/event-status#suspended";

    /// <summary>
    /// Literal for code: Unknown
    /// </summary>
    public const string LiteralUnknown = "unknown";

    /// <summary>
    /// Literal for code: EventStatusUnknown
    /// </summary>
    public const string LiteralEventStatusUnknown = "http://hl7.org/fhir/event-status#unknown";

    /// <summary>
    /// Dictionary for looking up EventStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "aborted", Aborted }, 
      { "http://hl7.org/fhir/event-status#aborted", Aborted }, 
      { "completed", Completed }, 
      { "http://hl7.org/fhir/event-status#completed", Completed }, 
      { "entered-in-error", EnteredInError }, 
      { "http://hl7.org/fhir/event-status#entered-in-error", EnteredInError }, 
      { "in-progress", InProgress }, 
      { "http://hl7.org/fhir/event-status#in-progress", InProgress }, 
      { "preparation", Preparation }, 
      { "http://hl7.org/fhir/event-status#preparation", Preparation }, 
      { "suspended", Suspended }, 
      { "http://hl7.org/fhir/event-status#suspended", Suspended }, 
      { "unknown", Unknown }, 
      { "http://hl7.org/fhir/event-status#unknown", Unknown }, 
    };
  };
}
