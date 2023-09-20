using System.Text.Json.Serialization;

namespace Basket.Application.Entities.Orders
{
    public class OrderLines
    {
        public OrderLines()
        {
            ProductName = string.Empty;
        }


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
