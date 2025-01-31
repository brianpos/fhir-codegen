// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  ///  Supports communication of purpose of use at a general level.
  /// </summary>
  public static class V3PurposeOfUseCodes
  {
    /// <summary>
    /// To perform one or more operations on information for provision of health care coordination.
    /// </summary>
    public static readonly Coding CareManagement = new Coding
    {
      Code = "CAREMGT",
      Display = "Care Management",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information for conducting scientific investigations in accordance with clinical trial protocols to obtain health care knowledge.
    /// </summary>
    public static readonly Coding ClinicalTrialResearch = new Coding
    {
      Code = "CLINTRCH",
      Display = "clinical trial research",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform health care as part of the clinical trial protocol.
    /// </summary>
    public static readonly Coding ClinicalTrial = new Coding
    {
      Code = "CLINTRL",
      Display = "clinical trial",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information for provision of additional clinical evidence in support of a request for coverage or payment for health services.
    /// </summary>
    public static readonly Coding ClaimAttachment = new Coding
    {
      Code = "CLMATTCH",
      Display = "claim attachment",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information for conducting prior authorization or predetermination of coverage for services.
    /// </summary>
    public static readonly Coding CoverageAuthorization = new Coding
    {
      Code = "COVAUTH",
      Display = "coverage authorization",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information for conducting activities related to coverage under a program or policy.
    /// </summary>
    public static readonly Coding CoverageUnderPolicyOrProgram = new Coding
    {
      Code = "COVERAGE",
      Display = "coverage under policy or program",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information used for provision of immediately needed health care to a population of living subjects located in a disaster zone.
    /// </summary>
    public static readonly Coding Disaster = new Coding
    {
      Code = "DISASTER",
      Display = "disaster",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information used for cadaveric organ, eye or tissue donation.
    /// </summary>
    public static readonly Coding Donation = new Coding
    {
      Code = "DONAT",
      Display = "donation",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information used for conducting eligibility determination for coverage in a program or policy.  May entail review of financial status or disability assessment.
    /// </summary>
    public static readonly Coding EligibilityDetermination = new Coding
    {
      Code = "ELIGDTRM",
      Display = "eligibility determination",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information used for conducting eligibility verification of coverage in a program or policy.  May entail provider contacting coverage source (e.g., government health program such as workers compensation or health plan) for confirmation of enrollment, eligibility for specific services, and any applicable copays.
    /// </summary>
    public static readonly Coding EligibilityVerification = new Coding
    {
      Code = "ELIGVER",
      Display = "eligibility verification",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information used for enrolling a covered party in a program or policy.  May entail recording of covered party's and any dependent's demographic information and benefit choices.
    /// </summary>
    public static readonly Coding Enrollment = new Coding
    {
      Code = "ENROLLM",
      Display = "enrollment",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information for provision of immediately needed health care for an emergent condition.
    /// </summary>
    public static readonly Coding EmergencyTreatment = new Coding
    {
      Code = "ETREAT",
      Display = "Emergency Treatment",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information in response to a request by a family member authorized by the patient.
    /// </summary>
    public static readonly Coding FamilyRequested = new Coding
    {
      Code = "FAMRQT",
      Display = "family requested",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information used for fraud detection and prevention processes.
    /// </summary>
    public static readonly Coding Fraud = new Coding
    {
      Code = "FRAUD",
      Display = "fraud",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information used within government processes.
    /// </summary>
    public static readonly Coding Government = new Coding
    {
      Code = "GOV",
      Display = "government",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information for conducting activities related to meeting accreditation criteria.
    /// </summary>
    public static readonly Coding HealthAccreditation = new Coding
    {
      Code = "HACCRED",
      Display = "health accreditation",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information used for conducting activities required to meet a mandate.
    /// </summary>
    public static readonly Coding HealthCompliance = new Coding
    {
      Code = "HCOMPL",
      Display = "health compliance",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information used for handling deceased patient matters.
    /// </summary>
    public static readonly Coding Decedent = new Coding
    {
      Code = "HDECD",
      Display = "decedent",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operation operations on information used to manage a patient directory.
    /// 
    ///                         
    ///                            Examples: 
    ///                         
    /// 
    ///                         
    ///                            facility
    ///                            enterprise
    ///                            payer
    ///                            health information exchange patient directory
    /// </summary>
    public static readonly Coding Directory = new Coding
    {
      Code = "HDIRECT",
      Display = "directory",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information for conducting activities required by legal proceeding.
    /// </summary>
    public static readonly Coding Legal = new Coding
    {
      Code = "HLEGAL",
      Display = "legal",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information for marketing services and products related to health care.
    /// </summary>
    public static readonly Coding HealthcareMarketing = new Coding
    {
      Code = "HMARKT",
      Display = "healthcare marketing",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information used for conducting administrative and contractual activities related to the provision of health care.
    /// </summary>
    public static readonly Coding HealthcareOperations = new Coding
    {
      Code = "HOPERAT",
      Display = "healthcare operations",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information used for assessing results and comparative effectiveness achieved by health care practices and interventions.
    /// </summary>
    public static readonly Coding HealthOutcomeMeasure = new Coding
    {
      Code = "HOUTCOMS",
      Display = "health outcome measure",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information for conducting financial or contractual activities related to payment for provision of health care.
    /// </summary>
    public static readonly Coding HealthcarePayment = new Coding
    {
      Code = "HPAYMT",
      Display = "healthcare payment",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information used for conducting activities to meet program accounting requirements.
    /// </summary>
    public static readonly Coding HealthProgramReporting = new Coding
    {
      Code = "HPRGRP",
      Display = "health program reporting",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information used for conducting administrative activities to improve health care quality.
    /// </summary>
    public static readonly Coding HealthQualityImprovement = new Coding
    {
      Code = "HQUALIMP",
      Display = "health quality improvement",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information for conducting scientific investigations to obtain health care knowledge.
    /// </summary>
    public static readonly Coding HealthcareResearch = new Coding
    {
      Code = "HRESCH",
      Display = "healthcare research",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information to administer the electronic systems used for the delivery of health care.
    /// </summary>
    public static readonly Coding HealthSystemAdministration = new Coding
    {
      Code = "HSYSADMIN",
      Display = "health system administration",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information to administer health care coverage to an enrollee under a policy or program.
    /// </summary>
    public static readonly Coding MemberAdministration = new Coding
    {
      Code = "MEMADMIN",
      Display = "member administration",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information used for operational activities conducted to administer the delivery of health care to a patient.
    /// </summary>
    public static readonly Coding PatientAdministration = new Coding
    {
      Code = "PATADMIN",
      Display = "patient administration",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information in response to a patient's request.
    /// </summary>
    public static readonly Coding PatientRequested = new Coding
    {
      Code = "PATRQT",
      Display = "patient requested",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information in processes related to ensuring the safety of health care.
    /// </summary>
    public static readonly Coding PatientSafety = new Coding
    {
      Code = "PATSFTY",
      Display = "patient safety",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information used for monitoring performance of recommended health care practices and interventions.
    /// </summary>
    public static readonly Coding PerformanceMeasure = new Coding
    {
      Code = "PERFMSR",
      Display = "performance measure",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information for provision of health care to a population of living subjects, e.g., needle exchange program.
    /// </summary>
    public static readonly Coding PopulationHealth = new Coding
    {
      Code = "POPHLTH",
      Display = "population health",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information for conducting public health activities, such as the reporting of notifiable conditions.
    /// </summary>
    public static readonly Coding PublicHealth = new Coding
    {
      Code = "PUBHLTH",
      Display = "public health",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// Reason for performing one or more operations on information, which may be permitted by source system's security policy in accordance with one or more privacy policies and consent directives.
    /// 
    ///                         
    ///                            Usage Notes: The rationale or purpose for an act relating to the management of personal health information, such as collecting personal health information for research or public health purposes.
    /// </summary>
    public static readonly Coding PurposeOfUse = new Coding
    {
      Code = "PurposeOfUse",
      Display = "purpose of use",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information in response to a request by a person appointed as the patient's legal representative.
    /// </summary>
    public static readonly Coding PowerOfAttorney = new Coding
    {
      Code = "PWATRNY",
      Display = "power of attorney",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information used within the health records management process.
    /// </summary>
    public static readonly Coding RecordsManagement = new Coding
    {
      Code = "RECORDMGT",
      Display = "records management",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information about the amount remitted for a health care claim.
    /// </summary>
    public static readonly Coding RemittanceAdvice = new Coding
    {
      Code = "REMITADV",
      Display = "remittance advice",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information in response to a request by a person authorized by the patient.
    /// </summary>
    public static readonly Coding SupportNetwork = new Coding
    {
      Code = "SUPNWK",
      Display = "support network",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information used to prevent injury or disease to living subjects who may be the target of violence.
    /// </summary>
    public static readonly Coding Threat = new Coding
    {
      Code = "THREAT",
      Display = "threat",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information used in training and education.
    /// </summary>
    public static readonly Coding Training = new Coding
    {
      Code = "TRAIN",
      Display = "training",
      System = "http://hl7.org/fhir/v3/ActReason"
    };
    /// <summary>
    /// To perform one or more operations on information for provision of health care.
    /// </summary>
    public static readonly Coding Treatment = new Coding
    {
      Code = "TREAT",
      Display = "treatment",
      System = "http://hl7.org/fhir/v3/ActReason"
    };

    /// <summary>
    /// Literal for code: CareManagement
    /// </summary>
    public const string LiteralCareManagement = "CAREMGT";

    /// <summary>
    /// Literal for code: V3ActReasonCareManagement
    /// </summary>
    public const string LiteralV3ActReasonCareManagement = "http://hl7.org/fhir/v3/ActReason#CAREMGT";

    /// <summary>
    /// Literal for code: ClinicalTrialResearch
    /// </summary>
    public const string LiteralClinicalTrialResearch = "CLINTRCH";

    /// <summary>
    /// Literal for code: V3ActReasonClinicalTrialResearch
    /// </summary>
    public const string LiteralV3ActReasonClinicalTrialResearch = "http://hl7.org/fhir/v3/ActReason#CLINTRCH";

    /// <summary>
    /// Literal for code: ClinicalTrial
    /// </summary>
    public const string LiteralClinicalTrial = "CLINTRL";

    /// <summary>
    /// Literal for code: V3ActReasonClinicalTrial
    /// </summary>
    public const string LiteralV3ActReasonClinicalTrial = "http://hl7.org/fhir/v3/ActReason#CLINTRL";

    /// <summary>
    /// Literal for code: ClaimAttachment
    /// </summary>
    public const string LiteralClaimAttachment = "CLMATTCH";

    /// <summary>
    /// Literal for code: V3ActReasonClaimAttachment
    /// </summary>
    public const string LiteralV3ActReasonClaimAttachment = "http://hl7.org/fhir/v3/ActReason#CLMATTCH";

    /// <summary>
    /// Literal for code: CoverageAuthorization
    /// </summary>
    public const string LiteralCoverageAuthorization = "COVAUTH";

    /// <summary>
    /// Literal for code: V3ActReasonCoverageAuthorization
    /// </summary>
    public const string LiteralV3ActReasonCoverageAuthorization = "http://hl7.org/fhir/v3/ActReason#COVAUTH";

    /// <summary>
    /// Literal for code: CoverageUnderPolicyOrProgram
    /// </summary>
    public const string LiteralCoverageUnderPolicyOrProgram = "COVERAGE";

    /// <summary>
    /// Literal for code: V3ActReasonCoverageUnderPolicyOrProgram
    /// </summary>
    public const string LiteralV3ActReasonCoverageUnderPolicyOrProgram = "http://hl7.org/fhir/v3/ActReason#COVERAGE";

    /// <summary>
    /// Literal for code: Disaster
    /// </summary>
    public const string LiteralDisaster = "DISASTER";

    /// <summary>
    /// Literal for code: V3ActReasonDisaster
    /// </summary>
    public const string LiteralV3ActReasonDisaster = "http://hl7.org/fhir/v3/ActReason#DISASTER";

    /// <summary>
    /// Literal for code: Donation
    /// </summary>
    public const string LiteralDonation = "DONAT";

    /// <summary>
    /// Literal for code: V3ActReasonDonation
    /// </summary>
    public const string LiteralV3ActReasonDonation = "http://hl7.org/fhir/v3/ActReason#DONAT";

    /// <summary>
    /// Literal for code: EligibilityDetermination
    /// </summary>
    public const string LiteralEligibilityDetermination = "ELIGDTRM";

    /// <summary>
    /// Literal for code: V3ActReasonEligibilityDetermination
    /// </summary>
    public const string LiteralV3ActReasonEligibilityDetermination = "http://hl7.org/fhir/v3/ActReason#ELIGDTRM";

    /// <summary>
    /// Literal for code: EligibilityVerification
    /// </summary>
    public const string LiteralEligibilityVerification = "ELIGVER";

    /// <summary>
    /// Literal for code: V3ActReasonEligibilityVerification
    /// </summary>
    public const string LiteralV3ActReasonEligibilityVerification = "http://hl7.org/fhir/v3/ActReason#ELIGVER";

    /// <summary>
    /// Literal for code: Enrollment
    /// </summary>
    public const string LiteralEnrollment = "ENROLLM";

    /// <summary>
    /// Literal for code: V3ActReasonEnrollment
    /// </summary>
    public const string LiteralV3ActReasonEnrollment = "http://hl7.org/fhir/v3/ActReason#ENROLLM";

    /// <summary>
    /// Literal for code: EmergencyTreatment
    /// </summary>
    public const string LiteralEmergencyTreatment = "ETREAT";

    /// <summary>
    /// Literal for code: V3ActReasonEmergencyTreatment
    /// </summary>
    public const string LiteralV3ActReasonEmergencyTreatment = "http://hl7.org/fhir/v3/ActReason#ETREAT";

    /// <summary>
    /// Literal for code: FamilyRequested
    /// </summary>
    public const string LiteralFamilyRequested = "FAMRQT";

    /// <summary>
    /// Literal for code: V3ActReasonFamilyRequested
    /// </summary>
    public const string LiteralV3ActReasonFamilyRequested = "http://hl7.org/fhir/v3/ActReason#FAMRQT";

    /// <summary>
    /// Literal for code: Fraud
    /// </summary>
    public const string LiteralFraud = "FRAUD";

    /// <summary>
    /// Literal for code: V3ActReasonFraud
    /// </summary>
    public const string LiteralV3ActReasonFraud = "http://hl7.org/fhir/v3/ActReason#FRAUD";

    /// <summary>
    /// Literal for code: Government
    /// </summary>
    public const string LiteralGovernment = "GOV";

    /// <summary>
    /// Literal for code: V3ActReasonGovernment
    /// </summary>
    public const string LiteralV3ActReasonGovernment = "http://hl7.org/fhir/v3/ActReason#GOV";

    /// <summary>
    /// Literal for code: HealthAccreditation
    /// </summary>
    public const string LiteralHealthAccreditation = "HACCRED";

    /// <summary>
    /// Literal for code: V3ActReasonHealthAccreditation
    /// </summary>
    public const string LiteralV3ActReasonHealthAccreditation = "http://hl7.org/fhir/v3/ActReason#HACCRED";

    /// <summary>
    /// Literal for code: HealthCompliance
    /// </summary>
    public const string LiteralHealthCompliance = "HCOMPL";

    /// <summary>
    /// Literal for code: V3ActReasonHealthCompliance
    /// </summary>
    public const string LiteralV3ActReasonHealthCompliance = "http://hl7.org/fhir/v3/ActReason#HCOMPL";

    /// <summary>
    /// Literal for code: Decedent
    /// </summary>
    public const string LiteralDecedent = "HDECD";

    /// <summary>
    /// Literal for code: V3ActReasonDecedent
    /// </summary>
    public const string LiteralV3ActReasonDecedent = "http://hl7.org/fhir/v3/ActReason#HDECD";

    /// <summary>
    /// Literal for code: Directory
    /// </summary>
    public const string LiteralDirectory = "HDIRECT";

    /// <summary>
    /// Literal for code: V3ActReasonDirectory
    /// </summary>
    public const string LiteralV3ActReasonDirectory = "http://hl7.org/fhir/v3/ActReason#HDIRECT";

    /// <summary>
    /// Literal for code: Legal
    /// </summary>
    public const string LiteralLegal = "HLEGAL";

    /// <summary>
    /// Literal for code: V3ActReasonLegal
    /// </summary>
    public const string LiteralV3ActReasonLegal = "http://hl7.org/fhir/v3/ActReason#HLEGAL";

    /// <summary>
    /// Literal for code: HealthcareMarketing
    /// </summary>
    public const string LiteralHealthcareMarketing = "HMARKT";

    /// <summary>
    /// Literal for code: V3ActReasonHealthcareMarketing
    /// </summary>
    public const string LiteralV3ActReasonHealthcareMarketing = "http://hl7.org/fhir/v3/ActReason#HMARKT";

    /// <summary>
    /// Literal for code: HealthcareOperations
    /// </summary>
    public const string LiteralHealthcareOperations = "HOPERAT";

    /// <summary>
    /// Literal for code: V3ActReasonHealthcareOperations
    /// </summary>
    public const string LiteralV3ActReasonHealthcareOperations = "http://hl7.org/fhir/v3/ActReason#HOPERAT";

    /// <summary>
    /// Literal for code: HealthOutcomeMeasure
    /// </summary>
    public const string LiteralHealthOutcomeMeasure = "HOUTCOMS";

    /// <summary>
    /// Literal for code: V3ActReasonHealthOutcomeMeasure
    /// </summary>
    public const string LiteralV3ActReasonHealthOutcomeMeasure = "http://hl7.org/fhir/v3/ActReason#HOUTCOMS";

    /// <summary>
    /// Literal for code: HealthcarePayment
    /// </summary>
    public const string LiteralHealthcarePayment = "HPAYMT";

    /// <summary>
    /// Literal for code: V3ActReasonHealthcarePayment
    /// </summary>
    public const string LiteralV3ActReasonHealthcarePayment = "http://hl7.org/fhir/v3/ActReason#HPAYMT";

    /// <summary>
    /// Literal for code: HealthProgramReporting
    /// </summary>
    public const string LiteralHealthProgramReporting = "HPRGRP";

    /// <summary>
    /// Literal for code: V3ActReasonHealthProgramReporting
    /// </summary>
    public const string LiteralV3ActReasonHealthProgramReporting = "http://hl7.org/fhir/v3/ActReason#HPRGRP";

    /// <summary>
    /// Literal for code: HealthQualityImprovement
    /// </summary>
    public const string LiteralHealthQualityImprovement = "HQUALIMP";

    /// <summary>
    /// Literal for code: V3ActReasonHealthQualityImprovement
    /// </summary>
    public const string LiteralV3ActReasonHealthQualityImprovement = "http://hl7.org/fhir/v3/ActReason#HQUALIMP";

    /// <summary>
    /// Literal for code: HealthcareResearch
    /// </summary>
    public const string LiteralHealthcareResearch = "HRESCH";

    /// <summary>
    /// Literal for code: V3ActReasonHealthcareResearch
    /// </summary>
    public const string LiteralV3ActReasonHealthcareResearch = "http://hl7.org/fhir/v3/ActReason#HRESCH";

    /// <summary>
    /// Literal for code: HealthSystemAdministration
    /// </summary>
    public const string LiteralHealthSystemAdministration = "HSYSADMIN";

    /// <summary>
    /// Literal for code: V3ActReasonHealthSystemAdministration
    /// </summary>
    public const string LiteralV3ActReasonHealthSystemAdministration = "http://hl7.org/fhir/v3/ActReason#HSYSADMIN";

    /// <summary>
    /// Literal for code: MemberAdministration
    /// </summary>
    public const string LiteralMemberAdministration = "MEMADMIN";

    /// <summary>
    /// Literal for code: V3ActReasonMemberAdministration
    /// </summary>
    public const string LiteralV3ActReasonMemberAdministration = "http://hl7.org/fhir/v3/ActReason#MEMADMIN";

    /// <summary>
    /// Literal for code: PatientAdministration
    /// </summary>
    public const string LiteralPatientAdministration = "PATADMIN";

    /// <summary>
    /// Literal for code: V3ActReasonPatientAdministration
    /// </summary>
    public const string LiteralV3ActReasonPatientAdministration = "http://hl7.org/fhir/v3/ActReason#PATADMIN";

    /// <summary>
    /// Literal for code: PatientRequested
    /// </summary>
    public const string LiteralPatientRequested = "PATRQT";

    /// <summary>
    /// Literal for code: V3ActReasonPatientRequested
    /// </summary>
    public const string LiteralV3ActReasonPatientRequested = "http://hl7.org/fhir/v3/ActReason#PATRQT";

    /// <summary>
    /// Literal for code: PatientSafety
    /// </summary>
    public const string LiteralPatientSafety = "PATSFTY";

    /// <summary>
    /// Literal for code: V3ActReasonPatientSafety
    /// </summary>
    public const string LiteralV3ActReasonPatientSafety = "http://hl7.org/fhir/v3/ActReason#PATSFTY";

    /// <summary>
    /// Literal for code: PerformanceMeasure
    /// </summary>
    public const string LiteralPerformanceMeasure = "PERFMSR";

    /// <summary>
    /// Literal for code: V3ActReasonPerformanceMeasure
    /// </summary>
    public const string LiteralV3ActReasonPerformanceMeasure = "http://hl7.org/fhir/v3/ActReason#PERFMSR";

    /// <summary>
    /// Literal for code: PopulationHealth
    /// </summary>
    public const string LiteralPopulationHealth = "POPHLTH";

    /// <summary>
    /// Literal for code: V3ActReasonPopulationHealth
    /// </summary>
    public const string LiteralV3ActReasonPopulationHealth = "http://hl7.org/fhir/v3/ActReason#POPHLTH";

    /// <summary>
    /// Literal for code: PublicHealth
    /// </summary>
    public const string LiteralPublicHealth = "PUBHLTH";

    /// <summary>
    /// Literal for code: V3ActReasonPublicHealth
    /// </summary>
    public const string LiteralV3ActReasonPublicHealth = "http://hl7.org/fhir/v3/ActReason#PUBHLTH";

    /// <summary>
    /// Literal for code: PurposeOfUse
    /// </summary>
    public const string LiteralPurposeOfUse = "PurposeOfUse";

    /// <summary>
    /// Literal for code: V3ActReasonPurposeOfUse
    /// </summary>
    public const string LiteralV3ActReasonPurposeOfUse = "http://hl7.org/fhir/v3/ActReason#PurposeOfUse";

    /// <summary>
    /// Literal for code: PowerOfAttorney
    /// </summary>
    public const string LiteralPowerOfAttorney = "PWATRNY";

    /// <summary>
    /// Literal for code: V3ActReasonPowerOfAttorney
    /// </summary>
    public const string LiteralV3ActReasonPowerOfAttorney = "http://hl7.org/fhir/v3/ActReason#PWATRNY";

    /// <summary>
    /// Literal for code: RecordsManagement
    /// </summary>
    public const string LiteralRecordsManagement = "RECORDMGT";

    /// <summary>
    /// Literal for code: V3ActReasonRecordsManagement
    /// </summary>
    public const string LiteralV3ActReasonRecordsManagement = "http://hl7.org/fhir/v3/ActReason#RECORDMGT";

    /// <summary>
    /// Literal for code: RemittanceAdvice
    /// </summary>
    public const string LiteralRemittanceAdvice = "REMITADV";

    /// <summary>
    /// Literal for code: V3ActReasonRemittanceAdvice
    /// </summary>
    public const string LiteralV3ActReasonRemittanceAdvice = "http://hl7.org/fhir/v3/ActReason#REMITADV";

    /// <summary>
    /// Literal for code: SupportNetwork
    /// </summary>
    public const string LiteralSupportNetwork = "SUPNWK";

    /// <summary>
    /// Literal for code: V3ActReasonSupportNetwork
    /// </summary>
    public const string LiteralV3ActReasonSupportNetwork = "http://hl7.org/fhir/v3/ActReason#SUPNWK";

    /// <summary>
    /// Literal for code: Threat
    /// </summary>
    public const string LiteralThreat = "THREAT";

    /// <summary>
    /// Literal for code: V3ActReasonThreat
    /// </summary>
    public const string LiteralV3ActReasonThreat = "http://hl7.org/fhir/v3/ActReason#THREAT";

    /// <summary>
    /// Literal for code: Training
    /// </summary>
    public const string LiteralTraining = "TRAIN";

    /// <summary>
    /// Literal for code: V3ActReasonTraining
    /// </summary>
    public const string LiteralV3ActReasonTraining = "http://hl7.org/fhir/v3/ActReason#TRAIN";

    /// <summary>
    /// Literal for code: Treatment
    /// </summary>
    public const string LiteralTreatment = "TREAT";

    /// <summary>
    /// Literal for code: V3ActReasonTreatment
    /// </summary>
    public const string LiteralV3ActReasonTreatment = "http://hl7.org/fhir/v3/ActReason#TREAT";

    /// <summary>
    /// Dictionary for looking up V3PurposeOfUse Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "CAREMGT", CareManagement }, 
      { "http://hl7.org/fhir/v3/ActReason#CAREMGT", CareManagement }, 
      { "CLINTRCH", ClinicalTrialResearch }, 
      { "http://hl7.org/fhir/v3/ActReason#CLINTRCH", ClinicalTrialResearch }, 
      { "CLINTRL", ClinicalTrial }, 
      { "http://hl7.org/fhir/v3/ActReason#CLINTRL", ClinicalTrial }, 
      { "CLMATTCH", ClaimAttachment }, 
      { "http://hl7.org/fhir/v3/ActReason#CLMATTCH", ClaimAttachment }, 
      { "COVAUTH", CoverageAuthorization }, 
      { "http://hl7.org/fhir/v3/ActReason#COVAUTH", CoverageAuthorization }, 
      { "COVERAGE", CoverageUnderPolicyOrProgram }, 
      { "http://hl7.org/fhir/v3/ActReason#COVERAGE", CoverageUnderPolicyOrProgram }, 
      { "DISASTER", Disaster }, 
      { "http://hl7.org/fhir/v3/ActReason#DISASTER", Disaster }, 
      { "DONAT", Donation }, 
      { "http://hl7.org/fhir/v3/ActReason#DONAT", Donation }, 
      { "ELIGDTRM", EligibilityDetermination }, 
      { "http://hl7.org/fhir/v3/ActReason#ELIGDTRM", EligibilityDetermination }, 
      { "ELIGVER", EligibilityVerification }, 
      { "http://hl7.org/fhir/v3/ActReason#ELIGVER", EligibilityVerification }, 
      { "ENROLLM", Enrollment }, 
      { "http://hl7.org/fhir/v3/ActReason#ENROLLM", Enrollment }, 
      { "ETREAT", EmergencyTreatment }, 
      { "http://hl7.org/fhir/v3/ActReason#ETREAT", EmergencyTreatment }, 
      { "FAMRQT", FamilyRequested }, 
      { "http://hl7.org/fhir/v3/ActReason#FAMRQT", FamilyRequested }, 
      { "FRAUD", Fraud }, 
      { "http://hl7.org/fhir/v3/ActReason#FRAUD", Fraud }, 
      { "GOV", Government }, 
      { "http://hl7.org/fhir/v3/ActReason#GOV", Government }, 
      { "HACCRED", HealthAccreditation }, 
      { "http://hl7.org/fhir/v3/ActReason#HACCRED", HealthAccreditation }, 
      { "HCOMPL", HealthCompliance }, 
      { "http://hl7.org/fhir/v3/ActReason#HCOMPL", HealthCompliance }, 
      { "HDECD", Decedent }, 
      { "http://hl7.org/fhir/v3/ActReason#HDECD", Decedent }, 
      { "HDIRECT", Directory }, 
      { "http://hl7.org/fhir/v3/ActReason#HDIRECT", Directory }, 
      { "HLEGAL", Legal }, 
      { "http://hl7.org/fhir/v3/ActReason#HLEGAL", Legal }, 
      { "HMARKT", HealthcareMarketing }, 
      { "http://hl7.org/fhir/v3/ActReason#HMARKT", HealthcareMarketing }, 
      { "HOPERAT", HealthcareOperations }, 
      { "http://hl7.org/fhir/v3/ActReason#HOPERAT", HealthcareOperations }, 
      { "HOUTCOMS", HealthOutcomeMeasure }, 
      { "http://hl7.org/fhir/v3/ActReason#HOUTCOMS", HealthOutcomeMeasure }, 
      { "HPAYMT", HealthcarePayment }, 
      { "http://hl7.org/fhir/v3/ActReason#HPAYMT", HealthcarePayment }, 
      { "HPRGRP", HealthProgramReporting }, 
      { "http://hl7.org/fhir/v3/ActReason#HPRGRP", HealthProgramReporting }, 
      { "HQUALIMP", HealthQualityImprovement }, 
      { "http://hl7.org/fhir/v3/ActReason#HQUALIMP", HealthQualityImprovement }, 
      { "HRESCH", HealthcareResearch }, 
      { "http://hl7.org/fhir/v3/ActReason#HRESCH", HealthcareResearch }, 
      { "HSYSADMIN", HealthSystemAdministration }, 
      { "http://hl7.org/fhir/v3/ActReason#HSYSADMIN", HealthSystemAdministration }, 
      { "MEMADMIN", MemberAdministration }, 
      { "http://hl7.org/fhir/v3/ActReason#MEMADMIN", MemberAdministration }, 
      { "PATADMIN", PatientAdministration }, 
      { "http://hl7.org/fhir/v3/ActReason#PATADMIN", PatientAdministration }, 
      { "PATRQT", PatientRequested }, 
      { "http://hl7.org/fhir/v3/ActReason#PATRQT", PatientRequested }, 
      { "PATSFTY", PatientSafety }, 
      { "http://hl7.org/fhir/v3/ActReason#PATSFTY", PatientSafety }, 
      { "PERFMSR", PerformanceMeasure }, 
      { "http://hl7.org/fhir/v3/ActReason#PERFMSR", PerformanceMeasure }, 
      { "POPHLTH", PopulationHealth }, 
      { "http://hl7.org/fhir/v3/ActReason#POPHLTH", PopulationHealth }, 
      { "PUBHLTH", PublicHealth }, 
      { "http://hl7.org/fhir/v3/ActReason#PUBHLTH", PublicHealth }, 
      { "PurposeOfUse", PurposeOfUse }, 
      { "http://hl7.org/fhir/v3/ActReason#PurposeOfUse", PurposeOfUse }, 
      { "PWATRNY", PowerOfAttorney }, 
      { "http://hl7.org/fhir/v3/ActReason#PWATRNY", PowerOfAttorney }, 
      { "RECORDMGT", RecordsManagement }, 
      { "http://hl7.org/fhir/v3/ActReason#RECORDMGT", RecordsManagement }, 
      { "REMITADV", RemittanceAdvice }, 
      { "http://hl7.org/fhir/v3/ActReason#REMITADV", RemittanceAdvice }, 
      { "SUPNWK", SupportNetwork }, 
      { "http://hl7.org/fhir/v3/ActReason#SUPNWK", SupportNetwork }, 
      { "THREAT", Threat }, 
      { "http://hl7.org/fhir/v3/ActReason#THREAT", Threat }, 
      { "TRAIN", Training }, 
      { "http://hl7.org/fhir/v3/ActReason#TRAIN", Training }, 
      { "TREAT", Treatment }, 
      { "http://hl7.org/fhir/v3/ActReason#TREAT", Treatment }, 
    };
  };
}
