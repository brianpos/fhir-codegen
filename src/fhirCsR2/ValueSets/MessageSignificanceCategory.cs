// <auto-generated />
// Built from: hl7.fhir.r2.core version: 1.0.2
  // Option: "NAMESPACE" = "fhirCsR2"

using fhirCsR2.Models;

namespace fhirCsR2.ValueSets
{
  /// <summary>
  /// The impact of the content of a message.
  /// </summary>
  public static class MessageSignificanceCategoryCodes
  {
    /// <summary>
    /// The message represents/requests a change that should not be processed more than once; e.g. Making a booking for an appointment.
    /// </summary>
    public static readonly Coding Consequence = new Coding
    {
      Code = "Consequence",
      Display = "Consequence",
      System = "http://hl7.org/fhir/message-significance-category"
    };
    /// <summary>
    /// The message represents a response to query for current information. Retrospective processing is wrong and/or wasteful.
    /// </summary>
    public static readonly Coding Currency = new Coding
    {
      Code = "Currency",
      Display = "Currency",
      System = "http://hl7.org/fhir/message-significance-category"
    };
    /// <summary>
    /// The content is not necessarily intended to be current, and it can be reprocessed, though there may be version issues created by processing old notifications.
    /// </summary>
    public static readonly Coding Notification = new Coding
    {
      Code = "Notification",
      Display = "Notification",
      System = "http://hl7.org/fhir/message-significance-category"
    };

    /// <summary>
    /// Literal for code: Consequence
    /// </summary>
    public const string LiteralConsequence = "Consequence";

    /// <summary>
    /// Literal for code: Currency
    /// </summary>
    public const string LiteralCurrency = "Currency";

    /// <summary>
    /// Literal for code: Notification
    /// </summary>
    public const string LiteralNotification = "Notification";
  };
}