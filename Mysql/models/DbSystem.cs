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


namespace Oci.MysqlService.Models
{
    /// <summary>
    /// A DB System is the core logical unit of MySQL Database Service.
    /// 
    /// </summary>
    public class DbSystem 
    {
        
        /// <value>
        /// The OCID of the DB System.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <value>
        /// The user-friendly name for the DB System. It does not have to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <value>
        /// User-provided data about the DB System.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <value>
        /// The OCID of the compartment the DB System belongs in.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        /// <value>
        /// The OCID of the subnet the DB System is associated with.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }

        /// <value>
        /// The Availability Domain where the primary DB System should be located.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }

        /// <value>
        /// The name of the Fault Domain the DB System is located in.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "faultDomain")]
        public string FaultDomain { get; set; }

        /// <value>
        /// The shape of the primary instances of the DB System. The shape
        /// determines resources allocated to a DB System - CPU cores
        /// and memory for VM shapes; CPU cores, memory and storage for non-VM
        /// (or bare metal) shapes. To get a list of shapes, use (the
        /// {@link #listShapes(ListShapesRequest) listShapes} operation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "shapeName")]
        public string ShapeName { get; set; }

        /// <value>
        /// Name of the MySQL Version in use for the DB System.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MysqlVersion is required.")]
        [JsonProperty(PropertyName = "mysqlVersion")]
        public string MysqlVersion { get; set; }

        [JsonProperty(PropertyName = "backupPolicy")]
        public BackupPolicy BackupPolicy { get; set; }

        [JsonProperty(PropertyName = "source")]
        public DbSystemSource Source { get; set; }

        /// <value>
        /// The OCID of the Configuration to be used for Instances in this DB System.
        /// </value>
        [JsonProperty(PropertyName = "configurationId")]
        public string ConfigurationId { get; set; }

        /// <value>
        /// Initial size of the data volume in GiBs that will be created and attached.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DataStorageSizeInGBs is required.")]
        [JsonProperty(PropertyName = "dataStorageSizeInGBs")]
        public System.Nullable<int> DataStorageSizeInGBs { get; set; }

        /// <value>
        /// The hostname for the primary endpoint of the DB System. Used for DNS.
        /// The value is the hostname portion of the primary private IP's fully qualified domain name (FQDN)
        /// (for example, \"dbsystem-1\" in FQDN \"dbsystem-1.subnet123.vcn1.oraclevcn.com\").
        /// Must be unique across all VNICs in the subnet and comply with RFC 952 and RFC 1123.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "hostnameLabel")]
        public string HostnameLabel { get; set; }

        /// <value>
        /// The IP address the DB System is configured to listen on. A private
        /// IP address of the primary endpoint of the DB System. Must be an
        /// available IP address within the subnet's CIDR. This will be a
        /// \"dotted-quad\" style IPv4 address.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }

        /// <value>
        /// The port for primary endpoint of the DB System to listen on.
        /// </value>
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }

        /// <value>
        /// The network port on which X Plugin listens for TCP/IP connections. This is the X Plugin equivalent of port.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "portX")]
        public System.Nullable<int> PortX { get; set; }

        /// <value>
        /// The network endpoints available for this DB System.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "endpoints")]
        public System.Collections.Generic.List<DbSystemEndpoint> Endpoints { get; set; }
        ///
        /// <value>
        /// The current state of the DB System.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current state of the DB System.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }

        /// <value>
        /// Additional information about the current lifecycleState.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }

        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Maintenance is required.")]
        [JsonProperty(PropertyName = "maintenance")]
        public MaintenanceDetails Maintenance { get; set; }

        /// <value>
        /// The date and time the DB System was created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }

        /// <value>
        /// The time the DB System was last updated.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }

        /// <value>
        /// Simple key-value pair applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }

        /// <value>
        /// Usage of predefined tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
    }
}
