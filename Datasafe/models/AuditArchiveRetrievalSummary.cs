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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// Summary details of an archive retrieval.
    /// </summary>
    public class AuditArchiveRetrievalSummary 
    {
        
        /// <value>
        /// The OCID of the archive retrieval.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the compartment that contains archive retrieval.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The display name of the archive retrieval. The name does not have to be unique, and is changeable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Description of the archive retrieval.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Start month of the archive retrieval, in the format defined by RFC3339.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StartDate is required.")]
        [JsonProperty(PropertyName = "startDate")]
        public System.Nullable<System.DateTime> StartDate { get; set; }
        
        /// <value>
        /// End month of the archive retrieval, in the format defined by RFC3339.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EndDate is required.")]
        [JsonProperty(PropertyName = "endDate")]
        public System.Nullable<System.DateTime> EndDate { get; set; }
        
        /// <value>
        /// The OCID of the target associated with the archive retrieval.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetId is required.")]
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// The date time when archive retrieval was requested, in the format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeRequested")]
        public System.Nullable<System.DateTime> TimeRequested { get; set; }
        
        /// <value>
        /// The date time when archive retrieval request was fulfilled, in the format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeCompleted")]
        public System.Nullable<System.DateTime> TimeCompleted { get; set; }
        
        /// <value>
        /// The date time when retrieved archive data will be deleted from Data Safe and unloaded back into archival.
        /// </value>
        [JsonProperty(PropertyName = "timeOfExpiry")]
        public System.Nullable<System.DateTime> TimeOfExpiry { get; set; }
        
        /// <value>
        /// Total retrieved archive records audit event count.
        /// </value>
        [JsonProperty(PropertyName = "auditEventCount")]
        public System.Nullable<long> AuditEventCount { get; set; }
        
        /// <value>
        /// Error details of failed archive retrieval.
        /// </value>
        [JsonProperty(PropertyName = "errorInfo")]
        public string ErrorInfo { get; set; }
        
        /// <value>
        /// The current state of the archive retrieval.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AuditArchiveRetrievalLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Details about the current state of the archive retrieval.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm)
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm)
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}