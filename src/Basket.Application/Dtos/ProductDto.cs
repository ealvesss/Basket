using System.Text.Json.Serialization;

namespace Basket.Application.Dtos
{
    public class ProductDto
    {

        public ProductDto()
        {
            Name = string.Empty;
        }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonPropertyName("size")]
        public double Size { get; set; }

        [JsonPropertyName("stars")]
        public int Stars { get; set; }
    }
}
