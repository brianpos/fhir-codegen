// <auto-generated />
// Built from: hl7.fhir.r2.core version: 1.0.2
  // Option: "NAMESPACE" = "fhirCsR2"

using fhirCsR2.Models;

namespace fhirCsR2.ValueSets
{
  /// <summary>
  /// Codes providing the status of an observation.
  /// </summary>
  public static class ObservationStatusCodes
  {
    /// <summary>
    /// The observation has been modified subsequent to being Final, and is complete and verified by an authorized person.
    /// </summary>
    public static readonly Coding Amended = new Coding
    {
      Code = "amended",
      Display = "Amended",
      System = "http://hl7.org/fhir/observation-status"
    };
    /// <summary>
    /// The observation is unavailable because the measurement was not started or not completed (also sometimes called "aborted").
    /// </summary>
    public static readonly Coding Cancelled = new Coding
    {
      Code = "cancelled",
      Display = "cancelled",
      System = "http://hl7.org/fhir/observation-status"
    };
    /// <summary>
    /// The observation has been withdrawn following previous final release.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://hl7.org/fhir/observation-status"
    };
    /// <summary>
    /// The observation is complete and verified by an authorized person.
    /// </summary>
    public static readonly Coding Final = new Coding
    {
      Code = "final",
      Display = "Final",
      System = "http://hl7.org/fhir/observation-status"
    };
    /// <summary>
    /// This is an initial or interim observation: data may be incomplete or unverified.
    /// </summary>
    public static readonly Coding Preliminary = new Coding
    {
      Code = "preliminary",
      Display = "Preliminary",
      System = "http://hl7.org/fhir/observation-status"
    };
    /// <summary>
    /// The existence of the observation is registered, but there is no result yet available.
    /// </summary>
    public static readonly Coding Registered = new Coding
    {
      Code = "registered",
      Display = "Registered",
      System = "http://hl7.org/fhir/observation-status"
    };
    /// <summary>
    /// The observation status is unknown.  Note that "unknown" is a value of last resort and every attempt should be made to provide a meaningful value other than "unknown".
    /// </summary>
    public static readonly Coding UnknownStatus = new Coding
    {
      Code = "unknown",
      Display = "Unknown Status",
      System = "http://hl7.org/fhir/observation-status"
    };

    /// <summary>
    /// Literal for code: Amended
    /// </summary>
    public const string LiteralAmended = "amended";

    /// <summary>
    /// Literal for code: ObservationStatusAmended
    /// </summary>
    public const string LiteralObservationStatusAmended = "http://hl7.org/fhir/observation-status#amended";

    /// <summary>
    /// Literal for code: Cancelled
    /// </summary>
    public const string LiteralCancelled = "cancelled";

    /// <summary>
    /// Literal for code: ObservationStatusCancelled
    /// </summary>
    public const string LiteralObservationStatusCancelled = "http://hl7.org/fhir/observation-status#cancelled";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: ObservationStatusEnteredInError
    /// </summary>
    public const string LiteralObservationStatusEnteredInError = "http://hl7.org/fhir/observation-status#entered-in-error";

    /// <summary>
    /// Literal for code: Final
    /// </summary>
    public const string LiteralFinal = "final";

    /// <summary>
    /// Literal for code: ObservationStatusFinal
    /// </summary>
    public const string LiteralObservationStatusFinal = "http://hl7.org/fhir/observation-status#final";

    /// <summary>
    /// Literal for code: Preliminary
    /// </summary>
    public const string LiteralPreliminary = "preliminary";

    /// <summary>
    /// Literal for code: ObservationStatusPreliminary
    /// </summary>
    public const string LiteralObservationStatusPreliminary = "http://hl7.org/fhir/observation-status#preliminary";

    /// <summary>
    /// Literal for code: Registered
    /// </summary>
    public const string LiteralRegistered = "registered";

    /// <summary>
    /// Literal for code: ObservationStatusRegistered
    /// </summary>
    public const string LiteralObservationStatusRegistered = "http://hl7.org/fhir/observation-status#registered";

    /// <summary>
    /// Literal for code: UnknownStatus
    /// </summary>
    public const string LiteralUnknownStatus = "unknown";

    /// <summary>
    /// Literal for code: ObservationStatusUnknownStatus
    /// </summary>
    public const string LiteralObservationStatusUnknownStatus = "http://hl7.org/fhir/observation-status#unknown";

    /// <summary>
    /// Dictionary for looking up ObservationStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "amended", Amended }, 
      { "http://hl7.org/fhir/observation-status#amended", Amended }, 
      { "cancelled", Cancelled }, 
      { "http://hl7.org/fhir/observation-status#cancelled", Cancelled }, 
      { "entered-in-error", EnteredInError }, 
      { "http://hl7.org/fhir/observation-status#entered-in-error", EnteredInError }, 
      { "final", Final }, 
      { "http://hl7.org/fhir/observation-status#final", Final }, 
      { "preliminary", Preliminary }, 
      { "http://hl7.org/fhir/observation-status#preliminary", Preliminary }, 
      { "registered", Registered }, 
      { "http://hl7.org/fhir/observation-status#registered", Registered }, 
      { "unknown", UnknownStatus }, 
      { "http://hl7.org/fhir/observation-status#unknown", UnknownStatus }, 
    };
  };
}
