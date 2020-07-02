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


namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// Use a function to validate a custom header or query parameter sent with the request authentication.
    /// A valid policy must specify either tokenHeader or tokenQueryParam.
    /// 
    /// </summary>
    public class CustomAuthenticationPolicy : AuthenticationPolicy
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Oracle Functions function resource.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FunctionId is required.")]
        [JsonProperty(PropertyName = "functionId")]
        public string FunctionId { get; set; }

        /// <value>
        /// The name of the header containing the authentication token.
        /// </value>
        [JsonProperty(PropertyName = "tokenHeader")]
        public string TokenHeader { get; set; }

        /// <value>
        /// The name of the query parameter containing the authentication token.
        /// </value>
        [JsonProperty(PropertyName = "tokenQueryParam")]
        public string TokenQueryParam { get; set; }
    }
}
