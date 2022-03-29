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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Specifies the Container Engine for Kubernetes (OKE) cluster blue-green deployment traffic shift stage.
    /// </summary>
    public class OkeBlueGreenTrafficShiftDeployStage : DeployStage
    {
        
        /// <value>
        /// The OCID of the upstream OKE blue-green deployment stage in this pipeline.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OkeBlueGreenDeployStageId is required.")]
        [JsonProperty(PropertyName = "okeBlueGreenDeployStageId")]
        public string OkeBlueGreenDeployStageId { get; set; }
        
        [JsonProperty(PropertyName = "deployStageType")]
        private readonly string deployStageType = "OKE_BLUE_GREEN_TRAFFIC_SHIFT";
    }
}
