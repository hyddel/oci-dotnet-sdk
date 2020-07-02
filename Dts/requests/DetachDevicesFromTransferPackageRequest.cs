/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DtsService.Models;

namespace Oci.DtsService.Requests
{
    public class DetachDevicesFromTransferPackageRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// ID of the Transfer Job
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Label of the Transfer Package
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TransferPackageLabel is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "transferPackageLabel")]
        public string TransferPackageLabel { get; set; }
        
        /// <value>
        /// Labels of Transfer Devices to detach
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DetachDevicesDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public DetachDevicesDetails DetachDevicesDetails { get; set; }
    }
}