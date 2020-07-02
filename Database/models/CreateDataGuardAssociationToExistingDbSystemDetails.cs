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
    /// The configuration details for creating a Data Guard association for a bare metal or Exadata DB system database. For these types of DB system databases, the `creationType` should be `ExistingDbSystem`. A standby database will be created in the DB system you specify.
    /// <br/>
    /// To create a Data Guard association for a database in a virtual machine DB system, use the {@link #createDataGuardAssociationWithNewDbSystemDetails(CreateDataGuardAssociationWithNewDbSystemDetailsRequest) createDataGuardAssociationWithNewDbSystemDetails} subtype instead.
    /// 
    /// </summary>
    public class CreateDataGuardAssociationToExistingDbSystemDetails : CreateDataGuardAssociationDetails
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the DB system in which to create the standby database.
        /// You must supply this value if creationType is `ExistingDbSystem`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "peerDbSystemId")]
        public string PeerDbSystemId { get; set; }
    }
}
