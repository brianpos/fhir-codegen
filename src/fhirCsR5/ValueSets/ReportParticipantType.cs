// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The type of participant.
  /// </summary>
  public static class ReportParticipantTypeCodes
  {
    /// <summary>
    /// A FHIR Client.
    /// </summary>
    public static readonly Coding Client = new Coding
    {
      Code = "client",
      Display = "Client",
      System = "http://hl7.org/fhir/report-participant-type"
    };
    /// <summary>
    /// A FHIR Server.
    /// </summary>
    public static readonly Coding Server = new Coding
    {
      Code = "server",
      Display = "Server",
      System = "http://hl7.org/fhir/report-participant-type"
    };
    /// <summary>
    /// The test execution engine.
    /// </summary>
    public static readonly Coding TestEngine = new Coding
    {
      Code = "test-engine",
      Display = "Test Engine",
      System = "http://hl7.org/fhir/report-participant-type"
    };

    /// <summary>
    /// Literal for code: Client
    /// </summary>
    public const string LiteralClient = "client";

    /// <summary>
    /// Literal for code: ReportParticipantTypeClient
    /// </summary>
    public const string LiteralReportParticipantTypeClient = "http://hl7.org/fhir/report-participant-type#client";

    /// <summary>
    /// Literal for code: Server
    /// </summary>
    public const string LiteralServer = "server";

    /// <summary>
    /// Literal for code: ReportParticipantTypeServer
    /// </summary>
    public const string LiteralReportParticipantTypeServer = "http://hl7.org/fhir/report-participant-type#server";

    /// <summary>
    /// Literal for code: TestEngine
    /// </summary>
    public const string LiteralTestEngine = "test-engine";

    /// <summary>
    /// Literal for code: ReportParticipantTypeTestEngine
    /// </summary>
    public const string LiteralReportParticipantTypeTestEngine = "http://hl7.org/fhir/report-participant-type#test-engine";

    /// <summary>
    /// Dictionary for looking up ReportParticipantType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "client", Client }, 
      { "http://hl7.org/fhir/report-participant-type#client", Client }, 
      { "server", Server }, 
      { "http://hl7.org/fhir/report-participant-type#server", Server }, 
      { "test-engine", TestEngine }, 
      { "http://hl7.org/fhir/report-participant-type#test-engine", TestEngine }, 
    };
  };
}
