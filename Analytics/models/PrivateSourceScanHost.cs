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


namespace Oci.AnalyticsService.Models
{
    /// <summary>
    /// Private source Scan Hostname model.
    /// 
    /// </summary>
    public class PrivateSourceScanHost 
    {
        
        /// <value>
        /// Private Source Scan hostname. Ex: db01-scan.corp.example.com, prd-db01-scan.mycompany.com.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ScanHostname is required.")]
        [JsonProperty(PropertyName = "scanHostname")]
        public string ScanHostname { get; set; }
        
        /// <value>
        /// Private Source Scan host port. This is the source port where SCAN protocol will get connected (e.g. 1521).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ScanPort is required.")]
        [JsonProperty(PropertyName = "scanPort")]
        public System.Nullable<int> ScanPort { get; set; }
        
        /// <value>
        /// Description of private source scan host zone.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
    }
}