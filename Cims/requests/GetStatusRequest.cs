/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.CimsService.Models;

namespace Oci.CimsService.Requests
{
    public class GetStatusRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// Source is a downstream system. Eg: JIRA or MOS or any other source in future.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Source is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "source")]
        public string Source { get; set; }
        
        /// <value>
        /// User OCID for IDCS users that have a shadow in OCI
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Ocid is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "ocid")]
        public string Ocid { get; set; }
        
        /// <value>
        /// Unique Header for request id
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}