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
  /// A record of a device being used by a patient where the record is the result of a report from the patient or another clinician.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<DeviceUseStatement>))]
  public class DeviceUseStatement : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "DeviceUseStatement";
    /// <summary>
    /// Indicates the site on the subject's body where the device was used ( i.e. the target site).
    /// </summary>
    public CodeableConcept BodySite { get; set; }
    /// <summary>
    /// The details of the device used.
    /// </summary>
    public Reference Device { get; set; }
    /// <summary>
    /// An external identifier for this statement such as an IRI.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// Reason or justification for the use of the device.
    /// </summary>
    public List<CodeableConcept> Indication { get; set; }
    /// <summary>
    /// Details about the device statement that were not represented at all or sufficiently in one of the attributes provided in a class. These may include for example a comment, an instruction, or a note associated with the statement.
    /// </summary>
    public List<Annotation> Note { get; set; }
    /// <summary>
    /// The time at which the statement was made/recorded.
    /// </summary>
    public string RecordedOn { get; set; }
    /// <summary>
    /// Extension container element for RecordedOn
    /// </summary>
    public Element _RecordedOn { get; set; }
    /// <summary>
    /// Who reported the device was being used by the patient.
    /// </summary>
    public Reference Source { get; set; }
    /// <summary>
    /// DeviceUseStatment is a statement at a point in time.  The status is only representative at the point when it was asserted.  The value set for contains codes that assert the status of the use  by the patient (for example, stopped or on hold) as well as codes that assert the status of the resource itself (for example, entered in error).
    /// This element is labeled as a modifier because the status contains the codes that mark the statement as not currently valid.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// The patient who used the device.
    /// </summary>
    public Reference Subject { get; set; }
    /// <summary>
    /// How often the device was used.
    /// </summary>
    public Timing TimingTiming { get; set; }
    /// <summary>
    /// How often the device was used.
    /// </summary>
    public Period TimingPeriod { get; set; }
    /// <summary>
    /// How often the device was used.
    /// </summary>
    public string TimingDateTime { get; set; }
    /// <summary>
    /// Extension container element for TimingDateTime
    /// </summary>
    public Element _TimingDateTime { get; set; }
    /// <summary>
    /// The time period over which the device was used.
    /// </summary>
    public Period WhenUsed { get; set; }
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

      if (Subject != null)
      {
        writer.WritePropertyName("subject");
        Subject.SerializeJson(writer, options);
      }

      if (WhenUsed != null)
      {
        writer.WritePropertyName("whenUsed");
        WhenUsed.SerializeJson(writer, options);
      }

      if (TimingTiming != null)
      {
        writer.WritePropertyName("timingTiming");
        TimingTiming.SerializeJson(writer, options);
      }

      if (TimingPeriod != null)
      {
        writer.WritePropertyName("timingPeriod");
        TimingPeriod.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(TimingDateTime))
      {
        writer.WriteString("timingDateTime", (string)TimingDateTime!);
      }

      if (_TimingDateTime != null)
      {
        writer.WritePropertyName("_timingDateTime");
        _TimingDateTime.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(RecordedOn))
      {
        writer.WriteString("recordedOn", (string)RecordedOn!);
      }

      if (_RecordedOn != null)
      {
        writer.WritePropertyName("_recordedOn");
        _RecordedOn.SerializeJson(writer, options);
      }

      if (Source != null)
      {
        writer.WritePropertyName("source");
        Source.SerializeJson(writer, options);
      }

      if (Device != null)
      {
        writer.WritePropertyName("device");
        Device.SerializeJson(writer, options);
      }

      if ((Indication != null) && (Indication.Count != 0))
      {
        writer.WritePropertyName("indication");
        writer.WriteStartArray();

        foreach (CodeableConcept valIndication in Indication)
        {
          valIndication.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (BodySite != null)
      {
        writer.WritePropertyName("bodySite");
        BodySite.SerializeJson(writer, options);
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
        case "bodySite":
          BodySite = new fhirCsR3.Models.CodeableConcept();
          BodySite.DeserializeJson(ref reader, options);
          break;

        case "device":
          Device = new fhirCsR3.Models.Reference();
          Device.DeserializeJson(ref reader, options);
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

        case "indication":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Indication = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.CodeableConcept objIndication = new fhirCsR3.Models.CodeableConcept();
            objIndication.DeserializeJson(ref reader, options);
            Indication.Add(objIndication);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Indication.Count == 0)
          {
            Indication = null;
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

        case "recordedOn":
          RecordedOn = reader.GetString();
          break;

        case "_recordedOn":
          _RecordedOn = new fhirCsR3.Models.Element();
          _RecordedOn.DeserializeJson(ref reader, options);
          break;

        case "source":
          Source = new fhirCsR3.Models.Reference();
          Source.DeserializeJson(ref reader, options);
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

        case "timingTiming":
          TimingTiming = new fhirCsR3.Models.Timing();
          TimingTiming.DeserializeJson(ref reader, options);
          break;

        case "timingPeriod":
          TimingPeriod = new fhirCsR3.Models.Period();
          TimingPeriod.DeserializeJson(ref reader, options);
          break;

        case "timingDateTime":
          TimingDateTime = reader.GetString();
          break;

        case "_timingDateTime":
          _TimingDateTime = new fhirCsR3.Models.Element();
          _TimingDateTime.DeserializeJson(ref reader, options);
          break;

        case "whenUsed":
          WhenUsed = new fhirCsR3.Models.Period();
          WhenUsed.DeserializeJson(ref reader, options);
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
  /// Code Values for the DeviceUseStatement.status field
  /// </summary>
  public static class DeviceUseStatementStatusCodes {
    public const string ACTIVE = "active";
    public const string COMPLETED = "completed";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public const string INTENDED = "intended";
    public const string STOPPED = "stopped";
    public const string ON_HOLD = "on-hold";
  }
}