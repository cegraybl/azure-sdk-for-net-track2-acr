// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageCorsRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("allowedOrigins");
            writer.WriteStartArray();
            foreach (var item in AllowedOrigins)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("allowedMethods");
            writer.WriteStartArray();
            foreach (var item in AllowedMethods)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
            writer.WritePropertyName("maxAgeInSeconds");
            writer.WriteNumberValue(MaxAgeInSeconds);
            writer.WritePropertyName("exposedHeaders");
            writer.WriteStartArray();
            foreach (var item in ExposedHeaders)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("allowedHeaders");
            writer.WriteStartArray();
            foreach (var item in AllowedHeaders)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static StorageCorsRule DeserializeStorageCorsRule(JsonElement element)
        {
            IList<string> allowedOrigins = default;
            IList<CorsRuleAllowedMethod> allowedMethods = default;
            int maxAgeInSeconds = default;
            IList<string> exposedHeaders = default;
            IList<string> allowedHeaders = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedOrigins"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedOrigins = array;
                    continue;
                }
                if (property.NameEquals("allowedMethods"))
                {
                    List<CorsRuleAllowedMethod> array = new List<CorsRuleAllowedMethod>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new CorsRuleAllowedMethod(item.GetString()));
                    }
                    allowedMethods = array;
                    continue;
                }
                if (property.NameEquals("maxAgeInSeconds"))
                {
                    maxAgeInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("exposedHeaders"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    exposedHeaders = array;
                    continue;
                }
                if (property.NameEquals("allowedHeaders"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedHeaders = array;
                    continue;
                }
            }
            return new StorageCorsRule(allowedOrigins, allowedMethods, maxAgeInSeconds, exposedHeaders, allowedHeaders);
        }
    }
}
