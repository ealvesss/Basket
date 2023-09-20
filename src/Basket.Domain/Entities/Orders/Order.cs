using System.Text.Json.Serialization;

namespace Basket.Application.Entities.Orders
{
    public class Order
    {
        public Order()
        {
            OrderLines = new OrderLines();
            UserEmail = string.Empty;
        }

        [JsonPropertyName("userEmail")]
        public string UserEmail { get; set; }

        [JsonPropertyName("totalAmount")]
        public decimal TotalAmount { get; set; }

        [JsonPropertyName("orderLines")]
        public OrderLines OrderLines { get; set; }

    }
}
