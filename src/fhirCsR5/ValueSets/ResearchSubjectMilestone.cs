// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Indicates the progression of a study subject through the study milestones.
  /// </summary>
  public static class ResearchSubjectMilestoneCodes
  {
    /// <summary>
    /// A subject has been allocated to an arm of the study.
    /// </summary>
    public static readonly Coding Randomized = new Coding
    {
      Code = "Randomized",
      Display = "Randomized",
      System = "http://terminology.hl7.org/CodeSystem/research-subject-milestone"
    };
    /// <summary>
    /// A potential subject has been screened for suitability.
    /// </summary>
    public static readonly Coding Screened = new Coding
    {
      Code = "Screened",
      Display = "Screened",
      System = "http://terminology.hl7.org/CodeSystem/research-subject-milestone"
    };
    /// <summary>
    /// A person has expressed an interest in being in a study but has not yet been through any assessment or consent processes.
    /// </summary>
    public static readonly Coding SignedUp = new Coding
    {
      Code = "SignedUp",
      Display = "Signed up",
      System = "http://terminology.hl7.org/CodeSystem/research-subject-milestone"
    };

    /// <summary>
    /// Literal for code: Randomized
    /// </summary>
    public const string LiteralRandomized = "Randomized";

    /// <summary>
    /// Literal for code: ResearchSubjectMilestoneRandomized
    /// </summary>
    public const string LiteralResearchSubjectMilestoneRandomized = "http://terminology.hl7.org/CodeSystem/research-subject-milestone#Randomized";

    /// <summary>
    /// Literal for code: Screened
    /// </summary>
    public const string LiteralScreened = "Screened";

    /// <summary>
    /// Literal for code: ResearchSubjectMilestoneScreened
    /// </summary>
    public const string LiteralResearchSubjectMilestoneScreened = "http://terminology.hl7.org/CodeSystem/research-subject-milestone#Screened";

    /// <summary>
    /// Literal for code: SignedUp
    /// </summary>
    public const string LiteralSignedUp = "SignedUp";

    /// <summary>
    /// Literal for code: ResearchSubjectMilestoneSignedUp
    /// </summary>
    public const string LiteralResearchSubjectMilestoneSignedUp = "http://terminology.hl7.org/CodeSystem/research-subject-milestone#SignedUp";

    /// <summary>
    /// Dictionary for looking up ResearchSubjectMilestone Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "Randomized", Randomized }, 
      { "http://terminology.hl7.org/CodeSystem/research-subject-milestone#Randomized", Randomized }, 
      { "Screened", Screened }, 
      { "http://terminology.hl7.org/CodeSystem/research-subject-milestone#Screened", Screened }, 
      { "SignedUp", SignedUp }, 
      { "http://terminology.hl7.org/CodeSystem/research-subject-milestone#SignedUp", SignedUp }, 
    };
  };
}
