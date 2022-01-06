// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// The reason why the supply item was requested.
  /// </summary>
  public static class SupplyrequestReasonCodes
  {
    /// <summary>
    /// The supply has been requested for use in direct patient care.
    /// </summary>
    public static readonly Coding PatientCare = new Coding
    {
      Code = "patient-care",
      Display = "Patient Care",
      System = "http://terminology.hl7.org/CodeSystem/supplyrequest-reason"
    };
    /// <summary>
    /// The supply has been requested for creating or replenishing ward stock.
    /// </summary>
    public static readonly Coding WardStock = new Coding
    {
      Code = "ward-stock",
      Display = "Ward Stock",
      System = "http://terminology.hl7.org/CodeSystem/supplyrequest-reason"
    };

    /// <summary>
    /// Literal for code: PatientCare
    /// </summary>
    public const string LiteralPatientCare = "patient-care";

    /// <summary>
    /// Literal for code: WardStock
    /// </summary>
    public const string LiteralWardStock = "ward-stock";
  };
}