// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The type of operator to use for assertion.
  /// </summary>
  public static class AssertOperatorCodesCodes
  {
    /// <summary>
    /// Compare value string contains a known value.
    /// </summary>
    public static readonly Coding Contains = new Coding
    {
      Code = "contains",
      Display = "contains",
      System = "http://hl7.org/fhir/assert-operator-codes"
    };
    /// <summary>
    /// Compare value is empty.
    /// </summary>
    public static readonly Coding Empty = new Coding
    {
      Code = "empty",
      Display = "empty",
      System = "http://hl7.org/fhir/assert-operator-codes"
    };
    /// <summary>
    /// Default value. Equals comparison.
    /// </summary>
    public static readonly new Coding Equals = new Coding
    {
      Code = "equals",
      Display = "equals",
      System = "http://hl7.org/fhir/assert-operator-codes"
    };
    /// <summary>
    /// Evaluate the FHIRPath expression as a boolean condition.
    /// </summary>
    public static readonly Coding Evaluate = new Coding
    {
      Code = "eval",
      Display = "evaluate",
      System = "http://hl7.org/fhir/assert-operator-codes"
    };
    /// <summary>
    /// Compare value to be greater than a known value.
    /// </summary>
    public static readonly Coding GreaterThan = new Coding
    {
      Code = "greaterThan",
      Display = "greaterThan",
      System = "http://hl7.org/fhir/assert-operator-codes"
    };
    /// <summary>
    /// Compare value within a known set of values.
    /// </summary>
    public static readonly Coding VALIn = new Coding
    {
      Code = "in",
      Display = "in",
      System = "http://hl7.org/fhir/assert-operator-codes"
    };
    /// <summary>
    /// Compare value to be less than a known value.
    /// </summary>
    public static readonly Coding LessThan = new Coding
    {
      Code = "lessThan",
      Display = "lessThan",
      System = "http://hl7.org/fhir/assert-operator-codes"
    };
    /// <summary>
    /// Compare value string does not contain a known value.
    /// </summary>
    public static readonly Coding NotContains = new Coding
    {
      Code = "notContains",
      Display = "notContains",
      System = "http://hl7.org/fhir/assert-operator-codes"
    };
    /// <summary>
    /// Compare value is not empty.
    /// </summary>
    public static readonly Coding NotEmpty = new Coding
    {
      Code = "notEmpty",
      Display = "notEmpty",
      System = "http://hl7.org/fhir/assert-operator-codes"
    };
    /// <summary>
    /// Not equals comparison.
    /// </summary>
    public static readonly Coding NotEquals = new Coding
    {
      Code = "notEquals",
      Display = "notEquals",
      System = "http://hl7.org/fhir/assert-operator-codes"
    };
    /// <summary>
    /// Compare value not within a known set of values.
    /// </summary>
    public static readonly Coding NotIn = new Coding
    {
      Code = "notIn",
      Display = "notIn",
      System = "http://hl7.org/fhir/assert-operator-codes"
    };

    /// <summary>
    /// Literal for code: Contains
    /// </summary>
    public const string LiteralContains = "contains";

    /// <summary>
    /// Literal for code: AssertOperatorCodesContains
    /// </summary>
    public const string LiteralAssertOperatorCodesContains = "http://hl7.org/fhir/assert-operator-codes#contains";

    /// <summary>
    /// Literal for code: Empty
    /// </summary>
    public const string LiteralEmpty = "empty";

    /// <summary>
    /// Literal for code: AssertOperatorCodesEmpty
    /// </summary>
    public const string LiteralAssertOperatorCodesEmpty = "http://hl7.org/fhir/assert-operator-codes#empty";

    /// <summary>
    /// Literal for code: Equals
    /// </summary>
    public const string LiteralEquals = "equals";

    /// <summary>
    /// Literal for code: AssertOperatorCodesEquals
    /// </summary>
    public const string LiteralAssertOperatorCodesEquals = "http://hl7.org/fhir/assert-operator-codes#equals";

    /// <summary>
    /// Literal for code: Evaluate
    /// </summary>
    public const string LiteralEvaluate = "eval";

    /// <summary>
    /// Literal for code: AssertOperatorCodesEvaluate
    /// </summary>
    public const string LiteralAssertOperatorCodesEvaluate = "http://hl7.org/fhir/assert-operator-codes#eval";

    /// <summary>
    /// Literal for code: GreaterThan
    /// </summary>
    public const string LiteralGreaterThan = "greaterThan";

    /// <summary>
    /// Literal for code: AssertOperatorCodesGreaterThan
    /// </summary>
    public const string LiteralAssertOperatorCodesGreaterThan = "http://hl7.org/fhir/assert-operator-codes#greaterThan";

    /// <summary>
    /// Literal for code: VALIn
    /// </summary>
    public const string LiteralVALIn = "in";

    /// <summary>
    /// Literal for code: AssertOperatorCodesVALIn
    /// </summary>
    public const string LiteralAssertOperatorCodesVALIn = "http://hl7.org/fhir/assert-operator-codes#in";

    /// <summary>
    /// Literal for code: LessThan
    /// </summary>
    public const string LiteralLessThan = "lessThan";

    /// <summary>
    /// Literal for code: AssertOperatorCodesLessThan
    /// </summary>
    public const string LiteralAssertOperatorCodesLessThan = "http://hl7.org/fhir/assert-operator-codes#lessThan";

    /// <summary>
    /// Literal for code: NotContains
    /// </summary>
    public const string LiteralNotContains = "notContains";

    /// <summary>
    /// Literal for code: AssertOperatorCodesNotContains
    /// </summary>
    public const string LiteralAssertOperatorCodesNotContains = "http://hl7.org/fhir/assert-operator-codes#notContains";

    /// <summary>
    /// Literal for code: NotEmpty
    /// </summary>
    public const string LiteralNotEmpty = "notEmpty";

    /// <summary>
    /// Literal for code: AssertOperatorCodesNotEmpty
    /// </summary>
    public const string LiteralAssertOperatorCodesNotEmpty = "http://hl7.org/fhir/assert-operator-codes#notEmpty";

    /// <summary>
    /// Literal for code: NotEquals
    /// </summary>
    public const string LiteralNotEquals = "notEquals";

    /// <summary>
    /// Literal for code: AssertOperatorCodesNotEquals
    /// </summary>
    public const string LiteralAssertOperatorCodesNotEquals = "http://hl7.org/fhir/assert-operator-codes#notEquals";

    /// <summary>
    /// Literal for code: NotIn
    /// </summary>
    public const string LiteralNotIn = "notIn";

    /// <summary>
    /// Literal for code: AssertOperatorCodesNotIn
    /// </summary>
    public const string LiteralAssertOperatorCodesNotIn = "http://hl7.org/fhir/assert-operator-codes#notIn";

    /// <summary>
    /// Dictionary for looking up AssertOperatorCodes Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "contains", Contains }, 
      { "http://hl7.org/fhir/assert-operator-codes#contains", Contains }, 
      { "empty", Empty }, 
      { "http://hl7.org/fhir/assert-operator-codes#empty", Empty }, 
      { "equals", Equals }, 
      { "http://hl7.org/fhir/assert-operator-codes#equals", Equals }, 
      { "eval", Evaluate }, 
      { "http://hl7.org/fhir/assert-operator-codes#eval", Evaluate }, 
      { "greaterThan", GreaterThan }, 
      { "http://hl7.org/fhir/assert-operator-codes#greaterThan", GreaterThan }, 
      { "in", VALIn }, 
      { "http://hl7.org/fhir/assert-operator-codes#in", VALIn }, 
      { "lessThan", LessThan }, 
      { "http://hl7.org/fhir/assert-operator-codes#lessThan", LessThan }, 
      { "notContains", NotContains }, 
      { "http://hl7.org/fhir/assert-operator-codes#notContains", NotContains }, 
      { "notEmpty", NotEmpty }, 
      { "http://hl7.org/fhir/assert-operator-codes#notEmpty", NotEmpty }, 
      { "notEquals", NotEquals }, 
      { "http://hl7.org/fhir/assert-operator-codes#notEquals", NotEquals }, 
      { "notIn", NotIn }, 
      { "http://hl7.org/fhir/assert-operator-codes#notIn", NotIn }, 
    };
  };
}
