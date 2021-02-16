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


namespace Oci.ApplicationmigrationService.Models
{
    /// <summary>
    /// Details about the Oracle Cloud @ Customer account, the source environment from which you want to migrate the application.
    /// 
    /// </summary>
    public class OccSourceDetails : SourceDetails
    {
        
        /// <value>
        /// If you are using a Oracle Cloud @ Customer account with Identity Cloud Service (IDCS), enter the service instance ID.
        /// For example, if Compute-567890123 is the account name of your Oracle Cloud @ Customer Compute service entitlement,
        /// then enter 567890123.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ComputeAccount is required.")]
        [JsonProperty(PropertyName = "computeAccount")]
        public string ComputeAccount { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "OCC";
    }
}
