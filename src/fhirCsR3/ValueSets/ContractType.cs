// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// This value set includes sample Contract Type codes.
  /// </summary>
  public static class ContractTypeCodes
  {
    /// <summary>
    /// Consent Directive.
    /// </summary>
    public static readonly Coding Consent = new Coding
    {
      Code = "consent",
      Display = "Consent",
      System = "http://hl7.org/fhir/contracttypecodes"
    };
    /// <summary>
    /// Information disclosure policy.
    /// </summary>
    public static readonly Coding Disclosure = new Coding
    {
      Code = "disclosure",
      Display = "Disclosure",
      System = "http://hl7.org/fhir/contracttypecodes"
    };
    /// <summary>
    /// Health Insurance policy.
    /// </summary>
    public static readonly Coding HealthInsurance = new Coding
    {
      Code = "healthinsurance",
      Display = "Health Insurance",
      System = "http://hl7.org/fhir/contracttypecodes"
    };
    /// <summary>
    /// Privacy policy.
    /// </summary>
    public static readonly Coding Privacy = new Coding
    {
      Code = "privacy",
      Display = "Privacy",
      System = "http://hl7.org/fhir/contracttypecodes"
    };
    /// <summary>
    /// Contract to supply goods or services.
    /// </summary>
    public static readonly Coding SupplyContract = new Coding
    {
      Code = "supply",
      Display = "Supply Contract",
      System = "http://hl7.org/fhir/contracttypecodes"
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