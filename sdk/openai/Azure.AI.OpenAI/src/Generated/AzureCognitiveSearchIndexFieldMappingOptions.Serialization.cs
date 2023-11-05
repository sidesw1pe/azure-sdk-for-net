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
    public partial class AzureCognitiveSearchIndexFieldMappingOptions : IUtf8JsonSerializable, IJsonModel<AzureCognitiveSearchIndexFieldMappingOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureCognitiveSearchIndexFieldMappingOptions>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<AzureCognitiveSearchIndexFieldMappingOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TitleFieldName))
            {
                writer.WritePropertyName("titleField"u8);
                writer.WriteStringValue(TitleFieldName);
            }
            if (Optional.IsDefined(UrlFieldName))
            {
                writer.WritePropertyName("urlField"u8);
                writer.WriteStringValue(UrlFieldName);
            }
            if (Optional.IsDefined(FilepathFieldName))
            {
                writer.WritePropertyName("filepathField"u8);
                writer.WriteStringValue(FilepathFieldName);
            }
            if (Optional.IsCollectionDefined(ContentFieldNames))
            {
                writer.WritePropertyName("contentFieldNames"u8);
                writer.WriteStartArray();
                foreach (var item in ContentFieldNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ContentFieldSeparator))
            {
                writer.WritePropertyName("contentFieldSeparator"u8);
                writer.WriteStringValue(ContentFieldSeparator);
            }
            if (Optional.IsCollectionDefined(VectorFieldNames))
            {
                writer.WritePropertyName("vectorFields"u8);
                writer.WriteStartArray();
                foreach (var item in VectorFieldNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        AzureCognitiveSearchIndexFieldMappingOptions IJsonModel<AzureCognitiveSearchIndexFieldMappingOptions>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureCognitiveSearchIndexFieldMappingOptions(document.RootElement, options);
        }

        internal static AzureCognitiveSearchIndexFieldMappingOptions DeserializeAzureCognitiveSearchIndexFieldMappingOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> titleField = default;
            Optional<string> urlField = default;
            Optional<string> filepathField = default;
            Optional<IList<string>> contentFieldNames = default;
            Optional<string> contentFieldSeparator = default;
            Optional<IList<string>> vectorFields = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("titleField"u8))
                {
                    titleField = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("urlField"u8))
                {
                    urlField = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filepathField"u8))
                {
                    filepathField = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentFieldNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    contentFieldNames = array;
                    continue;
                }
                if (property.NameEquals("contentFieldSeparator"u8))
                {
                    contentFieldSeparator = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vectorFields"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    vectorFields = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureCognitiveSearchIndexFieldMappingOptions(titleField.Value, urlField.Value, filepathField.Value, Optional.ToList(contentFieldNames), contentFieldSeparator.Value, Optional.ToList(vectorFields), serializedAdditionalRawData);
        }

        BinaryData IModel<AzureCognitiveSearchIndexFieldMappingOptions>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AzureCognitiveSearchIndexFieldMappingOptions IModel<AzureCognitiveSearchIndexFieldMappingOptions>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAzureCognitiveSearchIndexFieldMappingOptions(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<AzureCognitiveSearchIndexFieldMappingOptions>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AzureCognitiveSearchIndexFieldMappingOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAzureCognitiveSearchIndexFieldMappingOptions(document.RootElement, ModelReaderWriterOptions.DefaultWireOptions);
        }
    }
}
