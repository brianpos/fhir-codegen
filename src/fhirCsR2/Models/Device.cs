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
  /// This resource identifies an instance of a manufactured item that is used in the provision of healthcare without being substantially changed through that activity. The device may be a medical or non-medical device.  Medical devices includes durable (reusable) medical equipment, implantable devices, as well as disposable equipment used for diagnostic, treatment, and research for healthcare and public health.  Non-medical devices may include items such as a machine, cellphone, computer, application, etc.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<Device>))]
  public class Device : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "Device";
    /// <summary>
    /// Contact details for an organization or a particular human that is responsible for the device.
    /// </summary>
    public List<ContactPoint> Contact { get; set; }
    /// <summary>
    /// The date and time beyond which this device is no longer valid or should not be used (if applicable).
    /// </summary>
    public string Expiry { get; set; }
    /// <summary>
    /// Extension container element for Expiry
    /// </summary>
    public Element _Expiry { get; set; }
    /// <summary>
    /// Unique instance identifiers assigned to a device by organizations like manufacturers or owners. If the identifier identifies the type of device, Device.type should be used.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// The place where the device can be found.
    /// </summary>
    public Reference Location { get; set; }
    /// <summary>
    /// Lot number assigned by the manufacturer.
    /// </summary>
    public string LotNumber { get; set; }
    /// <summary>
    /// Extension container element for LotNumber
    /// </summary>
    public Element _LotNumber { get; set; }
    /// <summary>
    /// The date and time when the device was manufactured.
    /// </summary>
    public string ManufactureDate { get; set; }
    /// <summary>
    /// Extension container element for ManufactureDate
    /// </summary>
    public Element _ManufactureDate { get; set; }
    /// <summary>
    /// A name of the manufacturer.
    /// </summary>
    public string Manufacturer { get; set; }
    /// <summary>
    /// Extension container element for Manufacturer
    /// </summary>
    public Element _Manufacturer { get; set; }
    /// <summary>
    /// The "model" is an identifier assigned by the manufacturer to identify the product by its type. This number is shared by the all devices sold as the same type.
    /// </summary>
    public string Model { get; set; }
    /// <summary>
    /// Extension container element for Model
    /// </summary>
    public Element _Model { get; set; }
    /// <summary>
    /// Descriptive information, usage information or implantation information that is not captured in an existing element.
    /// </summary>
    public List<Annotation> Note { get; set; }
    /// <summary>
    /// An organization that is responsible for the provision and ongoing maintenance of the device.
    /// </summary>
    public Reference Owner { get; set; }
    /// <summary>
    /// Patient information, if the resource is affixed to a person.
    /// </summary>
    public Reference Patient { get; set; }
    /// <summary>
    /// Status of the Device availability.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// Code or identifier to identify a kind of device.
    /// </summary>
    public CodeableConcept Type { get; set; }
    /// <summary>
    /// United States Food and Drug Administration mandated Unique Device Identifier (UDI). Use the human readable information (the content that the user sees, which is sometimes different to the exact syntax represented in the barcode)  - see http://www.fda.gov/MedicalDevices/DeviceRegulationandGuidance/UniqueDeviceIdentification/default.htm.
    /// </summary>
    public string Udi { get; set; }
    /// <summary>
    /// Extension container element for Udi
    /// </summary>
    public Element _Udi { get; set; }
    /// <summary>
    /// A network address on which the device may be contacted directly.
    /// </summary>
    public string Url { get; set; }
    /// <summary>
    /// Extension container element for Url
    /// </summary>
    public Element _Url { get; set; }
    /// <summary>
    /// The version of the device, if the device has multiple releases under the same model, or if the device is software or carries firmware.
    /// </summary>
    public string Version { get; set; }
    /// <summary>
    /// Extension container element for Version
    /// </summary>
    public Element _Version { get; set; }
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

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
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

      if (!string.IsNullOrEmpty(Status))
      {
        writer.WriteString("status", (string)Status!);
      }

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Manufacturer))
      {
        writer.WriteString("manufacturer", (string)Manufacturer!);
      }

      if (_Manufacturer != null)
      {
        writer.WritePropertyName("_manufacturer");
        _Manufacturer.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Model))
      {
        writer.WriteString("model", (string)Model!);
      }

      if (_Model != null)
      {
        writer.WritePropertyName("_model");
        _Model.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Version))
      {
        writer.WriteString("version", (string)Version!);
      }

      if (_Version != null)
      {
        writer.WritePropertyName("_version");
        _Version.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(ManufactureDate))
      {
        writer.WriteString("manufactureDate", (string)ManufactureDate!);
      }

      if (_ManufactureDate != null)
      {
        writer.WritePropertyName("_manufactureDate");
        _ManufactureDate.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Expiry))
      {
        writer.WriteString("expiry", (string)Expiry!);
      }

      if (_Expiry != null)
      {
        writer.WritePropertyName("_expiry");
        _Expiry.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Udi))
      {
        writer.WriteString("udi", (string)Udi!);
      }

      if (_Udi != null)
      {
        writer.WritePropertyName("_udi");
        _Udi.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(LotNumber))
      {
        writer.WriteString("lotNumber", (string)LotNumber!);
      }

      if (_LotNumber != null)
      {
        writer.WritePropertyName("_lotNumber");
        _LotNumber.SerializeJson(writer, options);
      }

      if (Owner != null)
      {
        writer.WritePropertyName("owner");
        Owner.SerializeJson(writer, options);
      }

      if (Location != null)
      {
        writer.WritePropertyName("location");
        Location.SerializeJson(writer, options);
      }

      if (Patient != null)
      {
        writer.WritePropertyName("patient");
        Patient.SerializeJson(writer, options);
      }

      if ((Contact != null) && (Contact.Count != 0))
      {
        writer.WritePropertyName("contact");
        writer.WriteStartArray();

        foreach (ContactPoint valContact in Contact)
        {
          valContact.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Url))
      {
        writer.WriteString("url", (string)Url!);
      }

      if (_Url != null)
      {
        writer.WritePropertyName("_url");
        _Url.SerializeJson(writer, options);
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
        case "contact":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Contact = new List<ContactPoint>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.ContactPoint objContact = new fhirCsR2.Models.ContactPoint();
            objContact.DeserializeJson(ref reader, options);
            Contact.Add(objContact);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Contact.Count == 0)
          {
            Contact = null;
          }

          break;

        case "expiry":
          Expiry = reader.GetString();
          break;

        case "_expiry":
          _Expiry = new fhirCsR2.Models.Element();
          _Expiry.DeserializeJson(ref reader, options);
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

        case "location":
          Location = new fhirCsR2.Models.Reference();
          Location.DeserializeJson(ref reader, options);
          break;

        case "lotNumber":
          LotNumber = reader.GetString();
          break;

        case "_lotNumber":
          _LotNumber = new fhirCsR2.Models.Element();
          _LotNumber.DeserializeJson(ref reader, options);
          break;

        case "manufactureDate":
          ManufactureDate = reader.GetString();
          break;

        case "_manufactureDate":
          _ManufactureDate = new fhirCsR2.Models.Element();
          _ManufactureDate.DeserializeJson(ref reader, options);
          break;

        case "manufacturer":
          Manufacturer = reader.GetString();
          break;

        case "_manufacturer":
          _Manufacturer = new fhirCsR2.Models.Element();
          _Manufacturer.DeserializeJson(ref reader, options);
          break;

        case "model":
          Model = reader.GetString();
          break;

        case "_model":
          _Model = new fhirCsR2.Models.Element();
          _Model.DeserializeJson(ref reader, options);
          break;

        case "note":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Note = new List<Annotation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.Annotation objNote = new fhirCsR2.Models.Annotation();
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

        case "owner":
          Owner = new fhirCsR2.Models.Reference();
          Owner.DeserializeJson(ref reader, options);
          break;

        case "patient":
          Patient = new fhirCsR2.Models.Reference();
          Patient.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR2.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = new fhirCsR2.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
          break;

        case "udi":
          Udi = reader.GetString();
          break;

        case "_udi":
          _Udi = new fhirCsR2.Models.Element();
          _Udi.DeserializeJson(ref reader, options);
          break;

        case "url":
          Url = reader.GetString();
          break;

        case "_url":
          _Url = new fhirCsR2.Models.Element();
          _Url.DeserializeJson(ref reader, options);
          break;

        case "version":
          Version = reader.GetString();
          break;

        case "_version":
          _Version = new fhirCsR2.Models.Element();
          _Version.DeserializeJson(ref reader, options);
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
  /// Code Values for the Device.status field
  /// </summary>
  public static class DeviceStatusCodes {
    public const string AVAILABLE = "available";
    public const string NOT_AVAILABLE = "not-available";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public static HashSet<string> Values = new HashSet<string>() {
      "available",
      "not-available",
      "entered-in-error",
    };
  }
}
