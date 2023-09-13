using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basket_api.domain.Orders
{
    public class Order
    {
        public string UserEmail { get; set; }
        public Decimal TotalAmount { get; set; }
        public OrderLines OrderLines { get; set; }

    }
}
