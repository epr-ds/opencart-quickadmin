using Models.Converters;
using Newtonsoft.Json;
using System;

namespace Models
{
    public class SpecialOfferModel
    {
        [JsonProperty("product_special_id")]
        public int ID { get; set; }
        [JsonProperty("customer_group_id")]
        public int CustomerGroup { get; set; }
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
