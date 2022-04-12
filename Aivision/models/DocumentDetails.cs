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
using Newtonsoft.Json.Linq;

namespace Oci.AivisionService.Models
{
    /// <summary>
    /// The details of a document to analyze.
    /// </summary>
    [JsonConverter(typeof(DocumentDetailsModelConverter))]
    public class DocumentDetails 
    {
                ///
        /// <value>
        /// The location of the document data.
        /// The allowed values are:
        /// - `INLINE`: The data is included directly in the request payload.
        /// - `OBJECT_STORAGE`: The document is in OCI Object Storage.
        /// 
        /// </value>
        ///
        public enum SourceEnum {
            [EnumMember(Value = "INLINE")]
            Inline,
            [EnumMember(Value = "OBJECT_STORAGE")]
            ObjectStorage
        };

        
    }

    public class DocumentDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(DocumentDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(DocumentDetails);
            var discriminator = jsonObject["source"].Value<string>();
            switch (discriminator)
            {
                case "OBJECT_STORAGE":
                    obj = new ObjectStorageDocumentDetails();
                    break;
                case "INLINE":
                    obj = new InlineDocumentDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}