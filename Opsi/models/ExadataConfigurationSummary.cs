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
using Newtonsoft.Json.Linq;

namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Summary of a exadata configuration for a resource.
    /// </summary>
    [JsonConverter(typeof(ExadataConfigurationSummaryModelConverter))]
    public class ExadataConfigurationSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the Exadata insight.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExadataInsightId is required.")]
        [JsonProperty(PropertyName = "exadataInsightId")]
        public string ExadataInsightId { get; set; }
        
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The Exadata system name. If the Exadata systems managed by Enterprise Manager, the name is unique amongst the Exadata systems managed by the same Enterprise Manager.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExadataName is required.")]
        [JsonProperty(PropertyName = "exadataName")]
        public string ExadataName { get; set; }
        
        /// <value>
        /// The user-friendly name for the Exadata system. The name does not have to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExadataDisplayName is required.")]
        [JsonProperty(PropertyName = "exadataDisplayName")]
        public string ExadataDisplayName { get; set; }
        
        /// <value>
        /// Operations Insights internal representation of the the Exadata system type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExadataType is required.")]
        [JsonProperty(PropertyName = "exadataType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ExadataType> ExadataType { get; set; }
        
        /// <value>
        /// Exadata rack type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExadataRackType is required.")]
        [JsonProperty(PropertyName = "exadataRackType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ExadataRackType> ExadataRackType { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DefinedTags is required.")]
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FreeformTags is required.")]
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
    }

    public class ExadataConfigurationSummaryModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ExadataConfigurationSummary);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ExadataConfigurationSummary);
            var discriminator = jsonObject["entitySource"].Value<string>();
            switch (discriminator)
            {
                case "EM_MANAGED_EXTERNAL_EXADATA":
                    obj = new ExadataDatabaseMachineConfigurationSummary();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
