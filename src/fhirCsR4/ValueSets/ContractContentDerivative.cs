// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This is an example set of Content Derivative type codes, which represent the minimal content derived from the basal information source at a specific stage in its lifecycle, which is sufficient to manage that source information, for example, in a repository, registry, processes and workflows, for making access control decisions, and providing query responses.
  /// </summary>
  public static class ContractContentDerivativeCodes
  {
    /// <summary>
    /// Content derivative that conveys sufficient information needed to register the source basal content from which it is derived.  This derivative content may be used to register the basal content as it changes status in its lifecycle.  For example, content registration may occur when the basal content is created, updated, inactive, or deleted.
    /// </summary>
    public static readonly Coding ContentRegistration = new Coding
    {
      Code = "registration",
      Display = "Content Registration",
      System = "http://terminology.hl7.org/CodeSystem/contract-content-derivative"
    };
    /// <summary>
    /// A content derivative that conveys sufficient information to locate and retrieve the content.
    /// </summary>
    public static readonly Coding ContentRetrieval = new Coding
    {
      Code = "retrieval",
      Display = "Content Retrieval",
      System = "http://terminology.hl7.org/CodeSystem/contract-content-derivative"
    };
    /// <summary>
    /// A Content Derivative that conveys sufficient information to determine the authorized entities with which the content may be shared.
    /// </summary>
    public static readonly Coding ShareableContent = new Coding
    {
      Code = "shareable",
      Display = "Shareable Content",
      System = "http://terminology.hl7.org/CodeSystem/contract-content-derivative"
    };
    /// <summary>
    /// Content derivative that has less than full fidelity to the basal information source from which it was 'transcribed'. It provides recipients with the full content representation they may require for compliance purposes, and typically include a reference to or an attached unstructured representation for recipients needing an exact copy of the legal agreement.
    /// </summary>
    public static readonly Coding ContentStatement = new Coding
    {
      Code = "statement",
      Display = "Content Statement",
      System = "http://terminology.hl7.org/CodeSystem/contract-content-derivative"
    };

    /// <summary>
    /// Literal for code: ContentRegistration
    /// </summary>
    public const string LiteralContentRegistration = "registration";

    /// <summary>
    /// Literal for code: ContractContentDerivativeContentRegistration
    /// </summary>
    public const string LiteralContractContentDerivativeContentRegistration = "http://terminology.hl7.org/CodeSystem/contract-content-derivative#registration";

    /// <summary>
    /// Literal for code: ContentRetrieval
    /// </summary>
    public const string LiteralContentRetrieval = "retrieval";

    /// <summary>
    /// Literal for code: ContractContentDerivativeContentRetrieval
    /// </summary>
    public const string LiteralContractContentDerivativeContentRetrieval = "http://terminology.hl7.org/CodeSystem/contract-content-derivative#retrieval";

    /// <summary>
    /// Literal for code: ShareableContent
    /// </summary>
    public const string LiteralShareableContent = "shareable";

    /// <summary>
    /// Literal for code: ContractContentDerivativeShareableContent
    /// </summary>
    public const string LiteralContractContentDerivativeShareableContent = "http://terminology.hl7.org/CodeSystem/contract-content-derivative#shareable";

    /// <summary>
    /// Literal for code: ContentStatement
    /// </summary>
    public const string LiteralContentStatement = "statement";

    /// <summary>
    /// Literal for code: ContractContentDerivativeContentStatement
    /// </summary>
    public const string LiteralContractContentDerivativeContentStatement = "http://terminology.hl7.org/CodeSystem/contract-content-derivative#statement";

    /// <summary>
    /// Dictionary for looking up ContractContentDerivative Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "registration", ContentRegistration }, 
      { "http://terminology.hl7.org/CodeSystem/contract-content-derivative#registration", ContentRegistration }, 
      { "retrieval", ContentRetrieval }, 
      { "http://terminology.hl7.org/CodeSystem/contract-content-derivative#retrieval", ContentRetrieval }, 
      { "shareable", ShareableContent }, 
      { "http://terminology.hl7.org/CodeSystem/contract-content-derivative#shareable", ShareableContent }, 
      { "statement", ContentStatement }, 
      { "http://terminology.hl7.org/CodeSystem/contract-content-derivative#statement", ContentStatement }, 
    };
  };
}
