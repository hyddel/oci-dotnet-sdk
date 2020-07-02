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


namespace Oci.MarketplaceService.Models
{
    /// <summary>
    /// The model for a summary of an accepted agreement.
    /// </summary>
    public class AcceptedAgreementSummary 
    {
        
        /// <value>
        /// The unique identifier for the acceptance of the agreement within a specific compartment.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <value>
        /// A display name for the accepted agreement.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <value>
        /// The unique identifier for the compartment where the agreement was accepted.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        /// <value>
        /// The unique identifier for the listing associated with the agreement.
        /// </value>
        [JsonProperty(PropertyName = "listingId")]
        public string ListingId { get; set; }

        /// <value>
        /// The package version associated with the agreement.
        /// </value>
        [JsonProperty(PropertyName = "packageVersion")]
        public string PackageVersion { get; set; }

        /// <value>
        /// The unique identifier for the terms of use agreement itself.
        /// </value>
        [JsonProperty(PropertyName = "agreementId")]
        public string AgreementId { get; set; }

        /// <value>
        /// The time the agreement was accepted.
        /// </value>
        [JsonProperty(PropertyName = "timeAccepted")]
        public System.Nullable<System.DateTime> TimeAccepted { get; set; }
    }
}
