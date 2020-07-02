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


namespace Oci.KeymanagementService.Models
{
    
    public class KeyVersion 
    {
        
        /// <value>
        /// The OCID of the compartment that contains this key version.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        /// <value>
        /// The OCID of the key version.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <value>
        /// The OCID of the key associated with this key version.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "KeyId is required.")]
        [JsonProperty(PropertyName = "keyId")]
        public string KeyId { get; set; }
        ///
        /// <value>
        /// The key version's current lifecycle state.
        /// <br/>
        /// Example: ENABLED
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "ENABLING")]
            Enabling,
            [EnumMember(Value = "ENABLED")]
            Enabled,
            [EnumMember(Value = "DISABLING")]
            Disabling,
            [EnumMember(Value = "DISABLED")]
            Disabled,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "PENDING_DELETION")]
            PendingDeletion,
            [EnumMember(Value = "SCHEDULING_DELETION")]
            SchedulingDeletion,
            [EnumMember(Value = "CANCELLING_DELETION")]
            CancellingDeletion
        };

        /// <value>
        /// The key version's current lifecycle state.
        /// <br/>
        /// Example: ENABLED
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        ///
        /// <value>
        /// The source of the key material. When this value is `INTERNAL`, Key Management
        /// created the key material. When this value is `EXTERNAL`, the key material
        /// was imported from an external source.
        /// 
        /// </value>
        ///
        public enum OriginEnum {
            [EnumMember(Value = "INTERNAL")]
            Internal,
            [EnumMember(Value = "EXTERNAL")]
            External
        };

        /// <value>
        /// The source of the key material. When this value is `INTERNAL`, Key Management
        /// created the key material. When this value is `EXTERNAL`, the key material
        /// was imported from an external source.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "origin")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OriginEnum> Origin { get; set; }

        /// <value>
        /// The date and time this key version was created, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.
        /// <br/>
        /// Example: &quot;2018-04-03T21:10:29.600Z&quot;
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }

        /// <value>
        /// An optional property indicating when to delete the key version, expressed in [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.
        /// Example: 2019-04-03T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeOfDeletion")]
        public System.Nullable<System.DateTime> TimeOfDeletion { get; set; }

        /// <value>
        /// The OCID of the vault that contains this key version.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VaultId is required.")]
        [JsonProperty(PropertyName = "vaultId")]
        public string VaultId { get; set; }

        /// <value>
        /// The OCID of the key version from which this key version was restored.
        /// </value>
        [JsonProperty(PropertyName = "restoredFromKeyVersionId")]
        public string RestoredFromKeyVersionId { get; set; }
    }
}
