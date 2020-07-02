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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Connection strings to connect to an Oracle Autonomous Database.
    /// 
    /// </summary>
    public class AutonomousDatabaseConnectionStrings 
    {
        
        /// <value>
        /// The High database service provides the highest level of resources to each SQL statement resulting in the highest performance, but supports the fewest number of concurrent SQL statements.
        /// </value>
        [JsonProperty(PropertyName = "high")]
        public string High { get; set; }

        /// <value>
        /// The Medium database service provides a lower level of resources to each SQL statement potentially resulting a lower level of performance, but supports more concurrent SQL statements.
        /// </value>
        [JsonProperty(PropertyName = "medium")]
        public string Medium { get; set; }

        /// <value>
        /// The Low database service provides the least level of resources to each SQL statement, but supports the most number of concurrent SQL statements.
        /// </value>
        [JsonProperty(PropertyName = "low")]
        public string Low { get; set; }

        /// <value>
        /// The database service provides the least level of resources to each SQL statement, but supports the most number of concurrent SQL statements.
        /// </value>
        [JsonProperty(PropertyName = "dedicated")]
        public string Dedicated { get; set; }

        /// <value>
        /// Returns all connection strings that can be used to connect to the Autonomous Database.
        /// For more information, please see [Predefined Database Service Names for Autonomous Transaction Processing](https://docs.oracle.com/en/cloud/paas/atp-cloud/atpug/connect-predefined.html#GUID-9747539B-FD46-44F1-8FF8-F5AC650F15BE)
        /// 
        /// </value>
        [JsonProperty(PropertyName = "allConnectionStrings")]
        public System.Collections.Generic.Dictionary<string, string> AllConnectionStrings { get; set; }
    }
}
