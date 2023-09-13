using basket_api.Service.Orders.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basket_api.Service.Orders.Interfaces
{
    public interface IOrder
    {
        OrderDto SubmitOrder(OrderDto dto);
    }
}
