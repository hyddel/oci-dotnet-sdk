/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.CertificatesmanagementService.Models;

namespace Oci.CertificatesmanagementService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/certificatesmanagement/ListCertificates.cs.html">here</a> to see an example of how to use ListCertificates request.
    /// </example>
    public class ListCertificatesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If provided, the returned request ID
        /// will include this value. Otherwise, a random request ID will be
        /// generated by the service.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// A filter that returns only resources that match the given compartment OCID.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        ///
        /// <value>
        /// A filter that returns only resources that match the given lifecycle state. The state value is case-insensitive.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "SCHEDULING_DELETION")]
            SchedulingDeletion,
            [EnumMember(Value = "PENDING_DELETION")]
            PendingDeletion,
            [EnumMember(Value = "CANCELLING_DELETION")]
            CancellingDeletion,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// A filter that returns only resources that match the given lifecycle state. The state value is case-insensitive.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleState")]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// A filter that returns only resources that match the specified name.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "name")]
        public string Name { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. You can specify only one sort order. The default
        /// order for `EXPIRATIONDATE` and 'TIMECREATED' is descending. The default order for `NAME`
        /// is ascending.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "NAME")]
            Name,
            [EnumMember(Value = "EXPIRATIONDATE")]
            Expirationdate,
            [EnumMember(Value = "TIMECREATED")]
            Timecreated
        };

        /// <value>
        /// The field to sort by. You can specify only one sort order. The default
        /// order for `EXPIRATIONDATE` and 'TIMECREATED' is descending. The default order for `NAME`
        /// is ascending.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        ///
        /// <value>
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`).
        /// 
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        /// <value>
        /// The maximum number of items to return in a paginated \"List\" call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The value of the `opc-next-page` response header
        /// from the previous \"List\" call.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The OCID of the certificate authority (CA). If the parameter is set to null, the service lists all CAs.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "issuerCertificateAuthorityId")]
        public string IssuerCertificateAuthorityId { get; set; }
        
        /// <value>
        /// The OCID of the certificate. If the parameter is set to null, the service lists all certificates.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "certificateId")]
        public string CertificateId { get; set; }
    }
}