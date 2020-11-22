using Models.Converters;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Models
{
    public class CustomerModel
    {
        [JsonProperty("customer_id")]
        public int ID { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("telephone")]
        public string Telephone { get; set; }

        [JsonProperty("status"), JsonConverter(typeof(BoolConverter))]
        public bool Status { get; set; }

        [JsonProperty("address_id")]
        public int AddressID { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("newsletter"), JsonConverter(typeof(BoolConverter))]
        public bool Newsletter { get; set; }

        [JsonProperty("safe"), JsonConverter(typeof(BoolConverter))]
        public bool Safe { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("customer_group")]
        public CustomerGroupModel CustomerGroup { get; set; } = new CustomerGroupModel();

        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public AddressModel Address { get; set; } = new AddressModel() { Default = true };

        public override string ToString() => $"{Firstname} {Lastname}";
    }
}
