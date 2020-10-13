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

namespace Oci.LoggingService.Models
{
    /// <summary>
    /// source parser object.
    /// </summary>
    [JsonConverter(typeof(UnifiedAgentParserModelConverter))]
    public class UnifiedAgentParser 
    {
                ///
        /// <value>
        /// Type of fluent parser.
        /// </value>
        ///
        public enum ParserTypeEnum {
            [EnumMember(Value = "AUDITD")]
            Auditd,
            [EnumMember(Value = "JSON")]
            Json,
            [EnumMember(Value = "TSV")]
            Tsv,
            [EnumMember(Value = "CSV")]
            Csv,
            [EnumMember(Value = "NONE")]
            None,
            [EnumMember(Value = "SYSLOG")]
            Syslog,
            [EnumMember(Value = "APACHE2")]
            Apache2,
            [EnumMember(Value = "APACHE_ERROR")]
            ApacheError,
            [EnumMember(Value = "MSGPACK")]
            Msgpack,
            [EnumMember(Value = "REGEXP")]
            Regexp,
            [EnumMember(Value = "MULTILINE")]
            Multiline,
            [EnumMember(Value = "GROK")]
            Grok,
            [EnumMember(Value = "MULTILINE_GROK")]
            MultilineGrok
        };

        /// <value>
        /// Type of fluent parser.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ParserType is required.")]
        [JsonProperty(PropertyName = "parserType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ParserTypeEnum> ParserType { get; set; }

        /// <value>
        /// Specify time field for the event time. If the event doesn't have this field, the current time is used.
        /// </value>
        [JsonProperty(PropertyName = "fieldTimeKey")]
        public string FieldTimeKey { get; set; }

        /// <value>
        /// Specify types for converting a field into another type.
        /// </value>
        [JsonProperty(PropertyName = "types")]
        public System.Collections.Generic.Dictionary<string, string> Types { get; set; }

        /// <value>
        /// Specify the null value pattern.
        /// </value>
        [JsonProperty(PropertyName = "nullValuePattern")]
        public string NullValuePattern { get; set; }

        /// <value>
        /// If true, an empty string field is replaced with nil.
        /// </value>
        [JsonProperty(PropertyName = "isNullEmptyString")]
        public System.Nullable<bool> IsNullEmptyString { get; set; }

        /// <value>
        /// If true, use Fluent::EventTime.now(current time) as a timestamp when time_key is specified.
        /// </value>
        [JsonProperty(PropertyName = "isEstimateCurrentEvent")]
        public System.Nullable<bool> IsEstimateCurrentEvent { get; set; }

        /// <value>
        /// If true, keep time field in the record.
        /// </value>
        [JsonProperty(PropertyName = "isKeepTimeKey")]
        public System.Nullable<bool> IsKeepTimeKey { get; set; }

        /// <value>
        /// Specify the timeout for parse processing. This is mainly for detecting an incorrect regexp pattern.
        /// </value>
        [JsonProperty(PropertyName = "timeoutInMilliseconds")]
        public System.Nullable<int> TimeoutInMilliseconds { get; set; }
    }

    public class UnifiedAgentParserModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(UnifiedAgentParser);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(UnifiedAgentParser);
            var discriminator = jsonObject["parserType"].Value<string>();
            switch (discriminator)
            {
                case "MULTILINE_GROK":
                    obj = new UnifiedAgentMultilineGrokParser();
                    break;
                case "JSON":
                    obj = new UnifiedJSONParser();
                    break;
                case "GROK":
                    obj = new UnifiedAgentGrokParser();
                    break;
                case "NONE":
                    obj = new UnifiedAgentNoneParser();
                    break;
                case "SYSLOG":
                    obj = new UnifiedAgentSyslogParser();
                    break;
                case "AUDITD":
                    obj = new UnifiedAgentAuditdParser();
                    break;
                case "APACHE2":
                    obj = new UnifiedAgentApache2Parser();
                    break;
                case "REGEXP":
                    obj = new UnifiedAgentRegexParser();
                    break;
                case "MULTILINE":
                    obj = new UnifiedAgentMultilineParser();
                    break;
                case "TSV":
                    obj = new UnifiedAgentTsvParser();
                    break;
                case "APACHE_ERROR":
                    obj = new UnifiedAgentApacheErrorParser();
                    break;
                case "MSGPACK":
                    obj = new UnifiedAgentMsgpackParser();
                    break;
                case "CSV":
                    obj = new UnifiedAgentCsvParser();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
