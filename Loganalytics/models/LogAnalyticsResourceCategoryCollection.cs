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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// A collection of resources and their category assignments.
    /// </summary>
    public class LogAnalyticsResourceCategoryCollection 
    {
        
        /// <value>
        /// An array of categories. The array contents include detailed information about
        /// the distinct set of categories assigned to all the listed resources under items.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "categories")]
        public System.Collections.Generic.List<LogAnalyticsCategory> Categories { get; set; }
        
        /// <value>
        /// A list of resources and their category assignments
        /// </value>
        [JsonProperty(PropertyName = "items")]
        public System.Collections.Generic.List<LogAnalyticsResourceCategory> Items { get; set; }
        
    }
}
