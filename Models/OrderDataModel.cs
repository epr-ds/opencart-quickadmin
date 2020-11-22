using Newtonsoft.Json;
using System.Collections.Generic;

namespace Models
{
    public class OrderDataModel : OrderModel
    {
        [JsonProperty("invoice_no")]
        public int InvoiceNo { get; set; }

        [JsonProperty("invoice_prefix")]
        public string InvoicePrefix { get; set; }

        [JsonProperty("store")]
        public StoreModel Store { get; set; }

        [JsonProperty("customer")]
        public new CustomerModel Customer { get; set; }

        [JsonProperty("payment_custom_field")]
        public PaymentCustomFieldModel PaymentCustomField { get; set; }

        [JsonProperty("payment_address")]
        public AddressModel PaymentAddress { get; set; }

        [JsonProperty("payment_method")]
        public PaymentMethodModel PaymentMethod { get; set; }

        [JsonProperty("shipping_address")]
        public AddressModel ShippingAddress { get; set; }

        [JsonProperty("shipping_method")]
        public ShippingMethodModel ShippingMethod { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("reward")]
        public int Reward { get; set; }

        [JsonProperty("order_status_id")]
        public new int OrderStatus { get; set; }

        [JsonProperty("commission")]
        public decimal Commission { get; set; }

        [JsonProperty("currency")]
        public CurrencyModel Currency { get; set; }

        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }

        [JsonProperty("order_total")]
        public IEnumerable<OrderTotalModel> OrderTotals { get; set; }

        [JsonProperty("order_products")]
        public IEnumerable<OrderProductModel> Cart { get; set; }
    }
}
