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


namespace Oci.AivisionService.Models
{
    /// <summary>
    /// The information needed to create a new model.
    /// </summary>
    public class CreateModelDetails 
    {
        
        /// <value>
        /// A human-friendly name for the model, which can be changed.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// An optional description of the model.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The model version
        /// </value>
        [JsonProperty(PropertyName = "modelVersion")]
        public string ModelVersion { get; set; }
        
        /// <value>
        /// Which type of Vision model this is.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ModelType is required.")]
        [JsonProperty(PropertyName = "modelType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Model.ModelTypeEnum> ModelType { get; set; }
        
        /// <value>
        /// The compartment identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Set to true when experimenting with a new model type or dataset, so the model training is quick, with a predefined low number of passes through the training data.
        /// </value>
        [JsonProperty(PropertyName = "isQuickMode")]
        public System.Nullable<bool> IsQuickMode { get; set; }
        
        /// <value>
        /// The maximum model training duration in hours, expressed as a decimal fraction.
        /// </value>
        [JsonProperty(PropertyName = "maxTrainingDurationInHours")]
        public System.Double MaxTrainingDurationInHours { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TrainingDataset is required.")]
        [JsonProperty(PropertyName = "trainingDataset")]
        public Dataset TrainingDataset { get; set; }
        
        [JsonProperty(PropertyName = "testingDataset")]
        public Dataset TestingDataset { get; set; }
        
        [JsonProperty(PropertyName = "validationDataset")]
        public Dataset ValidationDataset { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the project that contains the model.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProjectId is required.")]
        [JsonProperty(PropertyName = "projectId")]
        public string ProjectId { get; set; }
        
        /// <value>
        /// A simple key-value pair that is applied without any predefined name, type, or scope. It exists for cross-compatibility only.
        /// For Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}