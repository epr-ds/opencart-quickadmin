using Newtonsoft.Json;

namespace Models
{
    public class DescriptionModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("tag")]
        public string Tag { get; set; }
        [JsonProperty("meta_title")]
        public string MetaTitle { get; set; }
        [JsonProperty("meta_description")]
        public string MetaDescription { get; set; }
        [JsonProperty("meta_keyword")]
        public string MetaKeyword { get; set; }
    }
}
