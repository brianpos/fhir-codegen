// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// A type defined by FHIR that is an abstract type
  /// </summary>
  public static class AbstractTypesCodes
  {
    /// <summary>
    /// A place holder that means any kind of resource
    /// </summary>
    public static readonly Coding Any = new Coding
    {
      Code = "Any",
      Display = "Any",
      System = "http://hl7.org/fhir/abstract-types"
    };
    /// <summary>
    /// A place holder that means any kind of data type
    /// </summary>
    public static readonly Coding Type = new Coding
    {
      Code = "Type",
      Display = "Type",
      System = "http://hl7.org/fhir/abstract-types"
    };

    /// <summary>
    /// Literal for code: Any
    /// </summary>
    public const string LiteralAny = "Any";

    /// <summary>
    /// Literal for code: Type
    /// </summary>
    public const string LiteralType = "Type";
  };
}