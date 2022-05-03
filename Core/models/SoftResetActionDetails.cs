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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// Parameters for the softReset [instance action](https://docs.cloud.oracle.com/iaas/latest/Instance/InstanceAction). If omitted, default values are used.
    /// 
    /// </summary>
    public class SoftResetActionDetails : InstancePowerActionDetails
    {
        
        /// <value>
        /// For instances with a date in the Maintenance reboot field, the flag denoting whether reboot migration is enabled for instances that use the DenseIO shape. The default value is 'false'.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "allowDenseRebootMigration")]
        public System.Nullable<bool> AllowDenseRebootMigration { get; set; }
        
        [JsonProperty(PropertyName = "actionType")]
        private readonly string actionType = "softreset";
    }
}
