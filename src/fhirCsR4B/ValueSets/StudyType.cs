// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// The type of study the evidence was derived from.
  /// </summary>
  public static class StudyTypeCodes
  {
    /// <summary>
    /// case-control study.
    /// </summary>
    public static readonly Coding CaseControlStudy = new Coding
    {
      Code = "case-control",
      Display = "case-control study",
      System = "http://terminology.hl7.org/CodeSystem/study-type"
    };
    /// <summary>
    /// a single case report.
    /// </summary>
    public static readonly Coding CaseReport = new Coding
    {
      Code = "case-report",
      Display = "case report",
      System = "http://terminology.hl7.org/CodeSystem/study-type"
    };
    /// <summary>
    /// controlled (but not randomized) trial.
    /// </summary>
    public static readonly Coding ControlledTrialNonRandomized = new Coding
    {
      Code = "CCT",
      Display = "controlled trial (non-randomized)",
      System = "http://terminology.hl7.org/CodeSystem/study-type"
    };
    /// <summary>
    /// observational study comparing cohorts.
    /// </summary>
    public static readonly Coding ComparativeCohortStudy = new Coding
    {
      Code = "cohort",
      Display = "comparative cohort study",
      System = "http://terminology.hl7.org/CodeSystem/study-type"
    };
    /// <summary>
    /// a combination of 1 or more types of studies.
    /// </summary>
    public static readonly Coding MixedMethods = new Coding
    {
      Code = "mixed",
      Display = "mixed methods",
      System = "http://terminology.hl7.org/CodeSystem/study-type"
    };
    /// <summary>
    /// randomized controlled trial.
    /// </summary>
    public static readonly Coding RandomizedTrial = new Coding
    {
      Code = "RCT",
      Display = "randomized trial",
      System = "http://terminology.hl7.org/CodeSystem/study-type"
    };
    /// <summary>
    /// uncontrolled cohort or case series.
    /// </summary>
    public static readonly Coding UncontrolledCohortOrCaseSeries = new Coding
    {
      Code = "series",
      Display = "uncontrolled cohort or case series",
      System = "http://terminology.hl7.org/CodeSystem/study-type"
    };

    /// <summary>
    /// Literal for code: CaseControlStudy
    /// </summary>
    public const string LiteralCaseControlStudy = "case-control";

    /// <summary>
    /// Literal for code: StudyTypeCaseControlStudy
    /// </summary>
    public const string LiteralStudyTypeCaseControlStudy = "http://terminology.hl7.org/CodeSystem/study-type#case-control";

    /// <summary>
    /// Literal for code: CaseReport
    /// </summary>
    public const string LiteralCaseReport = "case-report";

    /// <summary>
    /// Literal for code: StudyTypeCaseReport
    /// </summary>
    public const string LiteralStudyTypeCaseReport = "http://terminology.hl7.org/CodeSystem/study-type#case-report";

    /// <summary>
    /// Literal for code: ControlledTrialNonRandomized
    /// </summary>
    public const string LiteralControlledTrialNonRandomized = "CCT";

    /// <summary>
    /// Literal for code: StudyTypeControlledTrialNonRandomized
    /// </summary>
    public const string LiteralStudyTypeControlledTrialNonRandomized = "http://terminology.hl7.org/CodeSystem/study-type#CCT";

    /// <summary>
    /// Literal for code: ComparativeCohortStudy
    /// </summary>
    public const string LiteralComparativeCohortStudy = "cohort";

    /// <summary>
    /// Literal for code: StudyTypeComparativeCohortStudy
    /// </summary>
    public const string LiteralStudyTypeComparativeCohortStudy = "http://terminology.hl7.org/CodeSystem/study-type#cohort";

    /// <summary>
    /// Literal for code: MixedMethods
    /// </summary>
    public const string LiteralMixedMethods = "mixed";

    /// <summary>
    /// Literal for code: StudyTypeMixedMethods
    /// </summary>
    public const string LiteralStudyTypeMixedMethods = "http://terminology.hl7.org/CodeSystem/study-type#mixed";

    /// <summary>
    /// Literal for code: RandomizedTrial
    /// </summary>
    public const string LiteralRandomizedTrial = "RCT";

    /// <summary>
    /// Literal for code: StudyTypeRandomizedTrial
    /// </summary>
    public const string LiteralStudyTypeRandomizedTrial = "http://terminology.hl7.org/CodeSystem/study-type#RCT";

    /// <summary>
    /// Literal for code: UncontrolledCohortOrCaseSeries
    /// </summary>
    public const string LiteralUncontrolledCohortOrCaseSeries = "series";

    /// <summary>
    /// Literal for code: StudyTypeUncontrolledCohortOrCaseSeries
    /// </summary>
    public const string LiteralStudyTypeUncontrolledCohortOrCaseSeries = "http://terminology.hl7.org/CodeSystem/study-type#series";

    /// <summary>
    /// Dictionary for looking up StudyType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "case-control", CaseControlStudy }, 
      { "http://terminology.hl7.org/CodeSystem/study-type#case-control", CaseControlStudy }, 
      { "case-report", CaseReport }, 
      { "http://terminology.hl7.org/CodeSystem/study-type#case-report", CaseReport }, 
      { "CCT", ControlledTrialNonRandomized }, 
      { "http://terminology.hl7.org/CodeSystem/study-type#CCT", ControlledTrialNonRandomized }, 
      { "cohort", ComparativeCohortStudy }, 
      { "http://terminology.hl7.org/CodeSystem/study-type#cohort", ComparativeCohortStudy }, 
      { "mixed", MixedMethods }, 
      { "http://terminology.hl7.org/CodeSystem/study-type#mixed", MixedMethods }, 
      { "RCT", RandomizedTrial }, 
      { "http://terminology.hl7.org/CodeSystem/study-type#RCT", RandomizedTrial }, 
      { "series", UncontrolledCohortOrCaseSeries }, 
      { "http://terminology.hl7.org/CodeSystem/study-type#series", UncontrolledCohortOrCaseSeries }, 
    };
  };
}
