/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.LoggingingestionService.Models;

namespace Oci.LoggingingestionService.Requests
{
    public class PutLogsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// OCID of a log to work with.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LogId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "logId")]
        public string LogId { get; set; }
        
        /// <value>
        /// The logs to emit.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PutLogsDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public PutLogsDetails PutLogsDetails { get; set; }
        
        /// <value>
        /// Effective timestamp, for when the agent started processing the log
        /// segment being sent. An RFC3339-formatted date-time string.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "timestamp-opc-agent-processing")]
        public System.Nullable<System.DateTime> TimestampOpcAgentProcessing { get; set; }
        
        /// <value>
        /// Version of the agent sending the request.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-agent-version")]
        public string OpcAgentVersion { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about
        /// a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}