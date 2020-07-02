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


namespace Oci.IdentityService.Models
{
    /// <summary>
    /// A special type of {@link IdentityProvider} that
    /// supports the SAML 2.0 protocol. For more information, see
    /// [Identity Providers and Federation](https://docs.cloud.oracle.com/Content/Identity/Concepts/federation.htm).
    /// 
    /// </summary>
    public class Saml2IdentityProvider : IdentityProvider
    {
        
        /// <value>
        /// The URL for retrieving the identity provider's metadata, which
        /// contains information required for federating.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MetadataUrl is required.")]
        [JsonProperty(PropertyName = "metadataUrl")]
        public string MetadataUrl { get; set; }

        /// <value>
        /// The identity provider's signing certificate used by the IAM Service
        /// to validate the SAML2 token.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SigningCertificate is required.")]
        [JsonProperty(PropertyName = "signingCertificate")]
        public string SigningCertificate { get; set; }

        /// <value>
        /// The URL to redirect federated users to for authentication with the
        /// identity provider.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RedirectUrl is required.")]
        [JsonProperty(PropertyName = "redirectUrl")]
        public string RedirectUrl { get; set; }

        /// <value>
        /// Extra name value pairs associated with this identity provider.
        /// Example: {&quot;clientId&quot;: &quot;app_sf3kdjf3&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformAttributes")]
        public System.Collections.Generic.Dictionary<string, string> FreeformAttributes { get; set; }
    }
}
