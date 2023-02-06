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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Summary of database tools of autonomous database.
    /// </summary>
    public class DatabaseTool 
    {
                ///
        /// <value>
        /// Name of database tool.
        /// </value>
        ///
        public enum NameEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "APEX")]
            Apex,
            [EnumMember(Value = "DATABASE_ACTIONS")]
            DatabaseActions,
            [EnumMember(Value = "GRAPH_STUDIO")]
            GraphStudio,
            [EnumMember(Value = "OML")]
            Oml,
            [EnumMember(Value = "DATA_TRANSFORMS")]
            DataTransforms,
            [EnumMember(Value = "ORDS")]
            Ords,
            [EnumMember(Value = "MONGODB_API")]
            MongodbApi
        };

        /// <value>
        /// Name of database tool.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<NameEnum> Name { get; set; }
        
        /// <value>
        /// Indicates whether tool is enabled.
        /// </value>
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
        /// <value>
        /// Compute used by database tools.
        /// </value>
        [JsonProperty(PropertyName = "computeCount")]
        public System.Nullable<float> ComputeCount { get; set; }
        
        /// <value>
        /// The max idle time, in minutes, after which the VM used by database tools will be terminated.
        /// </value>
        [JsonProperty(PropertyName = "maxIdleTimeInMinutes")]
        public System.Nullable<int> MaxIdleTimeInMinutes { get; set; }
        
    }
}
