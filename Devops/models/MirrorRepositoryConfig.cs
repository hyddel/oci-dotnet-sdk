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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Configuration information for mirroring the repository.
    /// </summary>
    public class MirrorRepositoryConfig 
    {
        
        /// <value>
        /// Upstream git repository connection identifer.
        /// </value>
        [JsonProperty(PropertyName = "connectorId")]
        public string ConnectorId { get; set; }
        
        /// <value>
        /// Url of external repository we'd like to mirror
        /// </value>
        [JsonProperty(PropertyName = "repositoryUrl")]
        public string RepositoryUrl { get; set; }
        
        [JsonProperty(PropertyName = "triggerSchedule")]
        public TriggerSchedule TriggerSchedule { get; set; }
        
    }
}
