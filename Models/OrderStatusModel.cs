using Newtonsoft.Json;

namespace Models
{
    public class OrderStatusModel
    {
        [JsonProperty("order_status_id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        public override string ToString() => Name;
    }
}
