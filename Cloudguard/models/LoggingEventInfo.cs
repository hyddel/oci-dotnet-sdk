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


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// The information about new Logging event detail of DataSource.
    /// </summary>
    public class LoggingEventInfo : DataSourceEventInfo
    {
        
        [JsonProperty(PropertyName = "observedValue")]
        public string ObservedValue { get; set; }
        
        [JsonProperty(PropertyName = "triggerValue")]
        public string TriggerValue { get; set; }
        
        [JsonProperty(PropertyName = "operator")]
        public string Operator { get; set; }
        
        [JsonProperty(PropertyName = "logResult")]
        public string LogResult { get; set; }
        
        [JsonProperty(PropertyName = "dataSourceFeedProvider")]
        private readonly string dataSourceFeedProvider = "LOGGINGQUERY";
    }
}