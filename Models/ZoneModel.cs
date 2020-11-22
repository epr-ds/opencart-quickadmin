using Newtonsoft.Json;

namespace Models
{
    public class ZoneModel
    {
        [JsonProperty("zone_id")]
        public int ID { get; set; }

        [JsonProperty("country_id")]
        public int Country_ID { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        public override string ToString() => Name;
    }
}
