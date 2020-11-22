using Newtonsoft.Json;

namespace Models
{
    public class TaxModel
    {
        [JsonProperty("tax_class_id")]
        public int ID { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        public static bool operator ==(TaxModel x, TaxModel y) => x.ID == y.ID;

        public static bool operator !=(TaxModel x, TaxModel y) => !(x.ID == y.ID);

        public override bool Equals(object obj)  => obj is TaxModel tax && this == tax;

        public override int GetHashCode() => base.GetHashCode();

        public override string ToString() => Title;
    }
}
