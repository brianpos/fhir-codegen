// <auto-generated />
// Built from: hl7.fhir.r2.core version: 1.0.2
  // Option: "NAMESPACE" = "fhirCsR2"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR2.Serialization;

namespace fhirCsR2.Models
{
  /// <summary>
  /// Text, attachment(s), or resource(s) to be communicated to the recipient.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<CommunicationRequestPayload>))]
  public class CommunicationRequestPayload : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The communicated content (or for multi-part communications, one portion of the communication).
    /// </summary>
    public string ContentString { get; set; }
    /// <summary>
    /// Extension container element for ContentString
    /// </summary>
    public Element _ContentString { get; set; }
    /// <summary>
    /// The communicated content (or for multi-part communications, one portion of the communication).
    /// </summary>
    public Attachment ContentAttachment { get; set; }
    /// <summary>
    /// The communicated content (or for multi-part communications, one portion of the communication).
    /// </summary>
    public Reference ContentReference { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR2.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(ContentString))
      {
        writer.WriteString("contentString", (string)ContentString!);
      }

      if (_ContentString != null)
      {
        writer.WritePropertyName("_contentString");
        _ContentString.SerializeJson(writer, options);
      }

      if (ContentAttachment != null)
      {
        writer.WritePropertyName("contentAttachment");
        ContentAttachment.SerializeJson(writer, options);
      }

