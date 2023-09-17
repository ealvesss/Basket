using basket_api.domain.Orders;

namespace basket_api.Service.Orders.Dtos
{
    public class OrderDto
    {
        public string userEmail { get; set; }
        public Decimal totalAmount { get; set; }
        public OrderLines orderLines { get; set; }
    }
}
