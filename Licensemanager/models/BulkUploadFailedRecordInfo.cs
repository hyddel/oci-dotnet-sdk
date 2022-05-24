/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.LicensemanagerService.Models
{
    /// <summary>
    /// Error information for a valid license record that could not be uploaded.
    /// </summary>
    public class BulkUploadFailedRecordInfo 
    {
        
        /// <value>
        /// Refers to the license record number as provided in the bulk upload file.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RowNumber is required.")]
        [JsonProperty(PropertyName = "rowNumber")]
        public System.Nullable<int> RowNumber { get; set; }
        
        /// <value>
        /// Product name of the failed row.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProductName is required.")]
        [JsonProperty(PropertyName = "productName")]
        public string ProductName { get; set; }
        
        /// <value>
        /// Failed license record error information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Error is required.")]
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }
        
    }
}
