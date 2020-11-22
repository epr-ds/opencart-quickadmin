using Newtonsoft.Json;

namespace Models
{
    public class AddressModel
    {
        [JsonProperty("address_id")]
        public int ID { get; set; }


        [JsonProperty("firstname")]
        public string Firstname { get; set; }


        [JsonProperty("lastname")]
        public string Lastname { get; set; }


        [JsonProperty("company")]
        public string Company { get; set; }


        [JsonProperty("address_1")]
        public string Address1 { get; set; }


        [JsonProperty("address_2")]
        public string Address2 { get; set; }


        [JsonProperty("postcode")]
        public string Postcode { get; set; }


        [JsonProperty("city")]
        public string City { get; set; }


        [JsonProperty("zone")]
        public ZoneModel Zone { get; set; } = new ZoneModel();


        [JsonProperty("country")]
        public CountryModel Country { get; set; } = new CountryModel();


        [JsonProperty("custom_field")]
        public dynamic CustomField { get; set; }

        [JsonProperty("default")]
        public bool Default { get; set; }

        public override string ToString() => $"{Firstname} {Lastname}, {Address1}, {City}";
    }
}
