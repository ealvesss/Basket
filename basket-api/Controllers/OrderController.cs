using basket_api.Service.Orders.Dtos;
using basket_api.Service.Orders.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace basket_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrder _orderService;


        public OrderController(IOrder order) {
            this._orderService = order;
        }

        [HttpPost("submitOrder")]
        public OrderDto SubmitOrder(OrderDto dto)
        {
            //todo: make way better to return data
            return _orderService.SubmitOrder(dto);
        }

    }
}
