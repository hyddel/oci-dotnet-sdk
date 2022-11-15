/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Runtime.Serialization;
using Oci.ResourcemanagerService.Models;

namespace Oci.ResourcemanagerService.Responses
{
    public class ListJobOutputsResponse : Oci.Common.IOciResponse
    {

        /// <value>
        /// Unique identifier for the request.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }


        /// <value>
        /// Retrieves the next page of paginated list items. If the `opc-next-page`
        /// header appears in the response, additional pages of results remain.
        /// To receive the next page, include the header value in the `page` param.
        /// If the `opc-next-page` header does not appear in the response, there
        /// are no more list items to get. For more information about list pagination,
        /// see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-next-page")]
        public string OpcNextPage { get; set; }

        /// <value>
        /// The returned JobOutputsCollection instance.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public JobOutputsCollection JobOutputsCollection { get; set; }

    }
}
