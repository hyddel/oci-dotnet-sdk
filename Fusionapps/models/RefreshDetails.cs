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


namespace Oci.FusionappsService.Models
{
    /// <summary>
    /// Describes a refresh of a fusion environment
    /// </summary>
    public class RefreshDetails 
    {
        
        /// <value>
        /// The source environment id for the last refresh
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceFusionEnvironmentId is required.")]
        [JsonProperty(PropertyName = "sourceFusionEnvironmentId")]
        public string SourceFusionEnvironmentId { get; set; }
        
        /// <value>
        /// The time of when the last refresh finish
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeFinished is required.")]
        [JsonProperty(PropertyName = "timeFinished")]
        public System.Nullable<System.DateTime> TimeFinished { get; set; }
        
        /// <value>
        /// The point of time of the latest DB backup for the last refresh
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeOfRestorationPoint is required.")]
        [JsonProperty(PropertyName = "timeOfRestorationPoint")]
        public System.Nullable<System.DateTime> TimeOfRestorationPoint { get; set; }
        
    }
}