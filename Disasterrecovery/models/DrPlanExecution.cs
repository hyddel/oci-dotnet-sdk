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


namespace Oci.DisasterrecoveryService.Models
{
    /// <summary>
    /// The details of a DR Plan Execution.
    /// </summary>
    public class DrPlanExecution 
    {
        
        /// <value>
        /// The OCID of the DR Plan Execution.
        /// <br/>
        /// Example: ocid1.drplanexecution.oc1.iad.exampleocid2
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the compartment containing this DR Plan Execution.
        /// <br/>
        /// Example: ocid1.compartment.oc1..exampleocid1
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The display name of this DR Plan Execution.
        /// <br/>
        /// Example: Execution - EBS Switchover PHX to IAD
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The OCID of the DR Plan.
        /// <br/>
        /// Example: ocid1.drplan.oc1.iad.exampleocid2
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PlanId is required.")]
        [JsonProperty(PropertyName = "planId")]
        public string PlanId { get; set; }
        
        /// <value>
        /// The type of the DR Plan executed.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PlanExecutionType is required.")]
        [JsonProperty(PropertyName = "planExecutionType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DrPlanExecutionType> PlanExecutionType { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExecutionOptions is required.")]
        [JsonProperty(PropertyName = "executionOptions")]
        public DrPlanExecutionOptions ExecutionOptions { get; set; }
        
        /// <value>
        /// The OCID of the DR Protection Group to which this DR Plan Execution belongs.
        /// <br/>
        /// Example: ocid1.drprotectiongroup.oc1.iad.exampleocid2
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DrProtectionGroupId is required.")]
        [JsonProperty(PropertyName = "drProtectionGroupId")]
        public string DrProtectionGroupId { get; set; }
        
        /// <value>
        /// The OCID of peer (remote) DR Protection Group associated with this plan's
        /// DR Protection Group.
        /// <br/>
        /// Example: ocid1.drprotectiongroup.oc1.phx.exampleocid1
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PeerDrProtectionGroupId is required.")]
        [JsonProperty(PropertyName = "peerDrProtectionGroupId")]
        public string PeerDrProtectionGroupId { get; set; }
        
        /// <value>
        /// The region of the peer (remote) DR Protection Group.
        /// <br/>
        /// Example: us-ashburn-1
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PeerRegion is required.")]
        [JsonProperty(PropertyName = "peerRegion")]
        public string PeerRegion { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LogLocation is required.")]
        [JsonProperty(PropertyName = "logLocation")]
        public ObjectStorageLogLocation LogLocation { get; set; }
        
        /// <value>
        /// The date and time at which DR Plan Execution was created. An RFC3339 formatted datetime string.
        /// <br/>
        /// Example: 2019-03-29T09:36:42Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time at which DR Plan Execution began. An RFC3339 formatted datetime string.
        /// <br/>
        /// Example: 2019-03-29T09:36:42Z
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The time at which DR Plan Execution was last updated. An RFC3339 formatted datetime string.
        /// <br/>
        /// Example: 2019-03-29T09:36:42Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The date and time at which DR Plan Execution succeeded, failed, was paused, or was canceled.
        /// An RFC3339 formatted datetime string.
        /// <br/>
        /// Example: 2019-03-29T09:36:42Z
        /// </value>
        [JsonProperty(PropertyName = "timeEnded")]
        public System.Nullable<System.DateTime> TimeEnded { get; set; }
        
        /// <value>
        /// The total duration in seconds taken to complete the DR Plan Execution.
        /// <br/>
        /// Example: 750
        /// </value>
        [JsonProperty(PropertyName = "executionDurationInSec")]
        public System.Nullable<int> ExecutionDurationInSec { get; set; }
        
        /// <value>
        /// A list of groups executed in this DR Plan Execution.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "GroupExecutions is required.")]
        [JsonProperty(PropertyName = "groupExecutions")]
        public System.Collections.Generic.List<DrPlanGroupExecution> GroupExecutions { get; set; }
        
        /// <value>
        /// The current state of the DR Plan Execution.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DrPlanExecutionLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the DR Plan Execution's current state in more detail.
        /// <br/>
        /// Example: The DR Plan Execution [Execution - EBS Switchover PHX to IAD] is currently in progress
        /// </value>
        [JsonProperty(PropertyName = "lifeCycleDetails")]
        public string LifeCycleDetails { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}