// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value set includes example Payment Type codes.
  /// </summary>
  public static class ExPaymenttypeCodes
  {
    /// <summary>
    /// Complete
    /// </summary>
    public static readonly Coding Complete = new Coding
    {
      Code = "complete",
      Display = "Complete",
      System = "http://terminology.hl7.org/CodeSystem/ex-paymenttype"
    };
    /// <summary>
    /// Partial
    /// </summary>
    public static readonly Coding Partial = new Coding
    {
      Code = "partial",
      Display = "Partial",
      System = "http://terminology.hl7.org/CodeSystem/ex-paymenttype"
    };

    /// <summary>
    /// Literal for code: Complete
    /// </summary>
    public const string LiteralComplete = "complete";

    /// <summary>
    /// Literal for code: ExPaymenttypeComplete
    /// </summary>
    public const string LiteralExPaymenttypeComplete = "http://terminology.hl7.org/CodeSystem/ex-paymenttype#complete";

    /// <summary>
    /// Literal for code: Partial
    /// </summary>
    public const string LiteralPartial = "partial";

    /// <summary>
    /// Literal for code: ExPaymenttypePartial
    /// </summary>
    public const string LiteralExPaymenttypePartial = "http://terminology.hl7.org/CodeSystem/ex-paymenttype#partial";

    /// <summary>
    /// Dictionary for looking up ExPaymenttype Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "complete", Complete }, 
      { "http://terminology.hl7.org/CodeSystem/ex-paymenttype#complete", Complete }, 
      { "partial", Partial }, 
      { "http://terminology.hl7.org/CodeSystem/ex-paymenttype#partial", Partial }, 
    };
  };
}
