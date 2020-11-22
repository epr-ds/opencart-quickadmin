using Newtonsoft.Json;

namespace Models
{
    public class ShippingMethodModel
    {
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("cost")]
        public decimal Cost { get; set; }
        [JsonProperty("tax_class_id")]
        public int TaxClassID { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }

        public override string ToString() => Title;
    }
}
