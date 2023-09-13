using basket_api.Service.Orders.Dtos;
using basket_api.Service.Orders.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
