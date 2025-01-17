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
  /// Identifies a specification (other than a terminology) that the elements which make up the DataElement have some correspondence with.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<DataElementMapping>))]
  public class DataElementMapping : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Comments about this mapping, including version notes, issues, scope limitations, and other important notes for usage.
    /// </summary>
    public string Comment { get; set; }
    /// <summary>
    /// Extension container element for Comment
    /// </summary>
    public Element _Comment { get; set; }
    /// <summary>
    /// The specification is described once, with general comments, and then specific mappings are made that reference this declaration.
    /// </summary>
    public string Identity { get; set; }
    /// <summary>
    /// Extension container element for Identity
    /// </summary>
    public Element _Identity { get; set; }
    /// <summary>
    /// A name for the specification that is being mapped to.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Extension container element for Name
    /// </summary>
    public Element _Name { get; set; }
    /// <summary>
    /// A formal identity for the specification being mapped to helps with identifying maps consistently.
    /// </summary>
    public string Uri { get; set; }
    /// <summary>
    /// Extension container element for Uri
    /// </summary>
    public Element _Uri { get; set; }
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

      if (!string.IsNullOrEmpty(Identity))
      {
        writer.WriteString("identity", (string)Identity!);
      }

      if (_Identity != null)
      {
        writer.WritePropertyName("_identity");
        _Identity.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Uri))
      {
        writer.WriteString("uri", (string)Uri!);
      }

      if (_Uri != null)
      {
        writer.WritePropertyName("_uri");
        _Uri.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Name))
      {
        writer.WriteString("name", (string)Name!);
      }

      if (_Name != null)
      {
        writer.WritePropertyName("_name");
        _Name.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Comment))
      {
        writer.WriteString("comment", (string)Comment!);
      }

      if (_Comment != null)
      {
        writer.WritePropertyName("_comment");
        _Comment.SerializeJson(writer, options);
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
        case "comment":
          Comment = reader.GetString();
          break;

        case "_comment":
          _Comment = new fhirCsR3.Models.Element();
          _Comment.DeserializeJson(ref reader, options);
          break;

        case "identity":
          Identity = reader.GetString();
          break;

        case "_identity":
          _Identity = new fhirCsR3.Models.Element();
          _Identity.DeserializeJson(ref reader, options);
          break;

        case "name":
          Name = reader.GetString();
          break;

        case "_name":
          _Name = new fhirCsR3.Models.Element();
          _Name.DeserializeJson(ref reader, options);
          break;

        case "uri":
          Uri = reader.GetString();
          break;

        case "_uri":
          _Uri = new fhirCsR3.Models.Element();
          _Uri.DeserializeJson(ref reader, options);
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
  /// The formal description of a single piece of information that can be gathered and reported.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<DataElement>))]
  public class DataElement : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "DataElement";
    /// <summary>
    /// May be a web site, an email address, a telephone number, etc.
    /// </summary>
    public List<ContactDetail> Contact { get; set; }
    /// <summary>
    /// null The copyright statement does not apply to values for the data element, only to its definition.
    /// </summary>
    public string Copyright { get; set; }
    /// <summary>
    /// Extension container element for Copyright
    /// </summary>
    public Element _Copyright { get; set; }
    /// <summary>
    /// Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the data element. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.
    /// </summary>
    public string Date { get; set; }
    /// <summary>
    /// Extension container element for Date
    /// </summary>
    public Element _Date { get; set; }
    /// <summary>
    /// For simple data types there will only be one repetition.  For complex data types, multiple repetitions will be present defining a nested structure using the "path" element.
    /// </summary>
    public List<ElementDefinition> Element { get; set; }
    /// <summary>
    /// Allows filtering of data element that are appropriate for use vs. not. This is labeled as "Is Modifier" because applications should not use an experimental data element in production.
    /// </summary>
    public bool? Experimental { get; set; }
    /// <summary>
    /// Extension container element for Experimental
    /// </summary>
    public Element _Experimental { get; set; }
    /// <summary>
    /// Typically, this is used for identifiers that can go in an HL7 V3 II (instance identifier) data type, e.g., to identify this data element outside of FHIR, where it is not possible to use the logical URI.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// It may be possible for the data element to be used in jurisdictions other than those for which it was originally designed or intended.
    /// </summary>
    public List<CodeableConcept> Jurisdiction { get; set; }
    /// <summary>
    /// Identifies a specification (other than a terminology) that the elements which make up the DataElement have some correspondence with.
    /// </summary>
    public List<DataElementMapping> Mapping { get; set; }
    /// <summary>
    /// The name is not expected to be globally unique. The name should be a simple alpha-numeric type name to ensure that it is computable friendly.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Extension container element for Name
    /// </summary>
    public Element _Name { get; set; }
    /// <summary>
    /// Usually an organization, but may be an individual. The publisher (or steward) of the data element is the organization or individual primarily responsible for the maintenance and upkeep of the data element. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the data element. This item SHOULD be populated unless the information is available from context.
    /// </summary>
    public string Publisher { get; set; }
    /// <summary>
    /// Extension container element for Publisher
    /// </summary>
    public Element _Publisher { get; set; }
    /// <summary>
    /// Allows filtering of data elements that are appropriate for use vs. not.  
    /// This is labeled as "Is Modifier" because applications should not use a retired data element without due consideration.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// Identifies how precise the data element is in its definition.
    /// </summary>
    public string Stringency { get; set; }
    /// <summary>
    /// Extension container element for Stringency
    /// </summary>
    public Element _Stringency { get; set; }
    /// <summary>
    /// This name does not need to be machine-processing friendly and may contain punctuation, white-space, etc. This may be similar to the question used to prompt someone for a data element value, but the purpose is communicating about the data element, not asking the question.  (Refer to the 'question' element for the latter.).
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// Extension container element for Title
    /// </summary>
    public Element _Title { get; set; }
    /// <summary>
    /// Can be a urn:uuid: or a urn:oid:, but real http: addresses are preferred.  Multiple instances may share the same url if they have a distinct version.
    /// </summary>
    public string Url { get; set; }
    /// <summary>
    /// Extension container element for Url
    /// </summary>
    public Element _Url { get; set; }
    /// <summary>
    /// When multiple useContexts are specified, there is no expectation whether all or any of the contexts apply.
    /// </summary>
    public List<UsageContext> UseContext { get; set; }
    /// <summary>
    /// There may be different data element instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a refrence to a particular business version of the data element with the format [url]|[version].
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


      ((fhirCsR3.Models.DomainResource)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(Url))
      {
        writer.WriteString("url", (string)Url!);
      }

      if (_Url != null)
      {
        writer.WritePropertyName("_url");
        _Url.SerializeJson(writer, options);
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

      if (!string.IsNullOrEmpty(Version))
      {
        writer.WriteString("version", (string)Version!);
      }

      if (_Version != null)
      {
        writer.WritePropertyName("_version");
        _Version.SerializeJson(writer, options);
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

      if (Experimental != null)
      {
        writer.WriteBoolean("experimental", (bool)Experimental!);
      }

      if (_Experimental != null)
      {
        writer.WritePropertyName("_experimental");
        _Experimental.SerializeJson(writer, options);
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

      if (!string.IsNullOrEmpty(Publisher))
      {
        writer.WriteString("publisher", (string)Publisher!);
      }

      if (_Publisher != null)
      {
        writer.WritePropertyName("_publisher");
        _Publisher.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Name))
      {
        writer.WriteString("name", (string)Name!);
      }

      if (_Name != null)
      {
        writer.WritePropertyName("_name");
        _Name.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Title))
      {
        writer.WriteString("title", (string)Title!);
      }

      if (_Title != null)
      {
        writer.WritePropertyName("_title");
        _Title.SerializeJson(writer, options);
      }

      if ((Contact != null) && (Contact.Count != 0))
      {
        writer.WritePropertyName("contact");
        writer.WriteStartArray();

        foreach (ContactDetail valContact in Contact)
        {
          valContact.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((UseContext != null) && (UseContext.Count != 0))
      {
        writer.WritePropertyName("useContext");
        writer.WriteStartArray();

        foreach (UsageContext valUseContext in UseContext)
        {
          valUseContext.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Jurisdiction != null) && (Jurisdiction.Count != 0))
      {
        writer.WritePropertyName("jurisdiction");
        writer.WriteStartArray();

        foreach (CodeableConcept valJurisdiction in Jurisdiction)
        {
          valJurisdiction.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Copyright))
      {
        writer.WriteString("copyright", (string)Copyright!);
      }

      if (_Copyright != null)
      {
        writer.WritePropertyName("_copyright");
        _Copyright.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Stringency))
      {
        writer.WriteString("stringency", (string)Stringency!);
      }

      if (_Stringency != null)
      {
        writer.WritePropertyName("_stringency");
        _Stringency.SerializeJson(writer, options);
      }

      if ((Mapping != null) && (Mapping.Count != 0))
      {
        writer.WritePropertyName("mapping");
        writer.WriteStartArray();

        foreach (DataElementMapping valMapping in Mapping)
        {
          valMapping.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Element != null) && (Element.Count != 0))
      {
        writer.WritePropertyName("element");
        writer.WriteStartArray();

        foreach (ElementDefinition valElement in Element)
        {
          valElement.SerializeJson(writer, options, true);
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
        case "contact":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Contact = new List<ContactDetail>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.ContactDetail objContact = new fhirCsR3.Models.ContactDetail();
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

        case "copyright":
          Copyright = reader.GetString();
          break;

        case "_copyright":
          _Copyright = new fhirCsR3.Models.Element();
          _Copyright.DeserializeJson(ref reader, options);
          break;

        case "date":
          Date = reader.GetString();
          break;

        case "_date":
          _Date = new fhirCsR3.Models.Element();
          _Date.DeserializeJson(ref reader, options);
          break;

        case "element":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Element = new List<ElementDefinition>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.ElementDefinition objElement = new fhirCsR3.Models.ElementDefinition();
            objElement.DeserializeJson(ref reader, options);
            Element.Add(objElement);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Element.Count == 0)
          {
            Element = null;
          }

          break;

        case "experimental":
          Experimental = reader.GetBoolean();
          break;

        case "_experimental":
          _Experimental = new fhirCsR3.Models.Element();
          _Experimental.DeserializeJson(ref reader, options);
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

        case "jurisdiction":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Jurisdiction = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.CodeableConcept objJurisdiction = new fhirCsR3.Models.CodeableConcept();
            objJurisdiction.DeserializeJson(ref reader, options);
            Jurisdiction.Add(objJurisdiction);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Jurisdiction.Count == 0)
          {
            Jurisdiction = null;
          }

          break;

        case "mapping":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Mapping = new List<DataElementMapping>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.DataElementMapping objMapping = new fhirCsR3.Models.DataElementMapping();
            objMapping.DeserializeJson(ref reader, options);
            Mapping.Add(objMapping);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Mapping.Count == 0)
          {
            Mapping = null;
          }

          break;

        case "name":
          Name = reader.GetString();
          break;

        case "_name":
          _Name = new fhirCsR3.Models.Element();
          _Name.DeserializeJson(ref reader, options);
          break;

        case "publisher":
          Publisher = reader.GetString();
          break;

        case "_publisher":
          _Publisher = new fhirCsR3.Models.Element();
          _Publisher.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR3.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "stringency":
          Stringency = reader.GetString();
          break;

        case "_stringency":
          _Stringency = new fhirCsR3.Models.Element();
          _Stringency.DeserializeJson(ref reader, options);
          break;

        case "title":
          Title = reader.GetString();
          break;

        case "_title":
          _Title = new fhirCsR3.Models.Element();
          _Title.DeserializeJson(ref reader, options);
          break;

        case "url":
          Url = reader.GetString();
          break;

        case "_url":
          _Url = new fhirCsR3.Models.Element();
          _Url.DeserializeJson(ref reader, options);
          break;

        case "useContext":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          UseContext = new List<UsageContext>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.UsageContext objUseContext = new fhirCsR3.Models.UsageContext();
            objUseContext.DeserializeJson(ref reader, options);
            UseContext.Add(objUseContext);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (UseContext.Count == 0)
          {
            UseContext = null;
          }

          break;

        case "version":
          Version = reader.GetString();
          break;

        case "_version":
          _Version = new fhirCsR3.Models.Element();
          _Version.DeserializeJson(ref reader, options);
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
  /// Code Values for the DataElement.status field
  /// </summary>
  public static class DataElementStatusCodes {
    public const string DRAFT = "draft";
    public const string ACTIVE = "active";
    public const string RETIRED = "retired";
    public const string UNKNOWN = "unknown";
    public static HashSet<string> Values = new HashSet<string>() {
      "draft",
      "active",
      "retired",
      "unknown",
    };
  }
  /// <summary>
  /// Code Values for the DataElement.stringency field
  /// </summary>
  public static class DataElementStringencyCodes {
    public const string COMPARABLE = "comparable";
    public const string FULLY_SPECIFIED = "fully-specified";
    public const string EQUIVALENT = "equivalent";
    public const string CONVERTABLE = "convertable";
    public const string SCALEABLE = "scaleable";
    public const string FLEXIBLE = "flexible";
    public static HashSet<string> Values = new HashSet<string>() {
      "comparable",
      "fully-specified",
      "equivalent",
      "convertable",
      "scaleable",
      "flexible",
    };
  }
}
