/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// A valid value for a database parameter.
    /// </summary>
    public class AllowedParameterValue 
    {
        
        /// <value>
        /// The ordinal number in the list (1-based).
        /// </value>
        [JsonProperty(PropertyName = "ordinal")]
        public System.Nullable<decimal> Ordinal { get; set; }
        
        /// <value>
        /// The parameter value at ordinal.
        /// </value>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        /// <value>
        /// Indicates whether the given ordinal value is the default value for the parameter.
        /// </value>
        [JsonProperty(PropertyName = "isDefault")]
        public System.Nullable<bool> IsDefault { get; set; }
        
    }
}