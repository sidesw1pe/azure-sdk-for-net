// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    internal partial class CreationData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId");
                writer.WriteStringValue(SourceResourceId);
            }
            writer.WriteEndObject();
        }

        internal static CreationData DeserializeCreationData(JsonElement element)
        {
            Optional<ResourceIdentifier> sourceResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceResourceId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sourceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new CreationData(sourceResourceId.Value);
        }
    }
}
