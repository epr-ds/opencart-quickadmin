using Models.Converters;
using Newtonsoft.Json;
using System;

namespace Models
{
    public class DiscountModel
    {
        [JsonProperty("product_discount_id")]
        public int ID { get; set; }
        [JsonProperty("product_id")]
        public int ProductID { get; set; }
        [JsonProperty("customer_group_id")]
        public int CustomerGroup { get; set; }
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        [JsonProperty("priority")]
        public int Priority { get; set; }
        [JsonProperty("price")]
        public decimal Price { get; set; }
        [JsonProperty("date_start"), JsonConverter(typeof(DateTimeConverter))]
        public DateTime DateStart { get; set; }
        [JsonProperty("date_end"), JsonConverter(typeof(DateTimeConverter))]
        public DateTime DateEnd { get; set; }
    }
}
