/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.OpsiService.Models;

namespace Oci.OpsiService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/opsi/SummarizeHostInsightResourceCapacityTrend.cs.html">here</a> to see an example of how to use SummarizeHostInsightResourceCapacityTrend request.
    /// </example>
    public class SummarizeHostInsightResourceCapacityTrendRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Filter by host resource metric.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceMetric is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "resourceMetric")]
        public string ResourceMetric { get; set; }
        
        /// <value>
        /// Specify time period in ISO 8601 format with respect to current time.
        /// Default is last 30 days represented by P30D.
        /// If timeInterval is specified, then timeIntervalStart and timeIntervalEnd will be ignored.
        /// Examples  P90D (last 90 days), P4W (last 4 weeks), P2M (last 2 months), P1Y (last 12 months), . Maximum value allowed is 25 months prior to current time (P25M).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "analysisTimeInterval")]
        public string AnalysisTimeInterval { get; set; }
        
        /// <value>
        /// Analysis start time in UTC in ISO 8601 format(inclusive).
        /// Example 2019-10-30T00:00:00Z (yyyy-MM-ddThh:mm:ssZ).
        /// The minimum allowed value is 2 years prior to the current day.
        /// timeIntervalStart and timeIntervalEnd parameters are used together.
        /// If analysisTimeInterval is specified, this parameter is ignored.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeIntervalStart")]
        public System.Nullable<System.DateTime> TimeIntervalStart { get; set; }
        
        /// <value>
        /// Analysis end time in UTC in ISO 8601 format(exclusive).
        /// Example 2019-10-30T00:00:00Z (yyyy-MM-ddThh:mm:ssZ).
        /// timeIntervalStart and timeIntervalEnd are used together.
        /// If timeIntervalEnd is not specified, current time is used as timeIntervalEnd.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeIntervalEnd")]
        public System.Nullable<System.DateTime> TimeIntervalEnd { get; set; }
        
        ///
        /// <value>
        /// Filter by one or more platform types.
        /// Supported platformType(s) for MACS-managed external host insight: [LINUX].
        /// Supported platformType(s) for MACS-managed cloud host insight: [LINUX].
        /// Supported platformType(s) for EM-managed external host insight: [LINUX, SOLARIS, SUNOS, ZLINUX].
        /// 
        /// </value>
        ///
        public enum PlatformTypeEnum {
            [EnumMember(Value = "LINUX")]
            Linux,
            [EnumMember(Value = "SOLARIS")]
            Solaris,
            [EnumMember(Value = "SUNOS")]
            Sunos,
            [EnumMember(Value = "ZLINUX")]
            Zlinux
        };

        /// <value>
        /// Filter by one or more platform types.
        /// Supported platformType(s) for MACS-managed external host insight: [LINUX].
        /// Supported platformType(s) for MACS-managed cloud host insight: [LINUX].
        /// Supported platformType(s) for EM-managed external host insight: [LINUX, SOLARIS, SUNOS, ZLINUX].
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "platformType", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<PlatformTypeEnum> PlatformType { get; set; }
        
        /// <value>
        /// Optional list of host insight resource [OCIDs](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "id", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> Id { get; set; }
        
        /// <value>
        /// Optional list of exadata insight resource [OCIDs](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "exadataInsightId", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> ExadataInsightId { get; set; }
        
        ///
        /// <value>
        /// Filter by utilization level by the following buckets:
        ///   - HIGH_UTILIZATION: DBs with utilization greater or equal than 75.
        ///   - LOW_UTILIZATION: DBs with utilization lower than 25.
        ///   - MEDIUM_HIGH_UTILIZATION: DBs with utilization greater or equal than 50 but lower than 75.
        ///   - MEDIUM_LOW_UTILIZATION: DBs with utilization greater or equal than 25 but lower than 50.
        /// 
        /// </value>
        ///
        public enum UtilizationLevelEnum {
            [EnumMember(Value = "HIGH_UTILIZATION")]
            HighUtilization,
            [EnumMember(Value = "LOW_UTILIZATION")]
            LowUtilization,
            [EnumMember(Value = "MEDIUM_HIGH_UTILIZATION")]
            MediumHighUtilization,
            [EnumMember(Value = "MEDIUM_LOW_UTILIZATION")]
            MediumLowUtilization
        };

        /// <value>
        /// Filter by utilization level by the following buckets:
        ///   - HIGH_UTILIZATION: DBs with utilization greater or equal than 75.
        ///   - LOW_UTILIZATION: DBs with utilization lower than 25.
        ///   - MEDIUM_HIGH_UTILIZATION: DBs with utilization greater or equal than 50 but lower than 75.
        ///   - MEDIUM_LOW_UTILIZATION: DBs with utilization greater or equal than 25 but lower than 50.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "utilizationLevel")]
        public System.Nullable<UtilizationLevelEnum> UtilizationLevel { get; set; }
        
        /// <value>
        /// For list pagination. The value of the `opc-next-page` response header from
        /// the previous \"List\" call. For important details about how pagination works,
        /// see [List Pagination](https://docs.cloud.oracle.com/Content/API/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrder> SortOrder { get; set; }
        
        ///
        /// <value>
        /// Sorts using end timestamp or capacity
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "endTimestamp")]
            EndTimestamp,
            [EnumMember(Value = "capacity")]
            Capacity
        };

        /// <value>
        /// Sorts using end timestamp or capacity
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact
        /// Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// A list of tag filters to apply.  Only resources with a defined tag matching the value will be returned.
        /// Each item in the list has the format \"{namespace}.{tagName}.{value}\".  All inputs are case-insensitive.
        /// Multiple values for the same key (i.e. same namespace and tag name) are interpreted as \"OR\".
        /// Values for different keys (i.e. different namespaces, different tag names, or both) are interpreted as \"AND\".
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "definedTagEquals", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> DefinedTagEquals { get; set; }
        
        /// <value>
        /// A list of tag filters to apply.  Only resources with a freeform tag matching the value will be returned.
        /// The key for each tag is \"{tagName}.{value}\".  All inputs are case-insensitive.
        /// Multiple values for the same tag name are interpreted as \"OR\".  Values for different tag names are interpreted as \"AND\".
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "freeformTagEquals", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> FreeformTagEquals { get; set; }
        
        /// <value>
        /// A list of tag existence filters to apply.  Only resources for which the specified defined tags exist will be returned.
        /// Each item in the list has the format \"{namespace}.{tagName}.true\" (for checking existence of a defined tag)
        /// or \"{namespace}.true\".  All inputs are case-insensitive.
        /// Currently, only existence (\"true\" at the end) is supported. Absence (\"false\" at the end) is not supported.
        /// Multiple values for the same key (i.e. same namespace and tag name) are interpreted as \"OR\".
        /// Values for different keys (i.e. different namespaces, different tag names, or both) are interpreted as \"AND\".
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "definedTagExists", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> DefinedTagExists { get; set; }
        
        /// <value>
        /// A list of tag existence filters to apply.  Only resources for which the specified freeform tags exist the value will be returned.
        /// The key for each tag is \"{tagName}.true\".  All inputs are case-insensitive.
        /// Currently, only existence (\"true\" at the end) is supported. Absence (\"false\" at the end) is not supported.
        /// Multiple values for different tag names are interpreted as \"AND\".
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "freeformTagExists", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> FreeformTagExists { get; set; }
        
        /// <value>
        /// A flag to search all resources within a given compartment and all sub-compartments.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentIdInSubtree")]
        public System.Nullable<bool> CompartmentIdInSubtree { get; set; }
        
        /// <value>
        /// Filter by one or more host types.
        /// Possible values are CLOUD-HOST, EXTERNAL-HOST
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "hostType", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> HostType { get; set; }
        
        /// <value>
        /// Optional [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the host (Compute Id)
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "hostId")]
        public string HostId { get; set; }
        
        /// <value>
        /// Optional list of Exadata Insight VM cluster name.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "vmclusterName", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> VmclusterName { get; set; }
    }
}
