/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// The information about a new Hadoop Distributed File System Connection.
    /// 
    /// </summary>
    public class CreateHdfsConnectionDetails : CreateConnectionDetails
    {
        
        /// <value>
        /// The Hadoop Distributed File System technology type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TechnologyType is required.")]
        [JsonProperty(PropertyName = "technologyType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<HdfsConnection.TechnologyTypeEnum> TechnologyType { get; set; }
        
        /// <value>
        /// The base64 encoded content of the Hadoop Distributed File System configuration file (core-site.xml).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CoreSiteXml is required.")]
        [JsonProperty(PropertyName = "coreSiteXml")]
        public string CoreSiteXml { get; set; }
        
        [JsonProperty(PropertyName = "connectionType")]
        private readonly string connectionType = "HDFS";
    }
}
