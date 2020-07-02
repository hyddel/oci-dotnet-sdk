/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.MarketplaceService.Models
{
    /// <summary>
    /// The model of the description of a report.
    /// </summary>
    public class ReportTypeSummary 
    {
        
        /// <value>
        /// The type of report.
        /// </value>
        [JsonProperty(PropertyName = "reportType")]
        public string ReportType { get; set; }

        /// <value>
        /// The name of the report.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <value>
        /// A description of the report.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <value>
        /// The columns in the report.
        /// </value>
        [JsonProperty(PropertyName = "columns")]
        public System.Collections.Generic.List<string> Columns { get; set; }
    }
}
