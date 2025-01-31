// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set includes sample Consent Action codes.
  /// </summary>
  public static class ConsentActionCodes
  {
    /// <summary>
    /// Retrieval without permitting collection, use or disclosure. e.g., no screen-scraping for collection, use or disclosure (view-only access)
    /// </summary>
    public static readonly Coding Access = new Coding
    {
      Code = "access",
      Display = "Access",
      System = "http://terminology.hl7.org/CodeSystem/consentaction"
    };
    /// <summary>
    /// Gather retrieved information for storage
    /// </summary>
    public static readonly Coding Collect = new Coding
    {
      Code = "collect",
      Display = "Collect",
      System = "http://terminology.hl7.org/CodeSystem/consentaction"
    };
    /// <summary>
    /// Allow retrieval of a patient's information for the purpose of update or rectify
    /// </summary>
    public static readonly Coding AccessAndCorrect = new Coding
    {
      Code = "correct",
      Display = "Access and Correct",
      System = "http://terminology.hl7.org/CodeSystem/consentaction"
    };
    /// <summary>
    /// Transfer retrieved information
    /// </summary>
    public static readonly Coding Disclose = new Coding
    {
      Code = "disclose",
      Display = "Disclose",
      System = "http://terminology.hl7.org/CodeSystem/consentaction"
    };
    /// <summary>
    /// Utilize the retrieved information
    /// </summary>
    public static readonly Coding Use = new Coding
    {
      Code = "use",
      Display = "Use",
      System = "http://terminology.hl7.org/CodeSystem/consentaction"
    };

    /// <summary>
    /// Literal for code: Access
    /// </summary>
    public const string LiteralAccess = "access";

    /// <summary>
    /// Literal for code: ConsentActionAccess
    /// </summary>
    public const string LiteralConsentActionAccess = "http://terminology.hl7.org/CodeSystem/consentaction#access";

    /// <summary>
    /// Literal for code: Collect
    /// </summary>
    public const string LiteralCollect = "collect";

    /// <summary>
    /// Literal for code: ConsentActionCollect
    /// </summary>
    public const string LiteralConsentActionCollect = "http://terminology.hl7.org/CodeSystem/consentaction#collect";

    /// <summary>
    /// Literal for code: AccessAndCorrect
    /// </summary>
    public const string LiteralAccessAndCorrect = "correct";

    /// <summary>
    /// Literal for code: ConsentActionAccessAndCorrect
    /// </summary>
    public const string LiteralConsentActionAccessAndCorrect = "http://terminology.hl7.org/CodeSystem/consentaction#correct";

    /// <summary>
    /// Literal for code: Disclose
    /// </summary>
    public const string LiteralDisclose = "disclose";

    /// <summary>
    /// Literal for code: ConsentActionDisclose
    /// </summary>
    public const string LiteralConsentActionDisclose = "http://terminology.hl7.org/CodeSystem/consentaction#disclose";

    /// <summary>
    /// Literal for code: Use
    /// </summary>
    public const string LiteralUse = "use";

    /// <summary>
    /// Literal for code: ConsentActionUse
    /// </summary>
    public const string LiteralConsentActionUse = "http://terminology.hl7.org/CodeSystem/consentaction#use";

    /// <summary>
    /// Dictionary for looking up ConsentAction Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "access", Access }, 
      { "http://terminology.hl7.org/CodeSystem/consentaction#access", Access }, 
      { "collect", Collect }, 
      { "http://terminology.hl7.org/CodeSystem/consentaction#collect", Collect }, 
      { "correct", AccessAndCorrect }, 
      { "http://terminology.hl7.org/CodeSystem/consentaction#correct", AccessAndCorrect }, 
      { "disclose", Disclose }, 
      { "http://terminology.hl7.org/CodeSystem/consentaction#disclose", Disclose }, 
      { "use", Use }, 
      { "http://terminology.hl7.org/CodeSystem/consentaction#use", Use }, 
    };
  };
}
