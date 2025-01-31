// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// The validation status of the target
  /// </summary>
  public static class VerificationresultStatusCodes
  {
    /// <summary>
    /// ***TODO***
    /// </summary>
    public static readonly Coding Attested = new Coding
    {
      Code = "attested",
      Display = "Attested",
      System = "http://hl7.org/fhir/verificationresult-status"
    };
    /// <summary>
    /// ***TODO***
    /// </summary>
    public static readonly Coding InProcess = new Coding
    {
      Code = "in-process",
      Display = "In process",
      System = "http://hl7.org/fhir/verificationresult-status"
    };
    /// <summary>
    /// ***TODO***
    /// </summary>
    public static readonly Coding RequiresRevalidation = new Coding
    {
      Code = "req-revalid",
      Display = "Requires revalidation",
      System = "http://hl7.org/fhir/verificationresult-status"
    };
    /// <summary>
    /// ***TODO***
    /// </summary>
    public static readonly Coding ReValidationFailed = new Coding
    {
      Code = "reval-fail",
      Display = "Re-Validation failed",
      System = "http://hl7.org/fhir/verificationresult-status"
    };
    /// <summary>
    /// ***TODO***
    /// </summary>
    public static readonly Coding ValidationFailed = new Coding
    {
      Code = "val-fail",
      Display = "Validation failed",
      System = "http://hl7.org/fhir/verificationresult-status"
    };
    /// <summary>
    /// ***TODO***
    /// </summary>
    public static readonly Coding Validated = new Coding
    {
      Code = "validated",
      Display = "Validated",
      System = "http://hl7.org/fhir/verificationresult-status"
    };

    /// <summary>
    /// Literal for code: Attested
    /// </summary>
    public const string LiteralAttested = "attested";

    /// <summary>
    /// Literal for code: VerificationresultStatusAttested
    /// </summary>
    public const string LiteralVerificationresultStatusAttested = "http://hl7.org/fhir/verificationresult-status#attested";

    /// <summary>
    /// Literal for code: InProcess
    /// </summary>
    public const string LiteralInProcess = "in-process";

    /// <summary>
    /// Literal for code: VerificationresultStatusInProcess
    /// </summary>
    public const string LiteralVerificationresultStatusInProcess = "http://hl7.org/fhir/verificationresult-status#in-process";

    /// <summary>
    /// Literal for code: RequiresRevalidation
    /// </summary>
    public const string LiteralRequiresRevalidation = "req-revalid";

    /// <summary>
    /// Literal for code: VerificationresultStatusRequiresRevalidation
    /// </summary>
    public const string LiteralVerificationresultStatusRequiresRevalidation = "http://hl7.org/fhir/verificationresult-status#req-revalid";

    /// <summary>
    /// Literal for code: ReValidationFailed
    /// </summary>
    public const string LiteralReValidationFailed = "reval-fail";

    /// <summary>
    /// Literal for code: VerificationresultStatusReValidationFailed
    /// </summary>
    public const string LiteralVerificationresultStatusReValidationFailed = "http://hl7.org/fhir/verificationresult-status#reval-fail";

    /// <summary>
    /// Literal for code: ValidationFailed
    /// </summary>
    public const string LiteralValidationFailed = "val-fail";

    /// <summary>
    /// Literal for code: VerificationresultStatusValidationFailed
    /// </summary>
    public const string LiteralVerificationresultStatusValidationFailed = "http://hl7.org/fhir/verificationresult-status#val-fail";

    /// <summary>
    /// Literal for code: Validated
    /// </summary>
    public const string LiteralValidated = "validated";

    /// <summary>
    /// Literal for code: VerificationresultStatusValidated
    /// </summary>
    public const string LiteralVerificationresultStatusValidated = "http://hl7.org/fhir/verificationresult-status#validated";

    /// <summary>
    /// Dictionary for looking up VerificationresultStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "attested", Attested }, 
      { "http://hl7.org/fhir/verificationresult-status#attested", Attested }, 
      { "in-process", InProcess }, 
      { "http://hl7.org/fhir/verificationresult-status#in-process", InProcess }, 
      { "req-revalid", RequiresRevalidation }, 
      { "http://hl7.org/fhir/verificationresult-status#req-revalid", RequiresRevalidation }, 
      { "reval-fail", ReValidationFailed }, 
      { "http://hl7.org/fhir/verificationresult-status#reval-fail", ReValidationFailed }, 
      { "val-fail", ValidationFailed }, 
      { "http://hl7.org/fhir/verificationresult-status#val-fail", ValidationFailed }, 
      { "validated", Validated }, 
      { "http://hl7.org/fhir/verificationresult-status#validated", Validated }, 
    };
  };
}
