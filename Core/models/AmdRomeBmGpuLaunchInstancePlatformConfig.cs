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
    /// The platform configuration used when launching a bare metal GPU instance with the BM.GPU4.8 shape
    /// (the AMD Rome platform).
    /// 
    /// </summary>
    public class AmdRomeBmGpuLaunchInstancePlatformConfig : LaunchInstancePlatformConfig
    {
                ///
        /// <value>
        /// The number of NUMA nodes per socket (NPS).
        /// 
        /// </value>
        ///
        public enum NumaNodesPerSocketEnum {
            [EnumMember(Value = "NPS0")]
            Nps0,
            [EnumMember(Value = "NPS1")]
            Nps1,
            [EnumMember(Value = "NPS2")]
            Nps2,
            [EnumMember(Value = "NPS4")]
            Nps4
        };

        /// <value>
        /// The number of NUMA nodes per socket (NPS).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "numaNodesPerSocket")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<NumaNodesPerSocketEnum> NumaNodesPerSocket { get; set; }
        
        /// <value>
        /// Whether symmetric multithreading is enabled on the instance. Symmetric multithreading is also
        /// called simultaneous multithreading (SMT) or Intel Hyper-Threading.
        /// <br/>
        /// Intel and AMD processors have two hardware execution threads per core (OCPU). SMT permits multiple
        /// independent threads of execution, to better use the resources and increase the efficiency
        /// of the CPU. When multithreading is disabled, only one thread is permitted to run on each core, which
        /// can provide higher or more predictable performance for some workloads.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSymmetricMultiThreadingEnabled")]
        public System.Nullable<bool> IsSymmetricMultiThreadingEnabled { get; set; }
        
        /// <value>
        /// Whether the Access Control Service is enabled on the instance. When enabled,
        /// the platform can enforce PCIe device isolation, required for VFIO device pass-through.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAccessControlServiceEnabled")]
        public System.Nullable<bool> IsAccessControlServiceEnabled { get; set; }
        
        /// <value>
        /// Whether virtualization instructions are available. For example, Secure Virtual Machine for AMD shapes
        /// or VT-x for Intel shapes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "areVirtualInstructionsEnabled")]
        public System.Nullable<bool> AreVirtualInstructionsEnabled { get; set; }
        
        /// <value>
        /// Whether the input-output memory management unit is enabled.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isInputOutputMemoryManagementUnitEnabled")]
        public System.Nullable<bool> IsInputOutputMemoryManagementUnitEnabled { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "AMD_ROME_BM_GPU";
    }
}
