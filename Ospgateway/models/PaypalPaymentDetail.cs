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


namespace Oci.OspgatewayService.Models
{
    /// <summary>
    /// PayPal Payment related details
    /// </summary>
    public class PaypalPaymentDetail : PaymentDetail
    {
        
        /// <value>
        /// The id (email address) of the paypal payment
        /// </value>
        [JsonProperty(PropertyName = "paypalId")]
        public string PaypalId { get; set; }
        
        /// <value>
        /// paypal payment reference
        /// </value>
        [JsonProperty(PropertyName = "paypalReference")]
        public string PaypalReference { get; set; }
        
        [JsonProperty(PropertyName = "paymentMethod")]
        private readonly string paymentMethod = "PAYPAL";
    }
}
