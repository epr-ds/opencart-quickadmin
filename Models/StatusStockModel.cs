using Newtonsoft.Json;

namespace Models
{
    public class StatusStockModel
    {
        [JsonProperty("stock_status_id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        public override string ToString() => Name;
    }
}
