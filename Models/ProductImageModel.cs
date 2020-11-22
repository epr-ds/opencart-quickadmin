using Newtonsoft.Json;

namespace Models
{
    public class ProductImageModel
    {
        [JsonProperty("product_image_id")]
        public int ID { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("sort_order")]
        public int SortOrder { get; set; }
        
        [JsonProperty("product_id")]
        public int ProductID { get; set; }        
    }
}
