// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// How the system supports versioning for a resource.
  /// </summary>
  public static class VersioningPolicyCodes
  {
    /// <summary>
    /// VersionId meta-property is not supported (server) or used (client).
    /// </summary>
    public static readonly Coding NoVersionIdSupport = new Coding
    {
      Code = "no-version",
      Display = "No VersionId Support",
      System = "http://hl7.org/fhir/versioning-policy"
    };
    /// <summary>
    /// VersionId meta-property is supported (server) or used (client).
    /// </summary>
    public static readonly Coding Versioned = new Coding
    {
      Code = "versioned",
      Display = "Versioned",
      System = "http://hl7.org/fhir/versioning-policy"
    };
    /// <summary>
    /// VersionId must be correct for updates (server) or will be specified (If-match header) for updates (client).
    /// </summary>
    public static readonly Coding VersionIdTrackedFully = new Coding
    {
      Code = "versioned-update",
      Display = "VersionId tracked fully",
      System = "http://hl7.org/fhir/versioning-policy"
    };

    /// <summary>
    /// Literal for code: NoVersionIdSupport
    /// </summary>
    public const string LiteralNoVersionIdSupport = "no-version";

    /// <summary>
    /// Literal for code: Versioned
    /// </summary>
    public const string LiteralVersioned = "versioned";

    /// <summary>
    /// Literal for code: VersionIdTrackedFully
    /// </summary>
    public const string LiteralVersionIdTrackedFully = "versioned-update";
  };
}