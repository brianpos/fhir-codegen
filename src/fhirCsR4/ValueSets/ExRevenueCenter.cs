// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set includes sample Revenue Center codes.
  /// </summary>
  public static class ExRevenueCenterCodes
  {
    /// <summary>
    /// Vision Clinic
    /// </summary>
    public static readonly Coding VisionClinic = new Coding
    {
      Code = "0010",
      Display = "Vision Clinic",
      System = "http://terminology.hl7.org/CodeSystem/ex-revenue-center"
    };
    /// <summary>
    /// Anaesthesia.
    /// </summary>
    public static readonly Coding Anaesthesia = new Coding
    {
      Code = "0370",
      Display = "Anaesthesia",
      System = "http://terminology.hl7.org/CodeSystem/ex-revenue-center"
    };
    /// <summary>
    /// Physical Therapy.
    /// </summary>
    public static readonly Coding PhysicalTherapy = new Coding
    {
      Code = "0420",
      Display = "Physical Therapy",
      System = "http://terminology.hl7.org/CodeSystem/ex-revenue-center"
    };
    /// <summary>
    /// Physical Therapy - visit charge.
    /// </summary>
    public static readonly Coding PhysicalTherapy_2 = new Coding
    {
      Code = "0421",
      Display = "Physical Therapy - ",
      System = "http://terminology.hl7.org/CodeSystem/ex-revenue-center"
    };
    /// <summary>
    /// Speech-Language Pathology.
    /// </summary>
    public static readonly Coding SpeechLanguagePathology = new Coding
    {
      Code = "0440",
      Display = "Speech-Language Pathology",
      System = "http://terminology.hl7.org/CodeSystem/ex-revenue-center"
    };
    /// <summary>
    /// Speech-Language Pathology- visit charge
    /// </summary>
    public static readonly Coding SpeechLanguagePathologyVisit = new Coding
    {
      Code = "0441",
      Display = "Speech-Language Pathology - Visit",
      System = "http://terminology.hl7.org/CodeSystem/ex-revenue-center"
    };
    /// <summary>
    /// Emergency Room
    /// </summary>
    public static readonly Coding EmergencyRoom = new Coding
    {
      Code = "0450",
      Display = "Emergency Room",
      System = "http://terminology.hl7.org/CodeSystem/ex-revenue-center"
    };
    /// <summary>
    /// Emergency Room - EM/EMTALA
    /// </summary>
    public static readonly Coding EmergencyRoomEMEMTALA = new Coding
    {
      Code = "0451",
      Display = "Emergency Room - EM/EMTALA",
      System = "http://terminology.hl7.org/CodeSystem/ex-revenue-center"
    };
    /// <summary>
    /// Emergency Room - beyond EMTALA
    /// </summary>
    public static readonly Coding EmergencyRoomBeyondEMTALA = new Coding
    {
      Code = "0452",
      Display = "Emergency Room - beyond EMTALA",
      System = "http://terminology.hl7.org/CodeSystem/ex-revenue-center"
    };

    /// <summary>
    /// Literal for code: VisionClinic
    /// </summary>
    public const string LiteralVisionClinic = "0010";

    /// <summary>
    /// Literal for code: Anaesthesia
    /// </summary>
    public const string LiteralAnaesthesia = "0370";

    /// <summary>
    /// Literal for code: PhysicalTherapy
    /// </summary>
    public const string LiteralPhysicalTherapy = "0420";

    /// <summary>
    /// Literal for code: PhysicalTherapy_2
    /// </summary>
    public const string LiteralPhysicalTherapy_2 = "0421";

    /// <summary>
    /// Literal for code: SpeechLanguagePathology
    /// </summary>
    public const string LiteralSpeechLanguagePathology = "0440";

    /// <summary>
    /// Literal for code: SpeechLanguagePathologyVisit
    /// </summary>
    public const string LiteralSpeechLanguagePathologyVisit = "0441";

    /// <summary>
    /// Literal for code: EmergencyRoom
    /// </summary>
    public const string LiteralEmergencyRoom = "0450";

    /// <summary>
    /// Literal for code: EmergencyRoomEMEMTALA
    /// </summary>
    public const string LiteralEmergencyRoomEMEMTALA = "0451";

    /// <summary>
    /// Literal for code: EmergencyRoomBeyondEMTALA
    /// </summary>
    public const string LiteralEmergencyRoomBeyondEMTALA = "0452";
  };
}