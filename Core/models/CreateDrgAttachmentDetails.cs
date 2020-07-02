/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.CoreService.Models
{
    
    public class CreateDrgAttachmentDetails 
    {
        
        /// <value>
        /// A user-friendly name. Does not have to be unique. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <value>
        /// The OCID of the DRG.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DrgId is required.")]
        [JsonProperty(PropertyName = "drgId")]
        public string DrgId { get; set; }

        /// <value>
        /// The OCID of the route table the DRG attachment will use.
        /// <br/>
        /// If you don't specify a route table here, the DRG attachment is created without an associated route
        /// table. The Networking service does NOT automatically associate the attached VCN's default route table
        /// with the DRG attachment.
        /// <br/>
        /// For information about why you would associate a route table with a DRG attachment, see:
        /// <br/>
        ///   * [Transit Routing: Access to Multiple VCNs in Same Region](https://docs.cloud.oracle.com/Content/Network/Tasks/transitrouting.htm)
        ///   * [Transit Routing: Private Access to Oracle Services](https://docs.cloud.oracle.com/Content/Network/Tasks/transitroutingoracleservices.htm)
        /// 
        /// </value>
        [JsonProperty(PropertyName = "routeTableId")]
        public string RouteTableId { get; set; }

        /// <value>
        /// The OCID of the VCN.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VcnId is required.")]
        [JsonProperty(PropertyName = "vcnId")]
        public string VcnId { get; set; }
    }
}
