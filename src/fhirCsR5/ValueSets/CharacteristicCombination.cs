// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Logical grouping of characteristics.
  /// </summary>
  public static class CharacteristicCombinationCodes
  {
    /// <summary>
    /// Combine characteristics with AND.
    /// </summary>
    public static readonly Coding AllOf = new Coding
    {
      Code = "all-of",
      Display = "All of",
      System = "http://hl7.org/fhir/characteristic-combination"
    };
    /// <summary>
    /// Combine characteristics with OR.
    /// </summary>
    public static readonly Coding AnyOf = new Coding
    {
      Code = "any-of",
      Display = "Any of",
      System = "http://hl7.org/fhir/characteristic-combination"
    };
    /// <summary>
    /// Meet at least the threshold number of characteristics for definition.
    /// </summary>
    public static readonly Coding AtLeast = new Coding
    {
      Code = "at-least",
      Display = "At least",
      System = "http://hl7.org/fhir/characteristic-combination"
    };
    /// <summary>
    /// Meet at most the threshold number of characteristics for definition.
    /// </summary>
    public static readonly Coding AtMost = new Coding
    {
      Code = "at-most",
      Display = "At most",
      System = "http://hl7.org/fhir/characteristic-combination"
    };
    /// <summary>
    ///  Combine characteristics statistically.
    /// </summary>
    public static readonly Coding NetEffect = new Coding
    {
      Code = "net-effect",
      Display = "Net effect",
      System = "http://hl7.org/fhir/characteristic-combination"
    };

    /// <summary>
    /// Literal for code: AllOf
    /// </summary>
    public const string LiteralAllOf = "all-of";

    /// <summary>
    /// Literal for code: CharacteristicCombinationAllOf
    /// </summary>
    public const string LiteralCharacteristicCombinationAllOf = "http://hl7.org/fhir/characteristic-combination#all-of";

    /// <summary>
    /// Literal for code: AnyOf
    /// </summary>
    public const string LiteralAnyOf = "any-of";

    /// <summary>
    /// Literal for code: CharacteristicCombinationAnyOf
    /// </summary>
    public const string LiteralCharacteristicCombinationAnyOf = "http://hl7.org/fhir/characteristic-combination#any-of";

    /// <summary>
    /// Literal for code: AtLeast
    /// </summary>
    public const string LiteralAtLeast = "at-least";

    /// <summary>
    /// Literal for code: CharacteristicCombinationAtLeast
    /// </summary>
    public const string LiteralCharacteristicCombinationAtLeast = "http://hl7.org/fhir/characteristic-combination#at-least";

    /// <summary>
    /// Literal for code: AtMost
    /// </summary>
    public const string LiteralAtMost = "at-most";

    /// <summary>
    /// Literal for code: CharacteristicCombinationAtMost
    /// </summary>
    public const string LiteralCharacteristicCombinationAtMost = "http://hl7.org/fhir/characteristic-combination#at-most";

    /// <summary>
    /// Literal for code: NetEffect
    /// </summary>
    public const string LiteralNetEffect = "net-effect";

    /// <summary>
    /// Literal for code: CharacteristicCombinationNetEffect
    /// </summary>
    public const string LiteralCharacteristicCombinationNetEffect = "http://hl7.org/fhir/characteristic-combination#net-effect";

    /// <summary>
    /// Dictionary for looking up CharacteristicCombination Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "all-of", AllOf }, 
      { "http://hl7.org/fhir/characteristic-combination#all-of", AllOf }, 
      { "any-of", AnyOf }, 
      { "http://hl7.org/fhir/characteristic-combination#any-of", AnyOf }, 
      { "at-least", AtLeast }, 
      { "http://hl7.org/fhir/characteristic-combination#at-least", AtLeast }, 
      { "at-most", AtMost }, 
      { "http://hl7.org/fhir/characteristic-combination#at-most", AtMost }, 
      { "net-effect", NetEffect }, 
      { "http://hl7.org/fhir/characteristic-combination#net-effect", NetEffect }, 
    };
  };
}
