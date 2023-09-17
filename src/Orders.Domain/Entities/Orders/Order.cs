using System.Text.Json.Serialization;

namespace Orders.Application.Entities.Orders
{
    public class Order
    {
        [JsonPropertyName("userEmail")]
        public string UserEmail { get; set; }

        [JsonPropertyName("totalAmount")]
        public decimal TotalAmount { get; set; }

        [JsonPropertyName("orderLines")]
        public OrderLines OrderLines { get; set; }

    }
}
