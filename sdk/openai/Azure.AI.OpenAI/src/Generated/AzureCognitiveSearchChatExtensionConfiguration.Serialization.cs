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
    public partial class AzureCognitiveSearchChatExtensionConfiguration : IUtf8JsonSerializable, IJsonModel<AzureCognitiveSearchChatExtensionConfiguration>
    {
        void IJsonModel<AzureCognitiveSearchChatExtensionConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("endpoint"u8);
            writer.WriteStringValue(SearchEndpoint.AbsoluteUri);
            writer.WritePropertyName("key"u8);
            writer.WriteStringValue(SearchKey);
            writer.WritePropertyName("indexName"u8);
            writer.WriteStringValue(IndexName);
            if (Optional.IsDefined(FieldMappingOptions))
            {
                writer.WritePropertyName("fieldsMapping"u8);
                writer.WriteObjectValue(FieldMappingOptions);
            }
            if (Optional.IsDefined(DocumentCount))
            {
                writer.WritePropertyName("topNDocuments"u8);
                writer.WriteNumberValue(DocumentCount.Value);
            }
            if (Optional.IsDefined(QueryType))
            {
                writer.WritePropertyName("queryType"u8);
                writer.WriteStringValue(QueryType.Value.ToString());
            }
            if (Optional.IsDefined(ShouldRestrictResultScope))
            {
                writer.WritePropertyName("inScope"u8);
                writer.WriteBooleanValue(ShouldRestrictResultScope.Value);
            }
            if (Optional.IsDefined(SemanticConfiguration))
            {
                writer.WritePropertyName("semanticConfiguration"u8);
                writer.WriteStringValue(SemanticConfiguration);
            }
            if (Optional.IsDefined(EmbeddingEndpoint))
            {
                writer.WritePropertyName("embeddingEndpoint"u8);
                writer.WriteStringValue(EmbeddingEndpoint.AbsoluteUri);
            }
            if (Optional.IsDefined(EmbeddingKey))
            {
                writer.WritePropertyName("embeddingKey"u8);
                writer.WriteStringValue(EmbeddingKey);
            }
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

        AzureCognitiveSearchChatExtensionConfiguration IJsonModel<AzureCognitiveSearchChatExtensionConfiguration>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureCognitiveSearchChatExtensionConfiguration(document.RootElement, options);
        }

        internal static AzureCognitiveSearchChatExtensionConfiguration DeserializeAzureCognitiveSearchChatExtensionConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureChatExtensionType type = default;
            Uri endpoint = default;
            string key = default;
            string indexName = default;
            Optional<AzureCognitiveSearchIndexFieldMappingOptions> fieldsMapping = default;
            Optional<int> topNDocuments = default;
            Optional<AzureCognitiveSearchQueryType> queryType = default;
            Optional<bool> inScope = default;
            Optional<string> semanticConfiguration = default;
            Optional<Uri> embeddingEndpoint = default;
            Optional<string> embeddingKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new AzureChatExtensionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("endpoint"u8))
                {
                    endpoint = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("indexName"u8))
                {
                    indexName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fieldsMapping"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fieldsMapping = AzureCognitiveSearchIndexFieldMappingOptions.DeserializeAzureCognitiveSearchIndexFieldMappingOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("topNDocuments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    topNDocuments = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("queryType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryType = new AzureCognitiveSearchQueryType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("inScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    inScope = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("semanticConfiguration"u8))
                {
                    semanticConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("embeddingEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    embeddingEndpoint = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("embeddingKey"u8))
                {
                    embeddingKey = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureCognitiveSearchChatExtensionConfiguration(type, endpoint, key, indexName, fieldsMapping.Value, Optional.ToNullable(topNDocuments), Optional.ToNullable(queryType), Optional.ToNullable(inScope), semanticConfiguration.Value, embeddingEndpoint.Value, embeddingKey.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<AzureCognitiveSearchChatExtensionConfiguration>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AzureCognitiveSearchChatExtensionConfiguration IModel<AzureCognitiveSearchChatExtensionConfiguration>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAzureCognitiveSearchChatExtensionConfiguration(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<AzureCognitiveSearchChatExtensionConfiguration>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AzureCognitiveSearchChatExtensionConfiguration FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAzureCognitiveSearchChatExtensionConfiguration(document.RootElement, ModelReaderWriterOptions.DefaultWireOptions);
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
