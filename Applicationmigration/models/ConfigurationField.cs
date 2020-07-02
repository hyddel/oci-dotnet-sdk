/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.ApplicationmigrationService.Models
{
    /// <summary>
    /// Information required to migrate an application. Populated by the service as the source application is introspected
    /// 
    /// </summary>
    public class ConfigurationField 
    {
        
        /// <value>
        /// The name of the configuration field
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <value>
        /// The name of the group to which this field belongs, if any.
        /// </value>
        [JsonProperty(PropertyName = "group")]
        public string Group { get; set; }

        /// <value>
        /// The configuration field type
        /// </value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <value>
        /// The value of the field
        /// </value>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <value>
        /// Help text to guide the customer in setting the configuration value
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <value>
        /// Indicates whether or not the field is required (defaults to true)
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isRequired")]
        public System.Nullable<bool> IsRequired { get; set; }

        /// <value>
        /// Indicates whether or not the field may be modified (defaults to true)
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isMutable")]
        public System.Nullable<bool> IsMutable { get; set; }
    }
}
