// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// The type of participant.
  /// </summary>
  public static class ReportParticipantTypeCodes
  {
    /// <summary>
    /// A FHIR Client
    /// </summary>
    public static readonly Coding Client = new Coding
    {
      Code = "client",
      Display = "Client",
      System = "http://hl7.org/fhir/report-participant-type"
    };
    /// <summary>
    /// A FHIR Server
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
    /// Literal for code: Server
    /// </summary>
    public const string LiteralServer = "server";

    /// <summary>
    /// Literal for code: TestEngine
    /// </summary>
    public const string LiteralTestEngine = "test-engine";
  };
}