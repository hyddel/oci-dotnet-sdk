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


namespace Oci.OnsService.Models
{
    /// <summary>
    /// The confirmation details for the specified subscription.
    /// For information about confirming subscriptions, see
    /// [To confirm a subscription](https://docs.cloud.oracle.com/iaas/Content/Notification/Tasks/managingtopicsandsubscriptions.htm#confirmSub).
    /// 
    /// </summary>
    public class ConfirmationResult 
    {
        
        /// <value>
        /// The name of the subscribed topic.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TopicName is required.")]
        [JsonProperty(PropertyName = "topicName")]
        public string TopicName { get; set; }

        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the topic associated with the specified subscription.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TopicId is required.")]
        [JsonProperty(PropertyName = "topicId")]
        public string TopicId { get; set; }

        /// <value>
        /// A locator that corresponds to the subscription protocol.
        /// For example, an email address for a subscription that uses the `EMAIL` protocol, or a URL for a subscription that uses an HTTP-based protocol.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Endpoint is required.")]
        [JsonProperty(PropertyName = "endpoint")]
        public string Endpoint { get; set; }

        /// <value>
        /// The URL for unsubscribing from the topic.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UnsubscribeUrl is required.")]
        [JsonProperty(PropertyName = "unsubscribeUrl")]
        public string UnsubscribeUrl { get; set; }

        /// <value>
        /// A human-readable string indicating the status of the subscription confirmation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Message is required.")]
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the subscription specified in the request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubscriptionId is required.")]
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; set; }
    }
}
