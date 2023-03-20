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
    /// Represents the metadata of a Kafka Connection.
    /// 
    /// </summary>
    public class KafkaConnection : Connection
    {
                ///
        /// <value>
        /// The Kafka technology type.
        /// 
        /// </value>
        ///
        public enum TechnologyTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "APACHE_KAFKA")]
            ApacheKafka,
            [EnumMember(Value = "AZURE_EVENT_HUBS")]
            AzureEventHubs,
            [EnumMember(Value = "CONFLUENT_KAFKA")]
            ConfluentKafka,
            [EnumMember(Value = "OCI_STREAMING")]
            OciStreaming
        };

        /// <value>
        /// The Kafka technology type.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TechnologyType is required.")]
        [JsonProperty(PropertyName = "technologyType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TechnologyTypeEnum> TechnologyType { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the stream pool being referenced.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "streamPoolId")]
        public string StreamPoolId { get; set; }
        
        /// <value>
        /// Kafka bootstrap. Equivalent of bootstrap.servers configuration property in Kafka:
        /// list of KafkaBootstrapServer objects specified by host/port.
        /// Used for establishing the initial connection to the Kafka cluster.
        /// Example: &quot;server1.example.com:9092,server2.example.com:9092&quot;
        /// </value>
        [JsonProperty(PropertyName = "bootstrapServers")]
        public System.Collections.Generic.List<KafkaBootstrapServer> BootstrapServers { get; set; }
                ///
        /// <value>
        /// Kafka security protocol.
        /// 
        /// </value>
        ///
        public enum SecurityProtocolEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SSL")]
            Ssl,
            [EnumMember(Value = "SASL_SSL")]
            SaslSsl,
            [EnumMember(Value = "PLAINTEXT")]
            Plaintext,
            [EnumMember(Value = "SASL_PLAINTEXT")]
            SaslPlaintext
        };

        /// <value>
        /// Kafka security protocol.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "securityProtocol")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SecurityProtocolEnum> SecurityProtocol { get; set; }
        
        /// <value>
        /// The username Oracle GoldenGate uses to connect the associated system of the given technology.
        /// This username must already exist and be available by the system/application to be connected to
        /// and must conform to the case sensitivty requirments defined in it.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        
        [JsonProperty(PropertyName = "connectionType")]
        private readonly string connectionType = "KAFKA";
    }
}
