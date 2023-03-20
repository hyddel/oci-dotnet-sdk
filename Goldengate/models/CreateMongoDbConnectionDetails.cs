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
    /// The information about a new MongoDB Connection.
    /// 
    /// </summary>
    public class CreateMongoDbConnectionDetails : CreateConnectionDetails
    {
        
        /// <value>
        /// The MongoDB technology type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TechnologyType is required.")]
        [JsonProperty(PropertyName = "technologyType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MongoDbConnection.TechnologyTypeEnum> TechnologyType { get; set; }
        
        /// <value>
        /// MongoDB connection string.
        /// e.g.: 'mongodb://mongodb0.example.com:27017/recordsrecords'
        /// 
        /// </value>
        [JsonProperty(PropertyName = "connectionString")]
        public string ConnectionString { get; set; }
        
        /// <value>
        /// The username Oracle GoldenGate uses to connect to the database.
        /// This username must already exist and be available by the database to be connected to.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        
        /// <value>
        /// The password Oracle GoldenGate uses to connect the associated database.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Oracle Autonomous Json Database.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "databaseId")]
        public string DatabaseId { get; set; }
        
        [JsonProperty(PropertyName = "connectionType")]
        private readonly string connectionType = "MONGODB";
    }
}
