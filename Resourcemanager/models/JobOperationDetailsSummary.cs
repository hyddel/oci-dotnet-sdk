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
using Newtonsoft.Json.Linq;

namespace Oci.ResourcemanagerService.Models
{
    /// <summary>
    /// Job details that are specific to the operation type.
    /// 
    /// </summary>
    [JsonConverter(typeof(JobOperationDetailsSummaryModelConverter))]
    public class JobOperationDetailsSummary 
    {
        
        /// <value>
        /// Terraform-specific operation to execute.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Operation is required.")]
        [JsonProperty(PropertyName = "operation")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Job.OperationEnum> Operation { get; set; }
    }

    public class JobOperationDetailsSummaryModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(JobOperationDetailsSummary);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(JobOperationDetailsSummary);
            var discriminator = jsonObject["operation"].Value<string>();
            switch (discriminator)
            {
                case "IMPORT_TF_STATE":
                    obj = new ImportTfStateJobOperationDetailsSummary();
                    break;
                case "PLAN":
                    obj = new PlanJobOperationDetailsSummary();
                    break;
                case "DESTROY":
                    obj = new DestroyJobOperationDetailsSummary();
                    break;
                case "APPLY":
                    obj = new ApplyJobOperationDetailsSummary();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
