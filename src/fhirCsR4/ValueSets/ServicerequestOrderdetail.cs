// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// An example value set of Codified order entry details concepts.  These concepts only make sense in the context of what is being ordered.  This example is for a patient ventilation order
  /// </summary>
  public static class ServicerequestOrderdetailCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PatientTriggeredInspiratoryAssistanceProcedure = new Coding
    {
      Code = "243144002",
      Display = "Patient triggered inspiratory assistance (procedure)",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AssistedControlledMandatoryVentilationProcedure = new Coding
    {
      Code = "243150007",
      Display = "Assisted controlled mandatory ventilation (procedure)",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PressureControlledVentilationProcedure = new Coding
    {
      Code = "286812008",
      Display = "Pressure controlled ventilation (procedure)",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ContinuousPositiveAirwayPressureVentilationTreatmentRegimeTherapy = new Coding
    {
      Code = "47545007",
      Display = "Continuous positive airway pressure ventilation treatment (regime/therapy)",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding SynchronizedIntermittentMandatoryVentilationProcedure = new Coding
    {
      Code = "59427005",
      Display = "Synchronized intermittent mandatory ventilation (procedure)",
      System = "http://snomed.info/sct"
    };

    /// <summary>
    /// Literal for code: PatientTriggeredInspiratoryAssistanceProcedure
    /// </summary>
    public const string LiteralPatientTriggeredInspiratoryAssistanceProcedure = "243144002";

    /// <summary>
    /// Literal for code: AssistedControlledMandatoryVentilationProcedure
    /// </summary>
    public const string LiteralAssistedControlledMandatoryVentilationProcedure = "243150007";

    /// <summary>
    /// Literal for code: PressureControlledVentilationProcedure
    /// </summary>
    public const string LiteralPressureControlledVentilationProcedure = "286812008";

    /// <summary>
    /// Literal for code: ContinuousPositiveAirwayPressureVentilationTreatmentRegimeTherapy
    /// </summary>
    public const string LiteralContinuousPositiveAirwayPressureVentilationTreatmentRegimeTherapy = "47545007";

    /// <summary>
    /// Literal for code: SynchronizedIntermittentMandatoryVentilationProcedure
    /// </summary>
    public const string LiteralSynchronizedIntermittentMandatoryVentilationProcedure = "59427005";
  };
}