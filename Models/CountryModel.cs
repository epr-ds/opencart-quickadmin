using Newtonsoft.Json;

namespace Models
{
    public class CountryModel
    {
        [JsonProperty("country_id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("iso_code_2")]
        public string Iso_code_2 { get; set; }

        [JsonProperty("iso_code_3")]
        public string Iso_code_3 { get; set; }

        [JsonProperty("address_format")]
        public string Address_format { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        public override string ToString() => Name;
    }
}
