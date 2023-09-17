using basket_api.Service.Orders.Dtos;
using basket_api.Service.Orders.Interfaces;

namespace basket_api.Service.Orders
{
    public class Order : IOrder
    {
        public OrderDto SubmitOrder(OrderDto dto)
        {

            //todo: implement autoMapper to help fit the data before persists.
            return dto;
        }
    }
}
