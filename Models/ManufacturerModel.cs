using Newtonsoft.Json;

namespace Models
{
    public class ManufacturerModel
    {
        [JsonProperty("manufacturer_id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        public override string ToString() => Name;
    }
}
