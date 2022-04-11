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


namespace Oci.AivisionService.Models
{
    /// <summary>
    /// Text recognition
    /// </summary>
    public class DocumentTextDetectionFeature : DocumentFeature
    {
        
        /// <value>
        /// Whether or not to generate a searchable PDF file.
        /// </value>
        [JsonProperty(PropertyName = "generateSearchablePdf")]
        public System.Nullable<bool> GenerateSearchablePdf { get; set; }
        
        [JsonProperty(PropertyName = "featureType")]
        private readonly string featureType = "TEXT_DETECTION";
    }
}
