// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Used to specify why the normally expected content of the data element is missing.
  /// </summary>
  public static class DataAbsentReasonCodes
  {
    /// <summary>
    /// The content of the data is represented in the resource narrative.
    /// </summary>
    public static readonly Coding AsText = new Coding
    {
      Code = "as-text",
      Display = "As Text",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// The source was asked but declined to answer.
    /// </summary>
    public static readonly Coding AskedButDeclined = new Coding
    {
      Code = "asked-declined",
      Display = "Asked But Declined",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// The source was asked but does not know the value.
    /// </summary>
    public static readonly Coding AskedButUnknown = new Coding
    {
      Code = "asked-unknown",
      Display = "Asked But Unknown",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// Some system or workflow process error means that the information is not available.
    /// </summary>
    public static readonly Coding Error = new Coding
    {
      Code = "error",
      Display = "Error",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// The information is not available due to security, privacy or related reasons.
    /// </summary>
    public static readonly Coding Masked = new Coding
    {
      Code = "masked",
      Display = "Masked",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// The numeric value is excessively low and unrepresentable due to a floating point processing error.
    /// </summary>
    public static readonly Coding NegativeInfinityNINF = new Coding
    {
      Code = "negative-infinity",
      Display = "Negative Infinity (NINF)",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// The numeric value is undefined or unrepresentable due to a floating point processing error.
    /// </summary>
    public static readonly Coding NotANumberNaN = new Coding
    {
      Code = "not-a-number",
      Display = "Not a Number (NaN)",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// There is no proper value for this element (e.g. last menstrual period for a male).
    /// </summary>
    public static readonly Coding NotApplicable = new Coding
    {
      Code = "not-applicable",
      Display = "Not Applicable",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// The workflow didn't lead to this value being known.
    /// </summary>
    public static readonly Coding NotAsked = new Coding
    {
      Code = "not-asked",
      Display = "Not Asked",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// The value is not available because the observation procedure (test, etc.) was not performed.
    /// </summary>
    public static readonly Coding NotPerformed = new Coding
    {
      Code = "not-performed",
      Display = "Not Performed",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// The value is not permitted in this context (e.g. due to profiles, or the base data types).
    /// </summary>
    public static readonly Coding NotPermitted = new Coding
    {
      Code = "not-permitted",
      Display = "Not Permitted",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// The numeric value is excessively high and unrepresentable due to a floating point processing error.
    /// </summary>
    public static readonly Coding PositiveInfinityPINF = new Coding
    {
      Code = "positive-infinity",
      Display = "Positive Infinity (PINF)",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// There is reason to expect (from the workflow) that the value may become known.
    /// </summary>
    public static readonly Coding TemporarilyUnknown = new Coding
    {
      Code = "temp-unknown",
      Display = "Temporarily Unknown",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// The value is expected to exist but is not known.
    /// </summary>
    public static readonly Coding Unknown = new Coding
    {
      Code = "unknown",
      Display = "Unknown",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };
    /// <summary>
    /// The source system wasn't capable of supporting this element.
    /// </summary>
    public static readonly Coding Unsupported = new Coding
    {
      Code = "unsupported",
      Display = "Unsupported",
      System = "http://terminology.hl7.org/CodeSystem/data-absent-reason"
    };

    /// <summary>
    /// Literal for code: AsText
    /// </summary>
    public const string LiteralAsText = "as-text";

    /// <summary>
    /// Literal for code: AskedButDeclined
    /// </summary>
    public const string LiteralAskedButDeclined = "asked-declined";

    /// <summary>
    /// Literal for code: AskedButUnknown
    /// </summary>
    public const string LiteralAskedButUnknown = "asked-unknown";

    /// <summary>
    /// Literal for code: Error
    /// </summary>
    public const string LiteralError = "error";

    /// <summary>
    /// Literal for code: Masked
    /// </summary>
    public const string LiteralMasked = "masked";

    /// <summary>
    /// Literal for code: NegativeInfinityNINF
    /// </summary>
    public const string LiteralNegativeInfinityNINF = "negative-infinity";

    /// <summary>
    /// Literal for code: NotANumberNaN
    /// </summary>
    public const string LiteralNotANumberNaN = "not-a-number";

    /// <summary>
    /// Literal for code: NotApplicable
    /// </summary>
    public const string LiteralNotApplicable = "not-applicable";

    /// <summary>
    /// Literal for code: NotAsked
    /// </summary>
    public const string LiteralNotAsked = "not-asked";

    /// <summary>
    /// Literal for code: NotPerformed
    /// </summary>
    public const string LiteralNotPerformed = "not-performed";

    /// <summary>
    /// Literal for code: NotPermitted
    /// </summary>
    public const string LiteralNotPermitted = "not-permitted";

    /// <summary>
    /// Literal for code: PositiveInfinityPINF
    /// </summary>
    public const string LiteralPositiveInfinityPINF = "positive-infinity";

    /// <summary>
    /// Literal for code: TemporarilyUnknown
    /// </summary>
    public const string LiteralTemporarilyUnknown = "temp-unknown";

    /// <summary>
    /// Literal for code: Unknown
    /// </summary>
    public const string LiteralUnknown = "unknown";

    /// <summary>
    /// Literal for code: Unsupported
    /// </summary>
    public const string LiteralUnsupported = "unsupported";
  };
}