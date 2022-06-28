/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// A map of rule patterns.
    /// </summary>
    public class RuleBasedEntityMap : FieldMap
    {
        
        /// <value>
        /// The object key.
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The object's model version.
        /// </value>
        [JsonProperty(PropertyName = "modelVersion")]
        public string ModelVersion { get; set; }
        
        [JsonProperty(PropertyName = "parentRef")]
        public ParentReference ParentRef { get; set; }
        
        [JsonProperty(PropertyName = "configValues")]
        public ConfigValues ConfigValues { get; set; }
                ///
        /// <value>
        /// mapType
        /// </value>
        ///
        public enum MapTypeEnum {
            [EnumMember(Value = "MAPBYNAME")]
            Mapbyname,
            [EnumMember(Value = "MAPBYPATTERN")]
            Mapbypattern
        };

        /// <value>
        /// mapType
        /// </value>
        [JsonProperty(PropertyName = "mapType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MapTypeEnum> MapType { get; set; }
        
        /// <value>
        /// The pattern to map from.
        /// </value>
        [JsonProperty(PropertyName = "fromPattern")]
        public string FromPattern { get; set; }
        
        /// <value>
        /// The pattern to map to.
        /// </value>
        [JsonProperty(PropertyName = "toPattern")]
        public string ToPattern { get; set; }
        
        /// <value>
        /// Specifies whether the rule uses a java regex syntax.
        /// </value>
        [JsonProperty(PropertyName = "isJavaRegexSyntax")]
        public System.Nullable<bool> IsJavaRegexSyntax { get; set; }
        
        /// <value>
        /// The status of an object that can be set to value 1 for shallow references across objects, other values reserved.
        /// </value>
        [JsonProperty(PropertyName = "objectStatus")]
        public System.Nullable<int> ObjectStatus { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "RULE_BASED_ENTITY_MAP";
    }
}