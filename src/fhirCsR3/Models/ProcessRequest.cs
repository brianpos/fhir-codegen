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
  /// List of top level items to be re-adjudicated, if none specified then the entire submission is re-adjudicated.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<ProcessRequestItem>))]
  public class ProcessRequestItem : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// A service line number.
    /// </summary>
    public int SequenceLinkId { get; set; }
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

      writer.WriteNumber("sequenceLinkId", SequenceLinkId);

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
        case "sequenceLinkId":
          SequenceLinkId = reader.GetInt32();
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
  /// This resource provides the target, request and response, and action details for an action to be performed by the target on or about existing resources.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<ProcessRequest>))]
  public class ProcessRequest : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "ProcessRequest";
    /// <summary>
    /// The type of processing action being requested, for example Reversal, Readjudication, StatusRequest,PendedRequest.
    /// </summary>
    public string Action { get; set; }
    /// <summary>
    /// Extension container element for Action
    /// </summary>
    public Element _Action { get; set; }
    /// <summary>
    /// The date when this resource was created.
    /// </summary>
    public string Created { get; set; }
    /// <summary>
    /// Extension container element for Created
    /// </summary>
    public Element _Created { get; set; }
    /// <summary>
    /// Names of resource types to exclude.
    /// </summary>
    public List<string> Exclude { get; set; }
    /// <summary>
    /// Extension container element for Exclude
    /// </summary>
    public List<Element> _Exclude { get; set; }
    /// <summary>
    /// The ProcessRequest business identifier.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// Names of resource types to include.
    /// </summary>
    public List<string> Include { get; set; }
    /// <summary>
    /// Extension container element for Include
    /// </summary>
    public List<Element> _Include { get; set; }
    /// <summary>
    /// List of top level items to be re-adjudicated, if none specified then the entire submission is re-adjudicated.
    /// </summary>
    public List<ProcessRequestItem> Item { get; set; }
    /// <summary>
    /// If true remove all history excluding audit.
    /// </summary>
    public bool? Nullify { get; set; }
    /// <summary>
    /// The organization which is responsible for the action speccified in this request.
    /// </summary>
    public Reference Organization { get; set; }
    /// <summary>
    /// A period of time during which the fulfilling resources would have been created.
    /// </summary>
    public Period Period { get; set; }
    /// <summary>
    /// The practitioner who is responsible for the action specified in this request.
    /// </summary>
    public Reference Provider { get; set; }
    /// <summary>
    /// A reference to supply which authenticates the process.
    /// </summary>
    public string Reference { get; set; }
    /// <summary>
    /// Extension container element for Reference
    /// </summary>
    public Element _Reference { get; set; }
    /// <summary>
    /// Reference of resource which is the target or subject of this action.
    /// </summary>
    public Reference Request { get; set; }
    /// <summary>
    /// Reference of a prior response to resource which is the target or subject of this action.
    /// </summary>
    public Reference Response { get; set; }
    /// <summary>
    /// This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// The organization which is the target of the request.
    /// </summary>
    public Reference Target { get; set; }
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

      if (!string.IsNullOrEmpty(Action))
      {
        writer.WriteString("action", (string)Action!);
      }

      if (_Action != null)
      {
        writer.WritePropertyName("_action");
        _Action.SerializeJson(writer, options);
      }

      if (Target != null)
      {
        writer.WritePropertyName("target");
        Target.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Created))
      {
        writer.WriteString("created", (string)Created!);
      }

      if (_Created != null)
      {
        writer.WritePropertyName("_created");
        _Created.SerializeJson(writer, options);
      }

      if (Provider != null)
      {
        writer.WritePropertyName("provider");
        Provider.SerializeJson(writer, options);
      }

      if (Organization != null)
      {
        writer.WritePropertyName("organization");
        Organization.SerializeJson(writer, options);
      }

      if (Request != null)
      {
        writer.WritePropertyName("request");
        Request.SerializeJson(writer, options);
      }

      if (Response != null)
      {
        writer.WritePropertyName("response");
        Response.SerializeJson(writer, options);
      }

      if (Nullify != null)
      {
        writer.WriteBoolean("nullify", (bool)Nullify!);
      }

      if (!string.IsNullOrEmpty(Reference))
      {
        writer.WriteString("reference", (string)Reference!);
      }

      if (_Reference != null)
      {
        writer.WritePropertyName("_reference");
        _Reference.SerializeJson(writer, options);
      }

      if ((Item != null) && (Item.Count != 0))
      {
        writer.WritePropertyName("item");
        writer.WriteStartArray();

        foreach (ProcessRequestItem valItem in Item)
        {
          valItem.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Include != null) && (Include.Count != 0))
      {
        writer.WritePropertyName("include");
        writer.WriteStartArray();

        foreach (string valInclude in Include)
        {
          writer.WriteStringValue(valInclude);
        }

        writer.WriteEndArray();
      }

      if ((_Include != null) && (_Include.Count != 0))
      {
        writer.WritePropertyName("_include");
        writer.WriteStartArray();

        foreach (Element val_Include in _Include)
        {
          val_Include.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Exclude != null) && (Exclude.Count != 0))
      {
        writer.WritePropertyName("exclude");
        writer.WriteStartArray();

        foreach (string valExclude in Exclude)
        {
          writer.WriteStringValue(valExclude);
        }

        writer.WriteEndArray();
      }

      if ((_Exclude != null) && (_Exclude.Count != 0))
      {
        writer.WritePropertyName("_exclude");
        writer.WriteStartArray();

        foreach (Element val_Exclude in _Exclude)
        {
          val_Exclude.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Period != null)
      {
        writer.WritePropertyName("period");
        Period.SerializeJson(writer, options);
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
          Action = reader.GetString();
          break;

        case "_action":
          _Action = new fhirCsR3.Models.Element();
          _Action.DeserializeJson(ref reader, options);
          break;

        case "created":
          Created = reader.GetString();
          break;

        case "_created":
          _Created = new fhirCsR3.Models.Element();
          _Created.DeserializeJson(ref reader, options);
          break;

        case "exclude":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Exclude = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Exclude.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Exclude.Count == 0)
          {
            Exclude = null;
          }

          break;

        case "_exclude":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _Exclude = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Element obj_Exclude = new fhirCsR3.Models.Element();
            obj_Exclude.DeserializeJson(ref reader, options);
            _Exclude.Add(obj_Exclude);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_Exclude.Count == 0)
          {
            _Exclude = null;
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

        case "include":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Include = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Include.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Include.Count == 0)
          {
            Include = null;
          }

          break;

        case "_include":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _Include = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Element obj_Include = new fhirCsR3.Models.Element();
            obj_Include.DeserializeJson(ref reader, options);
            _Include.Add(obj_Include);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_Include.Count == 0)
          {
            _Include = null;
          }

          break;

        case "item":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Item = new List<ProcessRequestItem>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.ProcessRequestItem objItem = new fhirCsR3.Models.ProcessRequestItem();
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

        case "nullify":
          Nullify = reader.GetBoolean();
          break;

        case "organization":
          Organization = new fhirCsR3.Models.Reference();
          Organization.DeserializeJson(ref reader, options);
          break;

        case "period":
          Period = new fhirCsR3.Models.Period();
          Period.DeserializeJson(ref reader, options);
          break;

        case "provider":
          Provider = new fhirCsR3.Models.Reference();
          Provider.DeserializeJson(ref reader, options);
          break;

        case "reference":
          Reference = reader.GetString();
          break;

        case "_reference":
          _Reference = new fhirCsR3.Models.Element();
          _Reference.DeserializeJson(ref reader, options);
          break;

        case "request":
          Request = new fhirCsR3.Models.Reference();
          Request.DeserializeJson(ref reader, options);
          break;

        case "response":
          Response = new fhirCsR3.Models.Reference();
          Response.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR3.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "target":
          Target = new fhirCsR3.Models.Reference();
          Target.DeserializeJson(ref reader, options);
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
  /// Code Values for the ProcessRequest.action field
  /// </summary>
  public static class ProcessRequestActionCodes {
    public const string CANCEL = "cancel";
    public const string POLL = "poll";
    public const string REPROCESS = "reprocess";
    public const string STATUS = "status";
  }
  /// <summary>
  /// Code Values for the ProcessRequest.status field
  /// </summary>
  public static class ProcessRequestStatusCodes {
    public const string ACTIVE = "active";
    public const string CANCELLED = "cancelled";
    public const string DRAFT = "draft";
    public const string ENTERED_IN_ERROR = "entered-in-error";
  }
}