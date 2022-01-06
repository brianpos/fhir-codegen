// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Event Types for Audit Events - defined by DICOM with some FHIR specific additions.
  /// </summary>
  public static class AuditEventTypeCodes
  {
    /// <summary>
    /// Audit event: Application Activity has taken place
    /// </summary>
    public static readonly Coding ApplicationActivity_dicom_dcim = new Coding
    {
      Code = "110100",
      Display = "Application Activity",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Audit Log has been used
    /// </summary>
    public static readonly Coding AuditLogUsed_dicom_dcim = new Coding
    {
      Code = "110101",
      Display = "Audit Log Used",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Storage of DICOM Instances has begun
    /// </summary>
    public static readonly Coding BeginTransferringDICOMInstances_dicom_dcim = new Coding
    {
      Code = "110102",
      Display = "Begin Transferring DICOM Instances",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: DICOM Instances have been created, read, updated, or deleted
    /// </summary>
    public static readonly Coding DICOMInstancesAccessed_dicom_dcim = new Coding
    {
      Code = "110103",
      Display = "DICOM Instances Accessed",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Storage of DICOM Instances has been completed
    /// </summary>
    public static readonly Coding DICOMInstancesTransferred_dicom_dcim = new Coding
    {
      Code = "110104",
      Display = "DICOM Instances Transferred",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Entire Study has been deleted
    /// </summary>
    public static readonly Coding DICOMStudyDeleted_dicom_dcim = new Coding
    {
      Code = "110105",
      Display = "DICOM Study Deleted",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Data has been exported out of the system
    /// </summary>
    public static readonly Coding Export_dicom_dcim = new Coding
    {
      Code = "110106",
      Display = "Export",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Data has been imported into the system
    /// </summary>
    public static readonly Coding Import_dicom_dcim = new Coding
    {
      Code = "110107",
      Display = "Import",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: System has joined or left network
    /// </summary>
    public static readonly Coding NetworkEntry_dicom_dcim = new Coding
    {
      Code = "110108",
      Display = "Network Entry",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Order has been created, read, updated or deleted
    /// </summary>
    public static readonly Coding OrderRecord_dicom_dcim = new Coding
    {
      Code = "110109",
      Display = "Order Record",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Patient Record has been created, read, updated, or deleted
    /// </summary>
    public static readonly Coding PatientRecord_dicom_dcim = new Coding
    {
      Code = "110110",
      Display = "Patient Record",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Procedure Record has been created, read, updated, or deleted
    /// </summary>
    public static readonly Coding ProcedureRecord_dicom_dcim = new Coding
    {
      Code = "110111",
      Display = "Procedure Record",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Query has been made
    /// </summary>
    public static readonly Coding Query_dicom_dcim = new Coding
    {
      Code = "110112",
      Display = "Query",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: Security Alert has been raised
    /// </summary>
    public static readonly Coding SecurityAlert_dicom_dcim = new Coding
    {
      Code = "110113",
      Display = "Security Alert",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Audit event: User Authentication has been attempted
    /// </summary>
    public static readonly Coding UserAuthentication_dicom_dcim = new Coding
    {
      Code = "110114",
      Display = "User Authentication",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Occurs when an agent causes the system to obtain and open a record entry for inspection or review.
    /// </summary>
    public static readonly Coding AccessViewRecordLifecycleEvent_iso_21089_lifecycle = new Coding
    {
      Code = "access",
      Display = "Access/View Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// Occurs when an agent makes any change to record entry content currently residing in storage considered permanent (persistent).
    /// </summary>
    public static readonly Coding AmendUpdateRecordLifecycleEvent_iso_21089_lifecycle = new Coding
    {
      Code = "amend",
      Display = "Amend (Update) Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// Occurs when an agent causes the system to create and move archive artifacts containing record entry content, typically to long-term offline storage.
    /// </summary>
    public static readonly Coding ArchiveRecordLifecycleEvent_iso_21089_lifecycle = new Coding
    {
      Code = "archive",
      Display = "Archive Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// Occurs when an agent causes the system to capture the agent’s digital signature (or equivalent indication) during formal validation of record entry content.
    /// </summary>
    public static readonly Coding AttestRecordLifecycleEvent_iso_21089_lifecycle = new Coding
    {
      Code = "attest",
      Display = "Attest Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// Occurs when an agent causes the system to decode record entry content from a cipher.
    /// </summary>
    public static readonly Coding DecryptRecordLifecycleEvent_iso_21089_lifecycle = new Coding
    {
      Code = "decrypt",
      Display = "Decrypt Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// Occurs when an agent causes the system to scrub record entry content to reduce the association between a set of identifying data and the data subject in a way that might or might not be reversible.
    /// </summary>
    public static readonly Coding DeIdentifyAnononymizeRecordLifecycleEvent_iso_21089_lifecycle = new Coding
    {
      Code = "deidentify",
      Display = "De-Identify (Anononymize) Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// Occurs when an agent causes the system to tag record entry(ies) as obsolete, erroneous or untrustworthy, to warn against its future use.
    /// </summary>
    public static readonly Coding DeprecateRecordLifecycleEvent_iso_21089_lifecycle = new Coding
    {
      Code = "deprecate",
      Display = "Deprecate Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// Occurs when an agent causes the system to permanently erase record entry content from the system.
    /// </summary>
    public static readonly Coding DestroyDeleteRecordLifecycleEvent_iso_21089_lifecycle = new Coding
    {
      Code = "destroy",
      Display = "Destroy/Delete Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// Occurs when an agent causes the system to release, transfer, provision access to, or otherwise divulge record entry content.
    /// </summary>
    public static readonly Coding DiscloseRecordLifecycleEvent_iso_21089_lifecycle = new Coding
    {
      Code = "disclose",
      Display = "Disclose Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// Occurs when an agent causes the system to encode record entry content in a cipher.
    /// </summary>
    public static readonly Coding EncryptRecordLifecycleEvent_iso_21089_lifecycle = new Coding
    {
      Code = "encrypt",
      Display = "Encrypt Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// Occurs when an agent causes the system to selectively pull out a subset of record entry content, based on explicit criteria.
    /// </summary>
    public static readonly Coding ExtractRecordLifecycleEvent_iso_21089_lifecycle = new Coding
    {
      Code = "extract",
      Display = "Extract Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// Occurs when an agent causes the system to tag or otherwise indicate special access management and suspension of record entry deletion/destruction, if deemed relevant to a lawsuit or which are reasonably anticipated to be relevant or to fulfill organizational policy under the legal doctrine of “duty to preserve”.
    /// </summary>
    public static readonly Coding AddLegalHoldRecordLifecycleEvent_iso_21089_lifecycle = new Coding
    {
      Code = "hold",
      Display = "Add Legal Hold Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// Occurs when an agent causes the system to connect related record entries.
    /// </summary>
    public static readonly Coding LinkRecordLifecycleEvent_iso_21089_lifecycle = new Coding
    {
      Code = "link",
      Display = "Link Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// Occurs when an agent causes the system to combine or join content from two or more record entries, resulting in a single logical record entry.
    /// </summary>
    public static readonly Coding MergeRecordLifecycleEvent_iso_21089_lifecycle = new Coding
    {
      Code = "merge",
      Display = "Merge Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// Occurs when an agent causes the system to: a) initiate capture of potential record content, and b) incorporate that content into the storage considered a permanent part of the health record.
    /// </summary>
    public static readonly Coding OriginateRetainRecordLifecycleEvent_iso_21089_lifecycle = new Coding
    {
      Code = "originate",
      Display = "Originate/Retain Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// Occurs when an agent causes the system to remove record entry content to reduce the association between a set of identifying data and the data subject in a way that may be reversible.
    /// </summary>
    public static readonly Coding PseudonymizeRecordLifecycleEvent_iso_21089_lifecycle = new Coding
    {
      Code = "pseudonymize",
      Display = "Pseudonymize Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// Occurs when an agent causes the system to recreate or restore full status to record entries previously deleted or deprecated.
    /// </summary>
    public static readonly Coding ReActivateRecordLifecycleEvent_iso_21089_lifecycle = new Coding
    {
      Code = "reactivate",
      Display = "Re-activate Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// Occurs when an agent causes the system to a) initiate capture of data content from elsewhere, and b) incorporate that content into the storage considered a permanent part of the health record.
    /// </summary>
    public static readonly Coding ReceiveRetainRecordLifecycleEvent_iso_21089_lifecycle = new Coding
    {
      Code = "receive",
      Display = "Receive/Retain Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// Occurs when an agent causes the system to restore information to data that allows identification of information source and/or information subject.
    /// </summary>
    public static readonly Coding ReIdentifyRecordLifecycleEvent_iso_21089_lifecycle = new Coding
    {
      Code = "reidentify",
      Display = "Re-identify Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// Occurs when an agent causes the system to produce and deliver record entry content in a particular form and manner.
    /// </summary>
    public static readonly Coding ReportOutputRecordLifecycleEvent_iso_21089_lifecycle = new Coding
    {
      Code = "report",
      Display = "Report (Output) Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// Audit Event: Execution of a RESTful operation as defined by FHIR.
    /// </summary>
    public static readonly Coding RESTfulOperation_audit_event_type = new Coding
    {
      Code = "rest",
      Display = "RESTful Operation",
      System = "http://terminology.hl7.org/CodeSystem/audit-event-type"
    };
    /// <summary>
    /// Occurs when an agent causes the system to recreate record entries and their content from a previous created archive artefact.
    /// </summary>
    public static readonly Coding RestoreRecordLifecycleEvent_iso_21089_lifecycle = new Coding
    {
      Code = "restore",
      Display = "Restore Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// Occurs when an agent causes the system to change the form, language or code system used to represent record entry content.
    /// </summary>
    public static readonly Coding TransformTranslateRecordLifecycleEvent_iso_21089_lifecycle = new Coding
    {
      Code = "transform",
      Display = "Transform/Translate Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// Occurs when an agent causes the system to send record entry content from one (EHR/PHR/other) system to another.
    /// </summary>
    public static readonly Coding TransmitRecordLifecycleEvent_iso_21089_lifecycle = new Coding
    {
      Code = "transmit",
      Display = "Transmit Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// Occurs when an agent causes the system to remove a tag or other cues for special access management had required to fulfill organizational policy under the legal doctrine of “duty to preserve”.
    /// </summary>
    public static readonly Coding RemoveLegalHoldRecordLifecycleEvent_iso_21089_lifecycle = new Coding
    {
      Code = "unhold",
      Display = "Remove Legal Hold Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// Occurs when an agent causes the system to disconnect two or more record entries previously connected, rendering them separate (disconnected) again.
    /// </summary>
    public static readonly Coding UnlinkRecordLifecycleEvent_iso_21089_lifecycle = new Coding
    {
      Code = "unlink",
      Display = "Unlink Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// Occurs when an agent causes the system to reverse a previous record entry merge operation, rendering them separate again.
    /// </summary>
    public static readonly Coding UnmergeRecordLifecycleEvent_iso_21089_lifecycle = new Coding
    {
      Code = "unmerge",
      Display = "Unmerge Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };
    /// <summary>
    /// Occurs when an agent causes the system to confirm compliance of data or data objects with regulations, requirements, specifications, or other imposed conditions based on organizational policy.
    /// </summary>
    public static readonly Coding VerifyRecordLifecycleEvent_iso_21089_lifecycle = new Coding
    {
      Code = "verify",
      Display = "Verify Record Lifecycle Event",
      System = "http://terminology.hl7.org/CodeSystem/iso-21089-lifecycle"
    };

    /// <summary>
    /// Literal for code: ApplicationActivity_dicom_dcim
    /// </summary>
    public const string LiteralApplicationActivity_dicom_dcim = "110100";

    /// <summary>
    /// Literal for code: AuditLogUsed_dicom_dcim
    /// </summary>
    public const string LiteralAuditLogUsed_dicom_dcim = "110101";

    /// <summary>
    /// Literal for code: BeginTransferringDICOMInstances_dicom_dcim
    /// </summary>
    public const string LiteralBeginTransferringDICOMInstances_dicom_dcim = "110102";

    /// <summary>
    /// Literal for code: DICOMInstancesAccessed_dicom_dcim
    /// </summary>
    public const string LiteralDICOMInstancesAccessed_dicom_dcim = "110103";

    /// <summary>
    /// Literal for code: DICOMInstancesTransferred_dicom_dcim
    /// </summary>
    public const string LiteralDICOMInstancesTransferred_dicom_dcim = "110104";

    /// <summary>
    /// Literal for code: DICOMStudyDeleted_dicom_dcim
    /// </summary>
    public const string LiteralDICOMStudyDeleted_dicom_dcim = "110105";

    /// <summary>
    /// Literal for code: Export_dicom_dcim
    /// </summary>
    public const string LiteralExport_dicom_dcim = "110106";

    /// <summary>
    /// Literal for code: Import_dicom_dcim
    /// </summary>
    public const string LiteralImport_dicom_dcim = "110107";

    /// <summary>
    /// Literal for code: NetworkEntry_dicom_dcim
    /// </summary>
    public const string LiteralNetworkEntry_dicom_dcim = "110108";

    /// <summary>
    /// Literal for code: OrderRecord_dicom_dcim
    /// </summary>
    public const string LiteralOrderRecord_dicom_dcim = "110109";

    /// <summary>
    /// Literal for code: PatientRecord_dicom_dcim
    /// </summary>
    public const string LiteralPatientRecord_dicom_dcim = "110110";

    /// <summary>
    /// Literal for code: ProcedureRecord_dicom_dcim
    /// </summary>
    public const string LiteralProcedureRecord_dicom_dcim = "110111";

    /// <summary>
    /// Literal for code: Query_dicom_dcim
    /// </summary>
    public const string LiteralQuery_dicom_dcim = "110112";

    /// <summary>
    /// Literal for code: SecurityAlert_dicom_dcim
    /// </summary>
    public const string LiteralSecurityAlert_dicom_dcim = "110113";

    /// <summary>
    /// Literal for code: UserAuthentication_dicom_dcim
    /// </summary>
    public const string LiteralUserAuthentication_dicom_dcim = "110114";

    /// <summary>
    /// Literal for code: AccessViewRecordLifecycleEvent_iso_21089_lifecycle
    /// </summary>
    public const string LiteralAccessViewRecordLifecycleEvent_iso_21089_lifecycle = "access";

    /// <summary>
    /// Literal for code: AmendUpdateRecordLifecycleEvent_iso_21089_lifecycle
    /// </summary>
    public const string LiteralAmendUpdateRecordLifecycleEvent_iso_21089_lifecycle = "amend";

    /// <summary>
    /// Literal for code: ArchiveRecordLifecycleEvent_iso_21089_lifecycle
    /// </summary>
    public const string LiteralArchiveRecordLifecycleEvent_iso_21089_lifecycle = "archive";

    /// <summary>
    /// Literal for code: AttestRecordLifecycleEvent_iso_21089_lifecycle
    /// </summary>
    public const string LiteralAttestRecordLifecycleEvent_iso_21089_lifecycle = "attest";

    /// <summary>
    /// Literal for code: DecryptRecordLifecycleEvent_iso_21089_lifecycle
    /// </summary>
    public const string LiteralDecryptRecordLifecycleEvent_iso_21089_lifecycle = "decrypt";

    /// <summary>
    /// Literal for code: DeIdentifyAnononymizeRecordLifecycleEvent_iso_21089_lifecycle
    /// </summary>
    public const string LiteralDeIdentifyAnononymizeRecordLifecycleEvent_iso_21089_lifecycle = "deidentify";

    /// <summary>
    /// Literal for code: DeprecateRecordLifecycleEvent_iso_21089_lifecycle
    /// </summary>
    public const string LiteralDeprecateRecordLifecycleEvent_iso_21089_lifecycle = "deprecate";

    /// <summary>
    /// Literal for code: DestroyDeleteRecordLifecycleEvent_iso_21089_lifecycle
    /// </summary>
    public const string LiteralDestroyDeleteRecordLifecycleEvent_iso_21089_lifecycle = "destroy";

    /// <summary>
    /// Literal for code: DiscloseRecordLifecycleEvent_iso_21089_lifecycle
    /// </summary>
    public const string LiteralDiscloseRecordLifecycleEvent_iso_21089_lifecycle = "disclose";

    /// <summary>
    /// Literal for code: EncryptRecordLifecycleEvent_iso_21089_lifecycle
    /// </summary>
    public const string LiteralEncryptRecordLifecycleEvent_iso_21089_lifecycle = "encrypt";

    /// <summary>
    /// Literal for code: ExtractRecordLifecycleEvent_iso_21089_lifecycle
    /// </summary>
    public const string LiteralExtractRecordLifecycleEvent_iso_21089_lifecycle = "extract";

    /// <summary>
    /// Literal for code: AddLegalHoldRecordLifecycleEvent_iso_21089_lifecycle
    /// </summary>
    public const string LiteralAddLegalHoldRecordLifecycleEvent_iso_21089_lifecycle = "hold";

    /// <summary>
    /// Literal for code: LinkRecordLifecycleEvent_iso_21089_lifecycle
    /// </summary>
    public const string LiteralLinkRecordLifecycleEvent_iso_21089_lifecycle = "link";

    /// <summary>
    /// Literal for code: MergeRecordLifecycleEvent_iso_21089_lifecycle
    /// </summary>
    public const string LiteralMergeRecordLifecycleEvent_iso_21089_lifecycle = "merge";

    /// <summary>
    /// Literal for code: OriginateRetainRecordLifecycleEvent_iso_21089_lifecycle
    /// </summary>
    public const string LiteralOriginateRetainRecordLifecycleEvent_iso_21089_lifecycle = "originate";

    /// <summary>
    /// Literal for code: PseudonymizeRecordLifecycleEvent_iso_21089_lifecycle
    /// </summary>
    public const string LiteralPseudonymizeRecordLifecycleEvent_iso_21089_lifecycle = "pseudonymize";

    /// <summary>
    /// Literal for code: ReActivateRecordLifecycleEvent_iso_21089_lifecycle
    /// </summary>
    public const string LiteralReActivateRecordLifecycleEvent_iso_21089_lifecycle = "reactivate";

    /// <summary>
    /// Literal for code: ReceiveRetainRecordLifecycleEvent_iso_21089_lifecycle
    /// </summary>
    public const string LiteralReceiveRetainRecordLifecycleEvent_iso_21089_lifecycle = "receive";

    /// <summary>
    /// Literal for code: ReIdentifyRecordLifecycleEvent_iso_21089_lifecycle
    /// </summary>
    public const string LiteralReIdentifyRecordLifecycleEvent_iso_21089_lifecycle = "reidentify";

    /// <summary>
    /// Literal for code: ReportOutputRecordLifecycleEvent_iso_21089_lifecycle
    /// </summary>
    public const string LiteralReportOutputRecordLifecycleEvent_iso_21089_lifecycle = "report";

    /// <summary>
    /// Literal for code: RESTfulOperation_audit_event_type
    /// </summary>
    public const string LiteralRESTfulOperation_audit_event_type = "rest";

    /// <summary>
    /// Literal for code: RestoreRecordLifecycleEvent_iso_21089_lifecycle
    /// </summary>
    public const string LiteralRestoreRecordLifecycleEvent_iso_21089_lifecycle = "restore";

    /// <summary>
    /// Literal for code: TransformTranslateRecordLifecycleEvent_iso_21089_lifecycle
    /// </summary>
    public const string LiteralTransformTranslateRecordLifecycleEvent_iso_21089_lifecycle = "transform";

    /// <summary>
    /// Literal for code: TransmitRecordLifecycleEvent_iso_21089_lifecycle
    /// </summary>
    public const string LiteralTransmitRecordLifecycleEvent_iso_21089_lifecycle = "transmit";

    /// <summary>
    /// Literal for code: RemoveLegalHoldRecordLifecycleEvent_iso_21089_lifecycle
    /// </summary>
    public const string LiteralRemoveLegalHoldRecordLifecycleEvent_iso_21089_lifecycle = "unhold";

    /// <summary>
    /// Literal for code: UnlinkRecordLifecycleEvent_iso_21089_lifecycle
    /// </summary>
    public const string LiteralUnlinkRecordLifecycleEvent_iso_21089_lifecycle = "unlink";

    /// <summary>
    /// Literal for code: UnmergeRecordLifecycleEvent_iso_21089_lifecycle
    /// </summary>
    public const string LiteralUnmergeRecordLifecycleEvent_iso_21089_lifecycle = "unmerge";

    /// <summary>
    /// Literal for code: VerifyRecordLifecycleEvent_iso_21089_lifecycle
    /// </summary>
    public const string LiteralVerifyRecordLifecycleEvent_iso_21089_lifecycle = "verify";
  };
}