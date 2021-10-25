/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// The information needed to create a lightweight Tag
    /// </summary>
    public class RepositoryTagSummary : RepositoryRefSummary
    {
        
        /// <value>
        /// SHA-1 hash value of the object pointed to by the tag.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectId is required.")]
        [JsonProperty(PropertyName = "objectId")]
        public string ObjectId { get; set; }
        
        [JsonProperty(PropertyName = "refType")]
        private readonly string refType = "TAG";
    }
}
