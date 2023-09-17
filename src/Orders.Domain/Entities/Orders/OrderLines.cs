using System.Text.Json.Serialization;

namespace Orders.Application.Entities.Orders
{
    public class OrderLines
    {
        [JsonPropertyName("productId")]
        public int ProductId { get; set; }

        [JsonPropertyName("productName")]
        public string ProductName { get; set; }

        [JsonPropertyName("productUnitPrice")]
        public decimal ProductUnitPrice { get; set; }

        [JsonPropertyName("productSize")]
        public double ProductSize { get; set; }

        [JsonPropertyName("tokeQuantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("totalPrice")]
        public decimal TotalPrice { get; set; }
    }
}
