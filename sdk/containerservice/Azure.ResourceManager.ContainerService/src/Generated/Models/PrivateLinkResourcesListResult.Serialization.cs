// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    internal partial class PrivateLinkResourcesListResult
    {
        internal static PrivateLinkResourcesListResult DeserializePrivateLinkResourcesListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ContainerServicePrivateLinkResourceData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ContainerServicePrivateLinkResourceData> array = new List<ContainerServicePrivateLinkResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerServicePrivateLinkResourceData.DeserializeContainerServicePrivateLinkResourceData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new PrivateLinkResourcesListResult(Optional.ToList(value));
        }
    }
}
