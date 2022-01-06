// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// This value set includes sample Contract Type codes.
  /// </summary>
  public static class ContractTypeCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Consent = new Coding
    {
      Code = "consent",
      Display = "Consent",
      System = "http://terminology.hl7.org/CodeSystem/contract-type"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Disclosure = new Coding
    {
      Code = "disclosure",
      Display = "Disclosure",
      System = "http://terminology.hl7.org/CodeSystem/contract-type"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding HealthInsurance = new Coding
    {
      Code = "healthinsurance",
      Display = "Health Insurance",
      System = "http://terminology.hl7.org/CodeSystem/contract-type"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Privacy = new Coding
    {
      Code = "privacy",
      Display = "Privacy",
      System = "http://terminology.hl7.org/CodeSystem/contract-type"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding SupplyContract = new Coding
    {
      Code = "supply",
      Display = "Supply Contract",
      System = "http://terminology.hl7.org/CodeSystem/contract-type"
    };

    /// <summary>
    /// Literal for code: Consent
    /// </summary>
    public const string LiteralConsent = "consent";

    /// <summary>
    /// Literal for code: Disclosure
    /// </summary>
    public const string LiteralDisclosure = "disclosure";

    /// <summary>
    /// Literal for code: HealthInsurance
    /// </summary>
    public const string LiteralHealthInsurance = "healthinsurance";

    /// <summary>
    /// Literal for code: Privacy
    /// </summary>
    public const string LiteralPrivacy = "privacy";

    /// <summary>
    /// Literal for code: SupplyContract
    /// </summary>
    public const string LiteralSupplyContract = "supply";
  };
}