// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// This example value set defines a set of codes that can be used to indicate the type of encounter: a specific code indicating type of service provided.
  /// </summary>
  public static class EncounterTypeCodes
  {
    /// <summary>
    /// Annual diabetes mellitus screening
    /// </summary>
    public static readonly Coding AnnualDiabetesMellitusScreening = new Coding
    {
      Code = "ADMS",
      Display = "Annual diabetes mellitus screening",
      System = "http://hl7.org/fhir/encounter-type"
    };
    /// <summary>
    /// Bone drilling/bone marrow punction in clinic
    /// </summary>
    public static readonly Coding BoneDrillingBoneMarrowPunctionInClinic = new Coding
    {
      Code = "BD/BM-clin",
      Display = "Bone drilling/bone marrow punction in clinic",
      System = "http://hl7.org/fhir/encounter-type"
    };
    /// <summary>
    /// Infant colon screening - 60 minutes
    /// </summary>
    public static readonly Coding InfantColonScreening60Minutes = new Coding
    {
      Code = "CCS60",
      Display = "Infant colon screening - 60 minutes",
      System = "http://hl7.org/fhir/encounter-type"
    };
    /// <summary>
    /// Outpatient Kenacort injection
    /// </summary>
    public static readonly Coding OutpatientKenacortInjection = new Coding
    {
      Code = "OKI",
      Display = "Outpatient Kenacort injection",
      System = "http://hl7.org/fhir/encounter-type"
    };

    /// <summary>
    /// Literal for code: AnnualDiabetesMellitusScreening
    /// </summary>
    public const string LiteralAnnualDiabetesMellitusScreening = "ADMS";

    /// <summary>
    /// Literal for code: EncounterTypeAnnualDiabetesMellitusScreening
    /// </summary>
    public const string LiteralEncounterTypeAnnualDiabetesMellitusScreening = "http://hl7.org/fhir/encounter-type#ADMS";

    /// <summary>
    /// Literal for code: BoneDrillingBoneMarrowPunctionInClinic
    /// </summary>
    public const string LiteralBoneDrillingBoneMarrowPunctionInClinic = "BD/BM-clin";

    /// <summary>
    /// Literal for code: EncounterTypeBoneDrillingBoneMarrowPunctionInClinic
    /// </summary>
    public const string LiteralEncounterTypeBoneDrillingBoneMarrowPunctionInClinic = "http://hl7.org/fhir/encounter-type#BD/BM-clin";

    /// <summary>
    /// Literal for code: InfantColonScreening60Minutes
    /// </summary>
    public const string LiteralInfantColonScreening60Minutes = "CCS60";

    /// <summary>
    /// Literal for code: EncounterTypeInfantColonScreening60Minutes
    /// </summary>
    public const string LiteralEncounterTypeInfantColonScreening60Minutes = "http://hl7.org/fhir/encounter-type#CCS60";

    /// <summary>
    /// Literal for code: OutpatientKenacortInjection
    /// </summary>
    public const string LiteralOutpatientKenacortInjection = "OKI";

    /// <summary>
    /// Literal for code: EncounterTypeOutpatientKenacortInjection
    /// </summary>
    public const string LiteralEncounterTypeOutpatientKenacortInjection = "http://hl7.org/fhir/encounter-type#OKI";

    /// <summary>
    /// Dictionary for looking up EncounterType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "ADMS", AnnualDiabetesMellitusScreening }, 
      { "http://hl7.org/fhir/encounter-type#ADMS", AnnualDiabetesMellitusScreening }, 
      { "BD/BM-clin", BoneDrillingBoneMarrowPunctionInClinic }, 
      { "http://hl7.org/fhir/encounter-type#BD/BM-clin", BoneDrillingBoneMarrowPunctionInClinic }, 
      { "CCS60", InfantColonScreening60Minutes }, 
      { "http://hl7.org/fhir/encounter-type#CCS60", InfantColonScreening60Minutes }, 
      { "OKI", OutpatientKenacortInjection }, 
      { "http://hl7.org/fhir/encounter-type#OKI", OutpatientKenacortInjection }, 
    };
  };
}
