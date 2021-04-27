/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatabasemanagementService.Models;

namespace Oci.DatabasemanagementService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/databasemanagement/ListDatabaseParameters.cs.html">here</a> to see an example of how to use ListDatabaseParameters request.
    /// </example>
    public class ListDatabaseParametersRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Managed Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ManagedDatabaseId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "managedDatabaseId")]
        public string ManagedDatabaseId { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        ///
        /// <value>
        /// The source used to list database parameters. `CURRENT` is used to get the
        /// database parameters that are currently in effect for the database
        /// instance. `SPFILE` is used to list parameters from the server parameter
        /// file. Default is `CURRENT`.
        /// 
        /// </value>
        ///
        public enum SourceEnum {
            [EnumMember(Value = "CURRENT")]
            Current,
            [EnumMember(Value = "SPFILE")]
            Spfile
        };

        /// <value>
        /// The source used to list database parameters. `CURRENT` is used to get the
        /// database parameters that are currently in effect for the database
        /// instance. `SPFILE` is used to list parameters from the server parameter
        /// file. Default is `CURRENT`.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "source")]
        public System.Nullable<SourceEnum> Source { get; set; }
        
        /// <value>
        /// A filter to return all parameters that have the text given in their names.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "name")]
        public string Name { get; set; }
        
        /// <value>
        /// When true, results include a list of valid values for parameters (if applicable).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isAllowedValuesIncluded")]
        public System.Nullable<bool> IsAllowedValuesIncluded { get; set; }
        
        ///
        /// <value>
        /// The field to sort information by. Only one sortOrder can be used. The
        /// default sort order for `NAME` is ascending and it is case-sensitive.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "NAME")]
            Name
        };

        /// <value>
        /// The field to sort information by. Only one sortOrder can be used. The
        /// default sort order for `NAME` is ascending and it is case-sensitive.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// The option to sort information in ascending (\u2018ASC\u2019) or descending (\u2018DESC\u2019) order.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrders> SortOrder { get; set; }
    }
}