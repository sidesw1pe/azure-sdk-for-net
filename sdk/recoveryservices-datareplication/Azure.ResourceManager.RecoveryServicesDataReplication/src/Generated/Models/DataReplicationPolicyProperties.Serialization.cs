// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class DataReplicationPolicyProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("customProperties"u8);
            writer.WriteObjectValue(CustomProperties);
            writer.WriteEndObject();
        }

        internal static DataReplicationPolicyProperties DeserializeDataReplicationPolicyProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataReplicationProvisioningState> provisioningState = default;
            PolicyModelCustomProperties customProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new DataReplicationProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("customProperties"u8))
                {
                    customProperties = PolicyModelCustomProperties.DeserializePolicyModelCustomProperties(property.Value);
                    continue;
                }
            }
            return new DataReplicationPolicyProperties(Optional.ToNullable(provisioningState), customProperties);
        }
    }
}
