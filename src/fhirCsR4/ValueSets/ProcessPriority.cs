// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set includes the financial processing priority codes.
  /// </summary>
  public static class ProcessPriorityCodes
  {
    /// <summary>
    /// Later, when possible.
    /// </summary>
    public static readonly Coding Deferred = new Coding
    {
      Code = "deferred",
      Display = "Deferred",
      System = "http://terminology.hl7.org/CodeSystem/processpriority"
    };
    /// <summary>
    /// With best effort.
    /// </summary>
    public static readonly Coding Normal = new Coding
    {
      Code = "normal",
      Display = "Normal",
      System = "http://terminology.hl7.org/CodeSystem/processpriority"
    };
    /// <summary>
    /// Immediately in real time.
    /// </summary>
    public static readonly Coding Immediate = new Coding
    {
      Code = "stat",
      Display = "Immediate",
      System = "http://terminology.hl7.org/CodeSystem/processpriority"
    };

    /// <summary>
    /// Literal for code: Deferred
    /// </summary>
    public const string LiteralDeferred = "deferred";

    /// <summary>
    /// Literal for code: Normal
    /// </summary>
    public const string LiteralNormal = "normal";

    /// <summary>
    /// Literal for code: Immediate
    /// </summary>
    public const string LiteralImmediate = "stat";
  };
}