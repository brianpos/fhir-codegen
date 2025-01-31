// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// MedicationDispense Performer Function Codes
  /// </summary>
  public static class MedicationdispensePerformerFunctionCodes
  {
    /// <summary>
    /// Performed initial quality assurance on the prepared medication
    /// </summary>
    public static readonly Coding Checker = new Coding
    {
      Code = "checker",
      Display = "Checker",
      System = "http://terminology.hl7.org/CodeSystem/medicationdispense-performer-function"
    };
    /// <summary>
    /// Recorded the details of the request
    /// </summary>
    public static readonly Coding DataEnterer = new Coding
    {
      Code = "dataenterer",
      Display = "Data Enterer",
      System = "http://terminology.hl7.org/CodeSystem/medicationdispense-performer-function"
    };
    /// <summary>
    /// Performed the final quality assurance on the prepared medication against the request. Typically, this is a pharmacist function.
    /// </summary>
    public static readonly Coding FinalChecker = new Coding
    {
      Code = "finalchecker",
      Display = "Final Checker",
      System = "http://terminology.hl7.org/CodeSystem/medicationdispense-performer-function"
    };
    /// <summary>
    /// Prepared the medication.
    /// </summary>
    public static readonly Coding Packager = new Coding
    {
      Code = "packager",
      Display = "Packager",
      System = "http://terminology.hl7.org/CodeSystem/medicationdispense-performer-function"
    };

    /// <summary>
    /// Literal for code: Checker
    /// </summary>
    public const string LiteralChecker = "checker";

    /// <summary>
    /// Literal for code: MedicationdispensePerformerFunctionChecker
    /// </summary>
    public const string LiteralMedicationdispensePerformerFunctionChecker = "http://terminology.hl7.org/CodeSystem/medicationdispense-performer-function#checker";

    /// <summary>
    /// Literal for code: DataEnterer
    /// </summary>
    public const string LiteralDataEnterer = "dataenterer";

    /// <summary>
    /// Literal for code: MedicationdispensePerformerFunctionDataEnterer
    /// </summary>
    public const string LiteralMedicationdispensePerformerFunctionDataEnterer = "http://terminology.hl7.org/CodeSystem/medicationdispense-performer-function#dataenterer";

    /// <summary>
    /// Literal for code: FinalChecker
    /// </summary>
    public const string LiteralFinalChecker = "finalchecker";

    /// <summary>
    /// Literal for code: MedicationdispensePerformerFunctionFinalChecker
    /// </summary>
    public const string LiteralMedicationdispensePerformerFunctionFinalChecker = "http://terminology.hl7.org/CodeSystem/medicationdispense-performer-function#finalchecker";

    /// <summary>
    /// Literal for code: Packager
    /// </summary>
    public const string LiteralPackager = "packager";

    /// <summary>
    /// Literal for code: MedicationdispensePerformerFunctionPackager
    /// </summary>
    public const string LiteralMedicationdispensePerformerFunctionPackager = "http://terminology.hl7.org/CodeSystem/medicationdispense-performer-function#packager";

    /// <summary>
    /// Dictionary for looking up MedicationdispensePerformerFunction Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "checker", Checker }, 
      { "http://terminology.hl7.org/CodeSystem/medicationdispense-performer-function#checker", Checker }, 
      { "dataenterer", DataEnterer }, 
      { "http://terminology.hl7.org/CodeSystem/medicationdispense-performer-function#dataenterer", DataEnterer }, 
      { "finalchecker", FinalChecker }, 
      { "http://terminology.hl7.org/CodeSystem/medicationdispense-performer-function#finalchecker", FinalChecker }, 
      { "packager", Packager }, 
      { "http://terminology.hl7.org/CodeSystem/medicationdispense-performer-function#packager", Packager }, 
    };
  };
}
