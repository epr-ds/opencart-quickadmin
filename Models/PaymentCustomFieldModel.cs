using Newtonsoft.Json;

namespace Models
{
    public class PaymentCustomFieldModel
    {
        [JsonProperty("invoice_mode")]
        public string InvoiceMode { get; set; }
        [JsonProperty("discount")]
        public int Discount { get; set; }
        [JsonProperty("rfc")]
        public string RFC { get; set; }
    }
}
