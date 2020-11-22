using Newtonsoft.Json;

namespace Models
{
    public class WeightModel
    {
        [JsonProperty("weight_class_id")]
        public int ID { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        public override string ToString() => Title;
    }
}
