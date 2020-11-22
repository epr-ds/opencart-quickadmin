using Newtonsoft.Json;

namespace Models
{
    public class StoreModel
    {
        [JsonProperty("store_id")]
        public int ID { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("url")]
        public string URL { get; set; }
        [JsonProperty("ssl")]
        public string SSL { get; set; }

        public override string ToString() => Name;

        public override bool Equals(object obj) => obj is StoreModel && this == (obj as StoreModel);

        public static bool operator ==(StoreModel x, StoreModel y) => x?.ID == y?.ID && x?.Name == y?.Name;

        public static bool operator !=(StoreModel x, StoreModel y) => !(x == y);

        public override int GetHashCode() => base.GetHashCode();
    }
}
