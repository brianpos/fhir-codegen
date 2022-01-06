// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// This value set includes smattering of Payment Adjustment Reason codes.
  /// </summary>
  public static class PaymentAdjustmentReasonCodes
  {
    /// <summary>
    /// Prior Payment Reversal
    /// </summary>
    public static readonly Coding PriorPaymentReversal = new Coding
    {
      Code = "a001",
      Display = "Prior Payment Reversal",
      System = "http://hl7.org/fhir/payment-adjustment-reason"
    };
    /// <summary>
    /// Prior Overpayment
    /// </summary>
    public static readonly Coding PriorOverpayment = new Coding
    {
      Code = "a002",
      Display = "Prior Overpayment",
      System = "http://hl7.org/fhir/payment-adjustment-reason"
    };

    /// <summary>
    /// Literal for code: PriorPaymentReversal
    /// </summary>
    public const string LiteralPriorPaymentReversal = "a001";

    /// <summary>
    /// Literal for code: PriorOverpayment
    /// </summary>
    public const string LiteralPriorOverpayment = "a002";
  };
}