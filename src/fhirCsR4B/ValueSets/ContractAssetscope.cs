// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// This value set contract specific codes for asset scope.
  /// </summary>
  public static class ContractAssetscopeCodes
  {
    /// <summary>
    /// To be completed
    /// </summary>
    public static readonly Coding Thing = new Coding
    {
      Code = "thing",
      Display = "Thing",
      System = "http://hl7.org/fhir/contract-assetscope"
    };

    /// <summary>
    /// Literal for code: Thing
    /// </summary>
    public const string LiteralThing = "thing";

    /// <summary>
    /// Literal for code: ContractAssetscopeThing
    /// </summary>
    public const string LiteralContractAssetscopeThing = "http://hl7.org/fhir/contract-assetscope#thing";

    /// <summary>
    /// Dictionary for looking up ContractAssetscope Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "thing", Thing }, 
      { "http://hl7.org/fhir/contract-assetscope#thing", Thing }, 
    };
  };
}
