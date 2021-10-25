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
    /// Specifies the Run details for Build Stage.
    /// </summary>
    public class BuildStageRunProgress : BuildPipelineStageRunProgress
    {
        
        /// <value>
        /// Name of Build Runner shape where this Build Stage is running.
        /// </value>
        [JsonProperty(PropertyName = "actualBuildRunnerShape")]
        public string ActualBuildRunnerShape { get; set; }
        
        [JsonProperty(PropertyName = "actualBuildRunnerShapeConfig")]
        public ActualBuildRunnerShapeConfig ActualBuildRunnerShapeConfig { get; set; }
                ///
        /// <value>
        /// Image name for the Build Environment
        /// </value>
        ///
        public enum ImageEnum {
            [EnumMember(Value = "OL7_X86_64_STANDARD_10")]
            Ol7X8664Standard10
        };

        /// <value>
        /// Image name for the Build Environment
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Image is required.")]
        [JsonProperty(PropertyName = "image")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ImageEnum> Image { get; set; }
        
        /// <value>
        /// The path to the build specification file for this Environment. The default location if not specified is build_spec.yaml
        /// </value>
        [JsonProperty(PropertyName = "buildSpecFile")]
        public string BuildSpecFile { get; set; }
        
        /// <value>
        /// Timeout for the Build Stage Execution. Value in seconds.
        /// </value>
        [JsonProperty(PropertyName = "stageExecutionTimeoutInSeconds")]
        public System.Nullable<int> StageExecutionTimeoutInSeconds { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BuildSourceCollection is required.")]
        [JsonProperty(PropertyName = "buildSourceCollection")]
        public BuildSourceCollection BuildSourceCollection { get; set; }
        
        /// <value>
        /// Name of the BuildSource in which the build_spec.yml file need to be located. If not specified, the 1st entry in the BuildSource collection will be chosen as Primary.
        /// </value>
        [JsonProperty(PropertyName = "primaryBuildSource")]
        public string PrimaryBuildSource { get; set; }
        
        /// <value>
        /// The details about all the steps in a Build Stage
        /// </value>
        [JsonProperty(PropertyName = "steps")]
        public System.Collections.Generic.List<BuildStageRunStep> Steps { get; set; }
        
        [JsonProperty(PropertyName = "exportedVariables")]
        public ExportedVariableCollection ExportedVariables { get; set; }
        
        [JsonProperty(PropertyName = "buildPipelineStageType")]
        private readonly string buildPipelineStageType = "BUILD";
    }
}
