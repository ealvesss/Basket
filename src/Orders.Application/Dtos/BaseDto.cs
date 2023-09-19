using System.Text.Json.Serialization;

namespace Orders.Application.Dtos
{
    public abstract class BaseDto<T> where T : class
    {
        [JsonPropertyName("Items")]
        public IEnumerable<T>? Items { get; set; }

        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("pageSize")]
        public int PageSize { get; set; }

        [JsonPropertyName("totalItems")]
        public int TotalItens { get; set; }

        [JsonPropertyName("totalPages")]
        public int TotalPages { get; set; }
    }
}
