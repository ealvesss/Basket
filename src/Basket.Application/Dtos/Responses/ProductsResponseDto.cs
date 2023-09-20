using System.Text.Json.Serialization;

namespace Basket.Application.Dtos.Responses
{
    public class ProductsResponseDto<T> : BaseDto<ProductDto>
    {
        public ProductsResponseDto()
        {
              
        }

        [JsonPropertyName("Items")]
        public IEnumerable<T>? Items { get; set; }

    }
}
