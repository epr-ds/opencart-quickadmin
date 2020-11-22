using Newtonsoft.Json;

namespace REST.Responses
{
    public class MessageResponse
    {
        [JsonProperty("success")]
        public string Success { get; set; }
        
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("payload")]
        public dynamic Payload { get; set; }
    }
}
