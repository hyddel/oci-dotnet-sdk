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
    /// A named field map.
    /// </summary>
    public class NamedEntityMap : FieldMap
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
        
        /// <value>
        /// The source entity name.
        /// </value>
        [JsonProperty(PropertyName = "sourceEntity")]
        public string SourceEntity { get; set; }
        
        /// <value>
        /// The target entity name.
        /// </value>
        [JsonProperty(PropertyName = "targetEntity")]
        public string TargetEntity { get; set; }
        
        /// <value>
        /// The status of an object that can be set to value 1 for shallow references across objects, other values reserved.
        /// </value>
        [JsonProperty(PropertyName = "objectStatus")]
        public System.Nullable<int> ObjectStatus { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "NAMED_ENTITY_MAP";
    }
}