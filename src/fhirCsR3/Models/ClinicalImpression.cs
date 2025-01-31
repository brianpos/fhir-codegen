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
  /// One or more sets of investigations (signs, symptions, etc.). The actual grouping of investigations vary greatly depending on the type and context of the assessment. These investigations may include data generated during the assessment process, or data previously generated and recorded that is pertinent to the outcomes.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<ClinicalImpressionInvestigation>))]
  public class ClinicalImpressionInvestigation : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// A name/code for the group ("set") of investigations. Typically, this will be something like "signs", "symptoms", "clinical", "diagnostic", but the list is not constrained, and others such groups such as (exposure|family|travel|nutitirional) history may be used.
    /// </summary>
    public CodeableConcept Code { get; set; }
    /// <summary>
    /// Most investigations are observations of one kind of or another but some other specific types of data collection resources can also be used.
    /// </summary>
    public List<Reference> Item { get; set; }
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

      if (Code != null)
      {
        writer.WritePropertyName("code");
        Code.SerializeJson(writer, options);
      }

      if ((Item != null) && (Item.Count != 0))
      {
        writer.WritePropertyName("item");
        writer.WriteStartArray();

        foreach (Reference valItem in Item)
        {
          valItem.SerializeJson(writer, options, true);
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
        case "code":
          Code = new fhirCsR3.Models.CodeableConcept();
          Code.DeserializeJson(ref reader, options);
          break;

        case "item":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Item = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objItem = new fhirCsR3.Models.Reference();
            objItem.DeserializeJson(ref reader, options);
            Item.Add(objItem);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Item.Count == 0)
          {
            Item = null;
          }

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
  /// Specific findings or diagnoses that was considered likely or relevant to ongoing treatment.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<ClinicalImpressionFinding>))]
  public class ClinicalImpressionFinding : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Which investigations support finding or diagnosis.
    /// </summary>
    public string Basis { get; set; }
    /// <summary>
    /// Extension container element for Basis
    /// </summary>
    public Element _Basis { get; set; }
    /// <summary>
    /// Specific text, code or reference for finding or diagnosis, which may include ruled-out or resolved conditions.
    /// </summary>
    public CodeableConcept ItemCodeableConcept { get; set; }
    /// <summary>
    /// Specific text, code or reference for finding or diagnosis, which may include ruled-out or resolved conditions.
    /// </summary>
    public Reference ItemReference { get; set; }
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

      if (ItemCodeableConcept != null)
      {
        writer.WritePropertyName("itemCodeableConcept");
        ItemCodeableConcept.SerializeJson(writer, options);
      }

      if (ItemReference != null)
      {
        writer.WritePropertyName("itemReference");
        ItemReference.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Basis))
      {
        writer.WriteString("basis", (string)Basis!);
      }

      if (_Basis != null)
      {
        writer.WritePropertyName("_basis");
        _Basis.SerializeJson(writer, options);
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
        case "basis":
          Basis = reader.GetString();
          break;

        case "_basis":
          _Basis = new fhirCsR3.Models.Element();
          _Basis.DeserializeJson(ref reader, options);
          break;

        case "itemCodeableConcept":
          ItemCodeableConcept = new fhirCsR3.Models.CodeableConcept();
          ItemCodeableConcept.DeserializeJson(ref reader, options);
          break;

        case "itemReference":
          ItemReference = new fhirCsR3.Models.Reference();
          ItemReference.DeserializeJson(ref reader, options);
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
  /// A record of a clinical assessment performed to determine what problem(s) may affect the patient and before planning the treatments or management strategies that are best to manage a patient's condition. Assessments are often 1:1 with a clinical consultation / encounter,  but this varies greatly depending on the clinical workflow. This resource is called "ClinicalImpression" rather than "ClinicalAssessment" to avoid confusion with the recording of assessment tools such as Apgar score.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<ClinicalImpression>))]
  public class ClinicalImpression : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "ClinicalImpression";
    /// <summary>
    /// Actions recommended as a result of the impression should not be captured using the 'action' element.
    /// </summary>
    public List<Reference> Action { get; set; }
    /// <summary>
    /// The clinician performing the assessment.
    /// </summary>
    public Reference Assessor { get; set; }
    /// <summary>
    /// This is present as a place-holder only and may be removed based on feedback/work group opinion.
    /// </summary>
    public CodeableConcept Code { get; set; }
    /// <summary>
    /// The encounter or episode of care this impression was created as part of.
    /// </summary>
    public Reference Context { get; set; }
    /// <summary>
    /// Indicates when the documentation of the assessment was complete.
    /// </summary>
    public string Date { get; set; }
    /// <summary>
    /// Extension container element for Date
    /// </summary>
    public Element _Date { get; set; }
    /// <summary>
    /// A summary of the context and/or cause of the assessment - why / where was it performed, and what patient events/status prompted it.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Extension container element for Description
    /// </summary>
    public Element _Description { get; set; }
    /// <summary>
    /// This SHOULD be accurate to at least the minute, though some assessments only have a known date.
    /// </summary>
    public string EffectiveDateTime { get; set; }
    /// <summary>
    /// Extension container element for EffectiveDateTime
    /// </summary>
    public Element _EffectiveDateTime { get; set; }
    /// <summary>
    /// This SHOULD be accurate to at least the minute, though some assessments only have a known date.
    /// </summary>
    public Period EffectivePeriod { get; set; }
    /// <summary>
    /// Specific findings or diagnoses that was considered likely or relevant to ongoing treatment.
    /// </summary>
    public List<ClinicalImpressionFinding> Finding { get; set; }
    /// <summary>
    /// A unique identifier assigned to the clinical impression that remains consistent regardless of what server the impression is stored on.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// One or more sets of investigations (signs, symptions, etc.). The actual grouping of investigations vary greatly depending on the type and context of the assessment. These investigations may include data generated during the assessment process, or data previously generated and recorded that is pertinent to the outcomes.
    /// </summary>
    public List<ClinicalImpressionInvestigation> Investigation { get; set; }
    /// <summary>
    /// Don't use this element for content that should more properly appear as one of the specific elements of the impression.
    /// </summary>
    public List<Annotation> Note { get; set; }
    /// <summary>
    /// It is always likely that multiple previous assessments exist for a patient. The point of quoting a previous assessment is that this assessment is relative to it (see resolved).
    /// </summary>
    public Reference Previous { get; set; }
    /// <summary>
    /// e.g. The patient is a pregnant, and cardiac congestive failure, ‎Adenocarcinoma, and is allergic to penicillin.
    /// </summary>
    public List<Reference> Problem { get; set; }
    /// <summary>
    /// Estimate of likely outcome.
    /// </summary>
    public List<CodeableConcept> PrognosisCodeableConcept { get; set; }
    /// <summary>
    /// RiskAssessment expressing likely outcome.
    /// </summary>
    public List<Reference> PrognosisReference { get; set; }
    /// <summary>
    /// Reference to a specific published clinical protocol that was followed during this assessment, and/or that provides evidence in support of the diagnosis.
    /// </summary>
    public List<string> Protocol { get; set; }
    /// <summary>
    /// Extension container element for Protocol
    /// </summary>
    public List<Element> _Protocol { get; set; }
    /// <summary>
    /// This element is labeled as a modifier because the status contains the code entered-in-error that marks the clinical impression as not currently valid.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// The patient or group of individuals assessed as part of this record.
    /// </summary>
    public Reference Subject { get; set; }
    /// <summary>
    /// A text summary of the investigations and the diagnosis.
    /// </summary>
    public string Summary { get; set; }
    /// <summary>
    /// Extension container element for Summary
    /// </summary>
    public Element _Summary { get; set; }
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

      if (!string.IsNullOrEmpty(Status))
      {
        writer.WriteString("status", (string)Status!);
      }

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(writer, options);
      }

      if (Code != null)
      {
        writer.WritePropertyName("code");
        Code.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Description))
      {
        writer.WriteString("description", (string)Description!);
      }

      if (_Description != null)
      {
        writer.WritePropertyName("_description");
        _Description.SerializeJson(writer, options);
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

      if (!string.IsNullOrEmpty(EffectiveDateTime))
      {
        writer.WriteString("effectiveDateTime", (string)EffectiveDateTime!);
      }

      if (_EffectiveDateTime != null)
      {
        writer.WritePropertyName("_effectiveDateTime");
        _EffectiveDateTime.SerializeJson(writer, options);
      }

      if (EffectivePeriod != null)
      {
        writer.WritePropertyName("effectivePeriod");
        EffectivePeriod.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Date))
      {
        writer.WriteString("date", (string)Date!);
      }

      if (_Date != null)
      {
        writer.WritePropertyName("_date");
        _Date.SerializeJson(writer, options);
      }

      if (Assessor != null)
      {
        writer.WritePropertyName("assessor");
        Assessor.SerializeJson(writer, options);
      }

      if (Previous != null)
      {
        writer.WritePropertyName("previous");
        Previous.SerializeJson(writer, options);
      }

      if ((Problem != null) && (Problem.Count != 0))
      {
        writer.WritePropertyName("problem");
        writer.WriteStartArray();

        foreach (Reference valProblem in Problem)
        {
          valProblem.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Investigation != null) && (Investigation.Count != 0))
      {
        writer.WritePropertyName("investigation");
        writer.WriteStartArray();

        foreach (ClinicalImpressionInvestigation valInvestigation in Investigation)
        {
          valInvestigation.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Protocol != null) && (Protocol.Count != 0))
      {
        writer.WritePropertyName("protocol");
        writer.WriteStartArray();

        foreach (string valProtocol in Protocol)
        {
          writer.WriteStringValue(valProtocol);
        }

        writer.WriteEndArray();
      }

      if ((_Protocol != null) && (_Protocol.Count != 0))
      {
        writer.WritePropertyName("_protocol");
        writer.WriteStartArray();

        foreach (Element val_Protocol in _Protocol)
        {
          val_Protocol.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Summary))
      {
        writer.WriteString("summary", (string)Summary!);
      }

      if (_Summary != null)
      {
        writer.WritePropertyName("_summary");
        _Summary.SerializeJson(writer, options);
      }

      if ((Finding != null) && (Finding.Count != 0))
      {
        writer.WritePropertyName("finding");
        writer.WriteStartArray();

        foreach (ClinicalImpressionFinding valFinding in Finding)
        {
          valFinding.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((PrognosisCodeableConcept != null) && (PrognosisCodeableConcept.Count != 0))
      {
        writer.WritePropertyName("prognosisCodeableConcept");
        writer.WriteStartArray();

        foreach (CodeableConcept valPrognosisCodeableConcept in PrognosisCodeableConcept)
        {
          valPrognosisCodeableConcept.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((PrognosisReference != null) && (PrognosisReference.Count != 0))
      {
        writer.WritePropertyName("prognosisReference");
        writer.WriteStartArray();

        foreach (Reference valPrognosisReference in PrognosisReference)
        {
          valPrognosisReference.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Action != null) && (Action.Count != 0))
      {
        writer.WritePropertyName("action");
        writer.WriteStartArray();

        foreach (Reference valAction in Action)
        {
          valAction.SerializeJson(writer, options, true);
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
        case "action":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Action = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objAction = new fhirCsR3.Models.Reference();
            objAction.DeserializeJson(ref reader, options);
            Action.Add(objAction);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Action.Count == 0)
          {
            Action = null;
          }

          break;

        case "assessor":
          Assessor = new fhirCsR3.Models.Reference();
          Assessor.DeserializeJson(ref reader, options);
          break;

        case "code":
          Code = new fhirCsR3.Models.CodeableConcept();
          Code.DeserializeJson(ref reader, options);
          break;

        case "context":
          Context = new fhirCsR3.Models.Reference();
          Context.DeserializeJson(ref reader, options);
          break;

        case "date":
          Date = reader.GetString();
          break;

        case "_date":
          _Date = new fhirCsR3.Models.Element();
          _Date.DeserializeJson(ref reader, options);
          break;

        case "description":
          Description = reader.GetString();
          break;

        case "_description":
          _Description = new fhirCsR3.Models.Element();
          _Description.DeserializeJson(ref reader, options);
          break;

        case "effectiveDateTime":
          EffectiveDateTime = reader.GetString();
          break;

        case "_effectiveDateTime":
          _EffectiveDateTime = new fhirCsR3.Models.Element();
          _EffectiveDateTime.DeserializeJson(ref reader, options);
          break;

        case "effectivePeriod":
          EffectivePeriod = new fhirCsR3.Models.Period();
          EffectivePeriod.DeserializeJson(ref reader, options);
          break;

        case "finding":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Finding = new List<ClinicalImpressionFinding>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.ClinicalImpressionFinding objFinding = new fhirCsR3.Models.ClinicalImpressionFinding();
            objFinding.DeserializeJson(ref reader, options);
            Finding.Add(objFinding);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Finding.Count == 0)
          {
            Finding = null;
          }

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

        case "investigation":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Investigation = new List<ClinicalImpressionInvestigation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.ClinicalImpressionInvestigation objInvestigation = new fhirCsR3.Models.ClinicalImpressionInvestigation();
            objInvestigation.DeserializeJson(ref reader, options);
            Investigation.Add(objInvestigation);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Investigation.Count == 0)
          {
            Investigation = null;
          }

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

        case "previous":
          Previous = new fhirCsR3.Models.Reference();
          Previous.DeserializeJson(ref reader, options);
          break;

        case "problem":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Problem = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objProblem = new fhirCsR3.Models.Reference();
            objProblem.DeserializeJson(ref reader, options);
            Problem.Add(objProblem);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Problem.Count == 0)
          {
            Problem = null;
          }

          break;

        case "prognosisCodeableConcept":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          PrognosisCodeableConcept = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.CodeableConcept objPrognosisCodeableConcept = new fhirCsR3.Models.CodeableConcept();
            objPrognosisCodeableConcept.DeserializeJson(ref reader, options);
            PrognosisCodeableConcept.Add(objPrognosisCodeableConcept);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (PrognosisCodeableConcept.Count == 0)
          {
            PrognosisCodeableConcept = null;
          }

          break;

        case "prognosisReference":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          PrognosisReference = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objPrognosisReference = new fhirCsR3.Models.Reference();
            objPrognosisReference.DeserializeJson(ref reader, options);
            PrognosisReference.Add(objPrognosisReference);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (PrognosisReference.Count == 0)
          {
            PrognosisReference = null;
          }

          break;

        case "protocol":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Protocol = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Protocol.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Protocol.Count == 0)
          {
            Protocol = null;
          }

          break;

        case "_protocol":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _Protocol = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Element obj_Protocol = new fhirCsR3.Models.Element();
            obj_Protocol.DeserializeJson(ref reader, options);
            _Protocol.Add(obj_Protocol);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_Protocol.Count == 0)
          {
            _Protocol = null;
          }

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

        case "summary":
          Summary = reader.GetString();
          break;

        case "_summary":
          _Summary = new fhirCsR3.Models.Element();
          _Summary.DeserializeJson(ref reader, options);
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
  /// Code Values for the ClinicalImpression.status field
  /// </summary>
  public static class ClinicalImpressionStatusCodes {
    public const string DRAFT = "draft";
    public const string COMPLETED = "completed";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public static HashSet<string> Values = new HashSet<string>() {
      "draft",
      "completed",
      "entered-in-error",
    };
  }
}
