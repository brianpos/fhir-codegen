// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Example Message Reasons. These are the set of codes that might be used an updating an encounter using admin-update.
  /// </summary>
  public static class MessageReasonEncounterCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Absent = new Coding
    {
      Code = "absent",
      Display = "Absent",
      System = "http://terminology.hl7.org/CodeSystem/message-reasons-encounter"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Admit = new Coding
    {
      Code = "admit",
      Display = "Admit",
      System = "http://terminology.hl7.org/CodeSystem/message-reasons-encounter"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Discharge = new Coding
    {
      Code = "discharge",
      Display = "Discharge",
      System = "http://terminology.hl7.org/CodeSystem/message-reasons-encounter"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Edit = new Coding
    {
      Code = "edit",
      Display = "Edit",
      System = "http://terminology.hl7.org/CodeSystem/message-reasons-encounter"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Moved = new Coding
    {
      Code = "moved",
      Display = "Moved",
      System = "http://terminology.hl7.org/CodeSystem/message-reasons-encounter"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Returned = new Coding
    {
      Code = "return",
      Display = "Returned",
      System = "http://terminology.hl7.org/CodeSystem/message-reasons-encounter"
    };

    /// <summary>
    /// Literal for code: Absent
    /// </summary>
    public const string LiteralAbsent = "absent";

    /// <summary>
    /// Literal for code: Admit
    /// </summary>
    public const string LiteralAdmit = "admit";

    /// <summary>
    /// Literal for code: Discharge
    /// </summary>
    public const string LiteralDischarge = "discharge";

    /// <summary>
    /// Literal for code: Edit
    /// </summary>
    public const string LiteralEdit = "edit";

    /// <summary>
    /// Literal for code: Moved
    /// </summary>
    public const string LiteralMoved = "moved";

    /// <summary>
    /// Literal for code: Returned
    /// </summary>
    public const string LiteralReturned = "return";
  };
}