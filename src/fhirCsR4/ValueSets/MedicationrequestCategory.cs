// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// MedicationRequest Category Codes
  /// </summary>
  public static class MedicationrequestCategoryCodes
  {
    /// <summary>
    /// Includes requests for medications to be administered or consumed by the patient in their home (this would include long term care or nursing homes, hospices, etc.)
    /// </summary>
    public static readonly Coding Community = new Coding
    {
      Code = "community",
      Display = "Community",
      System = "http://terminology.hl7.org/CodeSystem/medicationrequest-category"
    };
    /// <summary>
    /// Includes requests for medications created when the patient is being released from a facility
    /// </summary>
    public static readonly Coding Discharge = new Coding
    {
      Code = "discharge",
      Display = "Discharge",
      System = "http://terminology.hl7.org/CodeSystem/medicationrequest-category"
    };
    /// <summary>
    /// Includes requests for medications to be administered or consumed in an inpatient or acute care setting
    /// </summary>
    public static readonly Coding Inpatient = new Coding
    {
      Code = "inpatient",
      Display = "Inpatient",
      System = "http://terminology.hl7.org/CodeSystem/medicationrequest-category"
    };
    /// <summary>
    /// Includes requests for medications to be administered or consumed in an outpatient setting (for example, Emergency Department, Outpatient Clinic, Outpatient Surgery, Doctor's office)
    /// </summary>
    public static readonly Coding Outpatient = new Coding
    {
      Code = "outpatient",
      Display = "Outpatient",
      System = "http://terminology.hl7.org/CodeSystem/medicationrequest-category"
    };

    /// <summary>
    /// Literal for code: Community
    /// </summary>
    public const string LiteralCommunity = "community";

    /// <summary>
    /// Literal for code: MedicationrequestCategoryCommunity
    /// </summary>
    public const string LiteralMedicationrequestCategoryCommunity = "http://terminology.hl7.org/CodeSystem/medicationrequest-category#community";

    /// <summary>
    /// Literal for code: Discharge
    /// </summary>
    public const string LiteralDischarge = "discharge";

    /// <summary>
    /// Literal for code: MedicationrequestCategoryDischarge
    /// </summary>
    public const string LiteralMedicationrequestCategoryDischarge = "http://terminology.hl7.org/CodeSystem/medicationrequest-category#discharge";

    /// <summary>
    /// Literal for code: Inpatient
    /// </summary>
    public const string LiteralInpatient = "inpatient";

    /// <summary>
    /// Literal for code: MedicationrequestCategoryInpatient
    /// </summary>
    public const string LiteralMedicationrequestCategoryInpatient = "http://terminology.hl7.org/CodeSystem/medicationrequest-category#inpatient";

    /// <summary>
    /// Literal for code: Outpatient
    /// </summary>
    public const string LiteralOutpatient = "outpatient";

    /// <summary>
    /// Literal for code: MedicationrequestCategoryOutpatient
    /// </summary>
    public const string LiteralMedicationrequestCategoryOutpatient = "http://terminology.hl7.org/CodeSystem/medicationrequest-category#outpatient";

    /// <summary>
    /// Dictionary for looking up MedicationrequestCategory Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "community", Community }, 
      { "http://terminology.hl7.org/CodeSystem/medicationrequest-category#community", Community }, 
      { "discharge", Discharge }, 
      { "http://terminology.hl7.org/CodeSystem/medicationrequest-category#discharge", Discharge }, 
      { "inpatient", Inpatient }, 
      { "http://terminology.hl7.org/CodeSystem/medicationrequest-category#inpatient", Inpatient }, 
      { "outpatient", Outpatient }, 
      { "http://terminology.hl7.org/CodeSystem/medicationrequest-category#outpatient", Outpatient }, 
    };
  };
}
