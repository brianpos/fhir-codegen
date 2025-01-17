// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR5.Serialization;

namespace fhirCsR5.Models
{
  /// <summary>
  /// Author – human or machine.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<ImagingSelectionPerformer>))]
  public class ImagingSelectionPerformer : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Author – human or machine.
    /// </summary>
    public Reference Actor { get; set; }
    /// <summary>
    /// Distinguishes the type of involvement of the performer.
    /// </summary>
    public CodeableConcept Function { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Function != null)
      {
        writer.WritePropertyName("function");
        Function.SerializeJson(writer, options);
      }

      if (Actor != null)
      {
        writer.WritePropertyName("actor");
        Actor.SerializeJson(writer, options);
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
        case "actor":
          Actor = new fhirCsR5.Models.Reference();
          Actor.DeserializeJson(ref reader, options);
          break;

        case "function":
          Function = new fhirCsR5.Models.CodeableConcept();
          Function.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR5.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Each imaging selection includes one or more selected DICOM SOP instances.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<ImagingSelectionInstance>))]
  public class ImagingSelectionInstance : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// See [DICOM PS3.3 10.3](http://dicom.nema.org/medical/dicom/current/output/chtml/part03/sect_10.3.html).
    /// </summary>
    public string FrameList { get; set; }
    /// <summary>
    /// Extension container element for FrameList
    /// </summary>
    public Element _FrameList { get; set; }
    /// <summary>
    /// See [DICOM PS3.3 C.12.1](http://dicom.nema.org/medical/dicom/current/output/chtml/part03/sect_C.12.html).
    /// </summary>
    public List<string> ObservationUid { get; set; }
    /// <summary>
    /// Extension container element for ObservationUid
    /// </summary>
    public List<Element> _ObservationUid { get; set; }
    /// <summary>
    /// See [DICOM PS3.3 C.8.8.5](http://dicom.nema.org/medical/dicom/current/output/chtml/part03/sect_C.8.8.5.html).
    /// </summary>
    public string RoiList { get; set; }
    /// <summary>
    /// Extension container element for RoiList
    /// </summary>
    public Element _RoiList { get; set; }
    /// <summary>
    /// See [DICOM PS3.3 10.3](http://dicom.nema.org/medical/dicom/current/output/chtml/part03/sect_10.3.html).
    /// </summary>
    public string SegmentList { get; set; }
    /// <summary>
    /// Extension container element for SegmentList
    /// </summary>
    public Element _SegmentList { get; set; }
    /// <summary>
    /// See [DICOM PS3.3 C.12.1](http://dicom.nema.org/medical/dicom/current/output/chtml/part03/sect_C.12.html).
    /// </summary>
    public Coding SopClass { get; set; }
    /// <summary>
    /// See [DICOM PS3.3 C.12.1](http://dicom.nema.org/medical/dicom/current/output/chtml/part03/sect_C.12.html).
    /// </summary>
    public string Uid { get; set; }
    /// <summary>
    /// Extension container element for Uid
    /// </summary>
    public Element _Uid { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(Uid))
      {
        writer.WriteString("uid", (string)Uid!);
      }

      if (_Uid != null)
      {
        writer.WritePropertyName("_uid");
        _Uid.SerializeJson(writer, options);
      }

      if (SopClass != null)
      {
        writer.WritePropertyName("sopClass");
        SopClass.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(FrameList))
      {
        writer.WriteString("frameList", (string)FrameList!);
      }

      if (_FrameList != null)
      {
        writer.WritePropertyName("_frameList");
        _FrameList.SerializeJson(writer, options);
      }

      if ((ObservationUid != null) && (ObservationUid.Count != 0))
      {
        writer.WritePropertyName("observationUid");
        writer.WriteStartArray();

        foreach (string valObservationUid in ObservationUid)
        {
          writer.WriteStringValue(valObservationUid);
        }

        writer.WriteEndArray();
      }

      if ((_ObservationUid != null) && (_ObservationUid.Count != 0))
      {
        writer.WritePropertyName("_observationUid");
        writer.WriteStartArray();

        foreach (Element val_ObservationUid in _ObservationUid)
        {
          val_ObservationUid.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(SegmentList))
      {
        writer.WriteString("segmentList", (string)SegmentList!);
      }

      if (_SegmentList != null)
      {
        writer.WritePropertyName("_segmentList");
        _SegmentList.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(RoiList))
      {
        writer.WriteString("roiList", (string)RoiList!);
      }

      if (_RoiList != null)
      {
        writer.WritePropertyName("_roiList");
        _RoiList.SerializeJson(writer, options);
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
        case "frameList":
          FrameList = reader.GetString();
          break;

        case "_frameList":
          _FrameList = new fhirCsR5.Models.Element();
          _FrameList.DeserializeJson(ref reader, options);
          break;

        case "observationUid":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ObservationUid = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            ObservationUid.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ObservationUid.Count == 0)
          {
            ObservationUid = null;
          }

          break;

        case "_observationUid":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _ObservationUid = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Element obj_ObservationUid = new fhirCsR5.Models.Element();
            obj_ObservationUid.DeserializeJson(ref reader, options);
            _ObservationUid.Add(obj_ObservationUid);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_ObservationUid.Count == 0)
          {
            _ObservationUid = null;
          }

          break;

        case "roiList":
          RoiList = reader.GetString();
          break;

        case "_roiList":
          _RoiList = new fhirCsR5.Models.Element();
          _RoiList.DeserializeJson(ref reader, options);
          break;

        case "segmentList":
          SegmentList = reader.GetString();
          break;

        case "_segmentList":
          _SegmentList = new fhirCsR5.Models.Element();
          _SegmentList.DeserializeJson(ref reader, options);
          break;

        case "sopClass":
          SopClass = new fhirCsR5.Models.Coding();
          SopClass.DeserializeJson(ref reader, options);
          break;

        case "uid":
          Uid = reader.GetString();
          break;

        case "_uid":
          _Uid = new fhirCsR5.Models.Element();
          _Uid.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR5.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Each imaging selection might includes one or more image regions. Image regions are specified by a region type and a set of 2D or 3D coordinates.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<ImagingSelectionImageRegion>))]
  public class ImagingSelectionImageRegion : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// For a description of how 2D coordinates are encoded, see [DICOM PS3.3 C.18.6](http://dicom.nema.org/medical/dicom/current/output/chtml/part03/sect_C.18.6.html).       For a description of how 3D coordinates are encoded, see [DICOM PS3.3 C.18.9](http://dicom.nema.org/medical/dicom/current/output/chtml/part03/sect_C.18.9.html).
    /// </summary>
    public List<decimal> Coordinates { get; set; }
    /// <summary>
    /// Extension container element for Coordinates
    /// </summary>
    public List<Element> _Coordinates { get; set; }
    /// <summary>
    /// Specifies the type of coordinate system that define the image region.
    /// </summary>
    public string CoordinateType { get; set; }
    /// <summary>
    /// Extension container element for CoordinateType
    /// </summary>
    public Element _CoordinateType { get; set; }
    /// <summary>
    /// See [DICOM PS3.3 C.18.9.1.2](http://dicom.nema.org/medical/dicom/current/output/chtml/part03/sect_C.18.9.html#sect_C.18.9.1.2).
    /// </summary>
    public string RegionType { get; set; }
    /// <summary>
    /// Extension container element for RegionType
    /// </summary>
    public Element _RegionType { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(RegionType))
      {
        writer.WriteString("regionType", (string)RegionType!);
      }

      if (_RegionType != null)
      {
        writer.WritePropertyName("_regionType");
        _RegionType.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(CoordinateType))
      {
        writer.WriteString("coordinateType", (string)CoordinateType!);
      }

      if (_CoordinateType != null)
      {
        writer.WritePropertyName("_coordinateType");
        _CoordinateType.SerializeJson(writer, options);
      }

      if ((Coordinates != null) && (Coordinates.Count != 0))
      {
        writer.WritePropertyName("coordinates");
        writer.WriteStartArray();

        foreach (decimal valCoordinates in Coordinates)
        {
          writer.WriteNumberValue(valCoordinates);
        }

        writer.WriteEndArray();
      }

      if ((_Coordinates != null) && (_Coordinates.Count != 0))
      {
        writer.WritePropertyName("_coordinates");
        writer.WriteStartArray();

        foreach (Element val_Coordinates in _Coordinates)
        {
          val_Coordinates.SerializeJson(writer, options, true);
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
        case "coordinates":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Coordinates = new List<decimal>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Coordinates.Add(reader.GetDecimal());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Coordinates.Count == 0)
          {
            Coordinates = null;
          }

          break;

        case "_coordinates":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _Coordinates = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Element obj_Coordinates = new fhirCsR5.Models.Element();
            obj_Coordinates.DeserializeJson(ref reader, options);
            _Coordinates.Add(obj_Coordinates);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_Coordinates.Count == 0)
          {
            _Coordinates = null;
          }

          break;

        case "coordinateType":
          CoordinateType = reader.GetString();
          break;

        case "_coordinateType":
          _CoordinateType = new fhirCsR5.Models.Element();
          _CoordinateType.DeserializeJson(ref reader, options);
          break;

        case "regionType":
          RegionType = reader.GetString();
          break;

        case "_regionType":
          _RegionType = new fhirCsR5.Models.Element();
          _RegionType.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR5.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Code Values for the ImagingSelection.imageRegion.coordinateType field
  /// </summary>
  public static class ImagingSelectionImageRegionCoordinateTypeCodes {
    public const string VAL_2D = "2d";
    public const string VAL_3D = "3d";
    public static HashSet<string> Values = new HashSet<string>() {
      "2d",
      "3d",
    };
  }
  /// <summary>
  /// Code Values for the ImagingSelection.imageRegion.regionType field
  /// </summary>
  public static class ImagingSelectionImageRegionRegionTypeCodes {
    public const string POINT = "POINT";
    public const string MULTIPOINT = "MULTIPOINT";
    public const string POLYLINE = "POLYLINE";
    public const string POLYGON = "POLYGON";
    public const string ELLIPSE = "ELLIPSE";
    public const string ELLIPSOID = "ELLIPSOID";
    public static HashSet<string> Values = new HashSet<string>() {
      "POINT",
      "MULTIPOINT",
      "POLYLINE",
      "POLYGON",
      "ELLIPSE",
      "ELLIPSOID",
    };
  }
  /// <summary>
  /// A selection of DICOM SOP instances and/or frames within a single Study and Series. This might include additional specifics such as an image region, an Observation UID or a Segmentation Number, allowing linkage to an Observation Resource or transferring this information along with the ImagingStudy Resource.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<ImagingSelection>))]
  public class ImagingSelection : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "ImagingSelection";
    /// <summary>
    /// A list of the diagnostic requests that resulted in this imaging selection being performed.
    /// </summary>
    public List<Reference> BasedOn { get; set; }
    /// <summary>
    /// The anatomic structures examined. See DICOM Part 16 Annex L (http://dicom.nema.org/medical/dicom/current/output/chtml/part16/chapter_L.html) for DICOM to SNOMED-CT mappings.
    /// </summary>
    public Coding BodySite { get; set; }
    /// <summary>
    /// *All* code-value and, if present, component.code-component.value pairs need to be taken into account to correctly understand the meaning of the observation.
    /// </summary>
    public CodeableConcept Code { get; set; }
    /// <summary>
    /// The imaging study from which the imaging selection is made.
    /// </summary>
    public List<Reference> DerivedFrom { get; set; }
    /// <summary>
    /// Typical endpoint types include DICOM WADO-RS, which is used to retrieve DICOM instances in native or rendered (e.g., JPG, PNG) formats using a RESTful API; DICOM WADO-URI, which can similarly retrieve native or rendered instances, except using an HTTP query-based approach.
    /// </summary>
    public List<Reference> Endpoint { get; set; }
    /// <summary>
    /// See [DICOM PS3.3 C.7.4.1](http://dicom.nema.org/medical/dicom/current/output/chtml/part03/sect_C.7.4.html).
    /// </summary>
    public string FrameOfReferenceUid { get; set; }
    /// <summary>
    /// Extension container element for FrameOfReferenceUid
    /// </summary>
    public Element _FrameOfReferenceUid { get; set; }
    /// <summary>
    /// This is a business identifier, not a resource identifier -- see discussion under [Business Identifiers](resource.html#identifiers). 
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// Each imaging selection might includes one or more image regions. Image regions are specified by a region type and a set of 2D or 3D coordinates.
    /// </summary>
    public ImagingSelectionImageRegion ImageRegion { get; set; }
    /// <summary>
    /// Each imaging selection includes one or more selected DICOM SOP instances.
    /// </summary>
    public List<ImagingSelectionInstance> Instance { get; set; }
    /// <summary>
    /// The date and time this imaging selection was created.
    /// </summary>
    public string Issued { get; set; }
    /// <summary>
    /// Extension container element for Issued
    /// </summary>
    public Element _Issued { get; set; }
    /// <summary>
    /// Author – human or machine.
    /// </summary>
    public List<ImagingSelectionPerformer> Performer { get; set; }
    /// <summary>
    /// See [DICOM PS3.3 C.7.3](http://dicom.nema.org/medical/dicom/current/output/chtml/part03/sect_C.7.3.html).
    /// </summary>
    public string SeriesUid { get; set; }
    /// <summary>
    /// Extension container element for SeriesUid
    /// </summary>
    public Element _SeriesUid { get; set; }
    /// <summary>
    /// See [DICOM PS3.3 C.7.2](http://dicom.nema.org/medical/dicom/current/output/chtml/part03/sect_C.7.2.html).
    /// </summary>
    public string StudyUid { get; set; }
    /// <summary>
    /// Extension container element for StudyUid
    /// </summary>
    public Element _StudyUid { get; set; }
    /// <summary>
    /// The patient, or group of patients, location, device, organization, procedure or practitioner this imaging selection is about and into whose or what record the imaging selection is placed.
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


      ((fhirCsR5.Models.DomainResource)this).SerializeJson(writer, options, false);

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

      if ((BasedOn != null) && (BasedOn.Count != 0))
      {
        writer.WritePropertyName("basedOn");
        writer.WriteStartArray();

        foreach (Reference valBasedOn in BasedOn)
        {
          valBasedOn.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Subject != null)
      {
        writer.WritePropertyName("subject");
        Subject.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Issued))
      {
        writer.WriteString("issued", (string)Issued!);
      }

      if (_Issued != null)
      {
        writer.WritePropertyName("_issued");
        _Issued.SerializeJson(writer, options);
      }

      if ((Performer != null) && (Performer.Count != 0))
      {
        writer.WritePropertyName("performer");
        writer.WriteStartArray();

        foreach (ImagingSelectionPerformer valPerformer in Performer)
        {
          valPerformer.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Code != null)
      {
        writer.WritePropertyName("code");
        Code.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(StudyUid))
      {
        writer.WriteString("studyUid", (string)StudyUid!);
      }

      if (_StudyUid != null)
      {
        writer.WritePropertyName("_studyUid");
        _StudyUid.SerializeJson(writer, options);
      }

      if ((DerivedFrom != null) && (DerivedFrom.Count != 0))
      {
        writer.WritePropertyName("derivedFrom");
        writer.WriteStartArray();

        foreach (Reference valDerivedFrom in DerivedFrom)
        {
          valDerivedFrom.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Endpoint != null) && (Endpoint.Count != 0))
      {
        writer.WritePropertyName("endpoint");
        writer.WriteStartArray();

        foreach (Reference valEndpoint in Endpoint)
        {
          valEndpoint.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(SeriesUid))
      {
        writer.WriteString("seriesUid", (string)SeriesUid!);
      }

      if (_SeriesUid != null)
      {
        writer.WritePropertyName("_seriesUid");
        _SeriesUid.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(FrameOfReferenceUid))
      {
        writer.WriteString("frameOfReferenceUid", (string)FrameOfReferenceUid!);
      }

      if (_FrameOfReferenceUid != null)
      {
        writer.WritePropertyName("_frameOfReferenceUid");
        _FrameOfReferenceUid.SerializeJson(writer, options);
      }

      if (BodySite != null)
      {
        writer.WritePropertyName("bodySite");
        BodySite.SerializeJson(writer, options);
      }

      if ((Instance != null) && (Instance.Count != 0))
      {
        writer.WritePropertyName("instance");
        writer.WriteStartArray();

        foreach (ImagingSelectionInstance valInstance in Instance)
        {
          valInstance.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (ImageRegion != null)
      {
        writer.WritePropertyName("imageRegion");
        ImageRegion.SerializeJson(writer, options);
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
        case "basedOn":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          BasedOn = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objBasedOn = new fhirCsR5.Models.Reference();
            objBasedOn.DeserializeJson(ref reader, options);
            BasedOn.Add(objBasedOn);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (BasedOn.Count == 0)
          {
            BasedOn = null;
          }

          break;

        case "bodySite":
          BodySite = new fhirCsR5.Models.Coding();
          BodySite.DeserializeJson(ref reader, options);
          break;

        case "code":
          Code = new fhirCsR5.Models.CodeableConcept();
          Code.DeserializeJson(ref reader, options);
          break;

        case "derivedFrom":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          DerivedFrom = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objDerivedFrom = new fhirCsR5.Models.Reference();
            objDerivedFrom.DeserializeJson(ref reader, options);
            DerivedFrom.Add(objDerivedFrom);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (DerivedFrom.Count == 0)
          {
            DerivedFrom = null;
          }

          break;

        case "endpoint":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Endpoint = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objEndpoint = new fhirCsR5.Models.Reference();
            objEndpoint.DeserializeJson(ref reader, options);
            Endpoint.Add(objEndpoint);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Endpoint.Count == 0)
          {
            Endpoint = null;
          }

          break;

        case "frameOfReferenceUid":
          FrameOfReferenceUid = reader.GetString();
          break;

        case "_frameOfReferenceUid":
          _FrameOfReferenceUid = new fhirCsR5.Models.Element();
          _FrameOfReferenceUid.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Identifier objIdentifier = new fhirCsR5.Models.Identifier();
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

        case "imageRegion":
          ImageRegion = new fhirCsR5.Models.ImagingSelectionImageRegion();
          ImageRegion.DeserializeJson(ref reader, options);
          break;

        case "instance":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Instance = new List<ImagingSelectionInstance>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.ImagingSelectionInstance objInstance = new fhirCsR5.Models.ImagingSelectionInstance();
            objInstance.DeserializeJson(ref reader, options);
            Instance.Add(objInstance);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Instance.Count == 0)
          {
            Instance = null;
          }

          break;

        case "issued":
          Issued = reader.GetString();
          break;

        case "_issued":
          _Issued = new fhirCsR5.Models.Element();
          _Issued.DeserializeJson(ref reader, options);
          break;

        case "performer":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Performer = new List<ImagingSelectionPerformer>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.ImagingSelectionPerformer objPerformer = new fhirCsR5.Models.ImagingSelectionPerformer();
            objPerformer.DeserializeJson(ref reader, options);
            Performer.Add(objPerformer);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Performer.Count == 0)
          {
            Performer = null;
          }

          break;

        case "seriesUid":
          SeriesUid = reader.GetString();
          break;

        case "_seriesUid":
          _SeriesUid = new fhirCsR5.Models.Element();
          _SeriesUid.DeserializeJson(ref reader, options);
          break;

        case "studyUid":
          StudyUid = reader.GetString();
          break;

        case "_studyUid":
          _StudyUid = new fhirCsR5.Models.Element();
          _StudyUid.DeserializeJson(ref reader, options);
          break;

        case "subject":
          Subject = new fhirCsR5.Models.Reference();
          Subject.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR5.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
