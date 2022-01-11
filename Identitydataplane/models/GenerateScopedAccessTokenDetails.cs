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


namespace Oci.IdentitydataplaneService.Models
{
    
    public class GenerateScopedAccessTokenDetails 
    {
        
        /// <value>
        /// Scope definition for the scoped access token
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Scope is required.")]
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }
        
        /// <value>
        /// A temporary public key, owned by the service. The service also owns the corresponding private key. This public
        /// key will by put inside the security token by the auth service after successful validation of the certificate.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PublicKey is required.")]
        [JsonProperty(PropertyName = "publicKey")]
        public string PublicKey { get; set; }
        
    }
}