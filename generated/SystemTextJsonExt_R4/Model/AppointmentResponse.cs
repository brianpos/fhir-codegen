// <auto-generated/>
// Contents of: hl7.fhir.r4.core version: 4.0.1

using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Hl7.Fhir.Model;
using Hl7.Fhir.Model.JsonExtensions;
using Hl7.Fhir.Serialization;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  
*/

namespace Hl7.Fhir.Model.JsonExtensions
{
  /// <summary>
  /// JSON Serialization Extensions for AppointmentResponse
  /// </summary>
  public static class AppointmentResponseJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR AppointmentResponse into JSON
    /// </summary>
    public static void SerializeJson(this AppointmentResponse current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","AppointmentResponse");
      // Complex: AppointmentResponse, Export: AppointmentResponse, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      if ((current.Identifier != null) && (current.Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();
        foreach (Identifier val in current.Identifier)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      writer.WritePropertyName("appointment");
      current.Appointment.SerializeJson(writer, options);

      if (current.StartElement != null)
      {
        if (current.StartElement.Value != null)
        {
          writer.WriteString("start",((DateTimeOffset)current.StartElement.Value).ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFFFK",System.Globalization.CultureInfo.InvariantCulture));
        }
        if (current.StartElement.HasExtensions() || (!string.IsNullOrEmpty(current.StartElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_start",false,current.StartElement.Extension,current.StartElement.ElementId);
        }
      }

      if (current.EndElement != null)
      {
        if (current.EndElement.Value != null)
        {
          writer.WriteString("end",((DateTimeOffset)current.EndElement.Value).ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFFFK",System.Globalization.CultureInfo.InvariantCulture));
        }
        if (current.EndElement.HasExtensions() || (!string.IsNullOrEmpty(current.EndElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_end",false,current.EndElement.Extension,current.EndElement.ElementId);
        }
      }

      if ((current.ParticipantType != null) && (current.ParticipantType.Count != 0))
      {
        writer.WritePropertyName("participantType");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.ParticipantType)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Actor != null)
      {
        writer.WritePropertyName("actor");
        current.Actor.SerializeJson(writer, options);
      }

      writer.WriteString("participantStatus",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.ParticipantStatusElement.Value));

      if (current.CommentElement != null)
      {
        if (!string.IsNullOrEmpty(current.CommentElement.Value))
        {
          writer.WriteString("comment",current.CommentElement.Value);
        }
        if (current.CommentElement.HasExtensions() || (!string.IsNullOrEmpty(current.CommentElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_comment",false,current.CommentElement.Extension,current.CommentElement.ElementId);
        }
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR AppointmentResponse
    /// </summary>
    public static void DeserializeJson(this AppointmentResponse current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"AppointmentResponse >>> AppointmentResponse.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"AppointmentResponse: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR AppointmentResponse
    /// </summary>
    public static void DeserializeJsonProperty(this AppointmentResponse current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"AppointmentResponse error reading 'identifier' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Identifier v_Identifier = new Hl7.Fhir.Model.Identifier();
            v_Identifier.DeserializeJson(ref reader, options);
            current.Identifier.Add(v_Identifier);

            if (!reader.Read())
            {
              throw new JsonException($"AppointmentResponse error reading 'identifier' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Identifier.Count == 0)
          {
            current.Identifier = null;
          }
          break;

        case "appointment":
          current.Appointment = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Appointment).DeserializeJson(ref reader, options);
          break;

        case "start":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.StartElement = new Instant();
            reader.Skip();
          }
          else
          {
            current.StartElement = new Instant(DateTimeOffset.Parse(reader.GetString()));
          }
          break;

        case "_start":
          if (current.StartElement == null) { current.StartElement = new Instant(); }
          ((Hl7.Fhir.Model.Element)current.StartElement).DeserializeJson(ref reader, options);
          break;

        case "end":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.EndElement = new Instant();
            reader.Skip();
          }
          else
          {
            current.EndElement = new Instant(DateTimeOffset.Parse(reader.GetString()));
          }
          break;

        case "_end":
          if (current.EndElement == null) { current.EndElement = new Instant(); }
          ((Hl7.Fhir.Model.Element)current.EndElement).DeserializeJson(ref reader, options);
          break;

        case "participantType":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"AppointmentResponse error reading 'participantType' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.ParticipantType = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_ParticipantType = new Hl7.Fhir.Model.CodeableConcept();
            v_ParticipantType.DeserializeJson(ref reader, options);
            current.ParticipantType.Add(v_ParticipantType);

            if (!reader.Read())
            {
              throw new JsonException($"AppointmentResponse error reading 'participantType' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ParticipantType.Count == 0)
          {
            current.ParticipantType = null;
          }
          break;

        case "actor":
          current.Actor = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Actor).DeserializeJson(ref reader, options);
          break;

        case "participantStatus":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.ParticipantStatusElement = new Code<Hl7.Fhir.Model.ParticipationStatus>();
            reader.Skip();
          }
          else
          {
            current.ParticipantStatusElement = new Code<Hl7.Fhir.Model.ParticipationStatus>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.ParticipationStatus>(reader.GetString()));
          }
          break;

        case "_participantStatus":
          if (current.ParticipantStatusElement == null) { current.ParticipantStatusElement = new Code<Hl7.Fhir.Model.ParticipationStatus>(); }
          ((Hl7.Fhir.Model.Element)current.ParticipantStatusElement).DeserializeJson(ref reader, options);
          break;

        case "comment":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.CommentElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.CommentElement = new FhirString(reader.GetString());
          }
          break;

        case "_comment":
          if (current.CommentElement == null) { current.CommentElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.CommentElement).DeserializeJson(ref reader, options);
          break;

        // Complex: AppointmentResponse, Export: AppointmentResponse, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class AppointmentResponseJsonConverter : JsonConverter<AppointmentResponse>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, AppointmentResponse value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override AppointmentResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        AppointmentResponse target = new AppointmentResponse();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file