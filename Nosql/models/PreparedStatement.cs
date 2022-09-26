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


namespace Oci.NosqlService.Models
{
    /// <summary>
    /// The result of query preparation.
    /// </summary>
    public class PreparedStatement 
    {
        
        /// <value>
        /// A base64-encoded, compiled and parameterized version of
        /// a SQL statement.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "statement")]
        public string Statement { get; set; }
        
        /// <value>
        /// A representation of the query plan as a schema-less JSON object.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "queryPlan")]
        public System.Object QueryPlan { get; set; }
        
        [JsonProperty(PropertyName = "usage")]
        public RequestUsage Usage { get; set; }
        
    }
}
