using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basket_api.domain.Products
{
    public class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Decimal Price { get; set; }
        public Double Size { get; set; }
        public int Stars { get; set; }
    }

}
