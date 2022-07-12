// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value set includes base Consent Verification codes.
  /// </summary>
  public static class ConsentVerificationCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding FamilyVerified = new Coding
    {
      Code = "family",
      Display = "FamilyVerified",
      System = "http://terminology.hl7.org/CodeSystem/consentverification"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Validation = new Coding
    {
      Code = "validation",
      Display = "Validation",
      System = "http://terminology.hl7.org/CodeSystem/consentverification"
    };
  };
}