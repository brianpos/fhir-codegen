// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// This value set includes a smattering of Benefit type codes.
  /// </summary>
  public static class BenefitTypeCodes
  {
    /// <summary>
    /// Maximum benefit allowable.
    /// </summary>
    public static readonly Coding Benefit = new Coding
    {
      Code = "benefit",
      Display = "Benefit",
      System = "http://hl7.org/fhir/benefit-type"
    };
    /// <summary>
    /// Copayment per service
    /// </summary>
    public static readonly Coding CopaymentPerService = new Coding
    {
      Code = "copay",
      Display = "Copayment per service",
      System = "http://hl7.org/fhir/benefit-type"
    };
    /// <summary>
    /// Copayment maximum per service
    /// </summary>
    public static readonly Coding CopaymentMaximumPerService = new Coding
    {
      Code = "copay-maximum",
      Display = "Copayment maximum per service",
      System = "http://hl7.org/fhir/benefit-type"
    };
    /// <summary>
    /// Copayment percentage per service
    /// </summary>
    public static readonly Coding CopaymentPercentPerService = new Coding
    {
      Code = "copay-percent",
      Display = "Copayment Percent per service",
      System = "http://hl7.org/fhir/benefit-type"
    };
    /// <summary>
    /// Cost to be incurred before benefits are applied
    /// </summary>
    public static readonly Coding Deductable = new Coding
    {
      Code = "deductable",
      Display = "Deductable",
      System = "http://hl7.org/fhir/benefit-type"
    };
    /// <summary>
    /// Medical Primary Health Coverage
    /// </summary>
    public static readonly Coding MedicalPrimaryHealthCoverage = new Coding
    {
      Code = "medical-primarycare",
      Display = "Medical Primary Health Coverage",
      System = "http://hl7.org/fhir/benefit-type"
    };
    /// <summary>
    /// Pharmacy Dispense Coverage
    /// </summary>
    public static readonly Coding PharmacyDispenseCoverage = new Coding
    {
      Code = "pharmacy-dispense",
      Display = "Pharmacy Dispense Coverage",
      System = "http://hl7.org/fhir/benefit-type"
    };
    /// <summary>
    /// Type of room
    /// </summary>
    public static readonly Coding Room = new Coding
    {
      Code = "room",
      Display = "Room",
      System = "http://hl7.org/fhir/benefit-type"
    };
    /// <summary>
    /// Contact Lenses
    /// </summary>
    public static readonly Coding VisionContactsCoverage = new Coding
    {
      Code = "vision-contacts",
      Display = "Vision Contacts Coverage",
      System = "http://hl7.org/fhir/benefit-type"
    };
    /// <summary>
    /// Vision Exam
    /// </summary>
    public static readonly Coding VisionExam = new Coding
    {
      Code = "vision-exam",
      Display = "Vision Exam",
      System = "http://hl7.org/fhir/benefit-type"
    };
    /// <summary>
    /// Frames and lenses
    /// </summary>
    public static readonly Coding VisionGlasses = new Coding
    {
      Code = "vision-glasses",
      Display = "Vision Glasses",
      System = "http://hl7.org/fhir/benefit-type"
    };
    /// <summary>
    /// Service visit
    /// </summary>
    public static readonly Coding Visit = new Coding
    {
      Code = "visit",
      Display = "Visit",
      System = "http://hl7.org/fhir/benefit-type"
    };

    /// <summary>
    /// Literal for code: Benefit
    /// </summary>
    public const string LiteralBenefit = "benefit";

    /// <summary>
    /// Literal for code: BenefitTypeBenefit
    /// </summary>
    public const string LiteralBenefitTypeBenefit = "http://hl7.org/fhir/benefit-type#benefit";

    /// <summary>
    /// Literal for code: CopaymentPerService
    /// </summary>
    public const string LiteralCopaymentPerService = "copay";

    /// <summary>
    /// Literal for code: BenefitTypeCopaymentPerService
    /// </summary>
    public const string LiteralBenefitTypeCopaymentPerService = "http://hl7.org/fhir/benefit-type#copay";

    /// <summary>
    /// Literal for code: CopaymentMaximumPerService
    /// </summary>
    public const string LiteralCopaymentMaximumPerService = "copay-maximum";

    /// <summary>
    /// Literal for code: BenefitTypeCopaymentMaximumPerService
    /// </summary>
    public const string LiteralBenefitTypeCopaymentMaximumPerService = "http://hl7.org/fhir/benefit-type#copay-maximum";

    /// <summary>
    /// Literal for code: CopaymentPercentPerService
    /// </summary>
    public const string LiteralCopaymentPercentPerService = "copay-percent";

    /// <summary>
    /// Literal for code: BenefitTypeCopaymentPercentPerService
    /// </summary>
    public const string LiteralBenefitTypeCopaymentPercentPerService = "http://hl7.org/fhir/benefit-type#copay-percent";

    /// <summary>
    /// Literal for code: Deductable
    /// </summary>
    public const string LiteralDeductable = "deductable";

    /// <summary>
    /// Literal for code: BenefitTypeDeductable
    /// </summary>
    public const string LiteralBenefitTypeDeductable = "http://hl7.org/fhir/benefit-type#deductable";

    /// <summary>
    /// Literal for code: MedicalPrimaryHealthCoverage
    /// </summary>
    public const string LiteralMedicalPrimaryHealthCoverage = "medical-primarycare";

    /// <summary>
    /// Literal for code: BenefitTypeMedicalPrimaryHealthCoverage
    /// </summary>
    public const string LiteralBenefitTypeMedicalPrimaryHealthCoverage = "http://hl7.org/fhir/benefit-type#medical-primarycare";

    /// <summary>
    /// Literal for code: PharmacyDispenseCoverage
    /// </summary>
    public const string LiteralPharmacyDispenseCoverage = "pharmacy-dispense";

    /// <summary>
    /// Literal for code: BenefitTypePharmacyDispenseCoverage
    /// </summary>
    public const string LiteralBenefitTypePharmacyDispenseCoverage = "http://hl7.org/fhir/benefit-type#pharmacy-dispense";

    /// <summary>
    /// Literal for code: Room
    /// </summary>
    public const string LiteralRoom = "room";

    /// <summary>
    /// Literal for code: BenefitTypeRoom
    /// </summary>
    public const string LiteralBenefitTypeRoom = "http://hl7.org/fhir/benefit-type#room";

    /// <summary>
    /// Literal for code: VisionContactsCoverage
    /// </summary>
    public const string LiteralVisionContactsCoverage = "vision-contacts";

    /// <summary>
    /// Literal for code: BenefitTypeVisionContactsCoverage
    /// </summary>
    public const string LiteralBenefitTypeVisionContactsCoverage = "http://hl7.org/fhir/benefit-type#vision-contacts";

    /// <summary>
    /// Literal for code: VisionExam
    /// </summary>
    public const string LiteralVisionExam = "vision-exam";

    /// <summary>
    /// Literal for code: BenefitTypeVisionExam
    /// </summary>
    public const string LiteralBenefitTypeVisionExam = "http://hl7.org/fhir/benefit-type#vision-exam";

    /// <summary>
    /// Literal for code: VisionGlasses
    /// </summary>
    public const string LiteralVisionGlasses = "vision-glasses";

    /// <summary>
    /// Literal for code: BenefitTypeVisionGlasses
    /// </summary>
    public const string LiteralBenefitTypeVisionGlasses = "http://hl7.org/fhir/benefit-type#vision-glasses";

    /// <summary>
    /// Literal for code: Visit
    /// </summary>
    public const string LiteralVisit = "visit";

    /// <summary>
    /// Literal for code: BenefitTypeVisit
    /// </summary>
    public const string LiteralBenefitTypeVisit = "http://hl7.org/fhir/benefit-type#visit";

    /// <summary>
    /// Dictionary for looking up BenefitType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "benefit", Benefit }, 
      { "http://hl7.org/fhir/benefit-type#benefit", Benefit }, 
      { "copay", CopaymentPerService }, 
      { "http://hl7.org/fhir/benefit-type#copay", CopaymentPerService }, 
      { "copay-maximum", CopaymentMaximumPerService }, 
      { "http://hl7.org/fhir/benefit-type#copay-maximum", CopaymentMaximumPerService }, 
      { "copay-percent", CopaymentPercentPerService }, 
      { "http://hl7.org/fhir/benefit-type#copay-percent", CopaymentPercentPerService }, 
      { "deductable", Deductable }, 
      { "http://hl7.org/fhir/benefit-type#deductable", Deductable }, 
      { "medical-primarycare", MedicalPrimaryHealthCoverage }, 
      { "http://hl7.org/fhir/benefit-type#medical-primarycare", MedicalPrimaryHealthCoverage }, 
      { "pharmacy-dispense", PharmacyDispenseCoverage }, 
      { "http://hl7.org/fhir/benefit-type#pharmacy-dispense", PharmacyDispenseCoverage }, 
      { "room", Room }, 
      { "http://hl7.org/fhir/benefit-type#room", Room }, 
      { "vision-contacts", VisionContactsCoverage }, 
      { "http://hl7.org/fhir/benefit-type#vision-contacts", VisionContactsCoverage }, 
      { "vision-exam", VisionExam }, 
      { "http://hl7.org/fhir/benefit-type#vision-exam", VisionExam }, 
      { "vision-glasses", VisionGlasses }, 
      { "http://hl7.org/fhir/benefit-type#vision-glasses", VisionGlasses }, 
      { "visit", Visit }, 
      { "http://hl7.org/fhir/benefit-type#visit", Visit }, 
    };
  };
}
