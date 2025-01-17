// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// This value set includes sample Consent Action codes.
  /// </summary>
  public static class ConsentActionCodes
  {
    /// <summary>
    /// Provide an entity access to information to achieve a stated purpose
    /// </summary>
    public static readonly Coding Access = new Coding
    {
      Code = "access",
      Display = "Access",
      System = "http://hl7.org/fhir/consentaction"
    };
    /// <summary>
    /// Gather/acquire information by an entity to achieve a stated purpose
    /// </summary>
    public static readonly Coding Collect = new Coding
    {
      Code = "collect",
      Display = "Collect",
      System = "http://hl7.org/fhir/consentaction"
    };
    /// <summary>
    /// Allowing an entity to correct a patient's information
    /// </summary>
    public static readonly Coding AccessAndCorrect = new Coding
    {
      Code = "correct",
      Display = "Access and Correct",
      System = "http://hl7.org/fhir/consentaction"
    };
    /// <summary>
    /// Release / transfer of information to an entity 
    /// </summary>
    public static readonly Coding Disclose = new Coding
    {
      Code = "disclose",
      Display = "Disclose",
      System = "http://hl7.org/fhir/consentaction"
    };
    /// <summary>
    /// Use of stored information by an entity fo the stated purpose
    /// </summary>
    public static readonly Coding Use = new Coding
    {
      Code = "use",
      Display = "Use",
      System = "http://hl7.org/fhir/consentaction"
    };

    /// <summary>
    /// Literal for code: Access
    /// </summary>
    public const string LiteralAccess = "access";

    /// <summary>
    /// Literal for code: ConsentActionAccess
    /// </summary>
    public const string LiteralConsentActionAccess = "http://hl7.org/fhir/consentaction#access";

    /// <summary>
    /// Literal for code: Collect
    /// </summary>
    public const string LiteralCollect = "collect";

    /// <summary>
    /// Literal for code: ConsentActionCollect
    /// </summary>
    public const string LiteralConsentActionCollect = "http://hl7.org/fhir/consentaction#collect";

    /// <summary>
    /// Literal for code: AccessAndCorrect
    /// </summary>
    public const string LiteralAccessAndCorrect = "correct";

    /// <summary>
    /// Literal for code: ConsentActionAccessAndCorrect
    /// </summary>
    public const string LiteralConsentActionAccessAndCorrect = "http://hl7.org/fhir/consentaction#correct";

    /// <summary>
    /// Literal for code: Disclose
    /// </summary>
    public const string LiteralDisclose = "disclose";

    /// <summary>
    /// Literal for code: ConsentActionDisclose
    /// </summary>
    public const string LiteralConsentActionDisclose = "http://hl7.org/fhir/consentaction#disclose";

    /// <summary>
    /// Literal for code: Use
    /// </summary>
    public const string LiteralUse = "use";

    /// <summary>
    /// Literal for code: ConsentActionUse
    /// </summary>
    public const string LiteralConsentActionUse = "http://hl7.org/fhir/consentaction#use";

    /// <summary>
    /// Dictionary for looking up ConsentAction Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "access", Access }, 
      { "http://hl7.org/fhir/consentaction#access", Access }, 
      { "collect", Collect }, 
      { "http://hl7.org/fhir/consentaction#collect", Collect }, 
      { "correct", AccessAndCorrect }, 
      { "http://hl7.org/fhir/consentaction#correct", AccessAndCorrect }, 
      { "disclose", Disclose }, 
      { "http://hl7.org/fhir/consentaction#disclose", Disclose }, 
      { "use", Use }, 
      { "http://hl7.org/fhir/consentaction#use", Use }, 
    };
  };
}
