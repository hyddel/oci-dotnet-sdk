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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Partial definition of the exadata insight resource.
    /// </summary>
    public class ExadataMemberCollection 
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
        /// Collection of Exadata members
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Items is required.")]
        [JsonProperty(PropertyName = "items")]
        public System.Collections.Generic.List<ExadataMemberSummary> Items { get; set; }
        
    }
}
