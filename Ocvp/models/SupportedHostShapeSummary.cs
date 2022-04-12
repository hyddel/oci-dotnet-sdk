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


namespace Oci.OcvpService.Models
{
    /// <summary>
    /// A specific compute shape supported by the Oracle Cloud VMware Solution.
    /// 
    /// </summary>
    public class SupportedHostShapeSummary 
    {
        
        /// <value>
        /// The name of the supported compute shape.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The operations where you can use the shape. The operations can be CREATE_SDDC or CREATE_ESXI_HOST.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SupportedOperations is required.")]
        [JsonProperty(PropertyName = "supportedOperations", ItemConverterType = typeof(StringEnumConverter))]
        public System.Collections.Generic.List<OperationTypes> SupportedOperations { get; set; }
        
        /// <value>
        /// The family of the shape. ESXi hosts of one SDDC must have the same shape family.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ShapeFamily is required.")]
        [JsonProperty(PropertyName = "shapeFamily")]
        public string ShapeFamily { get; set; }
        
        /// <value>
        /// The default OCPU count of the shape.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "defaultOcpuCount")]
        public System.Nullable<float> DefaultOcpuCount { get; set; }
        
        /// <value>
        /// Support OCPU count of the shape.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "supportedOcpuCount")]
        public System.Collections.Generic.List<float> SupportedOcpuCount { get; set; }
        
        /// <value>
        /// The supported SDDC types for the shape.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "supportedSddcTypes", ItemConverterType = typeof(StringEnumConverter))]
        public System.Collections.Generic.List<SddcTypes> SupportedSddcTypes { get; set; }
        
        /// <value>
        /// Description of the shape.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Indicates whether the shape supports shielded instances.
        /// </value>
        [JsonProperty(PropertyName = "isSupportShieldedInstances")]
        public System.Nullable<bool> IsSupportShieldedInstances { get; set; }
        
    }
}