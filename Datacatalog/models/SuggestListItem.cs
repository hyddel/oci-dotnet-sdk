/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Details of a potential match returned from the suggest operation for the given input text.
    /// by the limit parameter.
    /// 
    /// </summary>
    public class SuggestListItem 
    {
        
        /// <value>
        /// Potential string match. Matching is based on the frequency of usage within the catalog.
        /// </value>
        [JsonProperty(PropertyName = "suggestion")]
        public string Suggestion { get; set; }
        
        /// <value>
        /// The number of objects which contain this suggestion.
        /// </value>
        [JsonProperty(PropertyName = "objectCount")]
        public System.Nullable<int> ObjectCount { get; set; }
        
    }
}
