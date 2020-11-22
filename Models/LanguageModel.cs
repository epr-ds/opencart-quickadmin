using Newtonsoft.Json;

namespace Models
{
    public class LanguageModel
    {
        [JsonProperty("language_id")]
        public int ID { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("locale")]
        public string Locale { get; set; }
        [JsonProperty("directory")]
        public string Directory { get; set; }
        [JsonProperty("sort_order")]
        public string SortOrder { get; set; }
        [JsonProperty("status")]
        public int Status { get; set; }
    }
}
