using Models.Converters;
using Newtonsoft.Json;
using System;

namespace Models
{
    public class OrderModel
    {
        [JsonProperty("order_id")]
        public int ID { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("order_status")]
        public string OrderStatus { get; set; }

        [JsonProperty("total")]
        public decimal Total { get; set; }

        [JsonProperty("date_added"), JsonConverter(typeof(DateTimeConverter))]
        public DateTime DateAdded { get; set; }

        [JsonProperty("date_modified"), JsonConverter(typeof(DateTimeConverter))]
        public DateTime DateModified { get; set; }
    }
}
