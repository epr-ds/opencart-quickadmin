using Newtonsoft.Json;

namespace Models
{
    public class OrderTotalModel
    {
        [JsonProperty("order_total_id")]
        public int ID { get; set; }
        [JsonProperty("order_id")]
        public int OrderID { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("value")]
        public decimal Value { get; set; }
        [JsonProperty("sort_order")]
        public int SortOrder { get; set; }

        public override string ToString() => $"{Title}: ${((Value != 0) ? $"{Value:#.##}" : "0")}";
    }
}
