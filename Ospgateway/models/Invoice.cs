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


namespace Oci.OspgatewayService.Models
{
    /// <summary>
    /// Invoice details
    /// </summary>
    public class Invoice 
    {
        
        /// <value>
        /// Invoice identifier which is generated on the on-premise sie. Pls note this is not an OCID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InvoiceId is required.")]
        [JsonProperty(PropertyName = "invoiceId")]
        public string InvoiceId { get; set; }
        
        /// <value>
        /// Invoice external reference
        /// </value>
        [JsonProperty(PropertyName = "invoiceNumber")]
        public string InvoiceNumber { get; set; }
        
        /// <value>
        /// Transaction identifier
        /// </value>
        [JsonProperty(PropertyName = "internalInvoiceId")]
        public string InternalInvoiceId { get; set; }
        
        /// <value>
        /// Is credit card payment eligible
        /// </value>
        [JsonProperty(PropertyName = "isCreditCardPayable")]
        public System.Nullable<bool> IsCreditCardPayable { get; set; }
        
        /// <value>
        /// Date of invoice
        /// </value>
        [JsonProperty(PropertyName = "timeInvoice")]
        public System.Nullable<System.DateTime> TimeInvoice { get; set; }
        
        /// <value>
        /// Tax of invoice amount
        /// </value>
        [JsonProperty(PropertyName = "tax")]
        public System.Nullable<decimal> Tax { get; set; }
        
        /// <value>
        /// Total amount of invoice
        /// </value>
        [JsonProperty(PropertyName = "invoiceAmount")]
        public System.Nullable<decimal> InvoiceAmount { get; set; }
        
        /// <value>
        /// Balance of invoice
        /// </value>
        [JsonProperty(PropertyName = "invoiceAmountDue")]
        public System.Nullable<decimal> InvoiceAmountDue { get; set; }
        
        /// <value>
        /// Invoice amount credit
        /// </value>
        [JsonProperty(PropertyName = "invoiceAmountCredited")]
        public System.Nullable<decimal> InvoiceAmountCredited { get; set; }
        
        /// <value>
        /// Invoice amount adjust
        /// </value>
        [JsonProperty(PropertyName = "invoiceAmountAdjusted")]
        public System.Nullable<decimal> InvoiceAmountAdjusted { get; set; }
        
        /// <value>
        /// Invoice amount applied
        /// </value>
        [JsonProperty(PropertyName = "invoiceAmountApplied")]
        public System.Nullable<decimal> InvoiceAmountApplied { get; set; }
        
        [JsonProperty(PropertyName = "currency")]
        public Currency Currency { get; set; }
                ///
        /// <value>
        /// Type of invoice
        /// </value>
        ///
        public enum InvoiceTypeEnum {
            [EnumMember(Value = "HARDWARE")]
            Hardware,
            [EnumMember(Value = "SUBSCRIPTION")]
            Subscription,
            [EnumMember(Value = "SUPPORT")]
            Support,
            [EnumMember(Value = "LICENSE")]
            License,
            [EnumMember(Value = "EDUCATION")]
            Education,
            [EnumMember(Value = "CONSULTING")]
            Consulting,
            [EnumMember(Value = "SERVICE")]
            Service,
            [EnumMember(Value = "USAGE")]
            Usage
        };

        /// <value>
        /// Type of invoice
        /// </value>
        [JsonProperty(PropertyName = "invoiceType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<InvoiceTypeEnum> InvoiceType { get; set; }
        
        /// <value>
        /// Due date of invoice
        /// </value>
        [JsonProperty(PropertyName = "timeInvoiceDue")]
        public System.Nullable<System.DateTime> TimeInvoiceDue { get; set; }
        
        /// <value>
        /// Invoice reference number
        /// </value>
        [JsonProperty(PropertyName = "invoiceRefNumber")]
        public string InvoiceRefNumber { get; set; }
        
        /// <value>
        /// Invoice PO number
        /// </value>
        [JsonProperty(PropertyName = "invoicePoNumber")]
        public string InvoicePoNumber { get; set; }
                ///
        /// <value>
        /// Invoice status
        /// </value>
        ///
        public enum InvoiceStatusEnum {
            [EnumMember(Value = "OPEN")]
            Open,
            [EnumMember(Value = "PAST_DUE")]
            PastDue,
            [EnumMember(Value = "PAYMENT_SUBMITTED")]
            PaymentSubmitted,
            [EnumMember(Value = "CLOSED")]
            Closed
        };

        /// <value>
        /// Invoice status
        /// </value>
        [JsonProperty(PropertyName = "invoiceStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<InvoiceStatusEnum> InvoiceStatus { get; set; }
        
        /// <value>
        /// Preferred Email on the invoice
        /// </value>
        [JsonProperty(PropertyName = "preferredEmail")]
        public string PreferredEmail { get; set; }
        
        /// <value>
        /// Is emailing pdf allowed
        /// </value>
        [JsonProperty(PropertyName = "isPdfEmailAvailable")]
        public System.Nullable<bool> IsPdfEmailAvailable { get; set; }
        
        /// <value>
        /// Is pdf download access allowed
        /// </value>
        [JsonProperty(PropertyName = "isDisplayDownloadPdf")]
        public System.Nullable<bool> IsDisplayDownloadPdf { get; set; }
        
        /// <value>
        /// Whether invoice can be payed
        /// </value>
        [JsonProperty(PropertyName = "isPayable")]
        public System.Nullable<bool> IsPayable { get; set; }
        
        /// <value>
        /// Payment terms
        /// </value>
        [JsonProperty(PropertyName = "paymentTerms")]
        public string PaymentTerms { get; set; }
        
        [JsonProperty(PropertyName = "lastPaymentDetail")]
        public PaymentDetail LastPaymentDetail { get; set; }
        
        [JsonProperty(PropertyName = "billToAddress")]
        public BillToAddress BillToAddress { get; set; }
        
        /// <value>
        /// List of subscription identifiers
        /// </value>
        [JsonProperty(PropertyName = "subscriptionIds")]
        public System.Collections.Generic.List<string> SubscriptionIds { get; set; }
        
    }
}
