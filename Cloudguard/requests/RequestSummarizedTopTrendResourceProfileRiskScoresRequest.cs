/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.CloudguardService.Models;

namespace Oci.CloudguardService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/cloudguard/RequestSummarizedTopTrendResourceProfileRiskScores.cs.html">here</a> to see an example of how to use RequestSummarizedTopTrendResourceProfileRiskScores request.
    /// </example>
    public class RequestSummarizedTopTrendResourceProfileRiskScoresRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The ID of the compartment in which to list resources.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Start time for a filter. If start time is not specified, start time will be set to today's current time - 30 days.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeScoreComputedGreaterThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeScoreComputedGreaterThanOrEqualTo { get; set; }
        
        /// <value>
        /// End time for a filter. If end time is not specified, end time will be set to today's current time.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeScoreComputedLessThanOrEqualTo")]
        public System.Nullable<System.DateTime> TimeScoreComputedLessThanOrEqualTo { get; set; }
        
        /// <value>
        /// Default is false.
        /// When set to true, the hierarchy of compartments is traversed
        /// and all compartments and subcompartments in the tenancy are
        /// returned depending on the the setting of `accessLevel`.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentIdInSubtree")]
        public System.Nullable<bool> CompartmentIdInSubtree { get; set; }
        
        ///
        /// <value>
        /// The field to sort trendlines for resource profiles. Only one sort order may be provided. If no value is specified riskScore is default.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "riskScore")]
            RiskScore,
            [EnumMember(Value = "riskScoreGrowth")]
            RiskScoreGrowth,
            [EnumMember(Value = "timeFirstDetected")]
            TimeFirstDetected,
            [EnumMember(Value = "timeLastDetected")]
            TimeLastDetected
        };

        /// <value>
        /// The field to sort trendlines for resource profiles. Only one sort order may be provided. If no value is specified riskScore is default.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// Number of resource profile risk score trend-lines to be displayed. Default value is 10.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "count")]
        public System.Nullable<int> Count { get; set; }
        
        ///
        /// <value>
        /// Valid values are `RESTRICTED` and `ACCESSIBLE`. Default is `RESTRICTED`.
        /// Setting this to `ACCESSIBLE` returns only those compartments for which the
        /// user has INSPECT permissions directly or indirectly (permissions can be on a
        /// resource in a subcompartment).
        /// When set to `RESTRICTED` permissions are checked and no partial results are displayed.
        /// 
        /// </value>
        ///
        public enum AccessLevelEnum {
            [EnumMember(Value = "RESTRICTED")]
            Restricted,
            [EnumMember(Value = "ACCESSIBLE")]
            Accessible
        };

        /// <value>
        /// Valid values are `RESTRICTED` and `ACCESSIBLE`. Default is `RESTRICTED`.
        /// Setting this to `ACCESSIBLE` returns only those compartments for which the
        /// user has INSPECT permissions directly or indirectly (permissions can be on a
        /// resource in a subcompartment).
        /// When set to `RESTRICTED` permissions are checked and no partial results are displayed.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "accessLevel")]
        public System.Nullable<AccessLevelEnum> AccessLevel { get; set; }
        
        /// <value>
        /// The maximum number of items to return.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The page token representing the page at which to start retrieving results. This is usually retrieved from a previous list call.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}