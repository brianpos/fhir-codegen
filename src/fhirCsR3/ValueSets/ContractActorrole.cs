// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// This value set includes sample Contract Actor Role codes.
  /// </summary>
  public static class ContractActorroleCodes
  {
    /// <summary>
    /// A receiver, human or animal, of health care related goods and services.
    /// </summary>
    public static readonly Coding Patient = new Coding
    {
      Code = "patient",
      Display = "Patient",
      System = "http://www.hl7.org/fhir/contractactorrole"
    };
    /// <summary>
    /// Someone who provides health care related services to people or animals including both clinical and support services.
    /// </summary>
    public static readonly Coding Practitioner = new Coding
    {
      Code = "practitioner",
      Display = "Practitioner",
      System = "http://www.hl7.org/fhir/contractactorrole"
    };

    /// <summary>
    /// Literal for code: Patient
    /// </summary>
    public const string LiteralPatient = "patient";

    /// <summary>
    /// Literal for code: Practitioner
    /// </summary>
    public const string LiteralPractitioner = "practitioner";
  };
}