/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
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
    /// Specifies the execution details for Kubernetes (OKE) helm chart deployment stage.
    /// </summary>
    public class OkeHelmChartDeploymentStageExecutionProgress : DeployStageExecutionProgress
    {
        
        /// <value>
        /// Release name of the Helm chart.
        /// </value>
        [JsonProperty(PropertyName = "releaseName")]
        public string ReleaseName { get; set; }
        
        /// <value>
        /// The URL of an OCIR repository.
        /// </value>
        [JsonProperty(PropertyName = "chartUrl")]
        public string ChartUrl { get; set; }
        
        /// <value>
        /// The version of the helm chart stored in OCIR repository.
        /// </value>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
        /// <value>
        /// Default namespace to be used for Kubernetes deployment when not specified in the manifest.
        /// </value>
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }
        
        /// <value>
        /// Helm Diff output
        /// Example: Helm diff was successfuldata:- greeting: Version 1.0+ greeting: Version 1.1
        /// </value>
        [JsonProperty(PropertyName = "helmDiff")]
        public string HelmDiff { get; set; }
        
        [JsonProperty(PropertyName = "deployStageType")]
        private readonly string deployStageType = "OKE_HELM_CHART_DEPLOYMENT";
    }
}
