using Models.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Models
{
    public class ProductDataModel : ProductModel
    {
        [JsonProperty("sku")]
        public string SKU { get; set; }
        
        [JsonProperty("upc")]
        public string UPC { get; set; }
        
        [JsonProperty("ean")]
        public string EAN { get; set; }
        
        [JsonProperty("jan")]
        public string JAN { get; set; }
        
        [JsonProperty("isbn")]
        public string ISBN { get; set; }
        
        [JsonProperty("mpn")]
        public string MPN { get; set; }
        
        [JsonProperty("location")]
        public string Location { get; set; }
        
        [JsonProperty("stock_status_id")]
        public int StockStatus { get; set; }

        [JsonProperty("manufacturer_id")]
        public int Manufacturer { get; set; }
        
        [JsonProperty("shipping"), JsonConverter(typeof(BoolConverter))]
        public bool Shipping { get; set; }
        
        [JsonProperty("points")]
        public int Points { get; set; }
        
        [JsonProperty("tax_class_id")]
        public int TaxClass { get; set; }

        [JsonProperty("date_available")]
        public DateTime DateAvailable { get; set; } = DateTime.Today;

        [JsonProperty("weight")]
        public double Weight { get; set; }
        
        [JsonProperty("weight_class_id")]
        public int WeightClass { get; set; }

        [JsonProperty("length")]
        public double Length { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("length_class_id")]
        public int LengthClass { get; set; }

        [JsonProperty("subtract"), JsonConverter(typeof(BoolConverter))]
        public bool Subtract { get; set; }
        
        [JsonProperty("minimum")]
        public int Minimum { get; set; }
        
        [JsonProperty("sort_order")]
        public int SortOrder { get; set; }
        
        [JsonProperty("viewed")]
        public int Viewed { get; set; }

        [JsonProperty("date_added"), JsonConverter(typeof(Converters.DateTimeConverter))]
        public DateTime DateAdded { get; set; } = DateTime.Today;
        
        [JsonProperty("date_modified"), JsonConverter(typeof(Converters.DateTimeConverter))]
        public DateTime DateModified { get; set; } = DateTime.Today;
        
        [JsonProperty("product_description")]
        public IDictionary<int, DescriptionModel> Descriptions { get; set; } = new Dictionary<int, DescriptionModel>();

        [JsonProperty("product_image")]
        public BindingList<ProductImageModel> Images { get; set; } = new BindingList<ProductImageModel>();

        [JsonProperty("product_category")]
        public IList<int> Categories { get; set; } = new List<int>();

        [JsonProperty("product_store")]
        public IList<int> Stores { get; set; } = new List<int>();

        [JsonProperty("product_layout")]
        public IList<int> Layouts { get; set; } = new List<int>();

        [JsonProperty("product_related")]
        public IList<int> RelatedProducts { get; set; } = new List<int>();

        [JsonProperty("product_discount")]
        public IList<DiscountModel> Discounts { get; set; } = new List<DiscountModel>();

        [JsonProperty("product_special")]
        public IList<SpecialOfferModel> Specials { get; set; } = new List<SpecialOfferModel>();


        public static bool operator ==(ProductDataModel x, ProductDataModel y) => x.ID == y.ID;

        public static bool operator !=(ProductDataModel x, ProductDataModel y) => !(x.ID == y.ID);

        public override bool Equals(object obj) => obj is ProductDataModel model && model == this;

        public override int GetHashCode() => base.GetHashCode();
    }
}
