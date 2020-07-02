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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// Specifies the volume that the volume backup policy is assigned to.
    /// <br/>
    /// For more information about Oracle defined backup policies and custom backup policies,
    /// see [Policy-Based Backups](https://docs.cloud.oracle.com/iaas/Content/Block/Tasks/schedulingvolumebackups.htm).
    /// 
    /// </summary>
    public class VolumeBackupPolicyAssignment 
    {
        
        /// <value>
        /// The OCID of the volume the policy has been assigned to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AssetId is required.")]
        [JsonProperty(PropertyName = "assetId")]
        public string AssetId { get; set; }

        /// <value>
        /// The OCID of the volume backup policy assignment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <value>
        /// The OCID of the volume backup policy that has been assigned to the volume.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PolicyId is required.")]
        [JsonProperty(PropertyName = "policyId")]
        public string PolicyId { get; set; }

        /// <value>
        /// The date and time the volume backup policy was assigned to the volume. The format is defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
    }
}
