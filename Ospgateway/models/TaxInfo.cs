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
    /// Tax details.
    /// </summary>
    public class TaxInfo 
    {
        
        /// <value>
        /// Tay payer identifier.
        /// </value>
        [JsonProperty(PropertyName = "taxPayerId")]
        public string TaxPayerId { get; set; }
        
        /// <value>
        /// Tax registration number.
        /// </value>
        [JsonProperty(PropertyName = "taxRegNumber")]
        public string TaxRegNumber { get; set; }
        
        /// <value>
        /// Tax exemption reason code.
        /// </value>
        [JsonProperty(PropertyName = "noTaxReasonCode")]
        public string NoTaxReasonCode { get; set; }
        
        /// <value>
        /// Tax exemption reason description.
        /// </value>
        [JsonProperty(PropertyName = "noTaxReasonCodeDetails")]
        public string NoTaxReasonCodeDetails { get; set; }
        
        /// <value>
        /// Brazilian companies' CNPJ number.
        /// </value>
        [JsonProperty(PropertyName = "taxCnpj")]
        public string TaxCnpj { get; set; }
        
    }
}
