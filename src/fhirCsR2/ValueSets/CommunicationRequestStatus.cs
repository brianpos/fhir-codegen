// <auto-generated />
// Built from: hl7.fhir.r2.core version: 1.0.2
  // Option: "NAMESPACE" = "fhirCsR2"

using fhirCsR2.Models;

namespace fhirCsR2.ValueSets
{
  /// <summary>
  /// The status of the communication.
  /// </summary>
  public static class CommunicationRequestStatusCodes
  {
    /// <summary>
    /// The receiving system has accepted the order, but work has not yet commenced.
    /// </summary>
    public static readonly Coding Accepted = new Coding
    {
      Code = "accepted",
      Display = "Accepted",
      System = "http://hl7.org/fhir/communication-request-status"
    };
    /// <summary>
    /// The work has been complete, the report(s) released, and no further work is planned.
    /// </summary>
    public static readonly Coding Completed = new Coding
    {
      Code = "completed",
      Display = "Completed",
      System = "http://hl7.org/fhir/communication-request-status"
    };
    /// <summary>
    /// The communication was attempted, but due to some procedural error, it could not be completed.
    /// </summary>
    public static readonly Coding Failed = new Coding
    {
      Code = "failed",
      Display = "Failed",
      System = "http://hl7.org/fhir/communication-request-status"
    };
    /// <summary>
    /// The work to fulfill the order is happening.
    /// </summary>
    public static readonly Coding InProgress = new Coding
    {
      Code = "in-progress",
      Display = "In Progress",
      System = "http://hl7.org/fhir/communication-request-status"
    };
    /// <summary>
    /// The request has been planned.
    /// </summary>
    public static readonly Coding Planned = new Coding
    {
      Code = "planned",
      Display = "Planned",
      System = "http://hl7.org/fhir/communication-request-status"
    };
    /// <summary>
    /// The request has been proposed.
    /// </summary>
    public static readonly Coding Proposed = new Coding
    {
      Code = "proposed",
      Display = "Proposed",
      System = "http://hl7.org/fhir/communication-request-status"
    };
    /// <summary>
    /// The receiving system has received the request but not yet decided whether it will be performed.
    /// </summary>
    public static readonly Coding Received = new Coding
    {
      Code = "received",
      Display = "Received",
      System = "http://hl7.org/fhir/communication-request-status"
    };
    /// <summary>
    /// The receiving system has declined to fulfill the request
    /// </summary>
    public static readonly Coding Rejected = new Coding
    {
      Code = "rejected",
      Display = "Rejected",
      System = "http://hl7.org/fhir/communication-request-status"
    };
    /// <summary>
    /// The request has been placed.
    /// </summary>
    public static readonly Coding Requested = new Coding
    {
      Code = "requested",
      Display = "Requested",
      System = "http://hl7.org/fhir/communication-request-status"
    };
    /// <summary>
    /// The request has been held by originating system/user request.
    /// </summary>
    public static readonly Coding Suspended = new Coding
    {
      Code = "suspended",
      Display = "Suspended",
      System = "http://hl7.org/fhir/communication-request-status"
    };

    /// <summary>
    /// Literal for code: Accepted
    /// </summary>
    public const string LiteralAccepted = "accepted";

    /// <summary>
    /// Literal for code: Completed
    /// </summary>
    public const string LiteralCompleted = "completed";

    /// <summary>
    /// Literal for code: Failed
    /// </summary>
    public const string LiteralFailed = "failed";

    /// <summary>
    /// Literal for code: InProgress
    /// </summary>
    public const string LiteralInProgress = "in-progress";

    /// <summary>
    /// Literal for code: Planned
    /// </summary>
    public const string LiteralPlanned = "planned";

    /// <summary>
    /// Literal for code: Proposed
    /// </summary>
    public const string LiteralProposed = "proposed";

    /// <summary>
    /// Literal for code: Received
    /// </summary>
    public const string LiteralReceived = "received";

    /// <summary>
    /// Literal for code: Rejected
    /// </summary>
    public const string LiteralRejected = "rejected";

    /// <summary>
    /// Literal for code: Requested
    /// </summary>
    public const string LiteralRequested = "requested";

    /// <summary>
    /// Literal for code: Suspended
    /// </summary>
    public const string LiteralSuspended = "suspended";
  };
}