// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// How a rule statement is applied, such as adding additional consent or removing consent.
  /// </summary>
  public static class ConsentProvisionTypeCodes
  {
    /// <summary>
    /// Consent is denied for actions meeting these rules.
    /// </summary>
    public static readonly Coding Deny = new Coding
    {
      Code = "deny",
      Display = "Deny",
      System = "http://hl7.org/fhir/consent-provision-type"
    };
    /// <summary>
    /// Consent is provided for actions meeting these rules.
    /// </summary>
    public static readonly Coding Permit = new Coding
    {
      Code = "permit",
      Display = "Permit",
      System = "http://hl7.org/fhir/consent-provision-type"
    };
  };
}