/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Beef.Entities;
using Newtonsoft.Json;

namespace Cdr.Banking.Business.Data.Model
{
    /// <summary>
    /// Represents the Credit Card Account entity.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class CreditCardAccount
    {
        /// <summary>
        /// Gets or sets the Min Payment Amount.
        /// </summary>
        [JsonProperty("minPaymentAmount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal MinPaymentAmount { get; set; }

        /// <summary>
        /// Gets or sets the Payment Due Amount.
        /// </summary>
        [JsonProperty("paymentDueAmount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal PaymentDueAmount { get; set; }

        /// <summary>
        /// Gets or sets the Payment Currency.
        /// </summary>
        [JsonProperty("paymentCurrency", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? PaymentCurrency { get; set; }

        /// <summary>
        /// Gets or sets the Payment Due Date.
        /// </summary>
        [JsonProperty("paymentDueDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime PaymentDueDate { get; set; }
    } 
}

#nullable restore