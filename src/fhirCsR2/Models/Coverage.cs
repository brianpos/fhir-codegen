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
  /// Financial instrument which may be used to pay for or reimburse health care products and services.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<Coverage>))]
  public class Coverage : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "Coverage";
    /// <summary>
    /// Business Identification Number (BIN number) used to identify the routing  of eclaims if the insurer themselves don't have a BIN number for all of their business.
    /// </summary>
    public Identifier Bin { get; set; }
    /// <summary>
    /// The policy(s) which constitute this insurance coverage.
    /// </summary>
    public List<Reference> Contract { get; set; }
    /// <summary>
    /// For some coverage a single identifier is issued to the PolicyHolder and dependent number issues to each to each of their dependents to track and manage the plan.
    /// </summary>
    public uint? Dependent { get; set; }
    /// <summary>
    /// Identifies a style or collective of coverage issues by the underwriter, for example may be used to identify a class of coverage or employer group. May also be referred to as a Policy or Group ID.
    /// </summary>
    public string Group { get; set; }
    /// <summary>
    /// Extension container element for Group
    /// </summary>
    public Element _Group { get; set; }
    /// <summary>
    /// This value may uniquely identify the coverage or it may be used in conjunction with the additional identifiers below.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// Need to identify the issuer to target for processing and for coordination of benefit processing.
    /// </summary>
    public Reference Issuer { get; set; }
    /// <summary>
    /// The identifier for a community of providers.
    /// </summary>
    public Identifier Network { get; set; }
    /// <summary>
    /// Time period during which the coverage is in force. A missing start date indicates the start date isn't known, a missing end date means the coverage is continuing to be in force.
    /// </summary>
    public Period Period { get; set; }
    /// <summary>
    /// Identifies a style or collective of coverage issues by the underwriter, for example may be used to identify a class of coverage or employer group. May also be referred to as a Policy or Group ID.
    /// </summary>
    public string Plan { get; set; }
    /// <summary>
    /// Extension container element for Plan
    /// </summary>
    public Element _Plan { get; set; }
    /// <summary>
    /// Some coverage, for example social plans, may be offered in short time increments, for example for a week or a month at a time, so while the rest of the plan details and identifiers may remain constant over time, the instance is incremented with each renewal and provided to the covered party on their 'card'.
    /// </summary>
    public uint? Sequence { get; set; }
    /// <summary>
    /// Identifies a sub-style or sub-collective of coverage issues by the underwriter, for example may be used to identify a specific employer group within a class of employers. May be referred to as a Section or Division ID.
    /// </summary>
    public string SubPlan { get; set; }
    /// <summary>
    /// Extension container element for SubPlan
    /// </summary>
    public Element _SubPlan { get; set; }
    /// <summary>
    /// The party who 'owns' the insurance contractual relationship to the policy or to whom the benefit of the policy is due.
    /// </summary>
    public Reference Subscriber { get; set; }
    /// <summary>
    /// The id issued to the subscriber.
    /// </summary>
    public Identifier SubscriberId { get; set; }
    /// <summary>
    /// The order of application of coverages is dependent on the types of coverage.
    /// </summary>
    public Coding Type { get; set; }
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

      if (Issuer != null)
      {
        writer.WritePropertyName("issuer");
        Issuer.SerializeJson(writer, options);
      }

      if (Bin != null)
      {
        writer.WritePropertyName("bin");
        Bin.SerializeJson(writer, options);
      }

      if (Period != null)
      {
        writer.WritePropertyName("period");
        Period.SerializeJson(writer, options);
      }

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
      }

      if (SubscriberId != null)
      {
        writer.WritePropertyName("subscriberId");
        SubscriberId.SerializeJson(writer, options);
      }

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

      if (!string.IsNullOrEmpty(Group))
      {
        writer.WriteString("group", (string)Group!);
      }

      if (_Group != null)
      {
        writer.WritePropertyName("_group");
        _Group.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Plan))
      {
        writer.WriteString("plan", (string)Plan!);
      }

      if (_Plan != null)
      {
        writer.WritePropertyName("_plan");
        _Plan.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(SubPlan))
      {
        writer.WriteString("subPlan", (string)SubPlan!);
      }

      if (_SubPlan != null)
      {
        writer.WritePropertyName("_subPlan");
        _SubPlan.SerializeJson(writer, options);
      }

      if (Dependent != null)
      {
        writer.WriteNumber("dependent", (uint)Dependent!);
      }

      if (Sequence != null)
      {
        writer.WriteNumber("sequence", (uint)Sequence!);
      }

      if (Subscriber != null)
      {
        writer.WritePropertyName("subscriber");
        Subscriber.SerializeJson(writer, options);
      }

      if (Network != null)
      {
        writer.WritePropertyName("network");
        Network.SerializeJson(writer, options);
      }

      if ((Contract != null) && (Contract.Count != 0))
      {
        writer.WritePropertyName("contract");
        writer.WriteStartArray();

        foreach (Reference valContract in Contract)
        {
          valContract.SerializeJson(writer, options, true);
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
        case "bin":
          Bin = new fhirCsR2.Models.Identifier();
          Bin.DeserializeJson(ref reader, options);
          break;

        case "contract":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Contract = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.Reference objContract = new fhirCsR2.Models.Reference();
            objContract.DeserializeJson(ref reader, options);
            Contract.Add(objContract);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Contract.Count == 0)
          {
            Contract = null;
          }

          break;

        case "dependent":
          Dependent = reader.GetUInt32();
          break;

        case "group":
          Group = reader.GetString();
          break;

        case "_group":
          _Group = new fhirCsR2.Models.Element();
          _Group.DeserializeJson(ref reader, options);
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

        case "issuer":
          Issuer = new fhirCsR2.Models.Reference();
          Issuer.DeserializeJson(ref reader, options);
          break;

        case "network":
          Network = new fhirCsR2.Models.Identifier();
          Network.DeserializeJson(ref reader, options);
          break;

        case "period":
          Period = new fhirCsR2.Models.Period();
          Period.DeserializeJson(ref reader, options);
          break;

        case "plan":
          Plan = reader.GetString();
          break;

        case "_plan":
          _Plan = new fhirCsR2.Models.Element();
          _Plan.DeserializeJson(ref reader, options);
          break;

        case "sequence":
          Sequence = reader.GetUInt32();
          break;

        case "subPlan":
          SubPlan = reader.GetString();
          break;

        case "_subPlan":
          _SubPlan = new fhirCsR2.Models.Element();
          _SubPlan.DeserializeJson(ref reader, options);
          break;

        case "subscriber":
          Subscriber = new fhirCsR2.Models.Reference();
          Subscriber.DeserializeJson(ref reader, options);
          break;

        case "subscriberId":
          SubscriberId = new fhirCsR2.Models.Identifier();
          SubscriberId.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = new fhirCsR2.Models.Coding();
          Type.DeserializeJson(ref reader, options);
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
}
