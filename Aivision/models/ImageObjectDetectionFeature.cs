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
    /// The object detection parameters.
    /// </summary>
    public class ImageObjectDetectionFeature : ImageFeature
    {
        
        /// <value>
        /// The maximum number of results to return.
        /// </value>
        [JsonProperty(PropertyName = "maxResults")]
        public System.Nullable<int> MaxResults { get; set; }
        
        /// <value>
        /// The custom model ID.
        /// </value>
        [JsonProperty(PropertyName = "modelId")]
        public string ModelId { get; set; }
        
        [JsonProperty(PropertyName = "featureType")]
        private readonly string featureType = "OBJECT_DETECTION";
    }
}
