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


namespace Oci.CloudmigrationsService.Models
{
    /// <summary>
    /// The strategy based on average usage.
    /// </summary>
    public class AverageResourceAssessmentStrategy : ResourceAssessmentStrategy
    {
        
        /// <value>
        /// The real resource usage is multiplied to this number before making any recommendation.
        /// </value>
        [JsonProperty(PropertyName = "adjustmentMultiplier")]
        public System.Nullable<float> AdjustmentMultiplier { get; set; }
        
        /// <value>
        /// The current state of the migration plan.
        /// </value>
        [JsonProperty(PropertyName = "metricType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MetricType> MetricType { get; set; }
        
        /// <value>
        /// The current state of the migration plan.
        /// </value>
        [JsonProperty(PropertyName = "metricTimeWindow")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MetricTimeWindow> MetricTimeWindow { get; set; }
        
        [JsonProperty(PropertyName = "strategyType")]
        private readonly string strategyType = "AVERAGE";
    }
}