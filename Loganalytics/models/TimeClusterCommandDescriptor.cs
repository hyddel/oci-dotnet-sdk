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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// Command descriptor for querylanguage TIMECLUSTER command.
    /// 
    /// </summary>
    public class TimeClusterCommandDescriptor : AbstractCommandDescriptor
    {
        
        /// <value>
        /// Optional timestamp datatype field if specified. Default field is 'Start Time'.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "time")]
        public AbstractField Time { get; set; }
        
        /// <value>
        /// Option to control the size of buckets in the timeseries. Will be adjusted to a larger span if time range is very large.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "span")]
        public string Span { get; set; }
        
        /// <value>
        /// Group by fields specified in the query string.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "groupByFields")]
        public System.Collections.Generic.List<AbstractField> GroupByFields { get; set; }
        
        /// <value>
        /// Statistical functions specified in the query string. Atleast 1 is required for a TIMECLUSTER command.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "functions")]
        public System.Collections.Generic.List<FunctionField> Functions { get; set; }
        
        [JsonProperty(PropertyName = "name")]
        private readonly string name = "TIME_CLUSTER";
    }
}