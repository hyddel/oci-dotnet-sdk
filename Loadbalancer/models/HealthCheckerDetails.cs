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


namespace Oci.LoadbalancerService.Models
{
    /// <summary>
    /// The health check policy's configuration details.
    /// </summary>
    public class HealthCheckerDetails 
    {
        
        /// <value>
        /// The protocol the health check must use; either HTTP or TCP.
        /// <br/>
        /// Example: HTTP
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Protocol is required.")]
        [JsonProperty(PropertyName = "protocol")]
        public string Protocol { get; set; }
        
        /// <value>
        /// The path against which to run the health check.
        /// <br/>
        /// Example: /healthcheck
        /// </value>
        [JsonProperty(PropertyName = "urlPath")]
        public string UrlPath { get; set; }
        
        /// <value>
        /// The backend server port against which to run the health check. If the port is not specified, the load balancer uses the
        /// port information from the `Backend` object.
        /// <br/>
        /// Example: 8080
        /// </value>
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
        
        /// <value>
        /// The status code a healthy backend server should return.
        /// <br/>
        /// Example: 200
        /// </value>
        [JsonProperty(PropertyName = "returnCode")]
        public System.Nullable<int> ReturnCode { get; set; }
        
        /// <value>
        /// The number of retries to attempt before a backend server is considered \"unhealthy\". This number also applies
        /// when recovering a server to the \"healthy\" state.
        /// <br/>
        /// Example: 3
        /// </value>
        [JsonProperty(PropertyName = "retries")]
        public System.Nullable<int> Retries { get; set; }
        
        /// <value>
        /// The maximum time, in milliseconds, to wait for a reply to a health check. A health check is successful only if a reply
        /// returns within this timeout period.
        /// <br/>
        /// Example: 3000
        /// </value>
        [JsonProperty(PropertyName = "timeoutInMillis")]
        public System.Nullable<int> TimeoutInMillis { get; set; }
        
        /// <value>
        /// The interval between health checks, in milliseconds.
        /// <br/>
        /// Example: 10000
        /// </value>
        [JsonProperty(PropertyName = "intervalInMillis")]
        public System.Nullable<int> IntervalInMillis { get; set; }
        
        /// <value>
        /// A regular expression for parsing the response body from the backend server.
        /// <br/>
        /// Example: ^((?!false).|\\s)*$
        /// </value>
        [JsonProperty(PropertyName = "responseBodyRegex")]
        public string ResponseBodyRegex { get; set; }
        
        /// <value>
        /// Specifies if health checks should always be done using plain text instead of depending on
        /// whether or not the associated backend set is using SSL.
        /// <br/>
        /// If \"true\", health checks will be done using plain text even if the associated backend set is configured
        /// to use SSL.
        /// <br/>
        /// If \"false\", health checks will be done using SSL encryption if the associated backend set is configured
        /// to use SSL. If the backend set is not so configured the health checks will be done using plain text.
        /// <br/>
        /// Example: false
        /// </value>
        [JsonProperty(PropertyName = "isForcePlainText")]
        public System.Nullable<bool> IsForcePlainText { get; set; }
        
    }
}
