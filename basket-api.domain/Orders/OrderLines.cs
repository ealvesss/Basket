using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basket_api.domain.Orders
{
    public class OrderLines
    {
        public int ProductId { get; set; }
        public String ProductName { get; set; }
        public Decimal ProductUnitPrice { get; set; }
        public Double ProductSize { get; set; }
        public int Quantity { get; set; }
        public Decimal TotalPrice { get; set; }
    }
}
