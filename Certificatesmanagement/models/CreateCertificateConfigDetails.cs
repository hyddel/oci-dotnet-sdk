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

namespace Oci.CertificatesmanagementService.Models
{
    /// <summary>
    /// The details of the contents of the certificate and certificate metadata.
    /// </summary>
    [JsonConverter(typeof(CreateCertificateConfigDetailsModelConverter))]
    public class CreateCertificateConfigDetails 
    {
        
        
        /// <value>
        /// A name for the certificate. When the value is not null, a name is unique across versions of a given certificate.
        /// </value>
        [JsonProperty(PropertyName = "versionName")]
        public string VersionName { get; set; }
        
    }

    public class CreateCertificateConfigDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateCertificateConfigDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateCertificateConfigDetails);
            var discriminator = jsonObject["configType"].Value<string>();
            switch (discriminator)
            {
                case "MANAGED_EXTERNALLY_ISSUED_BY_INTERNAL_CA":
                    obj = new CreateCertificateManagedExternallyIssuedByInternalCaConfigDetails();
                    break;
                case "ISSUED_BY_INTERNAL_CA":
                    obj = new CreateCertificateIssuedByInternalCaConfigDetails();
                    break;
                case "IMPORTED":
                    obj = new CreateCertificateByImportingConfigDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}