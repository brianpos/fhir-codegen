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
  /// JSON Serialization Extensions for ChargeItemDefinition
  /// </summary>
  public static class ChargeItemDefinitionJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR ChargeItemDefinition into JSON
    /// </summary>
    public static void SerializeJson(this ChargeItemDefinition current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","ChargeItemDefinition");
      // Complex: ChargeItemDefinition, Export: ChargeItemDefinition, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      writer.WriteString("url",current.UrlElement.Value);

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

      if ((current.VersionElement != null) && (current.VersionElement.Value != null))
      {
        writer.WriteString("version",current.VersionElement.Value);
      }

      if ((current.TitleElement != null) && (current.TitleElement.Value != null))
      {
        writer.WriteString("title",current.TitleElement.Value);
      }

      if ((current.DerivedFromUriElement != null) && (current.DerivedFromUriElement.Count != 0))
      {
        writer.WritePropertyName("derivedFromUri");
        writer.WriteStartArray();
        foreach (FhirUri val in current.DerivedFromUriElement)
        {
          writer.WriteStringValue(val.Value);
        }
        writer.WriteEndArray();
      }

      if ((current.PartOfElement != null) && (current.PartOfElement.Count != 0))
      {
        writer.WritePropertyName("partOf");
        writer.WriteStartArray();
        foreach (Canonical val in current.PartOfElement)
        {
          writer.WriteStringValue(val.Value);
        }
        writer.WriteEndArray();
      }

      if ((current.ReplacesElement != null) && (current.ReplacesElement.Count != 0))
      {
        writer.WritePropertyName("replaces");
        writer.WriteStartArray();
        foreach (Canonical val in current.ReplacesElement)
        {
          writer.WriteStringValue(val.Value);
        }
        writer.WriteEndArray();
      }

      writer.WriteString("status",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.StatusElement.Value));

      if ((current.ExperimentalElement != null) && (current.ExperimentalElement.Value != null))
      {
        writer.WriteBoolean("experimental",(bool)current.ExperimentalElement.Value);
      }

      if ((current.DateElement != null) && (current.DateElement.Value != null))
      {
        writer.WriteString("date",current.DateElement.Value);
      }

      if ((current.PublisherElement != null) && (current.PublisherElement.Value != null))
      {
        writer.WriteString("publisher",current.PublisherElement.Value);
      }

      if ((current.Contact != null) && (current.Contact.Count != 0))
      {
        writer.WritePropertyName("contact");
        writer.WriteStartArray();
        foreach (ContactDetail val in current.Contact)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Description != null) && (current.Description.Value != null))
      {
        writer.WriteString("description",current.Description.Value);
      }

      if ((current.UseContext != null) && (current.UseContext.Count != 0))
      {
        writer.WritePropertyName("useContext");
        writer.WriteStartArray();
        foreach (UsageContext val in current.UseContext)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Jurisdiction != null) && (current.Jurisdiction.Count != 0))
      {
        writer.WritePropertyName("jurisdiction");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Jurisdiction)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Copyright != null) && (current.Copyright.Value != null))
      {
        writer.WriteString("copyright",current.Copyright.Value);
      }

      if ((current.ApprovalDateElement != null) && (current.ApprovalDateElement.Value != null))
      {
        writer.WriteString("approvalDate",current.ApprovalDateElement.Value);
      }

      if ((current.LastReviewDateElement != null) && (current.LastReviewDateElement.Value != null))
      {
        writer.WriteString("lastReviewDate",current.LastReviewDateElement.Value);
      }

      if (current.EffectivePeriod != null)
      {
        writer.WritePropertyName("effectivePeriod");
        current.EffectivePeriod.SerializeJson(writer, options);
      }

      if (current.Code != null)
      {
        writer.WritePropertyName("code");
        current.Code.SerializeJson(writer, options);
      }

      if ((current.Instance != null) && (current.Instance.Count != 0))
      {
        writer.WritePropertyName("instance");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.Instance)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Applicability != null) && (current.Applicability.Count != 0))
      {
        writer.WritePropertyName("applicability");
        writer.WriteStartArray();
        foreach (ChargeItemDefinition.ApplicabilityComponent val in current.Applicability)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.PropertyGroup != null) && (current.PropertyGroup.Count != 0))
      {
        writer.WritePropertyName("propertyGroup");
        writer.WriteStartArray();
        foreach (ChargeItemDefinition.PropertyGroupComponent val in current.PropertyGroup)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR ChargeItemDefinition
    /// </summary>
    public static void DeserializeJson(this ChargeItemDefinition current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }

    /// <summary>
    /// Deserialize JSON into a FHIR ChargeItemDefinition
    /// </summary>
    public static void DeserializeJsonProperty(this ChargeItemDefinition current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "url":
          current.UrlElement = new FhirUri(reader.GetString());
          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Identifier v_Identifier = new Hl7.Fhir.Model.Identifier();
            v_Identifier.DeserializeJson(ref reader, options);
            current.Identifier.Add(v_Identifier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Identifier.Count == 0)
          {
            current.Identifier = null;
          }
          break;

        case "version":
          current.VersionElement = new FhirString(reader.GetString());
          break;

        case "title":
          current.TitleElement = new FhirString(reader.GetString());
          break;

        case "derivedFromUri":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.DerivedFromUriElement = new List<FhirUri>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.DerivedFromUriElement.Add(new FhirUri(reader.GetString()));

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.DerivedFromUriElement.Count == 0)
          {
            current.DerivedFromUriElement = null;
          }
          break;

        case "partOf":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.PartOfElement = new List<Canonical>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.PartOfElement.Add(new Canonical(reader.GetString()));

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.PartOfElement.Count == 0)
          {
            current.PartOfElement = null;
          }
          break;

        case "_partOf":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          int i_partOf = 0;

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            ((Hl7.Fhir.Model.Element)current.PartOfElement[i_partOf++]).DeserializeJson(ref reader, options);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }
          break;

        case "replaces":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.ReplacesElement = new List<Canonical>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            current.ReplacesElement.Add(new Canonical(reader.GetString()));

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ReplacesElement.Count == 0)
          {
            current.ReplacesElement = null;
          }
          break;

        case "_replaces":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          int i_replaces = 0;

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            ((Hl7.Fhir.Model.Element)current.ReplacesElement[i_replaces++]).DeserializeJson(ref reader, options);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }
          break;

        case "status":
          current.StatusElement =new Code<Hl7.Fhir.Model.PublicationStatus>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.PublicationStatus>(reader.GetString()));
          break;

        case "experimental":
          current.ExperimentalElement = new FhirBoolean(reader.GetBoolean());
          break;

        case "date":
          current.DateElement = new FhirDateTime(reader.GetString());
          break;

        case "publisher":
          current.PublisherElement = new FhirString(reader.GetString());
          break;

        case "contact":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Contact = new List<ContactDetail>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ContactDetail v_Contact = new Hl7.Fhir.Model.ContactDetail();
            v_Contact.DeserializeJson(ref reader, options);
            current.Contact.Add(v_Contact);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Contact.Count == 0)
          {
            current.Contact = null;
          }
          break;

        case "description":
          current.Description = new Markdown(reader.GetString());
          break;

        case "useContext":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.UseContext = new List<UsageContext>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.UsageContext v_UseContext = new Hl7.Fhir.Model.UsageContext();
            v_UseContext.DeserializeJson(ref reader, options);
            current.UseContext.Add(v_UseContext);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.UseContext.Count == 0)
          {
            current.UseContext = null;
          }
          break;

        case "jurisdiction":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Jurisdiction = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Jurisdiction = new Hl7.Fhir.Model.CodeableConcept();
            v_Jurisdiction.DeserializeJson(ref reader, options);
            current.Jurisdiction.Add(v_Jurisdiction);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Jurisdiction.Count == 0)
          {
            current.Jurisdiction = null;
          }
          break;

        case "copyright":
          current.Copyright = new Markdown(reader.GetString());
          break;

        case "approvalDate":
          current.ApprovalDateElement = new Date(reader.GetString());
          break;

        case "_approvalDate":
          ((Hl7.Fhir.Model.Element)current.ApprovalDateElement).DeserializeJson(ref reader, options);
          break;

        case "lastReviewDate":
          current.LastReviewDateElement = new Date(reader.GetString());
          break;

        case "_lastReviewDate":
          ((Hl7.Fhir.Model.Element)current.LastReviewDateElement).DeserializeJson(ref reader, options);
          break;

        case "effectivePeriod":
          current.EffectivePeriod = new Hl7.Fhir.Model.Period();
          current.EffectivePeriod.DeserializeJson(ref reader, options);
          break;

        case "code":
          current.Code = new Hl7.Fhir.Model.CodeableConcept();
          current.Code.DeserializeJson(ref reader, options);
          break;

        case "instance":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Instance = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_Instance = new Hl7.Fhir.Model.ResourceReference();
            v_Instance.DeserializeJson(ref reader, options);
            current.Instance.Add(v_Instance);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Instance.Count == 0)
          {
            current.Instance = null;
          }
          break;

        case "applicability":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Applicability = new List<ChargeItemDefinition.ApplicabilityComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ChargeItemDefinition.ApplicabilityComponent v_Applicability = new Hl7.Fhir.Model.ChargeItemDefinition.ApplicabilityComponent();
            v_Applicability.DeserializeJson(ref reader, options);
            current.Applicability.Add(v_Applicability);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Applicability.Count == 0)
          {
            current.Applicability = null;
          }
          break;

        case "propertyGroup":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.PropertyGroup = new List<ChargeItemDefinition.PropertyGroupComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ChargeItemDefinition.PropertyGroupComponent v_PropertyGroup = new Hl7.Fhir.Model.ChargeItemDefinition.PropertyGroupComponent();
            v_PropertyGroup.DeserializeJson(ref reader, options);
            current.PropertyGroup.Add(v_PropertyGroup);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.PropertyGroup.Count == 0)
          {
            current.PropertyGroup = null;
          }
          break;

        // Complex: ChargeItemDefinition, Export: ChargeItemDefinition, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR ChargeItemDefinition#Applicability into JSON
    /// </summary>
    public static void SerializeJson(this ChargeItemDefinition.ApplicabilityComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: ChargeItemDefinition#Applicability, Export: ApplicabilityComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if ((current.DescriptionElement != null) && (current.DescriptionElement.Value != null))
      {
        writer.WriteString("description",current.DescriptionElement.Value);
      }

      if ((current.LanguageElement != null) && (current.LanguageElement.Value != null))
      {
        writer.WriteString("language",current.LanguageElement.Value);
      }

      if ((current.ExpressionElement != null) && (current.ExpressionElement.Value != null))
      {
        writer.WriteString("expression",current.ExpressionElement.Value);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR ChargeItemDefinition#Applicability
    /// </summary>
    public static void DeserializeJson(this ChargeItemDefinition.ApplicabilityComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }

    /// <summary>
    /// Deserialize JSON into a FHIR ChargeItemDefinition#Applicability
    /// </summary>
    public static void DeserializeJsonProperty(this ChargeItemDefinition.ApplicabilityComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "description":
          current.DescriptionElement = new FhirString(reader.GetString());
          break;

        case "language":
          current.LanguageElement = new FhirString(reader.GetString());
          break;

        case "expression":
          current.ExpressionElement = new FhirString(reader.GetString());
          break;

        // Complex: applicability, Export: ApplicabilityComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR ChargeItemDefinition#PropertyGroup into JSON
    /// </summary>
    public static void SerializeJson(this ChargeItemDefinition.PropertyGroupComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: ChargeItemDefinition#PropertyGroup, Export: PropertyGroupComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      if ((current.Applicability != null) && (current.Applicability.Count != 0))
      {
        writer.WritePropertyName("applicability");
        writer.WriteStartArray();
        foreach (ChargeItemDefinition.ApplicabilityComponent val in current.Applicability)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.PriceComponent != null) && (current.PriceComponent.Count != 0))
      {
        writer.WritePropertyName("priceComponent");
        writer.WriteStartArray();
        foreach (ChargeItemDefinition.PriceComponentComponent val in current.PriceComponent)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR ChargeItemDefinition#PropertyGroup
    /// </summary>
    public static void DeserializeJson(this ChargeItemDefinition.PropertyGroupComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }

    /// <summary>
    /// Deserialize JSON into a FHIR ChargeItemDefinition#PropertyGroup
    /// </summary>
    public static void DeserializeJsonProperty(this ChargeItemDefinition.PropertyGroupComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "applicability":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Applicability = new List<ChargeItemDefinition.ApplicabilityComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ChargeItemDefinition.ApplicabilityComponent v_Applicability = new Hl7.Fhir.Model.ChargeItemDefinition.ApplicabilityComponent();
            v_Applicability.DeserializeJson(ref reader, options);
            current.Applicability.Add(v_Applicability);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Applicability.Count == 0)
          {
            current.Applicability = null;
          }
          break;

        case "priceComponent":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.PriceComponent = new List<ChargeItemDefinition.PriceComponentComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ChargeItemDefinition.PriceComponentComponent v_PriceComponent = new Hl7.Fhir.Model.ChargeItemDefinition.PriceComponentComponent();
            v_PriceComponent.DeserializeJson(ref reader, options);
            current.PriceComponent.Add(v_PriceComponent);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.PriceComponent.Count == 0)
          {
            current.PriceComponent = null;
          }
          break;

        // Complex: propertyGroup, Export: PropertyGroupComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR ChargeItemDefinition#PriceComponent into JSON
    /// </summary>
    public static void SerializeJson(this ChargeItemDefinition.PriceComponentComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: ChargeItemDefinition#PriceComponent, Export: PriceComponentComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WriteString("type",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.TypeElement.Value));

      if (current.Code != null)
      {
        writer.WritePropertyName("code");
        current.Code.SerializeJson(writer, options);
      }

      if ((current.FactorElement != null) && (current.FactorElement.Value != null))
      {
        writer.WriteNumber("factor",(decimal)current.FactorElement.Value);
      }

      if (current.Amount != null)
      {
        writer.WritePropertyName("amount");
        current.Amount.SerializeJson(writer, options);
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR ChargeItemDefinition#PriceComponent
    /// </summary>
    public static void DeserializeJson(this ChargeItemDefinition.PriceComponentComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }

    /// <summary>
    /// Deserialize JSON into a FHIR ChargeItemDefinition#PriceComponent
    /// </summary>
    public static void DeserializeJsonProperty(this ChargeItemDefinition.PriceComponentComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "type":
          current.TypeElement =new Code<Hl7.Fhir.Model.InvoicePriceComponentType>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.InvoicePriceComponentType>(reader.GetString()));
          break;

        case "code":
          current.Code = new Hl7.Fhir.Model.CodeableConcept();
          current.Code.DeserializeJson(ref reader, options);
          break;

        case "factor":
          current.FactorElement = new FhirDecimal(reader.GetDecimal());
          break;

        case "amount":
          current.Amount = new Hl7.Fhir.Model.Money();
          current.Amount.DeserializeJson(ref reader, options);
          break;

        // Complex: priceComponent, Export: PriceComponentComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class ChargeItemDefinitionJsonConverter : JsonConverter<ChargeItemDefinition>
    {
      /// <summary>
      /// Determines whether the specified type can be converted.
      /// </summary>
      public override bool CanConvert(Type objectType) =>
        typeof(ChargeItemDefinition).IsAssignableFrom(objectType);

      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, ChargeItemDefinition value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override ChargeItemDefinition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        ChargeItemDefinition target = new ChargeItemDefinition();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file