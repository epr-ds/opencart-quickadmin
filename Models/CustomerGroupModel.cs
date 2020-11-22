using Newtonsoft.Json;

namespace Models
{
    public class CustomerGroupModel
    {
        [JsonProperty("customer_group_id")]
        public int ID { get; set; }

        [JsonProperty("approval")]
        public int Approval { get; set; }

        [JsonProperty("sort_order")]
        public string SortOrder { get; set; }

        [JsonProperty("language_id")]
        public int LanguageID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } = "Por defecto";

        [JsonProperty("description")]
        public string Description { get; set; }
        
        public override string ToString() => Name;

        public static bool operator ==(CustomerGroupModel x, CustomerGroupModel y) => x?.ID == y?.ID;

        public static bool operator !=(CustomerGroupModel x, CustomerGroupModel y) => !(x?.ID == y?.ID);

        public override int GetHashCode() => base.GetHashCode();

        public override bool Equals(object obj) => obj is CustomerGroupModel model && model == this;
    }
}
