// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    public partial class AzureChatExtensionConfiguration : IUtf8JsonSerializable, IJsonModel<AzureChatExtensionConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureChatExtensionConfiguration>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<AzureChatExtensionConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("parameters"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Parameters);
#else
            using (JsonDocument document = JsonDocument.Parse(Parameters))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        AzureChatExtensionConfiguration IJsonModel<AzureChatExtensionConfiguration>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureChatExtensionConfiguration(document.RootElement, options);
        }

        internal static AzureChatExtensionConfiguration DeserializeAzureChatExtensionConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureChatExtensionType type = default;
            BinaryData parameters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new AzureChatExtensionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    parameters = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureChatExtensionConfiguration(type, parameters, serializedAdditionalRawData);
        }

        BinaryData IModel<AzureChatExtensionConfiguration>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AzureChatExtensionConfiguration IModel<AzureChatExtensionConfiguration>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAzureChatExtensionConfiguration(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<AzureChatExtensionConfiguration>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AzureChatExtensionConfiguration FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAzureChatExtensionConfiguration(document.RootElement, ModelReaderWriterOptions.DefaultWireOptions);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
