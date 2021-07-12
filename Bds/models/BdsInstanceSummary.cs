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


namespace Oci.BdsService.Models
{
    /// <summary>
    /// Summary details of the Big Data Service cluster.
    /// </summary>
    public class BdsInstanceSummary 
    {
        
        /// <value>
        /// The OCID of the Big Data Service resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The name of the cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The state of the cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<BdsInstance.LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The number of nodes that form the cluster.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NumberOfNodes is required.")]
        [JsonProperty(PropertyName = "numberOfNodes")]
        public System.Nullable<int> NumberOfNodes { get; set; }
        
        /// <value>
        /// Version of the Hadoop distribution.
        /// </value>
        [JsonProperty(PropertyName = "clusterVersion")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<BdsInstance.ClusterVersionEnum> ClusterVersion { get; set; }
        
        /// <value>
        /// Boolean flag specifying whether or not the cluster is highly available(HA).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsHighAvailability is required.")]
        [JsonProperty(PropertyName = "isHighAvailability")]
        public System.Nullable<bool> IsHighAvailability { get; set; }
        
        /// <value>
        /// Boolean flag specifying whether or not the cluster should be set up as secure.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsSecure is required.")]
        [JsonProperty(PropertyName = "isSecure")]
        public System.Nullable<bool> IsSecure { get; set; }
        
        /// <value>
        /// Boolean flag specifying whether Cloud SQL is configured or not.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsCloudSqlConfigured is required.")]
        [JsonProperty(PropertyName = "isCloudSqlConfigured")]
        public System.Nullable<bool> IsCloudSqlConfigured { get; set; }
        
        /// <value>
        /// The time the cluster was created, shown as an RFC 3339 formatted datetime string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type, or scope.
        /// Exists for cross-compatibility only. For example, `{\"bar-key\": \"value\"}`
        /// 
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For example, `{\"foo-namespace\": {\"bar-key\": \"value\"}}`
        /// 
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
