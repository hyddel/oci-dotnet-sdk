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
    /// The name of a form field.
    /// </summary>
    public class FieldName 
    {
        
        /// <value>
        /// The name of the field.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The confidence score between 0 and 1.
        /// </value>
        [JsonProperty(PropertyName = "confidence")]
        public System.Nullable<float> Confidence { get; set; }
        
        [JsonProperty(PropertyName = "boundingPolygon")]
        public BoundingPolygon BoundingPolygon { get; set; }
        
        /// <value>
        /// The indexes of the words in the field name.
        /// </value>
        [JsonProperty(PropertyName = "wordIndexes")]
        public System.Collections.Generic.List<int> WordIndexes { get; set; }
        
    }
}
