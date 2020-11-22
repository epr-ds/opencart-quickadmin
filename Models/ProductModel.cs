using Models.Converters;
using Newtonsoft.Json;

namespace Models
{
    public class ProductModel
    {
        [JsonProperty("product_id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("status"), JsonConverter(typeof(BoolConverter))]
        public bool Status { get; set; }

        public override string ToString() => $"{Model} {Name}";

        public static bool operator ==(ProductModel x, ProductModel y) => x?.ID == y?.ID;

        public static bool operator !=(ProductModel x, ProductModel y) => !(x?.ID == y?.ID);

        public override bool Equals(object obj) => obj is ProductModel model && this == model;

        public override int GetHashCode() => base.GetHashCode();
    }
}
