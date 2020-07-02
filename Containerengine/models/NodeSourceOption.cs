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
using Newtonsoft.Json.Linq;

namespace Oci.ContainerengineService.Models
{
    /// <summary>
    /// The source option for the node.
    /// </summary>
    [JsonConverter(typeof(NodeSourceOptionModelConverter))]
    public class NodeSourceOption 
    {
        
        /// <value>
        /// The source type of this option.
        /// `IMAGE` means the OCID is of an image.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceType is required.")]
        [JsonProperty(PropertyName = "sourceType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<NodeSourceType> SourceType { get; set; }

        /// <value>
        /// The user-friendly name of the entity corresponding to the OCID.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourceName")]
        public string SourceName { get; set; }
    }

    public class NodeSourceOptionModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(NodeSourceOption);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(NodeSourceOption);
            var discriminator = jsonObject["sourceType"].Value<string>();
            switch (discriminator)
            {
                case "IMAGE":
                    obj = new NodeSourceViaImageOption();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
