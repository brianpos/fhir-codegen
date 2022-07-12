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
  /// JSON Serialization Extensions for PractitionerRole
  /// </summary>
  public static class PractitionerRoleJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR PractitionerRole into JSON
    /// </summary>
    public static void SerializeJson(this PractitionerRole current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","PractitionerRole");
      // Complex: PractitionerRole, Export: PractitionerRole, Base: DomainResource (DomainResource)
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

      if (current.ActiveElement != null)
      {
        if (current.ActiveElement.Value != null)
        {
          writer.WriteBoolean("active",(bool)current.ActiveElement.Value);
        }
        if (current.ActiveElement.HasExtensions() || (!string.IsNullOrEmpty(current.ActiveElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_active",false,current.ActiveElement.Extension,current.ActiveElement.ElementId);
        }
      }

      if (current.Period != null)
      {
        writer.WritePropertyName("period");
        current.Period.SerializeJson(writer, options);
      }

      if (current.Practitioner != null)
      {
        writer.WritePropertyName("practitioner");
        current.Practitioner.SerializeJson(writer, options);
      }

      if (current.Organization != null)
      {
        writer.WritePropertyName("organization");
        current.Organization.SerializeJson(writer, options);
      }

      if ((current.Code != null) && (current.Code.Count != 0))
      {
        writer.WritePropertyName("code");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Code)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Specialty != null) && (current.Specialty.Count != 0))
      {
        writer.WritePropertyName("specialty");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Specialty)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Location != null) && (current.Location.Count != 0))
      {
        writer.WritePropertyName("location");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Location)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.HealthcareService != null) && (current.HealthcareService.Count != 0))
      {
        writer.WritePropertyName("healthcareService");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.HealthcareService)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Telecom != null) && (current.Telecom.Count != 0))
      {
        writer.WritePropertyName("telecom");
        writer.WriteStartArray();
        foreach (ContactPoint val in current.Telecom)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.AvailableTime != null) && (current.AvailableTime.Count != 0))
      {
        writer.WritePropertyName("availableTime");
        writer.WriteStartArray();
        foreach (PractitionerRole.AvailableTimeComponent val in current.AvailableTime)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.NotAvailable != null) && (current.NotAvailable.Count != 0))
      {
        writer.WritePropertyName("notAvailable");
        writer.WriteStartArray();
        foreach (PractitionerRole.NotAvailableComponent val in current.NotAvailable)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.AvailabilityExceptionsElement != null)
      {
        if (!string.IsNullOrEmpty(current.AvailabilityExceptionsElement.Value))
        {
          writer.WriteString("availabilityExceptions",current.AvailabilityExceptionsElement.Value);
        }
        if (current.AvailabilityExceptionsElement.HasExtensions() || (!string.IsNullOrEmpty(current.AvailabilityExceptionsElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_availabilityExceptions",false,current.AvailabilityExceptionsElement.Extension,current.AvailabilityExceptionsElement.ElementId);
        }
      }

      if ((current.Endpoint != null) && (current.Endpoint.Count != 0))
      {
        writer.WritePropertyName("endpoint");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Endpoint)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR PractitionerRole
    /// </summary>
    public static void DeserializeJson(this PractitionerRole current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"PractitionerRole >>> PractitionerRole.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"PractitionerRole: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR PractitionerRole
    /// </summary>
    public static void DeserializeJsonProperty(this PractitionerRole current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"PractitionerRole error reading 'identifier' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Identifier v_Identifier = new Hl7.Fhir.Model.Identifier();
            v_Identifier.DeserializeJson(ref reader, options);
            current.Identifier.Add(v_Identifier);

            if (!reader.Read())
            {
              throw new JsonException($"PractitionerRole error reading 'identifier' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Identifier.Count == 0)
          {
            current.Identifier = null;
          }
          break;

        case "active":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.ActiveElement = new FhirBoolean();
            reader.Skip();
          }
          else
          {
            current.ActiveElement = new FhirBoolean(reader.GetBoolean());
          }
          break;

        case "_active":
          if (current.ActiveElement == null) { current.ActiveElement = new FhirBoolean(); }
          ((Hl7.Fhir.Model.Element)current.ActiveElement).DeserializeJson(ref reader, options);
          break;

        case "period":
          current.Period = new Hl7.Fhir.Model.Period();
          ((Hl7.Fhir.Model.Period)current.Period).DeserializeJson(ref reader, options);
          break;

        case "practitioner":
          current.Practitioner = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Practitioner).DeserializeJson(ref reader, options);
          break;

        case "organization":
          current.Organization = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Organization).DeserializeJson(ref reader, options);
          break;

        case "code":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"PractitionerRole error reading 'code' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Code = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Code = new Hl7.Fhir.Model.CodeableConcept();
            v_Code.DeserializeJson(ref reader, options);
            current.Code.Add(v_Code);

            if (!reader.Read())
            {
              throw new JsonException($"PractitionerRole error reading 'code' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Code.Count == 0)
          {
            current.Code = null;
          }
          break;

        case "specialty":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"PractitionerRole error reading 'specialty' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Specialty = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Specialty = new Hl7.Fhir.Model.CodeableConcept();
            v_Specialty.DeserializeJson(ref reader, options);
            current.Specialty.Add(v_Specialty);

            if (!reader.Read())
            {
              throw new JsonException($"PractitionerRole error reading 'specialty' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Specialty.Count == 0)
          {
            current.Specialty = null;
          }
          break;

        case "location":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"PractitionerRole error reading 'location' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Location = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Location = new Hl7.Fhir.Model.ResourceReference();
            v_Location.DeserializeJson(ref reader, options);
            current.Location.Add(v_Location);

            if (!reader.Read())
            {
              throw new JsonException($"PractitionerRole error reading 'location' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Location.Count == 0)
          {
            current.Location = null;
          }
          break;

        case "healthcareService":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"PractitionerRole error reading 'healthcareService' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.HealthcareService = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_HealthcareService = new Hl7.Fhir.Model.ResourceReference();
            v_HealthcareService.DeserializeJson(ref reader, options);
            current.HealthcareService.Add(v_HealthcareService);

            if (!reader.Read())
            {
              throw new JsonException($"PractitionerRole error reading 'healthcareService' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.HealthcareService.Count == 0)
          {
            current.HealthcareService = null;
          }
          break;

        case "telecom":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"PractitionerRole error reading 'telecom' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Telecom = new List<ContactPoint>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ContactPoint v_Telecom = new Hl7.Fhir.Model.ContactPoint();
            v_Telecom.DeserializeJson(ref reader, options);
            current.Telecom.Add(v_Telecom);

            if (!reader.Read())
            {
              throw new JsonException($"PractitionerRole error reading 'telecom' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Telecom.Count == 0)
          {
            current.Telecom = null;
          }
          break;

        case "availableTime":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"PractitionerRole error reading 'availableTime' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.AvailableTime = new List<PractitionerRole.AvailableTimeComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.PractitionerRole.AvailableTimeComponent v_AvailableTime = new Hl7.Fhir.Model.PractitionerRole.AvailableTimeComponent();
            v_AvailableTime.DeserializeJson(ref reader, options);
            current.AvailableTime.Add(v_AvailableTime);

            if (!reader.Read())
            {
              throw new JsonException($"PractitionerRole error reading 'availableTime' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.AvailableTime.Count == 0)
          {
            current.AvailableTime = null;
          }
          break;

        case "notAvailable":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"PractitionerRole error reading 'notAvailable' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.NotAvailable = new List<PractitionerRole.NotAvailableComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.PractitionerRole.NotAvailableComponent v_NotAvailable = new Hl7.Fhir.Model.PractitionerRole.NotAvailableComponent();
            v_NotAvailable.DeserializeJson(ref reader, options);
            current.NotAvailable.Add(v_NotAvailable);

            if (!reader.Read())
            {
              throw new JsonException($"PractitionerRole error reading 'notAvailable' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.NotAvailable.Count == 0)
          {
            current.NotAvailable = null;
          }
          break;

        case "availabilityExceptions":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.AvailabilityExceptionsElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.AvailabilityExceptionsElement = new FhirString(reader.GetString());
          }
          break;

        case "_availabilityExceptions":
          if (current.AvailabilityExceptionsElement == null) { current.AvailabilityExceptionsElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.AvailabilityExceptionsElement).DeserializeJson(ref reader, options);
          break;

        case "endpoint":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"PractitionerRole error reading 'endpoint' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Endpoint = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Endpoint = new Hl7.Fhir.Model.ResourceReference();
            v_Endpoint.DeserializeJson(ref reader, options);
            current.Endpoint.Add(v_Endpoint);

            if (!reader.Read())
            {
              throw new JsonException($"PractitionerRole error reading 'endpoint' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Endpoint.Count == 0)
          {
            current.Endpoint = null;
          }
          break;

        // Complex: PractitionerRole, Export: PractitionerRole, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR PractitionerRole#AvailableTime into JSON
    /// </summary>
    public static void SerializeJson(this PractitionerRole.AvailableTimeComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: PractitionerRole#AvailableTime, Export: AvailableTimeComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if ((current.DaysOfWeekElement != null) && (current.DaysOfWeekElement.Count != 0))
      {
        int valueCount = 0;
        int extensionCount = 0;
        foreach (Code<Hl7.Fhir.Model.DaysOfWeek> val in current.DaysOfWeekElement)
        {
          if (val.Value != null) { valueCount++; }
          if (val.HasExtensions()) { extensionCount++; }
        }

        if (valueCount > 0)
        {
          writer.WritePropertyName("daysOfWeek");
          writer.WriteStartArray();
          foreach (Code<Hl7.Fhir.Model.DaysOfWeek> val in current.DaysOfWeekElement)
          {
            if (val.Value == null)
            {
              writer.WriteNullValue();
            }
            else
            {
              writer.WriteStringValue(Hl7.Fhir.Utility.EnumUtility.GetLiteral(val.Value));
            }
          }

          writer.WriteEndArray();
        }

        if (extensionCount > 0)
        {
          writer.WritePropertyName("_daysOfWeek");
          writer.WriteStartArray();
          foreach (Code<Hl7.Fhir.Model.DaysOfWeek> val in current.DaysOfWeekElement)
          {
            if (val.HasExtensions() || (!string.IsNullOrEmpty(val.ElementId)))
            {
              JsonStreamUtilities.SerializeExtensionList(writer,options,string.Empty,true,val.Extension,val.ElementId);
            }
            else
            {
              writer.WriteNullValue();
            }

          }

          writer.WriteEndArray();
        }
      }

      if (current.AllDayElement != null)
      {
        if (current.AllDayElement.Value != null)
        {
          writer.WriteBoolean("allDay",(bool)current.AllDayElement.Value);
        }
        if (current.AllDayElement.HasExtensions() || (!string.IsNullOrEmpty(current.AllDayElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_allDay",false,current.AllDayElement.Extension,current.AllDayElement.ElementId);
        }
      }

      if (current.AvailableStartTimeElement != null)
      {
        writer.WritePropertyName("availableStartTime");
        current.AvailableStartTimeElement.SerializeJson(writer, options);
      }

      if (current.AvailableEndTimeElement != null)
      {
        writer.WritePropertyName("availableEndTime");
        current.AvailableEndTimeElement.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR PractitionerRole#AvailableTime
    /// </summary>
    public static void DeserializeJson(this PractitionerRole.AvailableTimeComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"PractitionerRole.AvailableTimeComponent >>> PractitionerRole#AvailableTime.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"PractitionerRole.AvailableTimeComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR PractitionerRole#AvailableTime
    /// </summary>
    public static void DeserializeJsonProperty(this PractitionerRole.AvailableTimeComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "daysOfWeek":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"AvailableTimeComponent error reading 'daysOfWeek' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.DaysOfWeekElement = new List<Code<Hl7.Fhir.Model.DaysOfWeek>>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (reader.TokenType == JsonTokenType.Null)
            {
              current.DaysOfWeekElement.Add(new Code<Hl7.Fhir.Model.DaysOfWeek>());
              reader.Skip();
            }
            else
            {
              current.DaysOfWeekElement.Add(new Code<Hl7.Fhir.Model.DaysOfWeek>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.DaysOfWeek>(reader.GetString())));
            }

            if (!reader.Read())
            {
              throw new JsonException($"AvailableTimeComponent error reading 'daysOfWeek' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.DaysOfWeekElement.Count == 0)
          {
            current.DaysOfWeekElement = null;
          }
          break;

        case "_daysOfWeek":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"AvailableTimeComponent error reading 'daysOfWeek' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          int i_daysOfWeek = 0;

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            if (i_daysOfWeek >= current.DaysOfWeekElement.Count)
            {
              current.DaysOfWeekElement.Add(new Code<Hl7.Fhir.Model.DaysOfWeek>());
            }
            if (reader.TokenType == JsonTokenType.Null)
            {
              reader.Skip();
            }
            else
            {
              ((Hl7.Fhir.Model.Element)current.DaysOfWeekElement[i_daysOfWeek++]).DeserializeJson(ref reader, options);
            }

            if (!reader.Read())
            {
              throw new JsonException($"AvailableTimeComponent error reading 'daysOfWeek' array, read failed! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }
          break;

        case "allDay":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.AllDayElement = new FhirBoolean();
            reader.Skip();
          }
          else
          {
            current.AllDayElement = new FhirBoolean(reader.GetBoolean());
          }
          break;

        case "_allDay":
          if (current.AllDayElement == null) { current.AllDayElement = new FhirBoolean(); }
          ((Hl7.Fhir.Model.Element)current.AllDayElement).DeserializeJson(ref reader, options);
          break;

        case "availableStartTime":
          current.AvailableStartTimeElement = new Hl7.Fhir.Model.Time();
          ((Hl7.Fhir.Model.Time)current.AvailableStartTimeElement).DeserializeJson(ref reader, options);
          break;

        case "availableEndTime":
          current.AvailableEndTimeElement = new Hl7.Fhir.Model.Time();
          ((Hl7.Fhir.Model.Time)current.AvailableEndTimeElement).DeserializeJson(ref reader, options);
          break;

        // Complex: availableTime, Export: AvailableTimeComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR PractitionerRole#NotAvailable into JSON
    /// </summary>
    public static void SerializeJson(this PractitionerRole.NotAvailableComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: PractitionerRole#NotAvailable, Export: NotAvailableComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WriteString("description",current.DescriptionElement.Value);

      if (current.During != null)
      {
        writer.WritePropertyName("during");
        current.During.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR PractitionerRole#NotAvailable
    /// </summary>
    public static void DeserializeJson(this PractitionerRole.NotAvailableComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"PractitionerRole.NotAvailableComponent >>> PractitionerRole#NotAvailable.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"PractitionerRole.NotAvailableComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR PractitionerRole#NotAvailable
    /// </summary>
    public static void DeserializeJsonProperty(this PractitionerRole.NotAvailableComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "description":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.DescriptionElement = new FhirString();
            reader.Skip();
          }
          else
          {
            current.DescriptionElement = new FhirString(reader.GetString());
          }
          break;

        case "_description":
          if (current.DescriptionElement == null) { current.DescriptionElement = new FhirString(); }
          ((Hl7.Fhir.Model.Element)current.DescriptionElement).DeserializeJson(ref reader, options);
          break;

        case "during":
          current.During = new Hl7.Fhir.Model.Period();
          ((Hl7.Fhir.Model.Period)current.During).DeserializeJson(ref reader, options);
          break;

        // Complex: notAvailable, Export: NotAvailableComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class PractitionerRoleJsonConverter : JsonConverter<PractitionerRole>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, PractitionerRole value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override PractitionerRole Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        PractitionerRole target = new PractitionerRole();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file