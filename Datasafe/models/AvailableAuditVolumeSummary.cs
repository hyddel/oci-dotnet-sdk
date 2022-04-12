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
    /// Represents the audit data volume collected by Data Safe from the target database for the specified audit profile.
    /// 
    /// </summary>
    public class AvailableAuditVolumeSummary 
    {
        
        /// <value>
        /// The OCID of the audit profile resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AuditProfileId is required.")]
        [JsonProperty(PropertyName = "auditProfileId")]
        public string AuditProfileId { get; set; }
        
        /// <value>
        /// Audit trail location on the target database from where the audit data is being collected by Data Safe.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TrailLocation is required.")]
        [JsonProperty(PropertyName = "trailLocation")]
        public string TrailLocation { get; set; }
        
        /// <value>
        /// Represents the month under consideration for which aggregated audit data volume available at the target is computed.
        /// This field will be the UTC start of the day of the first day of the month for which the aggregate count corresponds to, in the format defined by RFC3339..
        /// For instance, the value of 01-01-2021T00:00:00Z represents Jan 2021.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MonthInConsideration is required.")]
        [JsonProperty(PropertyName = "monthInConsideration")]
        public System.Nullable<System.DateTime> MonthInConsideration { get; set; }
        
        /// <value>
        /// Represents the aggregated audit data volume available in the audit trails on the target database which is yet to be collected by Data Safe for the specified month.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Volume is required.")]
        [JsonProperty(PropertyName = "volume")]
        public System.Nullable<long> Volume { get; set; }
        
    }
}