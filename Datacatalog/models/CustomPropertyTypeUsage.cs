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


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Object which describes the indivial object stats for every custom property
    /// </summary>
    public class CustomPropertyTypeUsage 
    {
        
        /// <value>
        /// Unique type key identifier
        /// </value>
        [JsonProperty(PropertyName = "typeId")]
        public string TypeId { get; set; }

        /// <value>
        /// Name of the type associated with
        /// </value>
        [JsonProperty(PropertyName = "typeName")]
        public string TypeName { get; set; }

        /// <value>
        /// Number of objects associated with this type
        /// </value>
        [JsonProperty(PropertyName = "count")]
        public System.Nullable<int> Count { get; set; }
    }
}
