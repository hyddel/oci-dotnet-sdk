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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Object containing information about a mirror record
    /// </summary>
    public class RepositoryMirrorRecord 
    {
                ///
        /// <value>
        /// Mirror status of current mirror entry.
        /// QUEUED - Mirroring Queued
        /// RUNNING - Mirroring is Running
        /// PASSED - Mirroring Passed
        /// FAILED - Mirroring Failed
        /// 
        /// </value>
        ///
        public enum MirrorStatusEnum {
            [EnumMember(Value = "NONE")]
            None,
            [EnumMember(Value = "QUEUED")]
            Queued,
            [EnumMember(Value = "RUNNING")]
            Running,
            [EnumMember(Value = "PASSED")]
            Passed,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// Mirror status of current mirror entry.
        /// QUEUED - Mirroring Queued
        /// RUNNING - Mirroring is Running
        /// PASSED - Mirroring Passed
        /// FAILED - Mirroring Failed
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MirrorStatus is required.")]
        [JsonProperty(PropertyName = "mirrorStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MirrorStatusEnum> MirrorStatus { get; set; }
        
        /// <value>
        /// Workrequest Id to track current mirror operation
        /// </value>
        [JsonProperty(PropertyName = "workRequestId")]
        public string WorkRequestId { get; set; }
        
        /// <value>
        /// The time to enqueue a mirror operation.
        /// </value>
        [JsonProperty(PropertyName = "timeEnqueued")]
        public System.Nullable<System.DateTime> TimeEnqueued { get; set; }
        
        /// <value>
        /// The time to start a mirror operation.
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// Time that the mirror operation ended or null if it hasn't yet ended.
        /// </value>
        [JsonProperty(PropertyName = "timeEnded")]
        public System.Nullable<System.DateTime> TimeEnded { get; set; }
        
    }
}
