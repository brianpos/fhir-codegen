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
  /// List of individual settlement amounts and the corresponding transaction.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<PaymentReconciliationDetail>))]
  public class PaymentReconciliationDetail : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Amount paid for this detail.
    /// </summary>
    public Quantity Amount { get; set; }
    /// <summary>
    /// The date of the invoice or financial resource.
    /// </summary>
    public string Date { get; set; }
    /// <summary>
    /// Extension container element for Date
    /// </summary>
    public Element _Date { get; set; }
    /// <summary>
    /// The organization which is receiving the payment.
    /// </summary>
    public Reference Payee { get; set; }
    /// <summary>
    /// The claim or financial resource.
    /// </summary>
    public Reference Request { get; set; }
    /// <summary>
    /// The claim response resource.
    /// </summary>
    public Reference Responce { get; set; }
    /// <summary>
    /// The Organization which submitted the invoice or financial transaction.
    /// </summary>
    public Reference Submitter { get; set; }
    /// <summary>
    /// Code to indicate the nature of the payment, adjustment, funds advance, etc.
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
      ((fhirCsR2.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
      }

      if (Request != null)
      {
        writer.WritePropertyName("request");
        Request.SerializeJson(writer, options);
      }

      if (Responce != null)
      {
        writer.WritePropertyName("responce");
        Responce.SerializeJson(writer, options);
      }

      if (Submitter != null)
      {
        writer.WritePropertyName("submitter");
        Submitter.SerializeJson(writer, options);
      }

      if (Payee != null)
      {
        writer.WritePropertyName("payee");
        Payee.SerializeJson(writer, options);
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

      if (Amount != null)
      {
        writer.WritePropertyName("amount");
        Amount.SerializeJson(writer, options);
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
        case "amount":
          Amount = new fhirCsR2.Models.Quantity();
          Amount.DeserializeJson(ref reader, options);
          break;

        case "date":
          Date = reader.GetString();
          break;

        case "_date":
          _Date = new fhirCsR2.Models.Element();
          _Date.DeserializeJson(ref reader, options);
          break;

        case "payee":
          Payee = new fhirCsR2.Models.Reference();
          Payee.DeserializeJson(ref reader, options);
          break;

        case "request":
          Request = new fhirCsR2.Models.Reference();
          Request.DeserializeJson(ref reader, options);
          break;

        case "responce":
          Responce = new fhirCsR2.Models.Reference();
          Responce.DeserializeJson(ref reader, options);
          break;

        case "submitter":
          Submitter = new fhirCsR2.Models.Reference();
          Submitter.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = new fhirCsR2.Models.Coding();
          Type.DeserializeJson(ref reader, options);
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
  /// Suite of notes.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<PaymentReconciliationNote>))]
  public class PaymentReconciliationNote : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The note text.
    /// </summary>
    public string Text { get; set; }
    /// <summary>
    /// Extension container element for Text
    /// </summary>
    public Element _Text { get; set; }
    /// <summary>
    /// The note purpose: Print/Display.
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
      ((fhirCsR2.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Text))
      {
        writer.WriteString("text", (string)Text!);
      }

      if (_Text != null)
      {
        writer.WritePropertyName("_text");
        _Text.SerializeJson(writer, options);
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
        case "text":
          Text = reader.GetString();
          break;

        case "_text":
          _Text = new fhirCsR2.Models.Element();
          _Text.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = new fhirCsR2.Models.Coding();
          Type.DeserializeJson(ref reader, options);
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
  /// This resource provides payment details and claim references supporting a bulk payment.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<PaymentReconciliation>))]
  public class PaymentReconciliation : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "PaymentReconciliation";
    /// <summary>
    /// The date when the enclosed suite of services were performed or completed.
    /// </summary>
    public string Created { get; set; }
    /// <summary>
    /// Extension container element for Created
    /// </summary>
    public Element _Created { get; set; }
    /// <summary>
    /// List of individual settlement amounts and the corresponding transaction.
    /// </summary>
    public List<PaymentReconciliationDetail> Detail { get; set; }
    /// <summary>
    /// A description of the status of the adjudication.
    /// </summary>
    public string Disposition { get; set; }
    /// <summary>
    /// Extension container element for Disposition
    /// </summary>
    public Element _Disposition { get; set; }
    /// <summary>
    /// The form to be used for printing the content.
    /// </summary>
    public Coding Form { get; set; }
    /// <summary>
    /// The Response business identifier.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// Suite of notes.
    /// </summary>
    public List<PaymentReconciliationNote> Note { get; set; }
    /// <summary>
    /// The Insurer who produced this adjudicated response.
    /// </summary>
    public Reference Organization { get; set; }
    /// <summary>
    /// Knowledge of the original version can inform the processing of this instance so that information which is processable by the originating system may be generated.
    /// </summary>
    public Coding OriginalRuleset { get; set; }
    /// <summary>
    /// Transaction status: error, complete.
    /// </summary>
    public string Outcome { get; set; }
    /// <summary>
    /// Extension container element for Outcome
    /// </summary>
    public Element _Outcome { get; set; }
    /// <summary>
    /// The period of time for which payments have been gathered into this bulk payment for settlement.
    /// </summary>
    public Period Period { get; set; }
    /// <summary>
    /// Original request resource reference.
    /// </summary>
    public Reference Request { get; set; }
    /// <summary>
    /// The organization which is responsible for the services rendered to the patient.
    /// </summary>
    public Reference RequestOrganization { get; set; }
    /// <summary>
    /// The practitioner who is responsible for the services rendered to the patient.
    /// </summary>
    public Reference RequestProvider { get; set; }
    /// <summary>
    /// The version of the style of resource contents. This should be mapped to the allowable profiles for this and supporting resources.
    /// </summary>
    public Coding Ruleset { get; set; }
    /// <summary>
    /// Total payment amount.
    /// </summary>
    public Quantity Total { get; set; }
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

      if (Request != null)
      {
        writer.WritePropertyName("request");
        Request.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Outcome))
      {
        writer.WriteString("outcome", (string)Outcome!);
      }

      if (_Outcome != null)
      {
        writer.WritePropertyName("_outcome");
        _Outcome.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Disposition))
      {
        writer.WriteString("disposition", (string)Disposition!);
      }

      if (_Disposition != null)
      {
        writer.WritePropertyName("_disposition");
        _Disposition.SerializeJson(writer, options);
      }

      if (Ruleset != null)
      {
        writer.WritePropertyName("ruleset");
        Ruleset.SerializeJson(writer, options);
      }

      if (OriginalRuleset != null)
      {
        writer.WritePropertyName("originalRuleset");
        OriginalRuleset.SerializeJson(writer, options);
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

      if (Period != null)
      {
        writer.WritePropertyName("period");
        Period.SerializeJson(writer, options);
      }

      if (Organization != null)
      {
        writer.WritePropertyName("organization");
        Organization.SerializeJson(writer, options);
      }

      if (RequestProvider != null)
      {
        writer.WritePropertyName("requestProvider");
        RequestProvider.SerializeJson(writer, options);
      }

      if (RequestOrganization != null)
      {
        writer.WritePropertyName("requestOrganization");
        RequestOrganization.SerializeJson(writer, options);
      }

      if ((Detail != null) && (Detail.Count != 0))
      {
        writer.WritePropertyName("detail");
        writer.WriteStartArray();

        foreach (PaymentReconciliationDetail valDetail in Detail)
        {
          valDetail.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Form != null)
      {
        writer.WritePropertyName("form");
        Form.SerializeJson(writer, options);
      }

      if (Total != null)
      {
        writer.WritePropertyName("total");
        Total.SerializeJson(writer, options);
      }

      if ((Note != null) && (Note.Count != 0))
      {
        writer.WritePropertyName("note");
        writer.WriteStartArray();

        foreach (PaymentReconciliationNote valNote in Note)
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
        case "created":
          Created = reader.GetString();
          break;

        case "_created":
          _Created = new fhirCsR2.Models.Element();
          _Created.DeserializeJson(ref reader, options);
          break;

        case "detail":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Detail = new List<PaymentReconciliationDetail>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.PaymentReconciliationDetail objDetail = new fhirCsR2.Models.PaymentReconciliationDetail();
            objDetail.DeserializeJson(ref reader, options);
            Detail.Add(objDetail);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Detail.Count == 0)
          {
            Detail = null;
          }

          break;

        case "disposition":
          Disposition = reader.GetString();
          break;

        case "_disposition":
          _Disposition = new fhirCsR2.Models.Element();
          _Disposition.DeserializeJson(ref reader, options);
          break;

        case "form":
          Form = new fhirCsR2.Models.Coding();
          Form.DeserializeJson(ref reader, options);
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

        case "note":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Note = new List<PaymentReconciliationNote>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.PaymentReconciliationNote objNote = new fhirCsR2.Models.PaymentReconciliationNote();
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

        case "organization":
          Organization = new fhirCsR2.Models.Reference();
          Organization.DeserializeJson(ref reader, options);
          break;

        case "originalRuleset":
          OriginalRuleset = new fhirCsR2.Models.Coding();
          OriginalRuleset.DeserializeJson(ref reader, options);
          break;

        case "outcome":
          Outcome = reader.GetString();
          break;

        case "_outcome":
          _Outcome = new fhirCsR2.Models.Element();
          _Outcome.DeserializeJson(ref reader, options);
          break;

        case "period":
          Period = new fhirCsR2.Models.Period();
          Period.DeserializeJson(ref reader, options);
          break;

        case "request":
          Request = new fhirCsR2.Models.Reference();
          Request.DeserializeJson(ref reader, options);
          break;

        case "requestOrganization":
          RequestOrganization = new fhirCsR2.Models.Reference();
          RequestOrganization.DeserializeJson(ref reader, options);
          break;

        case "requestProvider":
          RequestProvider = new fhirCsR2.Models.Reference();
          RequestProvider.DeserializeJson(ref reader, options);
          break;

        case "ruleset":
          Ruleset = new fhirCsR2.Models.Coding();
          Ruleset.DeserializeJson(ref reader, options);
          break;

        case "total":
          Total = new fhirCsR2.Models.Quantity();
          Total.DeserializeJson(ref reader, options);
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
  /// Code Values for the PaymentReconciliation.outcome field
  /// </summary>
  public static class PaymentReconciliationOutcomeCodes {
    public const string COMPLETE = "complete";
    public const string ERROR = "error";
  }
}