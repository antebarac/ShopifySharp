﻿using Newtonsoft.Json;
using ShopifySharp.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing a recurring application charge (i.e. a monthly subscription to your Shopify application).
    /// </summary>
    public class ShopifyRecurringCharge: ShopifyObject
    {
        /// <summary>
        /// The date and time when the customer activated the <see cref="ShopifyRecurringCharge"/>. Will be null if the charge
        /// has not been activated.
        /// </summary>
        [JsonProperty("activated_on")]
        public DateTime? ActivatedOn { get; set; }

        /// <summary>
        /// The date and time when the customer will be billed. Will be null if the charge has not been activated by the customer.
        /// </summary>
        [JsonProperty("billing_on")]
        public DateTime? BillingOn { get; set; }

        /// <summary>
        /// The date and time when the customer cancelled their recurring application charge. Will be null if the charge has not
        /// been cancelled.
        /// </summary>
        [JsonProperty("cancelled_on")]
        public DateTime? CancelledOn { get; set; }

        /// <summary>
        /// The URL that the customer should be sent to, to accept or decline the recurring application charge.
        /// </summary>
        [JsonProperty("confirmation_url")]
        public string ConfirmationUrl { get; set; }

        /// <summary>
        /// The date and time when the recurring application charge was created.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The name of the recurring application charge.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The price of the recurring application charge.
        /// </summary>
        /// <remarks>Shopify returns this as a string, but JSON.net should be able to convert it to a double.</remarks>
        [JsonProperty("price")]
        public double Price { get; set; }

        /// <summary>
        /// The URL the customer is sent to once they accept/decline a charge.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// States whether or not the application charge is a test transaction.
        /// </summary>
        /// <remarks>Valid values are 'true' or null. Needs a special converter to convert null to false and vice-versa.</remarks>
        [JsonProperty("test"), JsonConverter(typeof(FalseToNullConverter))]
        public bool Test { get; set; }

        /// <summary>
        /// Number of days that the customer is eligible for a free trial.
        /// </summary>
        [JsonProperty("trial_days")]
        public int TrialDays { get; set; }

        /// <summary>
        /// The date and time when the free trial ends. 
        /// </summary>
        [JsonProperty("trial_ends_on")]
        public DateTime TrialEndsOn { get; set; }

        /// <summary>
        /// The date and time when the recurring application charge was last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
