/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Runtime.Serialization;
using Oci.EventsService.Models;

namespace Oci.EventsService.Responses
{
    public class GetRuleResponse : Oci.Common.IOciResponse
    {

        /// <value>
        /// For optimistic concurrency control. Add this value to the `if-match` parameter
        /// in a PUT or DELETE operation. The resource will be updated only if the value you
        /// provide matches the `etag` on the resource.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "etag")]
        public string Etag { get; set; }


        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about
        /// a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }

        /// <value>
        /// The returned Rule instance.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public Rule Rule { get; set; }

    }
}