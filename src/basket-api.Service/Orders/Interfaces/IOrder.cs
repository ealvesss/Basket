using basket_api.Service.Orders.Dtos;

namespace basket_api.Service.Orders.Interfaces
{
    public interface IOrder
    {
        OrderDto SubmitOrder(OrderDto dto);
    }
}
