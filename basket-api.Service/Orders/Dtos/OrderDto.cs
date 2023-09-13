using basket_api.domain.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basket_api.Service.Orders.Dtos
{
    public class OrderDto
    {
        public string userEmail { get; set; }
        public Decimal totalAmount { get; set; }
        public OrderLines orderLines { get; set; }
    }
}
