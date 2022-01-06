// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR3.Serialization;

namespace fhirCsR3.Models
{
  /// <summary>
  /// The individual, organization or device that initiated the request and has responsibility for its activation.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<MedicationRequestRequester>))]
  public class MedicationRequestRequester : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// It is expected that the type of requester will be restricted for different stages of a MedicationRequest.  For example, Proposals can be created by a patient, relatedPerson, Practitioner or Device.  Plans can be created by Practitioners, Patients, RelatedPersons and Devices.  Original orders can be created by a Practitioner only.
    /// </summary>
    public Reference Agent { get; set; }
    /// <summary>
    /// The organization the device or practitioner was acting on behalf of.
    /// </summary>
    public Reference OnBehalfOf { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR3.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Agent != null)
      {
        writer.WritePropertyName("agent");
        Agent.SerializeJson(writer, options);
      }

      if (OnBehalfOf != null)
      {
        writer.WritePropertyName("onBehalfOf");
        OnBehalfOf.SerializeJson(writer, options);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "agent":
          Agent = new fhirCsR3.Models.Reference();
          Agent.DeserializeJson(ref reader, options);
          break;

        case "onBehalfOf":
          OnBehalfOf = new fhirCsR3.Models.Reference();
          OnBehalfOf.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR3.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// Indicates the specific details for the dispense or medication supply part of a medication request (also known as a Medication Prescription or Medication Order).  Note that this information is not always sent with the order.  There may be in some settings (e.g. hospitals) institutional or system support for completing the dispense details in the pharmacy department.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<MedicationRequestDispenseRequest>))]
  public class MedicationRequestDispenseRequest : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// In some situations, this attribute may be used instead of quantity to identify the amount supplied by how long it is expected to last, rather than the physical quantity issued, e.g. 90 days supply of medication (based on an ordered dosage) When possible, it is always better to specify quantity, as this tends to be more precise. expectedSupplyDuration will always be an estimate that can be influenced by external factors.
    /// </summary>
    public Duration ExpectedSupplyDuration { get; set; }
    /// <summary>
    /// If displaying "number of authorized fills", add 1 to this number.
    /// </summary>
    public uint? NumberOfRepeatsAllowed { get; set; }
    /// <summary>
    /// Indicates the intended dispensing Organization specified by the prescriber.
    /// </summary>
    public Reference Performer { get; set; }
    /// <summary>
    /// The amount that is to be dispensed for one fill.
    /// </summary>
    public Quantity Quantity { get; set; }
    /// <summary>
    /// It reflects the prescribers' perspective for the validity of the prescription. Dispenses must not be made against the prescription outside of this period. The lower-bound of the Dispensing Window signifies the earliest date that the prescription can be filled for the first time. If an upper-bound is not specified then the Prescription is open-ended or will default to a stale-date based on regulations.
    /// </summary>
    public Period ValidityPeriod { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR3.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (ValidityPeriod != null)
      {
        writer.WritePropertyName("validityPeriod");
        ValidityPeriod.SerializeJson(writer, options);
      }

      if (NumberOfRepeatsAllowed != null)
      {
        writer.WriteNumber("numberOfRepeatsAllowed", (uint)NumberOfRepeatsAllowed!);
      }

      if (Quantity != null)
      {
        writer.WritePropertyName("quantity");
        Quantity.SerializeJson(writer, options);
      }

      if (ExpectedSupplyDuration != null)
      {
        writer.WritePropertyName("expectedSupplyDuration");
        ExpectedSupplyDuration.SerializeJson(writer, options);
      }

      if (Performer != null)
      {
        writer.WritePropertyName("performer");
        Performer.SerializeJson(writer, options);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "expectedSupplyDuration":
          ExpectedSupplyDuration = new fhirCsR3.Models.Duration();
          ExpectedSupplyDuration.DeserializeJson(ref reader, options);
          break;

        case "numberOfRepeatsAllowed":
          NumberOfRepeatsAllowed = reader.GetUInt32();
          break;

        case "performer":
          Performer = new fhirCsR3.Models.Reference();
          Performer.DeserializeJson(ref reader, options);
          break;

        case "quantity":
          Quantity = new fhirCsR3.Models.Quantity();
          Quantity.DeserializeJson(ref reader, options);
          break;

        case "validityPeriod":
          ValidityPeriod = new fhirCsR3.Models.Period();
          ValidityPeriod.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR3.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// Indicates whether or not substitution can or should be part of the dispense. In some cases substitution must happen, in other cases substitution must not happen. This block explains the prescriber's intent. If nothing is specified substitution may be done.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<MedicationRequestSubstitution>))]
  public class MedicationRequestSubstitution : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// This element is labeled as a modifer because whether substitution is allow or not cannot be ignored.
    /// </summary>
    public bool Allowed { get; set; }
    /// <summary>
    /// Indicates the reason for the substitution, or why substitution must or must not be performed.
    /// </summary>
    public CodeableConcept Reason { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR3.Models.BackboneElement)this).SerializeJson(writer, options, false);

      writer.WriteBoolean("allowed", Allowed);

      if (Reason != null)
      {
        writer.WritePropertyName("reason");
        Reason.SerializeJson(writer, options);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "allowed":
          Allowed = reader.GetBoolean();
          break;

        case "reason":
          Reason = new fhirCsR3.Models.CodeableConcept();
          Reason.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR3.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// An order or request for both supply of the medication and the instructions for administration of the medication to a patient. The resource is called "MedicationRequest" rather than "MedicationPrescription" or "MedicationOrder" to generalize the use across inpatient and outpatient settings, including care plans, etc., and to harmonize with workflow patterns.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<MedicationRequest>))]
  public class MedicationRequest : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "MedicationRequest";
    /// <summary>
    /// The date (and perhaps time) when the prescription was initially written or authored on.
    /// </summary>
    public string AuthoredOn { get; set; }
    /// <summary>
    /// Extension container element for AuthoredOn
    /// </summary>
    public Element _AuthoredOn { get; set; }
    /// <summary>
    /// A plan or request that is fulfilled in whole or in part by this medication request.
    /// </summary>
    public List<Reference> BasedOn { get; set; }
    /// <summary>
    /// Indicates the type of medication order and where the medication is expected to be consumed or administered.
    /// </summary>
    public CodeableConcept Category { get; set; }
    /// <summary>
    /// SubstanceAdministration-&gt;component-&gt;EncounterEvent.
    /// </summary>
    public Reference Context { get; set; }
    /// <summary>
    /// Protocol or definition followed by this request.
    /// </summary>
    public List<Reference> Definition { get; set; }
    /// <summary>
    /// Indicates an actual or potential clinical issue with or between one or more active or proposed clinical actions for a patient; e.g. Drug-drug interaction, duplicate therapy, dosage alert etc.
    /// </summary>
    public List<Reference> DetectedIssue { get; set; }
    /// <summary>
    /// Indicates the specific details for the dispense or medication supply part of a medication request (also known as a Medication Prescription or Medication Order).  Note that this information is not always sent with the order.  There may be in some settings (e.g. hospitals) institutional or system support for completing the dispense details in the pharmacy department.
    /// </summary>
    public MedicationRequestDispenseRequest DispenseRequest { get; set; }
    /// <summary>
    /// There are examples where a medication request may include the option of an oral dose or an Intravenous or Intramuscular dose.  For example, "Ondansetron 8mg orally or IV twice a day as needed for nausea" or "Compazine® (prochlorperazine) 5-10mg PO or 25mg PR bid prn nausea or vomiting".  In these cases, two medication requests would be created that could be grouped together.  The decision on which dose and route of administration to use is based on the patient's condition at the time the dose is needed.
    /// </summary>
    public List<Dosage> DosageInstruction { get; set; }
    /// <summary>
    /// This may not include provenances for all versions of the request – only those deemed “relevant” or important. This SHALL NOT include the Provenance associated with this current version of the resource. (If that provenance is deemed to be a “relevant” change, it will need to be added as part of a later update. Until then, it can be queried directly as the Provenance that points to this version using _revinclude All Provenances should have some historical version of this Request as their subject.).
    /// </summary>
    public List<Reference> EventHistory { get; set; }
    /// <summary>
    /// A shared identifier common to all requests that were authorized more or less simultaneously by a single author, representing the identifier of the requisition or prescription.
    /// </summary>
    public Identifier GroupIdentifier { get; set; }
    /// <summary>
    /// This records identifiers associated with this medication request that are defined by business processes and/or used to refer to it when a direct URL reference to the resource itself is not appropriate. For example a re-imbursement system might issue its own id for each prescription that is created.  This is particularly important where FHIR only provides part of an entire workflow process where records must be tracked through an entire system.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// It is expected that the type of requester will be restricted for different stages of a MedicationRequest.  For example, Proposals can be created by a patient, relatedPerson, Practitioner or Device.  Plans can be created by Practitioners, Patients, RelatedPersons and Devices.  Original orders can be created by a Practitioner only.
    /// An instance-order is an instantiation of a request or order and may be used to populate Medication Administration Record.
    /// This element is labeled as a modifier because the intent alters when and how the resource is actually applicable.
    /// </summary>
    public string Intent { get; set; }
    /// <summary>
    /// Extension container element for Intent
    /// </summary>
    public Element _Intent { get; set; }
    /// <summary>
    /// If only a code is specified, then it needs to be a code for a specific product. If more information is required, then the use of the medication resource is recommended.  For example, if you require form or lot number or if the medication is compounded or extemporaneously prepared, then you must reference the Medication resource. .
    /// </summary>
    public CodeableConcept MedicationCodeableConcept { get; set; }
    /// <summary>
    /// If only a code is specified, then it needs to be a code for a specific product. If more information is required, then the use of the medication resource is recommended.  For example, if you require form or lot number or if the medication is compounded or extemporaneously prepared, then you must reference the Medication resource. .
    /// </summary>
    public Reference MedicationReference { get; set; }
    /// <summary>
    /// Extra information about the prescription that could not be conveyed by the other attributes.
    /// </summary>
    public List<Annotation> Note { get; set; }
    /// <summary>
    /// Indicates how quickly the Medication Request should be addressed with respect to other requests.
    /// </summary>
    public string Priority { get; set; }
    /// <summary>
    /// Extension container element for Priority
    /// </summary>
    public Element _Priority { get; set; }
    /// <summary>
    /// A link to a resource representing an earlier order related order or prescription.
    /// </summary>
    public Reference PriorPrescription { get; set; }
    /// <summary>
    /// This could be a diagnosis code. If a full condition record exists or additional detail is needed, use reasonReference.
    /// </summary>
    public List<CodeableConcept> ReasonCode { get; set; }
    /// <summary>
    /// This is a reference to a condition or observation that is the reason for the medication order.  If only a code exists, use reasonCode.
    /// </summary>
    public List<Reference> ReasonReference { get; set; }
    /// <summary>
    /// The person who entered the order on behalf of another individual for example in the case of a verbal or a telephone order.
    /// </summary>
    public Reference Recorder { get; set; }
    /// <summary>
    /// The individual, organization or device that initiated the request and has responsibility for its activation.
    /// </summary>
    public MedicationRequestRequester Requester { get; set; }
    /// <summary>
    /// This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// The subject on a medication request is mandatory.  For the secondary use case where the actual subject is not provided, there still must be an anonymized subject specified.
    /// </summary>
    public Reference Subject { get; set; }
    /// <summary>
    /// Indicates whether or not substitution can or should be part of the dispense. In some cases substitution must happen, in other cases substitution must not happen. This block explains the prescriber's intent. If nothing is specified substitution may be done.
    /// </summary>
    public MedicationRequestSubstitution Substitution { get; set; }
    /// <summary>
    /// Include additional information (for example, patient height and weight) that supports the ordering of the medication.
    /// </summary>
    public List<Reference> SupportingInformation { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      if (!string.IsNullOrEmpty(ResourceType))
      {
        writer.WriteString("resourceType", (string)ResourceType!);
      }


      ((fhirCsR3.Models.DomainResource)this).SerializeJson(writer, options, false);

      if ((Identifier != null) && (Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();

        foreach (Identifier valIdentifier in Identifier)
        {
          valIdentifier.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Definition != null) && (Definition.Count != 0))
      {
        writer.WritePropertyName("definition");
        writer.WriteStartArray();

        foreach (Reference valDefinition in Definition)
        {
          valDefinition.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((BasedOn != null) && (BasedOn.Count != 0))
      {
        writer.WritePropertyName("basedOn");
        writer.WriteStartArray();

        foreach (Reference valBasedOn in BasedOn)
        {
          valBasedOn.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (GroupIdentifier != null)
      {
        writer.WritePropertyName("groupIdentifier");
        GroupIdentifier.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Status))
      {
        writer.WriteString("status", (string)Status!);
      }

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Intent))
      {
        writer.WriteString("intent", (string)Intent!);
      }

      if (_Intent != null)
      {
        writer.WritePropertyName("_intent");
        _Intent.SerializeJson(writer, options);
      }

      if (Category != null)
      {
        writer.WritePropertyName("category");
        Category.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Priority))
      {
        writer.WriteString("priority", (string)Priority!);
      }

      if (_Priority != null)
      {
        writer.WritePropertyName("_priority");
        _Priority.SerializeJson(writer, options);
      }

      if (MedicationCodeableConcept != null)
      {
        writer.WritePropertyName("medicationCodeableConcept");
        MedicationCodeableConcept.SerializeJson(writer, options);
      }

      if (MedicationReference != null)
      {
        writer.WritePropertyName("medicationReference");
        MedicationReference.SerializeJson(writer, options);
      }

      if (Subject != null)
      {
        writer.WritePropertyName("subject");
        Subject.SerializeJson(writer, options);
      }

      if (Context != null)
      {
        writer.WritePropertyName("context");
        Context.SerializeJson(writer, options);
      }

      if ((SupportingInformation != null) && (SupportingInformation.Count != 0))
      {
        writer.WritePropertyName("supportingInformation");
        writer.WriteStartArray();

        foreach (Reference valSupportingInformation in SupportingInformation)
        {
          valSupportingInformation.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(AuthoredOn))
      {
        writer.WriteString("authoredOn", (string)AuthoredOn!);
      }

      if (_AuthoredOn != null)
      {
        writer.WritePropertyName("_authoredOn");
        _AuthoredOn.SerializeJson(writer, options);
      }

      if (Requester != null)
      {
        writer.WritePropertyName("requester");
        Requester.SerializeJson(writer, options);
      }

      if (Recorder != null)
      {
        writer.WritePropertyName("recorder");
        Recorder.SerializeJson(writer, options);
      }

      if ((ReasonCode != null) && (ReasonCode.Count != 0))
      {
        writer.WritePropertyName("reasonCode");
        writer.WriteStartArray();

        foreach (CodeableConcept valReasonCode in ReasonCode)
        {
          valReasonCode.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((ReasonReference != null) && (ReasonReference.Count != 0))
      {
        writer.WritePropertyName("reasonReference");
        writer.WriteStartArray();

        foreach (Reference valReasonReference in ReasonReference)
        {
          valReasonReference.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Note != null) && (Note.Count != 0))
      {
        writer.WritePropertyName("note");
        writer.WriteStartArray();

        foreach (Annotation valNote in Note)
        {
          valNote.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((DosageInstruction != null) && (DosageInstruction.Count != 0))
      {
        writer.WritePropertyName("dosageInstruction");
        writer.WriteStartArray();

        foreach (Dosage valDosageInstruction in DosageInstruction)
        {
          valDosageInstruction.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (DispenseRequest != null)
      {
        writer.WritePropertyName("dispenseRequest");
        DispenseRequest.SerializeJson(writer, options);
      }

      if (Substitution != null)
      {
        writer.WritePropertyName("substitution");
        Substitution.SerializeJson(writer, options);
      }

      if (PriorPrescription != null)
      {
        writer.WritePropertyName("priorPrescription");
        PriorPrescription.SerializeJson(writer, options);
      }

      if ((DetectedIssue != null) && (DetectedIssue.Count != 0))
      {
        writer.WritePropertyName("detectedIssue");
        writer.WriteStartArray();

        foreach (Reference valDetectedIssue in DetectedIssue)
        {
          valDetectedIssue.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((EventHistory != null) && (EventHistory.Count != 0))
      {
        writer.WritePropertyName("eventHistory");
        writer.WriteStartArray();

        foreach (Reference valEventHistory in EventHistory)
        {
          valEventHistory.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "authoredOn":
          AuthoredOn = reader.GetString();
          break;

        case "_authoredOn":
          _AuthoredOn = new fhirCsR3.Models.Element();
          _AuthoredOn.DeserializeJson(ref reader, options);
          break;

        case "basedOn":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          BasedOn = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objBasedOn = new fhirCsR3.Models.Reference();
            objBasedOn.DeserializeJson(ref reader, options);
            BasedOn.Add(objBasedOn);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (BasedOn.Count == 0)
          {
            BasedOn = null;
          }

          break;

        case "category":
          Category = new fhirCsR3.Models.CodeableConcept();
          Category.DeserializeJson(ref reader, options);
          break;

        case "context":
          Context = new fhirCsR3.Models.Reference();
          Context.DeserializeJson(ref reader, options);
          break;

        case "definition":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Definition = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objDefinition = new fhirCsR3.Models.Reference();
            objDefinition.DeserializeJson(ref reader, options);
            Definition.Add(objDefinition);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Definition.Count == 0)
          {
            Definition = null;
          }

          break;

        case "detectedIssue":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          DetectedIssue = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objDetectedIssue = new fhirCsR3.Models.Reference();
            objDetectedIssue.DeserializeJson(ref reader, options);
            DetectedIssue.Add(objDetectedIssue);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (DetectedIssue.Count == 0)
          {
            DetectedIssue = null;
          }

          break;

        case "dispenseRequest":
          DispenseRequest = new fhirCsR3.Models.MedicationRequestDispenseRequest();
          DispenseRequest.DeserializeJson(ref reader, options);
          break;

        case "dosageInstruction":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          DosageInstruction = new List<Dosage>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Dosage objDosageInstruction = new fhirCsR3.Models.Dosage();
            objDosageInstruction.DeserializeJson(ref reader, options);
            DosageInstruction.Add(objDosageInstruction);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (DosageInstruction.Count == 0)
          {
            DosageInstruction = null;
          }

          break;

        case "eventHistory":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          EventHistory = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objEventHistory = new fhirCsR3.Models.Reference();
            objEventHistory.DeserializeJson(ref reader, options);
            EventHistory.Add(objEventHistory);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (EventHistory.Count == 0)
          {
            EventHistory = null;
          }

          break;

        case "groupIdentifier":
          GroupIdentifier = new fhirCsR3.Models.Identifier();
          GroupIdentifier.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Identifier objIdentifier = new fhirCsR3.Models.Identifier();
            objIdentifier.DeserializeJson(ref reader, options);
            Identifier.Add(objIdentifier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Identifier.Count == 0)
          {
            Identifier = null;
          }

          break;

        case "intent":
          Intent = reader.GetString();
          break;

        case "_intent":
          _Intent = new fhirCsR3.Models.Element();
          _Intent.DeserializeJson(ref reader, options);
          break;

        case "medicationCodeableConcept":
          MedicationCodeableConcept = new fhirCsR3.Models.CodeableConcept();
          MedicationCodeableConcept.DeserializeJson(ref reader, options);
          break;

        case "medicationReference":
          MedicationReference = new fhirCsR3.Models.Reference();
          MedicationReference.DeserializeJson(ref reader, options);
          break;

        case "note":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Note = new List<Annotation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Annotation objNote = new fhirCsR3.Models.Annotation();
            objNote.DeserializeJson(ref reader, options);
            Note.Add(objNote);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Note.Count == 0)
          {
            Note = null;
          }

          break;

        case "priority":
          Priority = reader.GetString();
          break;

        case "_priority":
          _Priority = new fhirCsR3.Models.Element();
          _Priority.DeserializeJson(ref reader, options);
          break;

        case "priorPrescription":
          PriorPrescription = new fhirCsR3.Models.Reference();
          PriorPrescription.DeserializeJson(ref reader, options);
          break;

        case "reasonCode":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ReasonCode = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.CodeableConcept objReasonCode = new fhirCsR3.Models.CodeableConcept();
            objReasonCode.DeserializeJson(ref reader, options);
            ReasonCode.Add(objReasonCode);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ReasonCode.Count == 0)
          {
            ReasonCode = null;
          }

          break;

        case "reasonReference":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ReasonReference = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objReasonReference = new fhirCsR3.Models.Reference();
            objReasonReference.DeserializeJson(ref reader, options);
            ReasonReference.Add(objReasonReference);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ReasonReference.Count == 0)
          {
            ReasonReference = null;
          }

          break;

        case "recorder":
          Recorder = new fhirCsR3.Models.Reference();
          Recorder.DeserializeJson(ref reader, options);
          break;

        case "requester":
          Requester = new fhirCsR3.Models.MedicationRequestRequester();
          Requester.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR3.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "subject":
          Subject = new fhirCsR3.Models.Reference();
          Subject.DeserializeJson(ref reader, options);
          break;

        case "substitution":
          Substitution = new fhirCsR3.Models.MedicationRequestSubstitution();
          Substitution.DeserializeJson(ref reader, options);
          break;

        case "supportingInformation":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          SupportingInformation = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objSupportingInformation = new fhirCsR3.Models.Reference();
            objSupportingInformation.DeserializeJson(ref reader, options);
            SupportingInformation.Add(objSupportingInformation);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (SupportingInformation.Count == 0)
          {
            SupportingInformation = null;
          }

          break;

        default:
          ((fhirCsR3.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// Code Values for the MedicationRequest.intent field
  /// </summary>
  public static class MedicationRequestIntentCodes {
    public const string PROPOSAL = "proposal";
    public const string PLAN = "plan";
    public const string ORDER = "order";
    public const string INSTANCE_ORDER = "instance-order";
  }
  /// <summary>
  /// Code Values for the MedicationRequest.priority field
  /// </summary>
  public static class MedicationRequestPriorityCodes {
    public const string ROUTINE = "routine";
    public const string URGENT = "urgent";
    public const string STAT = "stat";
    public const string ASAP = "asap";
  }
  /// <summary>
  /// Code Values for the MedicationRequest.status field
  /// </summary>
  public static class MedicationRequestStatusCodes {
    public const string ACTIVE = "active";
    public const string ON_HOLD = "on-hold";
    public const string CANCELLED = "cancelled";
    public const string COMPLETED = "completed";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public const string STOPPED = "stopped";
    public const string DRAFT = "draft";
    public const string UNKNOWN = "unknown";
  }
}