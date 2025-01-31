// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// FHIR search modifiers allowed for use in Subscriptions and SubscriptionTopics.
  /// </summary>
  public static class SubscriptionSearchModifierCodes
  {
    /// <summary>
    /// Used to match a value according to FHIR Search rules (e.g., Patient/123, Encounter/2002).
    /// </summary>
    public static readonly new Coding Equals = new Coding
    {
      Code = "=",
      Display = "=",
      System = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier"
    };
    /// <summary>
    /// The search parameter is a concept with the form [system]|[code], and the search parameter tests whether the coding in a resource subsumes the specified search code.
    /// </summary>
    public static readonly Coding Above = new Coding
    {
      Code = "above",
      Display = "Above",
      System = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier"
    };
    /// <summary>
    /// The value for the parameter in the resource is approximately the same to the provided value. Note that the recommended value for the approximation is 10% of the stated value (or for a date, 10% of the gap between now and the date), but systems may choose other values where appropriate.
    /// </summary>
    public static readonly Coding Approximately = new Coding
    {
      Code = "ap",
      Display = "Approximately",
      System = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier"
    };
    /// <summary>
    /// The search parameter is a concept with the form [system]|[code], and the search parameter tests whether the coding in a resource is subsumed by the specified search code.
    /// </summary>
    public static readonly Coding Below = new Coding
    {
      Code = "below",
      Display = "Below",
      System = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier"
    };
    /// <summary>
    /// The value for the parameter in the resource ends before the provided value.
    /// </summary>
    public static readonly Coding EndsBefore = new Coding
    {
      Code = "eb",
      Display = "Ends Before",
      System = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier"
    };
    /// <summary>
    /// The value for the parameter in the resource is equal to the provided value.
    /// </summary>
    public static readonly Coding Equal = new Coding
    {
      Code = "eq",
      Display = "Equal",
      System = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier"
    };
    /// <summary>
    /// The value for the parameter in the resource is greater or equal to the provided value.
    /// </summary>
    public static readonly Coding GreaterThanOrEqual = new Coding
    {
      Code = "ge",
      Display = "Greater Than or Equal",
      System = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier"
    };
    /// <summary>
    /// The value for the parameter in the resource is greater than the provided value.
    /// </summary>
    public static readonly Coding GreaterThan = new Coding
    {
      Code = "gt",
      Display = "Greater Than",
      System = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier"
    };
    /// <summary>
    /// The search parameter is a member of a Group or List, or the search parameter is a URI (relative or absolute) that identifies a value set, and the search parameter tests whether the value is present in the specified Group, List, or Value Set.
    /// </summary>
    public static readonly Coding In = new Coding
    {
      Code = "in",
      Display = "In",
      System = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier"
    };
    /// <summary>
    /// The value for the parameter in the resource is less or equal to the provided value.
    /// </summary>
    public static readonly Coding LessThanOrEqual = new Coding
    {
      Code = "le",
      Display = "Less Than or Equal",
      System = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier"
    };
    /// <summary>
    /// The value for the parameter in the resource is less than the provided value.
    /// </summary>
    public static readonly Coding LessThan = new Coding
    {
      Code = "lt",
      Display = "Less Than",
      System = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier"
    };
    /// <summary>
    /// The value for the parameter in the resource is not equal to the provided value.
    /// </summary>
    public static readonly Coding NotEqual = new Coding
    {
      Code = "ne",
      Display = "Not Equal",
      System = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier"
    };
    /// <summary>
    /// The search parameter is a member of a Group or List, or the search parameter is a URI (relative or absolute) that identifies a value set, and the search parameter tests whether the value is NOT present in the specified Group, List, or Value Set.
    /// </summary>
    public static readonly Coding NotIn = new Coding
    {
      Code = "not-in",
      Display = "Not In",
      System = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier"
    };
    /// <summary>
    /// The search parameter has the format system|code|value, where the system and code refer to a Identifier.type.coding.system and .code, and match if any of the type codes match. All 3 parts must be present.
    /// </summary>
    public static readonly Coding OfType = new Coding
    {
      Code = "of-type",
      Display = "Of Type",
      System = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier"
    };
    /// <summary>
    /// The value for the parameter in the resource starts after the provided value.
    /// </summary>
    public static readonly Coding StartsAfter = new Coding
    {
      Code = "sa",
      Display = "Starts After",
      System = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier"
    };

    /// <summary>
    /// Literal for code: Equals
    /// </summary>
    public const string LiteralEquals = "=";

    /// <summary>
    /// Literal for code: SubscriptionSearchModifierEquals
    /// </summary>
    public const string LiteralSubscriptionSearchModifierEquals = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#=";

    /// <summary>
    /// Literal for code: Above
    /// </summary>
    public const string LiteralAbove = "above";

    /// <summary>
    /// Literal for code: SubscriptionSearchModifierAbove
    /// </summary>
    public const string LiteralSubscriptionSearchModifierAbove = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#above";

    /// <summary>
    /// Literal for code: Approximately
    /// </summary>
    public const string LiteralApproximately = "ap";

    /// <summary>
    /// Literal for code: SubscriptionSearchModifierApproximately
    /// </summary>
    public const string LiteralSubscriptionSearchModifierApproximately = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#ap";

    /// <summary>
    /// Literal for code: Below
    /// </summary>
    public const string LiteralBelow = "below";

    /// <summary>
    /// Literal for code: SubscriptionSearchModifierBelow
    /// </summary>
    public const string LiteralSubscriptionSearchModifierBelow = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#below";

    /// <summary>
    /// Literal for code: EndsBefore
    /// </summary>
    public const string LiteralEndsBefore = "eb";

    /// <summary>
    /// Literal for code: SubscriptionSearchModifierEndsBefore
    /// </summary>
    public const string LiteralSubscriptionSearchModifierEndsBefore = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#eb";

    /// <summary>
    /// Literal for code: Equal
    /// </summary>
    public const string LiteralEqual = "eq";

    /// <summary>
    /// Literal for code: SubscriptionSearchModifierEqual
    /// </summary>
    public const string LiteralSubscriptionSearchModifierEqual = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#eq";

    /// <summary>
    /// Literal for code: GreaterThanOrEqual
    /// </summary>
    public const string LiteralGreaterThanOrEqual = "ge";

    /// <summary>
    /// Literal for code: SubscriptionSearchModifierGreaterThanOrEqual
    /// </summary>
    public const string LiteralSubscriptionSearchModifierGreaterThanOrEqual = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#ge";

    /// <summary>
    /// Literal for code: GreaterThan
    /// </summary>
    public const string LiteralGreaterThan = "gt";

    /// <summary>
    /// Literal for code: SubscriptionSearchModifierGreaterThan
    /// </summary>
    public const string LiteralSubscriptionSearchModifierGreaterThan = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#gt";

    /// <summary>
    /// Literal for code: In
    /// </summary>
    public const string LiteralIn = "in";

    /// <summary>
    /// Literal for code: SubscriptionSearchModifierIn
    /// </summary>
    public const string LiteralSubscriptionSearchModifierIn = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#in";

    /// <summary>
    /// Literal for code: LessThanOrEqual
    /// </summary>
    public const string LiteralLessThanOrEqual = "le";

    /// <summary>
    /// Literal for code: SubscriptionSearchModifierLessThanOrEqual
    /// </summary>
    public const string LiteralSubscriptionSearchModifierLessThanOrEqual = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#le";

    /// <summary>
    /// Literal for code: LessThan
    /// </summary>
    public const string LiteralLessThan = "lt";

    /// <summary>
    /// Literal for code: SubscriptionSearchModifierLessThan
    /// </summary>
    public const string LiteralSubscriptionSearchModifierLessThan = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#lt";

    /// <summary>
    /// Literal for code: NotEqual
    /// </summary>
    public const string LiteralNotEqual = "ne";

    /// <summary>
    /// Literal for code: SubscriptionSearchModifierNotEqual
    /// </summary>
    public const string LiteralSubscriptionSearchModifierNotEqual = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#ne";

    /// <summary>
    /// Literal for code: NotIn
    /// </summary>
    public const string LiteralNotIn = "not-in";

    /// <summary>
    /// Literal for code: SubscriptionSearchModifierNotIn
    /// </summary>
    public const string LiteralSubscriptionSearchModifierNotIn = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#not-in";

    /// <summary>
    /// Literal for code: OfType
    /// </summary>
    public const string LiteralOfType = "of-type";

    /// <summary>
    /// Literal for code: SubscriptionSearchModifierOfType
    /// </summary>
    public const string LiteralSubscriptionSearchModifierOfType = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#of-type";

    /// <summary>
    /// Literal for code: StartsAfter
    /// </summary>
    public const string LiteralStartsAfter = "sa";

    /// <summary>
    /// Literal for code: SubscriptionSearchModifierStartsAfter
    /// </summary>
    public const string LiteralSubscriptionSearchModifierStartsAfter = "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#sa";

    /// <summary>
    /// Dictionary for looking up SubscriptionSearchModifier Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "=", Equals }, 
      { "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#=", Equals }, 
      { "above", Above }, 
      { "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#above", Above }, 
      { "ap", Approximately }, 
      { "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#ap", Approximately }, 
      { "below", Below }, 
      { "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#below", Below }, 
      { "eb", EndsBefore }, 
      { "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#eb", EndsBefore }, 
      { "eq", Equal }, 
      { "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#eq", Equal }, 
      { "ge", GreaterThanOrEqual }, 
      { "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#ge", GreaterThanOrEqual }, 
      { "gt", GreaterThan }, 
      { "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#gt", GreaterThan }, 
      { "in", In }, 
      { "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#in", In }, 
      { "le", LessThanOrEqual }, 
      { "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#le", LessThanOrEqual }, 
      { "lt", LessThan }, 
      { "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#lt", LessThan }, 
      { "ne", NotEqual }, 
      { "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#ne", NotEqual }, 
      { "not-in", NotIn }, 
      { "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#not-in", NotIn }, 
      { "of-type", OfType }, 
      { "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#of-type", OfType }, 
      { "sa", StartsAfter }, 
      { "http://terminology.hl7.org/CodeSystem/subscription-search-modifier#sa", StartsAfter }, 
    };
  };
}
