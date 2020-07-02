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


namespace Oci.OsmanagementService.Models
{
    /// <summary>
    /// Information for creating a Scheduled Job
    /// </summary>
    public class CreateScheduledJobDetails 
    {
        
        /// <value>
        /// OCID for the Compartment
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        /// <value>
        /// Scheduled Job name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <value>
        /// Details describing the Scheduled Job.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <value>
        /// the type of scheduling this Scheduled Job follows
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ScheduleType is required.")]
        [JsonProperty(PropertyName = "scheduleType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ScheduleTypes> ScheduleType { get; set; }

        /// <value>
        /// the desired time for the next execution of this Scheduled Job
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeNextExecution is required.")]
        [JsonProperty(PropertyName = "timeNextExecution")]
        public System.Nullable<System.DateTime> TimeNextExecution { get; set; }

        /// <value>
        /// the interval period for a recurring Scheduled Job (only if schedule type is RECURRING)
        /// </value>
        [JsonProperty(PropertyName = "intervalType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<IntervalTypes> IntervalType { get; set; }

        /// <value>
        /// the value for the interval period for a recurring Scheduled Job (only if schedule type is RECURRING)
        /// </value>
        [JsonProperty(PropertyName = "intervalValue")]
        public string IntervalValue { get; set; }

        /// <value>
        /// The list of managed instances this scheduled job operates on
        /// (mutually exclusive with managedInstanceGroups). Either this or the
        /// managedInstanceGroups must be supplied.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "managedInstances")]
        public System.Collections.Generic.List<Id> ManagedInstances { get; set; }

        /// <value>
        /// The list of managed instance groups this scheduled job operates on
        /// (mutually exclusive with managedInstances). Either this or
        /// managedInstances must be supplied. 
        /// 
        /// </value>
        [JsonProperty(PropertyName = "managedInstanceGroups")]
        public System.Collections.Generic.List<Id> ManagedInstanceGroups { get; set; }

        /// <value>
        /// the type of operation this Scheduled Job performs
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OperationType is required.")]
        [JsonProperty(PropertyName = "operationType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OperationTypes> OperationType { get; set; }

        /// <value>
        /// Type of the update (only if operation type is UPDATEALL)
        /// </value>
        [JsonProperty(PropertyName = "updateType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PackageUpdateTypes> UpdateType { get; set; }

        /// <value>
        /// the id of the package (only if operation type is INSTALL/UPDATE/REMOVE)
        /// </value>
        [JsonProperty(PropertyName = "packageNames")]
        public System.Collections.Generic.List<PackageName> PackageNames { get; set; }

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

        /// <value>
        /// The unique names of the Windows Updates (only if operation type is INSTALL).
        /// This is only applicable when the osFamily is for Windows managed instances.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "updateNames")]
        public System.Collections.Generic.List<string> UpdateNames { get; set; }

        /// <value>
        /// The Operating System type of the managed instance(s) on which this scheduled job will operate.
        /// If not specified, this defaults to Linux.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "osFamily")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OsFamilies> OsFamily { get; set; }
    }
}
