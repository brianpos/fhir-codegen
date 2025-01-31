// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value set includes sample Consent Directive Type codes, including several consent directive related LOINC codes; HL7 VALUE SET: ActConsentType(2.16.840.1.113883.1.11.19897); examples of US realm consent directive legal descriptions and references to online and/or downloadable forms such as the SSA-827 Authorization to Disclose Information to the Social Security Administration; and other anticipated consent directives related to participation in a clinical trial, medical procedures, reproductive procedures; health care directive (Living Will); advance directive, do not resuscitate (DNR); Physician Orders for Life-Sustaining Treatment (POLST)
  /// </summary>
  public static class ConsentCategoryCodes
  {
    /// <summary>
    /// ActConsentType
    /// </summary>
    public static readonly Coding ActConsentType = new Coding
    {
      Code = "_ActConsentType",
      Display = "ActConsentType",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// Privacy policy acknowledgement Document
    /// </summary>
    public static readonly Coding PrivacyPolicyAcknowledgementDocument = new Coding
    {
      Code = "57016-8",
      Display = "Privacy policy acknowledgement Document",
      System = "http://loinc.org"
    };
    /// <summary>
    /// Privacy policy Organization Document 
    /// </summary>
    public static readonly Coding PrivacyPolicyOrganizationDocument = new Coding
    {
      Code = "57017-6",
      Display = "Privacy policy Organization Document ",
      System = "http://loinc.org"
    };
    /// <summary>
    /// Patient Consent 
    /// </summary>
    public static readonly Coding PatientConsent = new Coding
    {
      Code = "59284-0",
      Display = "Patient Consent ",
      System = "http://loinc.org"
    };
    /// <summary>
    /// Release of information consent 
    /// </summary>
    public static readonly Coding ReleaseOfInformationConsent = new Coding
    {
      Code = "64292-6",
      Display = "Release of information consent ",
      System = "http://loinc.org"
    };
    /// <summary>
    /// Advance Directive
    /// </summary>
    public static readonly Coding AdvanceDirective = new Coding
    {
      Code = "acd",
      Display = "Advance Directive",
      System = "http://terminology.hl7.org/CodeSystem/consentcategorycodes"
    };
    /// <summary>
    /// Do Not Resuscitate
    /// </summary>
    public static readonly Coding DoNotResuscitate = new Coding
    {
      Code = "dnr",
      Display = "Do Not Resuscitate",
      System = "http://terminology.hl7.org/CodeSystem/consentcategorycodes"
    };
    /// <summary>
    /// Emergency Only
    /// </summary>
    public static readonly Coding EmergencyOnly = new Coding
    {
      Code = "emrgonly",
      Display = "Emergency Only",
      System = "http://terminology.hl7.org/CodeSystem/consentcategorycodes"
    };
    /// <summary>
    /// Health Care Directive
    /// </summary>
    public static readonly Coding HealthCareDirective = new Coding
    {
      Code = "hcd",
      Display = "Health Care Directive",
      System = "http://terminology.hl7.org/CodeSystem/consentcategorycodes"
    };
    /// <summary>
    /// information collection
    /// </summary>
    public static readonly Coding InformationCollection = new Coding
    {
      Code = "ICOL",
      Display = "information collection",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// information disclosure
    /// </summary>
    public static readonly Coding InformationDisclosure = new Coding
    {
      Code = "IDSCL",
      Display = "information disclosure",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// information access
    /// </summary>
    public static readonly Coding InformationAccess = new Coding
    {
      Code = "INFA",
      Display = "information access",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// access only
    /// </summary>
    public static readonly Coding AccessOnly = new Coding
    {
      Code = "INFAO",
      Display = "access only",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// access and save only
    /// </summary>
    public static readonly Coding AccessAndSaveOnly = new Coding
    {
      Code = "INFASO",
      Display = "access and save only",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// information redisclosure
    /// </summary>
    public static readonly Coding InformationRedisclosure = new Coding
    {
      Code = "IRDSCL",
      Display = "information redisclosure",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// Notice of Privacy Practices
    /// </summary>
    public static readonly Coding NoticeOfPrivacyPractices = new Coding
    {
      Code = "npp",
      Display = "Notice of Privacy Practices",
      System = "http://terminology.hl7.org/CodeSystem/consentcategorycodes"
    };
    /// <summary>
    /// Privacy Consent
    /// </summary>
    public static readonly Coding PrivacyConsent = new Coding
    {
      Code = "patient-privacy",
      Display = "Privacy Consent",
      System = "http://terminology.hl7.org/CodeSystem/consentscope"
    };
    /// <summary>
    /// POLST
    /// </summary>
    public static readonly Coding POLST = new Coding
    {
      Code = "polst",
      Display = "POLST",
      System = "http://terminology.hl7.org/CodeSystem/consentcategorycodes"
    };
    /// <summary>
    /// Research
    /// </summary>
    public static readonly Coding Research = new Coding
    {
      Code = "research",
      Display = "Research",
      System = "http://terminology.hl7.org/CodeSystem/consentscope"
    };
    /// <summary>
    /// Research Information Access
    /// </summary>
    public static readonly Coding ResearchInformationAccess = new Coding
    {
      Code = "research",
      Display = "Research Information Access",
      System = "http://terminology.hl7.org/CodeSystem/consentcategorycodes"
    };
    /// <summary>
    /// research information access
    /// </summary>
    public static readonly Coding ResearchInformationAccess_2 = new Coding
    {
      Code = "RESEARCH",
      Display = "research information access",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// De-identified Information Access
    /// </summary>
    public static readonly Coding DeIdentifiedInformationAccess = new Coding
    {
      Code = "rsdid",
      Display = "De-identified Information Access",
      System = "http://terminology.hl7.org/CodeSystem/consentcategorycodes"
    };
    /// <summary>
    /// de-identified information access
    /// </summary>
    public static readonly Coding DeIdentifiedInformationAccess_2 = new Coding
    {
      Code = "RSDID",
      Display = "de-identified information access",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// Re-identifiable Information Access
    /// </summary>
    public static readonly Coding ReIdentifiableInformationAccess = new Coding
    {
      Code = "rsreid",
      Display = "Re-identifiable Information Access",
      System = "http://terminology.hl7.org/CodeSystem/consentcategorycodes"
    };
    /// <summary>
    /// re-identifiable information access
    /// </summary>
    public static readonly Coding ReIdentifiableInformationAccess_2 = new Coding
    {
      Code = "RSREID",
      Display = "re-identifiable information access",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActCode"
    };
    /// <summary>
    /// Treatment
    /// </summary>
    public static readonly Coding Treatment = new Coding
    {
      Code = "treatment",
      Display = "Treatment",
      System = "http://terminology.hl7.org/CodeSystem/consentscope"
    };

    /// <summary>
    /// Literal for code: ActConsentType
    /// </summary>
    public const string LiteralActConsentType = "_ActConsentType";

    /// <summary>
    /// Literal for code: V3ActCodeActConsentType
    /// </summary>
    public const string LiteralV3ActCodeActConsentType = "http://terminology.hl7.org/CodeSystem/v3-ActCode#_ActConsentType";

    /// <summary>
    /// Literal for code: PrivacyPolicyAcknowledgementDocument
    /// </summary>
    public const string LiteralPrivacyPolicyAcknowledgementDocument = "57016-8";

    /// <summary>
    /// Literal for code: NONEPrivacyPolicyAcknowledgementDocument
    /// </summary>
    public const string LiteralNONEPrivacyPolicyAcknowledgementDocument = "http://loinc.org#57016-8";

    /// <summary>
    /// Literal for code: PrivacyPolicyOrganizationDocument
    /// </summary>
    public const string LiteralPrivacyPolicyOrganizationDocument = "57017-6";

    /// <summary>
    /// Literal for code: NONEPrivacyPolicyOrganizationDocument
    /// </summary>
    public const string LiteralNONEPrivacyPolicyOrganizationDocument = "http://loinc.org#57017-6";

    /// <summary>
    /// Literal for code: PatientConsent
    /// </summary>
    public const string LiteralPatientConsent = "59284-0";

    /// <summary>
    /// Literal for code: NONEPatientConsent
    /// </summary>
    public const string LiteralNONEPatientConsent = "http://loinc.org#59284-0";

    /// <summary>
    /// Literal for code: ReleaseOfInformationConsent
    /// </summary>
    public const string LiteralReleaseOfInformationConsent = "64292-6";

    /// <summary>
    /// Literal for code: NONEReleaseOfInformationConsent
    /// </summary>
    public const string LiteralNONEReleaseOfInformationConsent = "http://loinc.org#64292-6";

    /// <summary>
    /// Literal for code: AdvanceDirective
    /// </summary>
    public const string LiteralAdvanceDirective = "acd";

    /// <summary>
    /// Literal for code: ConsentcategorycodesAdvanceDirective
    /// </summary>
    public const string LiteralConsentcategorycodesAdvanceDirective = "http://terminology.hl7.org/CodeSystem/consentcategorycodes#acd";

    /// <summary>
    /// Literal for code: DoNotResuscitate
    /// </summary>
    public const string LiteralDoNotResuscitate = "dnr";

    /// <summary>
    /// Literal for code: ConsentcategorycodesDoNotResuscitate
    /// </summary>
    public const string LiteralConsentcategorycodesDoNotResuscitate = "http://terminology.hl7.org/CodeSystem/consentcategorycodes#dnr";

    /// <summary>
    /// Literal for code: EmergencyOnly
    /// </summary>
    public const string LiteralEmergencyOnly = "emrgonly";

    /// <summary>
    /// Literal for code: ConsentcategorycodesEmergencyOnly
    /// </summary>
    public const string LiteralConsentcategorycodesEmergencyOnly = "http://terminology.hl7.org/CodeSystem/consentcategorycodes#emrgonly";

    /// <summary>
    /// Literal for code: HealthCareDirective
    /// </summary>
    public const string LiteralHealthCareDirective = "hcd";

    /// <summary>
    /// Literal for code: ConsentcategorycodesHealthCareDirective
    /// </summary>
    public const string LiteralConsentcategorycodesHealthCareDirective = "http://terminology.hl7.org/CodeSystem/consentcategorycodes#hcd";

    /// <summary>
    /// Literal for code: InformationCollection
    /// </summary>
    public const string LiteralInformationCollection = "ICOL";

    /// <summary>
    /// Literal for code: V3ActCodeInformationCollection
    /// </summary>
    public const string LiteralV3ActCodeInformationCollection = "http://terminology.hl7.org/CodeSystem/v3-ActCode#ICOL";

    /// <summary>
    /// Literal for code: InformationDisclosure
    /// </summary>
    public const string LiteralInformationDisclosure = "IDSCL";

    /// <summary>
    /// Literal for code: V3ActCodeInformationDisclosure
    /// </summary>
    public const string LiteralV3ActCodeInformationDisclosure = "http://terminology.hl7.org/CodeSystem/v3-ActCode#IDSCL";

    /// <summary>
    /// Literal for code: InformationAccess
    /// </summary>
    public const string LiteralInformationAccess = "INFA";

    /// <summary>
    /// Literal for code: V3ActCodeInformationAccess
    /// </summary>
    public const string LiteralV3ActCodeInformationAccess = "http://terminology.hl7.org/CodeSystem/v3-ActCode#INFA";

    /// <summary>
    /// Literal for code: AccessOnly
    /// </summary>
    public const string LiteralAccessOnly = "INFAO";

    /// <summary>
    /// Literal for code: V3ActCodeAccessOnly
    /// </summary>
    public const string LiteralV3ActCodeAccessOnly = "http://terminology.hl7.org/CodeSystem/v3-ActCode#INFAO";

    /// <summary>
    /// Literal for code: AccessAndSaveOnly
    /// </summary>
    public const string LiteralAccessAndSaveOnly = "INFASO";

    /// <summary>
    /// Literal for code: V3ActCodeAccessAndSaveOnly
    /// </summary>
    public const string LiteralV3ActCodeAccessAndSaveOnly = "http://terminology.hl7.org/CodeSystem/v3-ActCode#INFASO";

    /// <summary>
    /// Literal for code: InformationRedisclosure
    /// </summary>
    public const string LiteralInformationRedisclosure = "IRDSCL";

    /// <summary>
    /// Literal for code: V3ActCodeInformationRedisclosure
    /// </summary>
    public const string LiteralV3ActCodeInformationRedisclosure = "http://terminology.hl7.org/CodeSystem/v3-ActCode#IRDSCL";

    /// <summary>
    /// Literal for code: NoticeOfPrivacyPractices
    /// </summary>
    public const string LiteralNoticeOfPrivacyPractices = "npp";

    /// <summary>
    /// Literal for code: ConsentcategorycodesNoticeOfPrivacyPractices
    /// </summary>
    public const string LiteralConsentcategorycodesNoticeOfPrivacyPractices = "http://terminology.hl7.org/CodeSystem/consentcategorycodes#npp";

    /// <summary>
    /// Literal for code: PrivacyConsent
    /// </summary>
    public const string LiteralPrivacyConsent = "patient-privacy";

    /// <summary>
    /// Literal for code: ConsentscopePrivacyConsent
    /// </summary>
    public const string LiteralConsentscopePrivacyConsent = "http://terminology.hl7.org/CodeSystem/consentscope#patient-privacy";

    /// <summary>
    /// Literal for code: POLST
    /// </summary>
    public const string LiteralPOLST = "polst";

    /// <summary>
    /// Literal for code: ConsentcategorycodesPOLST
    /// </summary>
    public const string LiteralConsentcategorycodesPOLST = "http://terminology.hl7.org/CodeSystem/consentcategorycodes#polst";

    /// <summary>
    /// Literal for code: Research
    /// </summary>
    public const string LiteralResearch = "research";

    /// <summary>
    /// Literal for code: ConsentscopeResearch
    /// </summary>
    public const string LiteralConsentscopeResearch = "http://terminology.hl7.org/CodeSystem/consentscope#research";

    /// <summary>
    /// Literal for code: ResearchInformationAccess
    /// </summary>
    public const string LiteralResearchInformationAccess = "research";

    /// <summary>
    /// Literal for code: ConsentcategorycodesResearchInformationAccess
    /// </summary>
    public const string LiteralConsentcategorycodesResearchInformationAccess = "http://terminology.hl7.org/CodeSystem/consentcategorycodes#research";

    /// <summary>
    /// Literal for code: ResearchInformationAccess_2
    /// </summary>
    public const string LiteralResearchInformationAccess_2 = "RESEARCH";

    /// <summary>
    /// Literal for code: V3ActCodeResearchInformationAccess_2
    /// </summary>
    public const string LiteralV3ActCodeResearchInformationAccess_2 = "http://terminology.hl7.org/CodeSystem/v3-ActCode#RESEARCH";

    /// <summary>
    /// Literal for code: DeIdentifiedInformationAccess
    /// </summary>
    public const string LiteralDeIdentifiedInformationAccess = "rsdid";

    /// <summary>
    /// Literal for code: ConsentcategorycodesDeIdentifiedInformationAccess
    /// </summary>
    public const string LiteralConsentcategorycodesDeIdentifiedInformationAccess = "http://terminology.hl7.org/CodeSystem/consentcategorycodes#rsdid";

    /// <summary>
    /// Literal for code: DeIdentifiedInformationAccess_2
    /// </summary>
    public const string LiteralDeIdentifiedInformationAccess_2 = "RSDID";

    /// <summary>
    /// Literal for code: V3ActCodeDeIdentifiedInformationAccess_2
    /// </summary>
    public const string LiteralV3ActCodeDeIdentifiedInformationAccess_2 = "http://terminology.hl7.org/CodeSystem/v3-ActCode#RSDID";

    /// <summary>
    /// Literal for code: ReIdentifiableInformationAccess
    /// </summary>
    public const string LiteralReIdentifiableInformationAccess = "rsreid";

    /// <summary>
    /// Literal for code: ConsentcategorycodesReIdentifiableInformationAccess
    /// </summary>
    public const string LiteralConsentcategorycodesReIdentifiableInformationAccess = "http://terminology.hl7.org/CodeSystem/consentcategorycodes#rsreid";

    /// <summary>
    /// Literal for code: ReIdentifiableInformationAccess_2
    /// </summary>
    public const string LiteralReIdentifiableInformationAccess_2 = "RSREID";

    /// <summary>
    /// Literal for code: V3ActCodeReIdentifiableInformationAccess_2
    /// </summary>
    public const string LiteralV3ActCodeReIdentifiableInformationAccess_2 = "http://terminology.hl7.org/CodeSystem/v3-ActCode#RSREID";

    /// <summary>
    /// Literal for code: Treatment
    /// </summary>
    public const string LiteralTreatment = "treatment";

    /// <summary>
    /// Literal for code: ConsentscopeTreatment
    /// </summary>
    public const string LiteralConsentscopeTreatment = "http://terminology.hl7.org/CodeSystem/consentscope#treatment";

    /// <summary>
    /// Dictionary for looking up ConsentCategory Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "_ActConsentType", ActConsentType }, 
      { "http://terminology.hl7.org/CodeSystem/v3-ActCode#_ActConsentType", ActConsentType }, 
      { "57016-8", PrivacyPolicyAcknowledgementDocument }, 
      { "http://loinc.org#57016-8", PrivacyPolicyAcknowledgementDocument }, 
      { "57017-6", PrivacyPolicyOrganizationDocument }, 
      { "http://loinc.org#57017-6", PrivacyPolicyOrganizationDocument }, 
      { "59284-0", PatientConsent }, 
      { "http://loinc.org#59284-0", PatientConsent }, 
      { "64292-6", ReleaseOfInformationConsent }, 
      { "http://loinc.org#64292-6", ReleaseOfInformationConsent }, 
      { "acd", AdvanceDirective }, 
      { "http://terminology.hl7.org/CodeSystem/consentcategorycodes#acd", AdvanceDirective }, 
      { "dnr", DoNotResuscitate }, 
      { "http://terminology.hl7.org/CodeSystem/consentcategorycodes#dnr", DoNotResuscitate }, 
      { "emrgonly", EmergencyOnly }, 
      { "http://terminology.hl7.org/CodeSystem/consentcategorycodes#emrgonly", EmergencyOnly }, 
      { "hcd", HealthCareDirective }, 
      { "http://terminology.hl7.org/CodeSystem/consentcategorycodes#hcd", HealthCareDirective }, 
      { "ICOL", InformationCollection }, 
      { "http://terminology.hl7.org/CodeSystem/v3-ActCode#ICOL", InformationCollection }, 
      { "IDSCL", InformationDisclosure }, 
      { "http://terminology.hl7.org/CodeSystem/v3-ActCode#IDSCL", InformationDisclosure }, 
      { "INFA", InformationAccess }, 
      { "http://terminology.hl7.org/CodeSystem/v3-ActCode#INFA", InformationAccess }, 
      { "INFAO", AccessOnly }, 
      { "http://terminology.hl7.org/CodeSystem/v3-ActCode#INFAO", AccessOnly }, 
      { "INFASO", AccessAndSaveOnly }, 
      { "http://terminology.hl7.org/CodeSystem/v3-ActCode#INFASO", AccessAndSaveOnly }, 
      { "IRDSCL", InformationRedisclosure }, 
      { "http://terminology.hl7.org/CodeSystem/v3-ActCode#IRDSCL", InformationRedisclosure }, 
      { "npp", NoticeOfPrivacyPractices }, 
      { "http://terminology.hl7.org/CodeSystem/consentcategorycodes#npp", NoticeOfPrivacyPractices }, 
      { "patient-privacy", PrivacyConsent }, 
      { "http://terminology.hl7.org/CodeSystem/consentscope#patient-privacy", PrivacyConsent }, 
      { "polst", POLST }, 
      { "http://terminology.hl7.org/CodeSystem/consentcategorycodes#polst", POLST }, 
      { "research", Research }, 
      { "http://terminology.hl7.org/CodeSystem/consentscope#research", Research }, 
      { "research", ResearchInformationAccess }, 
      { "http://terminology.hl7.org/CodeSystem/consentcategorycodes#research", ResearchInformationAccess }, 
      { "RESEARCH", ResearchInformationAccess_2 }, 
      { "http://terminology.hl7.org/CodeSystem/v3-ActCode#RESEARCH", ResearchInformationAccess_2 }, 
      { "rsdid", DeIdentifiedInformationAccess }, 
      { "http://terminology.hl7.org/CodeSystem/consentcategorycodes#rsdid", DeIdentifiedInformationAccess }, 
      { "RSDID", DeIdentifiedInformationAccess_2 }, 
      { "http://terminology.hl7.org/CodeSystem/v3-ActCode#RSDID", DeIdentifiedInformationAccess_2 }, 
      { "rsreid", ReIdentifiableInformationAccess }, 
      { "http://terminology.hl7.org/CodeSystem/consentcategorycodes#rsreid", ReIdentifiableInformationAccess }, 
      { "RSREID", ReIdentifiableInformationAccess_2 }, 
      { "http://terminology.hl7.org/CodeSystem/v3-ActCode#RSREID", ReIdentifiableInformationAccess_2 }, 
      { "treatment", Treatment }, 
      { "http://terminology.hl7.org/CodeSystem/consentscope#treatment", Treatment }, 
    };
  };
}
