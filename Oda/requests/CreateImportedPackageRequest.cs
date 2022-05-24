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
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/oda/CreateImportedPackage.cs.html">here</a> to see an example of how to use CreateImportedPackage request.
    /// </example>
    public class CreateImportedPackageRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// Parameter values required to import the package.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CreateImportedPackageDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public CreateImportedPackageDetails CreateImportedPackageDetails { get; set; }
        
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
        
        /// <value>
        /// The client request ID for tracing. This value is included in the opc-request-id response header.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
