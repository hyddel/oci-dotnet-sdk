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


namespace Oci.UsageapiService.Models
{
    /// <summary>
    /// The result from usage store.
    /// </summary>
    public class UsageSummary 
    {
        
        /// <value>
        /// The OCID of the compartment.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        /// <value>
        /// The path of the compartment, starting from root.
        /// </value>
        [JsonProperty(PropertyName = "compartmentPath")]
        public string CompartmentPath { get; set; }

        /// <value>
        /// The name of the compartment.
        /// </value>
        [JsonProperty(PropertyName = "compartmentName")]
        public string CompartmentName { get; set; }

        /// <value>
        /// The name of the service that is incurring the cost.
        /// </value>
        [JsonProperty(PropertyName = "service")]
        public string Service { get; set; }

        /// <value>
        /// The name of the resource that is incurring the cost.
        /// </value>
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }

        /// <value>
        /// The Ocid of the resource that is incurring the cost.
        /// </value>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

        /// <value>
        /// The region of the usage.
        /// </value>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }

        /// <value>
        /// The availability domain of the usage.
        /// </value>
        [JsonProperty(PropertyName = "ad")]
        public string Ad { get; set; }

        /// <value>
        /// The size of resource being metered.
        /// </value>
        [JsonProperty(PropertyName = "weight")]
        public System.Nullable<decimal> Weight { get; set; }

        /// <value>
        /// The shape of the resource.
        /// </value>
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }

        /// <value>
        /// The part number of the SKU.
        /// </value>
        [JsonProperty(PropertyName = "skuPartNumber")]
        public string SkuPartNumber { get; set; }

        /// <value>
        /// The friendly name for the SKU.
        /// </value>
        [JsonProperty(PropertyName = "skuName")]
        public string SkuName { get; set; }

        /// <value>
        /// The unit of the usage.
        /// </value>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        /// <value>
        /// The discretionary discount applied to the SKU.
        /// </value>
        [JsonProperty(PropertyName = "discount")]
        public System.Nullable<decimal> Discount { get; set; }

        /// <value>
        /// The list rate for the SKU (not discount).
        /// </value>
        [JsonProperty(PropertyName = "listRate")]
        public System.Nullable<decimal> ListRate { get; set; }

        /// <value>
        /// Platform for the cost.
        /// </value>
        [JsonProperty(PropertyName = "platform")]
        public string Platform { get; set; }

        /// <value>
        /// The start time of the usage.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUsageStarted is required.")]
        [JsonProperty(PropertyName = "timeUsageStarted")]
        public System.Nullable<System.DateTime> TimeUsageStarted { get; set; }

        /// <value>
        /// The end time of the usage.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUsageEnded is required.")]
        [JsonProperty(PropertyName = "timeUsageEnded")]
        public System.Nullable<System.DateTime> TimeUsageEnded { get; set; }

        /// <value>
        /// The computed cost.
        /// </value>
        [JsonProperty(PropertyName = "computedAmount")]
        public System.Nullable<decimal> ComputedAmount { get; set; }

        /// <value>
        /// The usage number.
        /// </value>
        [JsonProperty(PropertyName = "computedQuantity")]
        public System.Nullable<decimal> ComputedQuantity { get; set; }

        /// <value>
        /// The SPM OverageFlag.
        /// </value>
        [JsonProperty(PropertyName = "overagesFlag")]
        public string OveragesFlag { get; set; }

        /// <value>
        /// The price per unit.
        /// </value>
        [JsonProperty(PropertyName = "unitPrice")]
        public System.Nullable<decimal> UnitPrice { get; set; }

        /// <value>
        /// The currency for the price.
        /// </value>
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        /// <value>
        /// The subscription Id.
        /// </value>
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <value>
        /// The overage usage.
        /// </value>
        [JsonProperty(PropertyName = "overage")]
        public string Overage { get; set; }

        /// <value>
        /// For grouping, a tag definition. For filtering, a definition and key
        /// </value>
        [JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.List<Tag> Tags { get; set; }
    }
}
