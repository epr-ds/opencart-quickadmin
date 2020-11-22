using Newtonsoft.Json;

namespace REST.Responses
{
    public class LoginResponse : MessageResponse
    {
        [JsonProperty("api_token")]
        public string Token { get; set; }
    }
}
