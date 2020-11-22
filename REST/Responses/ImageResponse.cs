using Newtonsoft.Json;

namespace REST.Responses
{
    public class ImageResponse : MessageResponse
    {
        [JsonProperty("image")]
        public string URL { get; set; }
    }
}
