/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.OdaService.Models;

namespace Oci.OdaService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/oda/RotateChannelKeys.cs.html">here</a> to see an example of how to use RotateChannelKeys request.
    /// </example>
    public class RotateChannelKeysRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// Unique Digital Assistant instance identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OdaInstanceId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "odaInstanceId")]
        public string OdaInstanceId { get; set; }
        
        /// <value>
        /// Unique Channel identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ChannelId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "channelId")]
        public string ChannelId { get; set; }
        
        /// <value>
        /// The client request ID for tracing. This value is included in the opc-request-id response header.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// For optimistic concurrency control in a PUT or DELETE call for
        /// a Digital Assistant instance, set the `if-match` query parameter
        /// to the value of the `ETAG` header from a previous GET or POST
        /// response for that instance. The service updates or deletes the
        /// instance only if the etag that you provide matches the instance's
        /// current etag value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-match")]
        public string IfMatch { get; set; }
        
        /// <value>
        /// A token that uniquely identifies a request so that you can retry the request if there's
        /// a timeout or server error without the risk of executing that same action again.
        /// <br/>
        /// Retry tokens expire after 24 hours, but they can become invalid before then if there are
        /// conflicting operations. For example, if an instance was deleted and purged from the system,
        /// then the service might reject a retry of the original creation request.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-retry-token")]
        public string OpcRetryToken { get; set; }
    }
}