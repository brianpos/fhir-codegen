// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// How an exception statement is applied, such as adding additional consent or removing consent
  /// </summary>
  public static class ConsentExceptTypeCodes
  {
    /// <summary>
    /// Consent is denied for actions meeting these rules
    /// </summary>
    public static readonly Coding OptOut = new Coding
    {
      Code = "deny",
      Display = "Opt Out",
      System = "http://hl7.org/fhir/consent-except-type"
    };
    /// <summary>
    /// Consent is provided for actions meeting these rules
    /// </summary>
    public static readonly Coding OptIn = new Coding
    {
      Code = "permit",
      Display = "Opt In",
      System = "http://hl7.org/fhir/consent-except-type"
    };

    /// <summary>
    /// Literal for code: OptOut
    /// </summary>
    public const string LiteralOptOut = "deny";

    /// <summary>
    /// Literal for code: OptIn
    /// </summary>
    public const string LiteralOptIn = "permit";
  };
}