      if (ContentReference != null)
      {
        writer.WritePropertyName("contentReference");
        ContentReference.SerializeJson(writer, options);
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
        case "contentString":
          ContentString = reader.GetString();
          break;

        case "_contentString":
          _ContentString = new fhirCsR2.Models.Element();
          _ContentString.DeserializeJson(ref reader, options);
          break;

        case "contentAttachment":
          ContentAttachment = new fhirCsR2.Models.Attachment();
          ContentAttachment.DeserializeJson(ref reader, options);
          break;

        case "contentReference":
          ContentReference = new fhirCsR2.Models.Reference();
          ContentReference.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR2.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// A request to convey information; e.g. the CDS system proposes that an alert be sent to a responsible provider, the CDS system proposes that the public health agency be notified about a reportable condition.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<CommunicationRequest>))]
  public class CommunicationRequest : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "CommunicationRequest";
    /// <summary>
    /// The type of message to be sent such as alert, notification, reminder, instruction, etc.
    /// </summary>
    public CodeableConcept Category { get; set; }
    /// <summary>
    /// The encounter within which the communication request was created.
    /// </summary>
    public Reference Encounter { get; set; }
    /// <summary>
    /// A unique ID of this request for reference purposes. It must be provided if user wants it returned as part of any output, otherwise it will be autogenerated, if needed, by CDS system. Does not need to be the actual ID of the source system.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// A channel that was used for this communication (e.g. email, fax).
    /// </summary>
    public List<CodeableConcept> Medium { get; set; }
    /// <summary>
    /// Text, attachment(s), or resource(s) to be communicated to the recipient.
    /// </summary>
    public List<CommunicationRequestPayload> Payload { get; set; }
    /// <summary>
    /// Characterizes how quickly the proposed act must be initiated. Includes concepts such as stat, urgent, routine.
    /// </summary>
    public CodeableConcept Priority { get; set; }
    /// <summary>
    /// The reason or justification for the communication request.
    /// </summary>
    public List<CodeableConcept> Reason { get; set; }
    /// <summary>
    /// The entity (e.g. person, organization, clinical information system, or device) which is the intended target of the communication.
    /// </summary>
    public List<Reference> Recipient { get; set; }
    /// <summary>
    /// The time when the request was made.
    /// </summary>
    public string RequestedOn { get; set; }
    /// <summary>
    /// Extension container element for RequestedOn
    /// </summary>
    public Element _RequestedOn { get; set; }
    /// <summary>
    /// The responsible person who authorizes this order, e.g. physician. This may be different than the author of the order statement, e.g. clerk, who may have entered the statement into the order entry application.
    /// </summary>
    public Reference Requester { get; set; }
    /// <summary>
    /// The time when this communication is to occur.
    /// </summary>
    public string ScheduledDateTime { get; set; }
    /// <summary>
    /// Extension container element for ScheduledDateTime
    /// </summary>
    public Element _ScheduledDateTime { get; set; }
    /// <summary>
    /// The time when this communication is to occur.
    /// </summary>
    public Period ScheduledPeriod { get; set; }
    /// <summary>
    /// The entity (e.g. person, organization, clinical information system, or device) which is to be the source of the communication.
    /// </summary>
    public Reference Sender { get; set; }
    /// <summary>
    /// The status of the proposal or order.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// The patient who is the focus of this communication request.
    /// </summary>
    public Reference Subject { get; set; }
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


      ((fhirCsR2.Models.DomainResource)this).SerializeJson(writer, options, false);

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

      if (Category != null)
      {
        writer.WritePropertyName("category");
        Category.SerializeJson(writer, options);
      }

      if (Sender != null)
      {
        writer.WritePropertyName("sender");
        Sender.SerializeJson(writer, options);
      }

      if ((Recipient != null) && (Recipient.Count != 0))
      {
        writer.WritePropertyName("recipient");
        writer.WriteStartArray();

        foreach (Reference valRecipient in Recipient)
        {
          valRecipient.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Payload != null) && (Payload.Count != 0))
      {
        writer.WritePropertyName("payload");
        writer.WriteStartArray();

        foreach (CommunicationRequestPayload valPayload in Payload)
        {
          valPayload.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Medium != null) && (Medium.Count != 0))
      {
        writer.WritePropertyName("medium");
        writer.WriteStartArray();

        foreach (CodeableConcept valMedium in Medium)
        {
          valMedium.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Requester != null)
      {
        writer.WritePropertyName("requester");
        Requester.SerializeJson(writer, options);
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

      if (Encounter != null)
      {
        writer.WritePropertyName("encounter");
        Encounter.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(ScheduledDateTime))
      {
        writer.WriteString("scheduledDateTime", (string)ScheduledDateTime!);
      }

      if (_ScheduledDateTime != null)
      {
        writer.WritePropertyName("_scheduledDateTime");
        _ScheduledDateTime.SerializeJson(writer, options);
      }

      if (ScheduledPeriod != null)
      {
        writer.WritePropertyName("scheduledPeriod");
        ScheduledPeriod.SerializeJson(writer, options);
      }

      if ((Reason != null) && (Reason.Count != 0))
      {
        writer.WritePropertyName("reason");
        writer.WriteStartArray();

        foreach (CodeableConcept valReason in Reason)
        {
          valReason.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(RequestedOn))
      {
        writer.WriteString("requestedOn", (string)RequestedOn!);
      }

      if (_RequestedOn != null)
      {
        writer.WritePropertyName("_requestedOn");
        _RequestedOn.SerializeJson(writer, options);
      }

      if (Subject != null)
      {
        writer.WritePropertyName("subject");
        Subject.SerializeJson(writer, options);
      }

      if (Priority != null)
      {
        writer.WritePropertyName("priority");
        Priority.SerializeJson(writer, options);
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
          Category = new fhirCsR2.Models.CodeableConcept();
          Category.DeserializeJson(ref reader, options);
          break;

        case "encounter":
          Encounter = new fhirCsR2.Models.Reference();
          Encounter.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.Identifier objIdentifier = new fhirCsR2.Models.Identifier();
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

        case "medium":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Medium = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.CodeableConcept objMedium = new fhirCsR2.Models.CodeableConcept();
            objMedium.DeserializeJson(ref reader, options);
            Medium.Add(objMedium);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Medium.Count == 0)
          {
            Medium = null;
          }

          break;

        case "payload":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Payload = new List<CommunicationRequestPayload>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.CommunicationRequestPayload objPayload = new fhirCsR2.Models.CommunicationRequestPayload();
            objPayload.DeserializeJson(ref reader, options);
            Payload.Add(objPayload);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Payload.Count == 0)
          {
            Payload = null;
          }

          break;

        case "priority":
          Priority = new fhirCsR2.Models.CodeableConcept();
          Priority.DeserializeJson(ref reader, options);
          break;

        case "reason":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Reason = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.CodeableConcept objReason = new fhirCsR2.Models.CodeableConcept();
            objReason.DeserializeJson(ref reader, options);
            Reason.Add(objReason);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Reason.Count == 0)
          {
            Reason = null;
          }

          break;

        case "recipient":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Recipient = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.Reference objRecipient = new fhirCsR2.Models.Reference();
            objRecipient.DeserializeJson(ref reader, options);
            Recipient.Add(objRecipient);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Recipient.Count == 0)
          {
            Recipient = null;
          }

          break;

        case "requestedOn":
          RequestedOn = reader.GetString();
          break;

        case "_requestedOn":
          _RequestedOn = new fhirCsR2.Models.Element();
          _RequestedOn.DeserializeJson(ref reader, options);
          break;

        case "requester":
          Requester = new fhirCsR2.Models.Reference();
          Requester.DeserializeJson(ref reader, options);
          break;

        case "scheduledDateTime":
          ScheduledDateTime = reader.GetString();
          break;

        case "_scheduledDateTime":
          _ScheduledDateTime = new fhirCsR2.Models.Element();
          _ScheduledDateTime.DeserializeJson(ref reader, options);
          break;

        case "scheduledPeriod":
          ScheduledPeriod = new fhirCsR2.Models.Period();
          ScheduledPeriod.DeserializeJson(ref reader, options);
          break;

        case "sender":
          Sender = new fhirCsR2.Models.Reference();
          Sender.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR2.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "subject":
          Subject = new fhirCsR2.Models.Reference();
          Subject.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR2.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Code Values for the CommunicationRequest.status field
  /// </summary>
  public static class CommunicationRequestStatusCodes {
    public const string PROPOSED = "proposed";
    public const string PLANNED = "planned";
    public const string REQUESTED = "requested";
    public const string RECEIVED = "received";
    public const string ACCEPTED = "accepted";
    public const string IN_PROGRESS = "in-progress";
    public const string COMPLETED = "completed";
    public const string SUSPENDED = "suspended";
    public const string REJECTED = "rejected";
    public const string FAILED = "failed";
  }
}