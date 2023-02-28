/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
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
    /// The details of an Oracle DB node discovered in an external DB system discovery run.
    /// </summary>
    public class DiscoveredExternalDbNode : DiscoveredExternalDbSystemComponent
    {
        
        /// <value>
        /// The name of the host on which the ASM instance is running.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HostName is required.")]
        [JsonProperty(PropertyName = "hostName")]
        public string HostName { get; set; }
        
        /// <value>
        /// The number of CPU cores available on the DB node.
        /// </value>
        [JsonProperty(PropertyName = "cpuCoreCount")]
        public System.Nullable<float> CpuCoreCount { get; set; }
        
        /// <value>
        /// The total memory in gigabytes (GB) on the DB node.
        /// </value>
        [JsonProperty(PropertyName = "memorySizeInGBs")]
        public System.Nullable<float> MemorySizeInGBs { get; set; }
        
        [JsonProperty(PropertyName = "connector")]
        public ExternalDbSystemDiscoveryConnector Connector { get; set; }
        
        [JsonProperty(PropertyName = "componentType")]
        private readonly string componentType = "DATABASE_NODE";
    }
}