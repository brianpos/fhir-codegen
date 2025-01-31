// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// This value set includes codes for the relationship between the Policyholder and the Beneficiary (insured/covered party/patient)..
  /// </summary>
  public static class PolicyholderRelationshipCodes
  {
    /// <summary>
    /// The Beneficiary is a child of the Policyholder
    /// </summary>
    public static readonly Coding Child = new Coding
    {
      Code = "child",
      Display = "Child",
      System = "http://hl7.org/fhir/policyholder-relationship"
    };
    /// <summary>
    /// The Beneficiary is a common law spouse or equivalent of the Policyholder
    /// </summary>
    public static readonly Coding CommonLawSpouse = new Coding
    {
      Code = "common",
      Display = "Common Law Spouse",
      System = "http://hl7.org/fhir/policyholder-relationship"
    };
    /// <summary>
    /// The Beneficiary has some other relationship the Policyholder
    /// </summary>
    public static readonly Coding Other = new Coding
    {
      Code = "other",
      Display = "Other",
      System = "http://hl7.org/fhir/policyholder-relationship"
    };
    /// <summary>
    /// The Beneficiary is a parent of the Policyholder
    /// </summary>
    public static readonly Coding Parent = new Coding
    {
      Code = "parent",
      Display = "Parent",
      System = "http://hl7.org/fhir/policyholder-relationship"
    };
    /// <summary>
    /// The Beneficiary is the Policyholder
    /// </summary>
    public static readonly Coding Self = new Coding
    {
      Code = "self",
      Display = "Self",
      System = "http://hl7.org/fhir/policyholder-relationship"
    };
    /// <summary>
    /// The Beneficiary is a spouse or equivalent of the Policyholder
    /// </summary>
    public static readonly Coding Spouse = new Coding
    {
      Code = "spouse",
      Display = "Spouse",
      System = "http://hl7.org/fhir/policyholder-relationship"
    };

    /// <summary>
    /// Literal for code: Child
    /// </summary>
    public const string LiteralChild = "child";

    /// <summary>
    /// Literal for code: PolicyholderRelationshipChild
    /// </summary>
    public const string LiteralPolicyholderRelationshipChild = "http://hl7.org/fhir/policyholder-relationship#child";

    /// <summary>
    /// Literal for code: CommonLawSpouse
    /// </summary>
    public const string LiteralCommonLawSpouse = "common";

    /// <summary>
    /// Literal for code: PolicyholderRelationshipCommonLawSpouse
    /// </summary>
    public const string LiteralPolicyholderRelationshipCommonLawSpouse = "http://hl7.org/fhir/policyholder-relationship#common";

    /// <summary>
    /// Literal for code: Other
    /// </summary>
    public const string LiteralOther = "other";

    /// <summary>
    /// Literal for code: PolicyholderRelationshipOther
    /// </summary>
    public const string LiteralPolicyholderRelationshipOther = "http://hl7.org/fhir/policyholder-relationship#other";

    /// <summary>
    /// Literal for code: Parent
    /// </summary>
    public const string LiteralParent = "parent";

    /// <summary>
    /// Literal for code: PolicyholderRelationshipParent
    /// </summary>
    public const string LiteralPolicyholderRelationshipParent = "http://hl7.org/fhir/policyholder-relationship#parent";

    /// <summary>
    /// Literal for code: Self
    /// </summary>
    public const string LiteralSelf = "self";

    /// <summary>
    /// Literal for code: PolicyholderRelationshipSelf
    /// </summary>
    public const string LiteralPolicyholderRelationshipSelf = "http://hl7.org/fhir/policyholder-relationship#self";

    /// <summary>
    /// Literal for code: Spouse
    /// </summary>
    public const string LiteralSpouse = "spouse";

    /// <summary>
    /// Literal for code: PolicyholderRelationshipSpouse
    /// </summary>
    public const string LiteralPolicyholderRelationshipSpouse = "http://hl7.org/fhir/policyholder-relationship#spouse";

    /// <summary>
    /// Dictionary for looking up PolicyholderRelationship Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "child", Child }, 
      { "http://hl7.org/fhir/policyholder-relationship#child", Child }, 
      { "common", CommonLawSpouse }, 
      { "http://hl7.org/fhir/policyholder-relationship#common", CommonLawSpouse }, 
      { "other", Other }, 
      { "http://hl7.org/fhir/policyholder-relationship#other", Other }, 
      { "parent", Parent }, 
      { "http://hl7.org/fhir/policyholder-relationship#parent", Parent }, 
      { "self", Self }, 
      { "http://hl7.org/fhir/policyholder-relationship#self", Self }, 
      { "spouse", Spouse }, 
      { "http://hl7.org/fhir/policyholder-relationship#spouse", Spouse }, 
    };
  };
}
