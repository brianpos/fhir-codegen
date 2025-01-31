// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// This value set includes sample Payment Type codes.
  /// </summary>
  public static class PaymentTypeCodes
  {
    /// <summary>
    /// The amount is an adjustment regarding claims already paid.
    /// </summary>
    public static readonly Coding Adjustment = new Coding
    {
      Code = "adjustment",
      Display = "Adjustment",
      System = "http://hl7.org/fhir/payment-type"
    };
    /// <summary>
    /// The amount is an advance against future claims.
    /// </summary>
    public static readonly Coding Advance = new Coding
    {
      Code = "advance",
      Display = "Advance",
      System = "http://hl7.org/fhir/payment-type"
    };
    /// <summary>
    /// The amount is partial or complete settlement of the amounts due.
    /// </summary>
    public static readonly Coding Payment = new Coding
    {
      Code = "payment",
      Display = "Payment",
      System = "http://hl7.org/fhir/payment-type"
    };

    /// <summary>
    /// Literal for code: Adjustment
    /// </summary>
    public const string LiteralAdjustment = "adjustment";

    /// <summary>
    /// Literal for code: PaymentTypeAdjustment
    /// </summary>
    public const string LiteralPaymentTypeAdjustment = "http://hl7.org/fhir/payment-type#adjustment";

    /// <summary>
    /// Literal for code: Advance
    /// </summary>
    public const string LiteralAdvance = "advance";

    /// <summary>
    /// Literal for code: PaymentTypeAdvance
    /// </summary>
    public const string LiteralPaymentTypeAdvance = "http://hl7.org/fhir/payment-type#advance";

    /// <summary>
    /// Literal for code: Payment
    /// </summary>
    public const string LiteralPayment = "payment";

    /// <summary>
    /// Literal for code: PaymentTypePayment
    /// </summary>
    public const string LiteralPaymentTypePayment = "http://hl7.org/fhir/payment-type#payment";

    /// <summary>
    /// Dictionary for looking up PaymentType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "adjustment", Adjustment }, 
      { "http://hl7.org/fhir/payment-type#adjustment", Adjustment }, 
      { "advance", Advance }, 
      { "http://hl7.org/fhir/payment-type#advance", Advance }, 
      { "payment", Payment }, 
      { "http://hl7.org/fhir/payment-type#payment", Payment }, 
    };
  };
}
