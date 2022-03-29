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
using Newtonsoft.Json.Linq;

namespace Oci.DevopsService.Models
{
    /// <summary>
    /// The information about new deployment stage.
    /// </summary>
    [JsonConverter(typeof(CreateDeployStageDetailsModelConverter))]
    public class CreateDeployStageDetails 
    {
        
        /// <value>
        /// Optional description about the deployment stage.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Deployment stage display name, which can be renamed and is not necessarily unique. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        
        /// <value>
        /// The OCID of a pipeline.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeployPipelineId is required.")]
        [JsonProperty(PropertyName = "deployPipelineId")]
        public string DeployPipelineId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeployStagePredecessorCollection is required.")]
        [JsonProperty(PropertyName = "deployStagePredecessorCollection")]
        public DeployStagePredecessorCollection DeployStagePredecessorCollection { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.  See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm). Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm). Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }

    public class CreateDeployStageDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateDeployStageDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateDeployStageDetails);
            var discriminator = jsonObject["deployStageType"].Value<string>();
            switch (discriminator)
            {
                case "OKE_CANARY_TRAFFIC_SHIFT":
                    obj = new CreateOkeCanaryTrafficShiftDeployStageDetails();
                    break;
                case "OKE_BLUE_GREEN_TRAFFIC_SHIFT":
                    obj = new CreateOkeBlueGreenTrafficShiftDeployStageDetails();
                    break;
                case "COMPUTE_INSTANCE_GROUP_CANARY_DEPLOYMENT":
                    obj = new CreateComputeInstanceGroupCanaryDeployStageDetails();
                    break;
                case "WAIT":
                    obj = new CreateWaitDeployStageDetails();
                    break;
                case "LOAD_BALANCER_TRAFFIC_SHIFT":
                    obj = new CreateLoadBalancerTrafficShiftDeployStageDetails();
                    break;
                case "COMPUTE_INSTANCE_GROUP_BLUE_GREEN_TRAFFIC_SHIFT":
                    obj = new CreateComputeInstanceGroupBlueGreenTrafficShiftDeployStageDetails();
                    break;
                case "OKE_BLUE_GREEN_DEPLOYMENT":
                    obj = new CreateOkeBlueGreenDeployStageDetails();
                    break;
                case "COMPUTE_INSTANCE_GROUP_ROLLING_DEPLOYMENT":
                    obj = new CreateComputeInstanceGroupDeployStageDetails();
                    break;
                case "INVOKE_FUNCTION":
                    obj = new CreateInvokeFunctionDeployStageDetails();
                    break;
                case "DEPLOY_FUNCTION":
                    obj = new CreateFunctionDeployStageDetails();
                    break;
                case "OKE_CANARY_DEPLOYMENT":
                    obj = new CreateOkeCanaryDeployStageDetails();
                    break;
                case "COMPUTE_INSTANCE_GROUP_CANARY_TRAFFIC_SHIFT":
                    obj = new CreateComputeInstanceGroupCanaryTrafficShiftDeployStageDetails();
                    break;
                case "COMPUTE_INSTANCE_GROUP_CANARY_APPROVAL":
                    obj = new CreateComputeInstanceGroupCanaryApprovalDeployStageDetails();
                    break;
                case "MANUAL_APPROVAL":
                    obj = new CreateManualApprovalDeployStageDetails();
                    break;
                case "OKE_DEPLOYMENT":
                    obj = new CreateOkeDeployStageDetails();
                    break;
                case "COMPUTE_INSTANCE_GROUP_BLUE_GREEN_DEPLOYMENT":
                    obj = new CreateComputeInstanceGroupBlueGreenDeployStageDetails();
                    break;
                case "OKE_CANARY_APPROVAL":
                    obj = new CreateOkeCanaryApprovalDeployStageDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
