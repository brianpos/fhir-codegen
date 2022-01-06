// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// How much of the content of the code system - the concepts and codes it defines - are represented in a code system resource
  /// </summary>
  public static class CodesystemContentModeCodes
  {
    /// <summary>
    /// All the concepts defined by the code system are included in the code system resource
    /// </summary>
    public static readonly Coding Complete = new Coding
    {
      Code = "complete",
      Display = "Complete",
      System = "http://hl7.org/fhir/codesystem-content-mode"
    };
    /// <summary>
    /// A few representative concepts are included in the code system resource
    /// </summary>
    public static readonly Coding Example = new Coding
    {
      Code = "example",
      Display = "Example",
      System = "http://hl7.org/fhir/codesystem-content-mode"
    };
    /// <summary>
    /// A subset of the code system concepts are included in the code system resource
    /// </summary>
    public static readonly Coding Fragment = new Coding
    {
      Code = "fragment",
      Display = "Fragment",
      System = "http://hl7.org/fhir/codesystem-content-mode"
    };
    /// <summary>
    /// None of the concepts defined by the code system are included in the code system resource
    /// </summary>
    public static readonly Coding NotPresent = new Coding
    {
      Code = "not-present",
      Display = "Not Present",
      System = "http://hl7.org/fhir/codesystem-content-mode"
    };

    /// <summary>
    /// Literal for code: Complete
    /// </summary>
    public const string LiteralComplete = "complete";

    /// <summary>
    /// Literal for code: Example
    /// </summary>
    public const string LiteralExample = "example";

    /// <summary>
    /// Literal for code: Fragment
    /// </summary>
    public const string LiteralFragment = "fragment";

    /// <summary>
    /// Literal for code: NotPresent
    /// </summary>
    public const string LiteralNotPresent = "not-present";
  };
}