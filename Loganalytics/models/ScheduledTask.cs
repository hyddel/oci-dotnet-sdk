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

namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// Log analytics scheduled task resource.
    /// 
    /// </summary>
    [JsonConverter(typeof(ScheduledTaskModelConverter))]
    public class ScheduledTask 
    {
                ///
        /// <value>
        /// Discriminator.
        /// </value>
        ///
        public enum KindEnum {
            [EnumMember(Value = "ACCELERATION")]
            Acceleration,
            [EnumMember(Value = "STANDARD")]
            Standard
        };

        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the data plane resource.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// A user-friendly name that is changeable and that does not have to be unique.
        /// Format: a leading alphanumeric, followed by zero or more
        /// alphanumerics, underscores, spaces, backslashes, or hyphens in any order).
        /// No trailing spaces allowed.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Task type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TaskType is required.")]
        [JsonProperty(PropertyName = "taskType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TaskType> TaskType { get; set; }
        
        /// <value>
        /// Schedules.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Schedules is required.")]
        [JsonProperty(PropertyName = "schedules")]
        public System.Collections.Generic.List<Schedule> Schedules { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Action is required.")]
        [JsonProperty(PropertyName = "action")]
        public Action Action { get; set; }
                ///
        /// <value>
        /// Status of the scheduled task.
        /// </value>
        ///
        public enum TaskStatusEnum {
            [EnumMember(Value = "READY")]
            Ready,
            [EnumMember(Value = "PAUSED")]
            Paused,
            [EnumMember(Value = "COMPLETED")]
            Completed,
            [EnumMember(Value = "BLOCKED")]
            Blocked
        };

        /// <value>
        /// Status of the scheduled task.
        /// </value>
        [JsonProperty(PropertyName = "taskStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TaskStatusEnum> TaskStatus { get; set; }
                ///
        /// <value>
        /// reason for taskStatus PAUSED.
        /// </value>
        ///
        public enum PauseReasonEnum {
            [EnumMember(Value = "METRIC_EXTRACTION_NOT_VALID")]
            MetricExtractionNotValid,
            [EnumMember(Value = "SAVED_SEARCH_NOT_VALID")]
            SavedSearchNotValid,
            [EnumMember(Value = "SAVED_SEARCH_NOT_FOUND")]
            SavedSearchNotFound,
            [EnumMember(Value = "QUERY_STRING_NOT_VALID")]
            QueryStringNotValid,
            [EnumMember(Value = "USER_ACTION")]
            UserAction,
            [EnumMember(Value = "TENANCY_LIFECYCLE")]
            TenancyLifecycle,
            [EnumMember(Value = "PURGE_RESOURCE_NOT_FOUND")]
            PurgeResourceNotFound
        };

        /// <value>
        /// reason for taskStatus PAUSED.
        /// </value>
        [JsonProperty(PropertyName = "pauseReason")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PauseReasonEnum> PauseReason { get; set; }
        
        /// <value>
        /// most recent Work Request Identifier [OCID] (https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) for the asynchronous request.
        /// </value>
        [JsonProperty(PropertyName = "workRequestId")]
        public string WorkRequestId { get; set; }
        
        /// <value>
        /// Number of execution occurrences.
        /// </value>
        [JsonProperty(PropertyName = "numOccurrences")]
        public System.Nullable<long> NumOccurrences { get; set; }
        
        /// <value>
        /// Compartment Identifier [OCID] (https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The date and time the scheduled task was created, in the format defined by RFC3339.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the scheduled task was last updated, in the format defined by RFC3339.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The date and time the scheduled task will execute next,
        /// in the format defined by RFC3339.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeOfNextExecution")]
        public System.Nullable<System.DateTime> TimeOfNextExecution { get; set; }
                ///
        /// <value>
        /// The current state of the scheduled task.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "DELETED")]
            Deleted
        };

        /// <value>
        /// The current state of the scheduled task.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }

    public class ScheduledTaskModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ScheduledTask);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ScheduledTask);
            var discriminator = jsonObject["kind"].Value<string>();
            switch (discriminator)
            {
                case "STANDARD":
                    obj = new StandardTask();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
