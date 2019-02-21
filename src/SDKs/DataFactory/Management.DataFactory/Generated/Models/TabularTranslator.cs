// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A copy activity tabular translator.
    /// </summary>
    public partial class TabularTranslator : CopyTranslator
    {
        /// <summary>
        /// Initializes a new instance of the TabularTranslator class.
        /// </summary>
        public TabularTranslator()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TabularTranslator class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="columnMappings">Column mappings. Example: "UserId:
        /// MyUserId, Group: MyGroup, Name: MyName" Type: string (or Expression
        /// with resultType string).</param>
        /// <param name="schemaMapping">The schema mapping to map between
        /// tabular data and hierarchical data. Example: {"Column1":
        /// "$.Column1", "Column2": "$.Column2.Property1", "Column3":
        /// "$.Column2.Property2"}. Type: object (or Expression with resultType
        /// object).</param>
        /// <param name="collectionReference">The JSON Path of the Nested Array
        /// that is going to do cross-apply. Type: object (or Expression with
        /// resultType object).</param>
        public TabularTranslator(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object columnMappings = default(object), object schemaMapping = default(object), object collectionReference = default(object))
            : base(additionalProperties)
        {
            ColumnMappings = columnMappings;
            SchemaMapping = schemaMapping;
            CollectionReference = collectionReference;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets column mappings. Example: "UserId: MyUserId, Group:
        /// MyGroup, Name: MyName" Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "columnMappings")]
        public object ColumnMappings { get; set; }

        /// <summary>
        /// Gets or sets the schema mapping to map between tabular data and
        /// hierarchical data. Example: {"Column1": "$.Column1", "Column2":
        /// "$.Column2.Property1", "Column3": "$.Column2.Property2"}. Type:
        /// object (or Expression with resultType object).
        /// </summary>
        [JsonProperty(PropertyName = "schemaMapping")]
        public object SchemaMapping { get; set; }

        /// <summary>
        /// Gets or sets the JSON Path of the Nested Array that is going to do
        /// cross-apply. Type: object (or Expression with resultType object).
        /// </summary>
        [JsonProperty(PropertyName = "collectionReference")]
        public object CollectionReference { get; set; }

    }
}
