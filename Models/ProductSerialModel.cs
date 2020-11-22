using Models.Converters;
using Newtonsoft.Json;
using System;

namespace Models
{
    public class ProductSerialModel
    {
        [JsonProperty("order_id")]
        public int OrderID { get; set; }

        [JsonProperty("product_id")]
        public int ProductID { get; set; }

        [JsonProperty("product_name")]
        public string ProductName { get; set; }

        [JsonProperty("product_model")]
        public string ProductModel { get; set; }

        [JsonProperty("serial_number")]
        public string SerialNumber { get; set; }

        [JsonProperty("date_start"), JsonConverter(typeof(DateTimeConverter))]
        public DateTime DateStart { get; set; }

        [JsonProperty("date_end"), JsonConverter(typeof(DateTimeConverter))]
        public DateTime DateEnd { get; set; }

        [JsonProperty("product_warranty_id")]
        public int ID { get; set; }
    }
}
