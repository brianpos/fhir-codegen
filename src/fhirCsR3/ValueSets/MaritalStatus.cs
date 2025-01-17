// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// This value set defines the set of codes that can be used to indicate the marital status of a person.
  /// </summary>
  public static class MaritalStatusCodes
  {
    /// <summary>
    /// Marriage contract has been declared null and to not have existed
    /// </summary>
    public static readonly Coding Annulled_v3_MaritalStatus = new Coding
    {
      Code = "A",
      Display = "Annulled",
      System = "http://hl7.org/fhir/v3/MaritalStatus"
    };
    /// <summary>
    /// Marriage contract has been declared dissolved and inactive
    /// </summary>
    public static readonly Coding Divorced_v3_MaritalStatus = new Coding
    {
      Code = "D",
      Display = "Divorced",
      System = "http://hl7.org/fhir/v3/MaritalStatus"
    };
    /// <summary>
    /// Subject to an Interlocutory Decree.
    /// </summary>
    public static readonly Coding Interlocutory_v3_MaritalStatus = new Coding
    {
      Code = "I",
      Display = "Interlocutory",
      System = "http://hl7.org/fhir/v3/MaritalStatus"
    };
    /// <summary>
    /// Legally Separated
    /// </summary>
    public static readonly Coding LegallySeparated_v3_MaritalStatus = new Coding
    {
      Code = "L",
      Display = "Legally Separated",
      System = "http://hl7.org/fhir/v3/MaritalStatus"
    };
    /// <summary>
    /// A current marriage contract is active
    /// </summary>
    public static readonly Coding Married_v3_MaritalStatus = new Coding
    {
      Code = "M",
      Display = "Married",
      System = "http://hl7.org/fhir/v3/MaritalStatus"
    };
    /// <summary>
    /// More than 1 current spouse
    /// </summary>
    public static readonly Coding Polygamous_v3_MaritalStatus = new Coding
    {
      Code = "P",
      Display = "Polygamous",
      System = "http://hl7.org/fhir/v3/MaritalStatus"
    };
    /// <summary>
    /// No marriage contract has ever been entered
    /// </summary>
    public static readonly Coding NeverMarried_v3_MaritalStatus = new Coding
    {
      Code = "S",
      Display = "Never Married",
      System = "http://hl7.org/fhir/v3/MaritalStatus"
    };
    /// <summary>
    /// Person declares that a domestic partner relationship exists.
    /// </summary>
    public static readonly Coding DomesticPartner_v3_MaritalStatus = new Coding
    {
      Code = "T",
      Display = "Domestic partner",
      System = "http://hl7.org/fhir/v3/MaritalStatus"
    };
    /// <summary>
    /// Currently not in a marriage contract.
    /// </summary>
    public static readonly Coding Unmarried_v3_MaritalStatus = new Coding
    {
      Code = "U",
      Display = "unmarried",
      System = "http://hl7.org/fhir/v3/MaritalStatus"
    };
    /// <summary>
    /// Description:A proper value is applicable, but not known.
    /// 
    ///                         
    ///                            Usage Notes: This means the actual value is not known.  If the only thing that is unknown is how to properly express the value in the necessary constraints (value set, datatype, etc.), then the OTH or UNC flavor should be used.  No properties should be included for a datatype with this property unless:
    /// 
    ///                         
    ///                            Those properties themselves directly translate to a semantic of "unknown".  (E.g. a local code sent as a translation that conveys 'unknown')
    ///                            Those properties further qualify the nature of what is unknown.  (E.g. specifying a use code of "H" and a URL prefix of "tel:" to convey that it is the home phone number that is unknown.)
    /// </summary>
    public static readonly Coding Unknown_v3_NullFlavor = new Coding
    {
      Code = "UNK",
      Display = "unknown",
      System = "http://hl7.org/fhir/v3/NullFlavor"
    };
    /// <summary>
    /// The spouse has died
    /// </summary>
    public static readonly Coding Widowed_v3_MaritalStatus = new Coding
    {
      Code = "W",
      Display = "Widowed",
      System = "http://hl7.org/fhir/v3/MaritalStatus"
    };

    /// <summary>
    /// Literal for code: Annulled_v3_MaritalStatus
    /// </summary>
    public const string LiteralAnnulled_v3_MaritalStatus = "A";

    /// <summary>
    /// Literal for code: V3MaritalStatusAnnulled_v3_MaritalStatus
    /// </summary>
    public const string LiteralV3MaritalStatusAnnulled_v3_MaritalStatus = "http://hl7.org/fhir/v3/MaritalStatus#A";

    /// <summary>
    /// Literal for code: Divorced_v3_MaritalStatus
    /// </summary>
    public const string LiteralDivorced_v3_MaritalStatus = "D";

    /// <summary>
    /// Literal for code: V3MaritalStatusDivorced_v3_MaritalStatus
    /// </summary>
    public const string LiteralV3MaritalStatusDivorced_v3_MaritalStatus = "http://hl7.org/fhir/v3/MaritalStatus#D";

    /// <summary>
    /// Literal for code: Interlocutory_v3_MaritalStatus
    /// </summary>
    public const string LiteralInterlocutory_v3_MaritalStatus = "I";

    /// <summary>
    /// Literal for code: V3MaritalStatusInterlocutory_v3_MaritalStatus
    /// </summary>
    public const string LiteralV3MaritalStatusInterlocutory_v3_MaritalStatus = "http://hl7.org/fhir/v3/MaritalStatus#I";

    /// <summary>
    /// Literal for code: LegallySeparated_v3_MaritalStatus
    /// </summary>
    public const string LiteralLegallySeparated_v3_MaritalStatus = "L";

    /// <summary>
    /// Literal for code: V3MaritalStatusLegallySeparated_v3_MaritalStatus
    /// </summary>
    public const string LiteralV3MaritalStatusLegallySeparated_v3_MaritalStatus = "http://hl7.org/fhir/v3/MaritalStatus#L";

    /// <summary>
    /// Literal for code: Married_v3_MaritalStatus
    /// </summary>
    public const string LiteralMarried_v3_MaritalStatus = "M";

    /// <summary>
    /// Literal for code: V3MaritalStatusMarried_v3_MaritalStatus
    /// </summary>
    public const string LiteralV3MaritalStatusMarried_v3_MaritalStatus = "http://hl7.org/fhir/v3/MaritalStatus#M";

    /// <summary>
    /// Literal for code: Polygamous_v3_MaritalStatus
    /// </summary>
    public const string LiteralPolygamous_v3_MaritalStatus = "P";

    /// <summary>
    /// Literal for code: V3MaritalStatusPolygamous_v3_MaritalStatus
    /// </summary>
    public const string LiteralV3MaritalStatusPolygamous_v3_MaritalStatus = "http://hl7.org/fhir/v3/MaritalStatus#P";

    /// <summary>
    /// Literal for code: NeverMarried_v3_MaritalStatus
    /// </summary>
    public const string LiteralNeverMarried_v3_MaritalStatus = "S";

    /// <summary>
    /// Literal for code: V3MaritalStatusNeverMarried_v3_MaritalStatus
    /// </summary>
    public const string LiteralV3MaritalStatusNeverMarried_v3_MaritalStatus = "http://hl7.org/fhir/v3/MaritalStatus#S";

    /// <summary>
    /// Literal for code: DomesticPartner_v3_MaritalStatus
    /// </summary>
    public const string LiteralDomesticPartner_v3_MaritalStatus = "T";

    /// <summary>
    /// Literal for code: V3MaritalStatusDomesticPartner_v3_MaritalStatus
    /// </summary>
    public const string LiteralV3MaritalStatusDomesticPartner_v3_MaritalStatus = "http://hl7.org/fhir/v3/MaritalStatus#T";

    /// <summary>
    /// Literal for code: Unmarried_v3_MaritalStatus
    /// </summary>
    public const string LiteralUnmarried_v3_MaritalStatus = "U";

    /// <summary>
    /// Literal for code: V3MaritalStatusUnmarried_v3_MaritalStatus
    /// </summary>
    public const string LiteralV3MaritalStatusUnmarried_v3_MaritalStatus = "http://hl7.org/fhir/v3/MaritalStatus#U";

    /// <summary>
    /// Literal for code: Unknown_v3_NullFlavor
    /// </summary>
    public const string LiteralUnknown_v3_NullFlavor = "UNK";

    /// <summary>
    /// Literal for code: V3NullFlavorUnknown_v3_NullFlavor
    /// </summary>
    public const string LiteralV3NullFlavorUnknown_v3_NullFlavor = "http://hl7.org/fhir/v3/NullFlavor#UNK";

    /// <summary>
    /// Literal for code: Widowed_v3_MaritalStatus
    /// </summary>
    public const string LiteralWidowed_v3_MaritalStatus = "W";

    /// <summary>
    /// Literal for code: V3MaritalStatusWidowed_v3_MaritalStatus
    /// </summary>
    public const string LiteralV3MaritalStatusWidowed_v3_MaritalStatus = "http://hl7.org/fhir/v3/MaritalStatus#W";

    /// <summary>
    /// Dictionary for looking up MaritalStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "A", Annulled_v3_MaritalStatus }, 
      { "http://hl7.org/fhir/v3/MaritalStatus#A", Annulled_v3_MaritalStatus }, 
      { "D", Divorced_v3_MaritalStatus }, 
      { "http://hl7.org/fhir/v3/MaritalStatus#D", Divorced_v3_MaritalStatus }, 
      { "I", Interlocutory_v3_MaritalStatus }, 
      { "http://hl7.org/fhir/v3/MaritalStatus#I", Interlocutory_v3_MaritalStatus }, 
      { "L", LegallySeparated_v3_MaritalStatus }, 
      { "http://hl7.org/fhir/v3/MaritalStatus#L", LegallySeparated_v3_MaritalStatus }, 
      { "M", Married_v3_MaritalStatus }, 
      { "http://hl7.org/fhir/v3/MaritalStatus#M", Married_v3_MaritalStatus }, 
      { "P", Polygamous_v3_MaritalStatus }, 
      { "http://hl7.org/fhir/v3/MaritalStatus#P", Polygamous_v3_MaritalStatus }, 
      { "S", NeverMarried_v3_MaritalStatus }, 
      { "http://hl7.org/fhir/v3/MaritalStatus#S", NeverMarried_v3_MaritalStatus }, 
      { "T", DomesticPartner_v3_MaritalStatus }, 
      { "http://hl7.org/fhir/v3/MaritalStatus#T", DomesticPartner_v3_MaritalStatus }, 
      { "U", Unmarried_v3_MaritalStatus }, 
      { "http://hl7.org/fhir/v3/MaritalStatus#U", Unmarried_v3_MaritalStatus }, 
      { "UNK", Unknown_v3_NullFlavor }, 
      { "http://hl7.org/fhir/v3/NullFlavor#UNK", Unknown_v3_NullFlavor }, 
      { "W", Widowed_v3_MaritalStatus }, 
      { "http://hl7.org/fhir/v3/MaritalStatus#W", Widowed_v3_MaritalStatus }, 
    };
  };
}
