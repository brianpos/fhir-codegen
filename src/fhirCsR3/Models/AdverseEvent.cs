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
  /// Describes the entity that is suspected to have caused the adverse event.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<AdverseEventSuspectEntity>))]
  public class AdverseEventSuspectEntity : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// causality1 | causality2.
    /// </summary>
    public string Causality { get; set; }
    /// <summary>
    /// Extension container element for Causality
    /// </summary>
    public Element _Causality { get; set; }
    /// <summary>
    /// assess1 | assess2.
    /// </summary>
    public CodeableConcept CausalityAssessment { get; set; }
    /// <summary>
    /// AdverseEvent.suspectEntity.causalityAuthor.
    /// </summary>
    public Reference CausalityAuthor { get; set; }
    /// <summary>
    /// method1 | method2.
    /// </summary>
    public CodeableConcept CausalityMethod { get; set; }
    /// <summary>
    /// AdverseEvent.suspectEntity.causalityProductRelatedness.
    /// </summary>
    public string CausalityProductRelatedness { get; set; }
    /// <summary>
    /// Extension container element for CausalityProductRelatedness
    /// </summary>
    public Element _CausalityProductRelatedness { get; set; }
    /// <summary>
    /// result1 | result2.
    /// </summary>
    public CodeableConcept CausalityResult { get; set; }
    /// <summary>
    /// Identifies the actual instance of what caused the adverse event.  May be a substance, medication, medication administration, medication statement or a device.
    /// </summary>
    public Reference Instance { get; set; }
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

      if (Instance != null)
      {
        writer.WritePropertyName("instance");
        Instance.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Causality))
      {
        writer.WriteString("causality", (string)Causality!);
      }

      if (_Causality != null)
      {
        writer.WritePropertyName("_causality");
        _Causality.SerializeJson(writer, options);
      }

      if (CausalityAssessment != null)
      {
        writer.WritePropertyName("causalityAssessment");
        CausalityAssessment.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(CausalityProductRelatedness))
      {
        writer.WriteString("causalityProductRelatedness", (string)CausalityProductRelatedness!);
      }

      if (_CausalityProductRelatedness != null)
      {
        writer.WritePropertyName("_causalityProductRelatedness");
        _CausalityProductRelatedness.SerializeJson(writer, options);
      }

      if (CausalityMethod != null)
      {
        writer.WritePropertyName("causalityMethod");
        CausalityMethod.SerializeJson(writer, options);
      }

      if (CausalityAuthor != null)
      {
        writer.WritePropertyName("causalityAuthor");
        CausalityAuthor.SerializeJson(writer, options);
      }

      if (CausalityResult != null)
      {
        writer.WritePropertyName("causalityResult");
        CausalityResult.SerializeJson(writer, options);
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
        case "causality":
          Causality = reader.GetString();
          break;

        case "_causality":
          _Causality = new fhirCsR3.Models.Element();
          _Causality.DeserializeJson(ref reader, options);
          break;

        case "causalityAssessment":
          CausalityAssessment = new fhirCsR3.Models.CodeableConcept();
          CausalityAssessment.DeserializeJson(ref reader, options);
          break;

        case "causalityAuthor":
          CausalityAuthor = new fhirCsR3.Models.Reference();
          CausalityAuthor.DeserializeJson(ref reader, options);
          break;

        case "causalityMethod":
          CausalityMethod = new fhirCsR3.Models.CodeableConcept();
          CausalityMethod.DeserializeJson(ref reader, options);
          break;

        case "causalityProductRelatedness":
          CausalityProductRelatedness = reader.GetString();
          break;

        case "_causalityProductRelatedness":
          _CausalityProductRelatedness = new fhirCsR3.Models.Element();
          _CausalityProductRelatedness.DeserializeJson(ref reader, options);
          break;

        case "causalityResult":
          CausalityResult = new fhirCsR3.Models.CodeableConcept();
          CausalityResult.DeserializeJson(ref reader, options);
          break;

        case "instance":
          Instance = new fhirCsR3.Models.Reference();
          Instance.DeserializeJson(ref reader, options);
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
  /// Code Values for the AdverseEvent.suspectEntity.causality field
  /// </summary>
  public static class AdverseEventSuspectEntityCausalityCodes {
    public const string CAUSALITY1 = "causality1";
    public const string CAUSALITY2 = "causality2";
  }
  /// <summary>
  /// Actual or  potential/avoided event causing unintended physical injury resulting from or contributed to by medical care, a research study or other healthcare setting factors that requires additional monitoring, treatment, or hospitalization, or that results in death.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<AdverseEvent>))]
  public class AdverseEvent : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "AdverseEvent";
    /// <summary>
    /// The type of event which is important to characterize what occurred and caused harm to the subject, or had the potential to cause harm to the subject.
    /// </summary>
    public string Category { get; set; }
    /// <summary>
    /// Extension container element for Category
    /// </summary>
    public Element _Category { get; set; }
    /// <summary>
    /// The date (and perhaps time) when the adverse event occurred.
    /// </summary>
    public string Date { get; set; }
    /// <summary>
    /// Extension container element for Date
    /// </summary>
    public Element _Date { get; set; }
    /// <summary>
    /// Describes the adverse event in text.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Extension container element for Description
    /// </summary>
    public Element _Description { get; set; }
    /// <summary>
    /// Parties that may or should contribute or have contributed information to the Act. Such information includes information leading to the decision to perform the Act and how to perform the Act (e.g. consultant), information that the Act itself seeks to reveal (e.g. informant of clinical history), or information about what Act was performed (e.g. informant witness).
    /// </summary>
    public Reference EventParticipant { get; set; }
    /// <summary>
    /// The identifier(s) of this adverse event that are assigned by business processes and/or used to refer to it when a direct URL reference to the resource itsefl is not appropriate.
    /// </summary>
    public Identifier Identifier { get; set; }
    /// <summary>
    /// The information about where the adverse event occurred.
    /// </summary>
    public Reference Location { get; set; }
    /// <summary>
    /// Describes the type of outcome from the adverse event.
    /// </summary>
    public CodeableConcept Outcome { get; set; }
    /// <summary>
    /// Includes information about the reaction that occurred as a result of exposure to a substance (for example, a drug or a chemical).
    /// </summary>
    public List<Reference> Reaction { get; set; }
    /// <summary>
    /// Information on who recorded the adverse event.  May be the patient or a practitioner.
    /// </summary>
    public Reference Recorder { get; set; }
    /// <summary>
    /// AdverseEvent.referenceDocument.
    /// </summary>
    public List<Reference> ReferenceDocument { get; set; }
    /// <summary>
    /// Describes the seriousness or severity of the adverse event.
    /// </summary>
    public CodeableConcept Seriousness { get; set; }
    /// <summary>
    /// AdverseEvent.study.
    /// </summary>
    public List<Reference> Study { get; set; }
    /// <summary>
    /// This subject or group impacted by the event.  With a prospective adverse event, there will be no subject as the adverse event was prevented.
    /// </summary>
    public Reference Subject { get; set; }
    /// <summary>
    /// AdverseEvent.subjectMedicalHistory.
    /// </summary>
    public List<Reference> SubjectMedicalHistory { get; set; }
    /// <summary>
    /// Describes the entity that is suspected to have caused the adverse event.
    /// </summary>
    public List<AdverseEventSuspectEntity> SuspectEntity { get; set; }
    /// <summary>
    /// This element defines the specific type of event that occurred or that was prevented from occurring.
    /// </summary>
    public CodeableConcept Type { get; set; }
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

      if (Identifier != null)
      {
        writer.WritePropertyName("identifier");
        Identifier.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Category))
      {
        writer.WriteString("category", (string)Category!);
      }

      if (_Category != null)
      {
        writer.WritePropertyName("_category");
        _Category.SerializeJson(writer, options);
      }

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
      }

      if (Subject != null)
      {
        writer.WritePropertyName("subject");
        Subject.SerializeJson(writer, options);
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

      if ((Reaction != null) && (Reaction.Count != 0))
      {
        writer.WritePropertyName("reaction");
        writer.WriteStartArray();

        foreach (Reference valReaction in Reaction)
        {
          valReaction.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Location != null)
      {
        writer.WritePropertyName("location");
        Location.SerializeJson(writer, options);
      }

      if (Seriousness != null)
      {
        writer.WritePropertyName("seriousness");
        Seriousness.SerializeJson(writer, options);
      }

      if (Outcome != null)
      {
        writer.WritePropertyName("outcome");
        Outcome.SerializeJson(writer, options);
      }

      if (Recorder != null)
      {
        writer.WritePropertyName("recorder");
        Recorder.SerializeJson(writer, options);
      }

      if (EventParticipant != null)
      {
        writer.WritePropertyName("eventParticipant");
        EventParticipant.SerializeJson(writer, options);
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

      if ((SuspectEntity != null) && (SuspectEntity.Count != 0))
      {
        writer.WritePropertyName("suspectEntity");
        writer.WriteStartArray();

        foreach (AdverseEventSuspectEntity valSuspectEntity in SuspectEntity)
        {
          valSuspectEntity.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((SubjectMedicalHistory != null) && (SubjectMedicalHistory.Count != 0))
      {
        writer.WritePropertyName("subjectMedicalHistory");
        writer.WriteStartArray();

        foreach (Reference valSubjectMedicalHistory in SubjectMedicalHistory)
        {
          valSubjectMedicalHistory.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((ReferenceDocument != null) && (ReferenceDocument.Count != 0))
      {
        writer.WritePropertyName("referenceDocument");
        writer.WriteStartArray();

        foreach (Reference valReferenceDocument in ReferenceDocument)
        {
          valReferenceDocument.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Study != null) && (Study.Count != 0))
      {
        writer.WritePropertyName("study");
        writer.WriteStartArray();

        foreach (Reference valStudy in Study)
        {
          valStudy.SerializeJson(writer, options, true);
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
        case "category":
          Category = reader.GetString();
          break;

        case "_category":
          _Category = new fhirCsR3.Models.Element();
          _Category.DeserializeJson(ref reader, options);
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

        case "eventParticipant":
          EventParticipant = new fhirCsR3.Models.Reference();
          EventParticipant.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          Identifier = new fhirCsR3.Models.Identifier();
          Identifier.DeserializeJson(ref reader, options);
          break;

        case "location":
          Location = new fhirCsR3.Models.Reference();
          Location.DeserializeJson(ref reader, options);
          break;

        case "outcome":
          Outcome = new fhirCsR3.Models.CodeableConcept();
          Outcome.DeserializeJson(ref reader, options);
          break;

        case "reaction":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Reaction = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objReaction = new fhirCsR3.Models.Reference();
            objReaction.DeserializeJson(ref reader, options);
            Reaction.Add(objReaction);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Reaction.Count == 0)
          {
            Reaction = null;
          }

          break;

        case "recorder":
          Recorder = new fhirCsR3.Models.Reference();
          Recorder.DeserializeJson(ref reader, options);
          break;

        case "referenceDocument":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ReferenceDocument = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objReferenceDocument = new fhirCsR3.Models.Reference();
            objReferenceDocument.DeserializeJson(ref reader, options);
            ReferenceDocument.Add(objReferenceDocument);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ReferenceDocument.Count == 0)
          {
            ReferenceDocument = null;
          }

          break;

        case "seriousness":
          Seriousness = new fhirCsR3.Models.CodeableConcept();
          Seriousness.DeserializeJson(ref reader, options);
          break;

        case "study":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Study = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objStudy = new fhirCsR3.Models.Reference();
            objStudy.DeserializeJson(ref reader, options);
            Study.Add(objStudy);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Study.Count == 0)
          {
            Study = null;
          }

          break;

        case "subject":
          Subject = new fhirCsR3.Models.Reference();
          Subject.DeserializeJson(ref reader, options);
          break;

        case "subjectMedicalHistory":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          SubjectMedicalHistory = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objSubjectMedicalHistory = new fhirCsR3.Models.Reference();
            objSubjectMedicalHistory.DeserializeJson(ref reader, options);
            SubjectMedicalHistory.Add(objSubjectMedicalHistory);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (SubjectMedicalHistory.Count == 0)
          {
            SubjectMedicalHistory = null;
          }

          break;

        case "suspectEntity":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          SuspectEntity = new List<AdverseEventSuspectEntity>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.AdverseEventSuspectEntity objSuspectEntity = new fhirCsR3.Models.AdverseEventSuspectEntity();
            objSuspectEntity.DeserializeJson(ref reader, options);
            SuspectEntity.Add(objSuspectEntity);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (SuspectEntity.Count == 0)
          {
            SuspectEntity = null;
          }

          break;

        case "type":
          Type = new fhirCsR3.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
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
  /// Code Values for the AdverseEvent.category field
  /// </summary>
  public static class AdverseEventCategoryCodes {
    public const string AE = "AE";
    public const string PAE = "PAE";
  }
}