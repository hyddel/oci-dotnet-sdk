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
using Newtonsoft.Json.Linq;

namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Summary of a database configuration for a resource.
    /// </summary>
    [JsonConverter(typeof(DatabaseConfigurationSummaryModelConverter))]
    public class DatabaseConfigurationSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the database insight resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseInsightId is required.")]
        [JsonProperty(PropertyName = "databaseInsightId")]
        public string DatabaseInsightId { get; set; }
        
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The database name. The database name is unique within the tenancy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseName is required.")]
        [JsonProperty(PropertyName = "databaseName")]
        public string DatabaseName { get; set; }
        
        /// <value>
        /// The user-friendly name for the database. The name does not have to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseDisplayName is required.")]
        [JsonProperty(PropertyName = "databaseDisplayName")]
        public string DatabaseDisplayName { get; set; }
        
        /// <value>
        /// Operations Insights internal representation of the database type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseType is required.")]
        [JsonProperty(PropertyName = "databaseType")]
        public string DatabaseType { get; set; }
        
        /// <value>
        /// The version of the database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DatabaseVersion is required.")]
        [JsonProperty(PropertyName = "databaseVersion")]
        public string DatabaseVersion { get; set; }
        
        /// <value>
        /// Name of the CDB.Only applies to PDB.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CdbName is required.")]
        [JsonProperty(PropertyName = "cdbName")]
        public string CdbName { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DefinedTags is required.")]
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FreeformTags is required.")]
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Processor count. This is the OCPU count for Autonomous Database and CPU core count for other database types.
        /// </value>
        [JsonProperty(PropertyName = "processorCount")]
        public System.Nullable<int> ProcessorCount { get; set; }
        
    }

    public class DatabaseConfigurationSummaryModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(DatabaseConfigurationSummary);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(DatabaseConfigurationSummary);
            var discriminator = jsonObject["entitySource"].Value<string>();
            switch (discriminator)
            {
                case "EM_MANAGED_EXTERNAL_DATABASE":
                    obj = new EmManagedExternalDatabaseConfigurationSummary();
                    break;
                case "AUTONOMOUS_DATABASE":
                    obj = new AutonomousDatabaseConfigurationSummary();
                    break;
                case "MACS_MANAGED_EXTERNAL_DATABASE":
                    obj = new MacsManagedExternalDatabaseConfigurationSummary();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
