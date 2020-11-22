using System;
using Newtonsoft.Json;
using Models.Converters;

namespace Models
{
    public class LayoutModel
    {
        [JsonProperty("product_discount_id")]
        public int ID { get; set; }
        [JsonProperty("product_id")]
        public int ProductID { get; set; }
        [JsonProperty("customer_group_id")]
        public int CustomerGroupID { get; set; }
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        [JsonProperty("priority")]
        public int Priority { get; set; }
        [JsonProperty("price")]
        public double Price { get; set; }
        [JsonProperty("date_start"), JsonConverter(typeof(DateTimeConverter))]
        public DateTime DateStart { get; set; }
        [JsonProperty("date_end"), JsonConverter(typeof(DateTimeConverter))]
        public DateTime DateEnd { get; set; }
    }
}
