using Newtonsoft.Json;

namespace Models
{
    public class CategoryModel
    {
        [JsonProperty("category_id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        public override string ToString() => Name;

        public override bool Equals(object obj) => this == (obj as CategoryModel);

        public static bool operator ==(CategoryModel x, CategoryModel y) => x.ID == y.ID && x.Name == y.Name;

        public static bool operator !=(CategoryModel x, CategoryModel y) => !(x == y);

        public override int GetHashCode() => base.GetHashCode();
    }
}
