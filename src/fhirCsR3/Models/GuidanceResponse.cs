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
  /// A guidance response is the formal response to a guidance request, including any output parameters returned by the evaluation, as well as the description of any proposed actions to be taken.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<GuidanceResponse>))]
  public class GuidanceResponse : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "GuidanceResponse";
    /// <summary>
    /// Allows the context of the guidance response to be provided if available. In a service context, this would likely be unavailable.
    /// </summary>
    public Reference Context { get; set; }
    /// <summary>
    /// If the evaluation could not be completed due to lack of information, or additional information would potentially result in a more accurate response, this element will a description of the data required in order to proceed with the evaluation. A subsequent request to the service should include this data.
    /// </summary>
    public List<DataRequirement> DataRequirement { get; set; }
    /// <summary>
    /// Messages resulting from the evaluation of the artifact or artifacts. As part of evaluating the request, the engine may produce informational or warning messages. These messages will be provided by this element.
    /// </summary>
    public List<Reference> EvaluationMessage { get; set; }
    /// <summary>
    /// Allows a service to provide a unique, business identifier for the response.
    /// </summary>
    public Identifier Identifier { get; set; }
    /// <summary>
    /// A reference to the knowledge module that was invoked.
    /// </summary>
    public Reference Module { get; set; }
    /// <summary>
    /// Provides a mechanism to communicate additional information about the response.
    /// </summary>
    public List<Annotation> Note { get; set; }
    /// <summary>
    /// Indicates when the guidance response was processed.
    /// </summary>
    public string OccurrenceDateTime { get; set; }
    /// <summary>
    /// Extension container element for OccurrenceDateTime
    /// </summary>
    public Element _OccurrenceDateTime { get; set; }
    /// <summary>
    /// The output parameters of the evaluation, if any. Many modules will result in the return of specific resources such as procedure or communication requests that are returned as part of the operation result. However, modules may define specific outputs that would be returned as the result of the evaluation, and these would be returned in this element.
    /// </summary>
    public Reference OutputParameters { get; set; }
    /// <summary>
    /// Provides a reference to the device that performed the guidance.
    /// </summary>
    public Reference Performer { get; set; }
    /// <summary>
    /// Indicates the reason the request was initiated. This is typically provided as a parameter to the evaluation and echoed by the service, although for some use cases, such as subscription- or event-based scenarios, it may provide an indication of the cause for the response.
    /// </summary>
    public CodeableConcept ReasonCodeableConcept { get; set; }
    /// <summary>
    /// Indicates the reason the request was initiated. This is typically provided as a parameter to the evaluation and echoed by the service, although for some use cases, such as subscription- or event-based scenarios, it may provide an indication of the cause for the response.
    /// </summary>
    public Reference ReasonReference { get; set; }
    /// <summary>
    /// The id of the request associated with this response. If an id was given as part of the request, it will be reproduced here to enable the requester to more easily identify the response in a multi-request scenario.
    /// </summary>
    public string RequestId { get; set; }
    /// <summary>
    /// Extension container element for RequestId
    /// </summary>
    public Element _RequestId { get; set; }
    /// <summary>
    /// The actions, if any, produced by the evaluation of the artifact.
    /// </summary>
    public Reference Result { get; set; }
    /// <summary>
    /// This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// The patient for which the request was processed.
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


      ((fhirCsR3.Models.DomainResource)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(RequestId))
      {
        writer.WriteString("requestId", (string)RequestId!);
      }

      if (_RequestId != null)
      {
        writer.WritePropertyName("_requestId");
        _RequestId.SerializeJson(writer, options);
      }

      if (Identifier != null)
      {
        writer.WritePropertyName("identifier");
        Identifier.SerializeJson(writer, options);
      }

      if (Module != null)
      {
        writer.WritePropertyName("module");
        Module.SerializeJson(writer, options);
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

      if (Context != null)
      {
        writer.WritePropertyName("context");
        Context.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(OccurrenceDateTime))
      {
        writer.WriteString("occurrenceDateTime", (string)OccurrenceDateTime!);
      }

      if (_OccurrenceDateTime != null)
      {
        writer.WritePropertyName("_occurrenceDateTime");
        _OccurrenceDateTime.SerializeJson(writer, options);
      }

      if (Performer != null)
      {
        writer.WritePropertyName("performer");
        Performer.SerializeJson(writer, options);
      }

      if (ReasonCodeableConcept != null)
      {
        writer.WritePropertyName("reasonCodeableConcept");
        ReasonCodeableConcept.SerializeJson(writer, options);
      }

      if (ReasonReference != null)
      {
        writer.WritePropertyName("reasonReference");
        ReasonReference.SerializeJson(writer, options);
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

      if ((EvaluationMessage != null) && (EvaluationMessage.Count != 0))
      {
        writer.WritePropertyName("evaluationMessage");
        writer.WriteStartArray();

        foreach (Reference valEvaluationMessage in EvaluationMessage)
        {
          valEvaluationMessage.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (OutputParameters != null)
      {
        writer.WritePropertyName("outputParameters");
        OutputParameters.SerializeJson(writer, options);
      }

      if (Result != null)
      {
        writer.WritePropertyName("result");
        Result.SerializeJson(writer, options);
      }

      if ((DataRequirement != null) && (DataRequirement.Count != 0))
      {
        writer.WritePropertyName("dataRequirement");
        writer.WriteStartArray();

        foreach (DataRequirement valDataRequirement in DataRequirement)
        {
          valDataRequirement.SerializeJson(writer, options, true);
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
        case "context":
          Context = new fhirCsR3.Models.Reference();
          Context.DeserializeJson(ref reader, options);
          break;

        case "dataRequirement":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          DataRequirement = new List<DataRequirement>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.DataRequirement objDataRequirement = new fhirCsR3.Models.DataRequirement();
            objDataRequirement.DeserializeJson(ref reader, options);
            DataRequirement.Add(objDataRequirement);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (DataRequirement.Count == 0)
          {
            DataRequirement = null;
          }

          break;

        case "evaluationMessage":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          EvaluationMessage = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Reference objEvaluationMessage = new fhirCsR3.Models.Reference();
            objEvaluationMessage.DeserializeJson(ref reader, options);
            EvaluationMessage.Add(objEvaluationMessage);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (EvaluationMessage.Count == 0)
          {
            EvaluationMessage = null;
          }

          break;

        case "identifier":
          Identifier = new fhirCsR3.Models.Identifier();
          Identifier.DeserializeJson(ref reader, options);
          break;

        case "module":
          Module = new fhirCsR3.Models.Reference();
          Module.DeserializeJson(ref reader, options);
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

        case "occurrenceDateTime":
          OccurrenceDateTime = reader.GetString();
          break;

        case "_occurrenceDateTime":
          _OccurrenceDateTime = new fhirCsR3.Models.Element();
          _OccurrenceDateTime.DeserializeJson(ref reader, options);
          break;

        case "outputParameters":
          OutputParameters = new fhirCsR3.Models.Reference();
          OutputParameters.DeserializeJson(ref reader, options);
          break;

        case "performer":
          Performer = new fhirCsR3.Models.Reference();
          Performer.DeserializeJson(ref reader, options);
          break;

        case "reasonCodeableConcept":
          ReasonCodeableConcept = new fhirCsR3.Models.CodeableConcept();
          ReasonCodeableConcept.DeserializeJson(ref reader, options);
          break;

        case "reasonReference":
          ReasonReference = new fhirCsR3.Models.Reference();
          ReasonReference.DeserializeJson(ref reader, options);
          break;

        case "requestId":
          RequestId = reader.GetString();
          break;

        case "_requestId":
          _RequestId = new fhirCsR3.Models.Element();
          _RequestId.DeserializeJson(ref reader, options);
          break;

        case "result":
          Result = new fhirCsR3.Models.Reference();
          Result.DeserializeJson(ref reader, options);
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
  /// Code Values for the GuidanceResponse.status field
  /// </summary>
  public static class GuidanceResponseStatusCodes {
    public const string SUCCESS = "success";
    public const string DATA_REQUESTED = "data-requested";
    public const string DATA_REQUIRED = "data-required";
    public const string IN_PROGRESS = "in-progress";
    public const string FAILURE = "failure";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public static HashSet<string> Values = new HashSet<string>() {
      "success",
      "data-requested",
      "data-required",
      "in-progress",
      "failure",
      "entered-in-error",
    };
  }
}
