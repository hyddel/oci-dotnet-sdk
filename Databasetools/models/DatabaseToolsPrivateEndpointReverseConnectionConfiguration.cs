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


namespace Oci.DatabasetoolsService.Models
{
    /// <summary>
    /// Reverse connection configuration details of Private Endpoint.
    /// </summary>
    public class DatabaseToolsPrivateEndpointReverseConnectionConfiguration 
    {
        
        /// <value>
        /// A list of IP addresses in the customer VCN to be used as the source IPs for reverse connection packets
        /// traveling from the service's VCN to the customer's VCN.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "reverseConnectionsSourceIps")]
        public System.Collections.Generic.List<DatabaseToolsPrivateEndpointReverseConnectionsSourceIp> ReverseConnectionsSourceIps { get; set; }
        
    }
}