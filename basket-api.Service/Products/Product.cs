using basket_api.Service.Products.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basket_api.Service.Products
{
    public class Product : IProduct
    {
        public string AddProductToBasket(int id)
        {
            return $"Product {id} added!";
        }

        public string DecreaseQuantity(int quantity, int productId)
        {
            return $"decreased {quantity} from the product {productId}";
        }

        public string IncreaseQuantity(int quantity, int productId)
        {
            return $"added {quantity} to the product {productId}";
        }

        public string RemoveProductFromBasket(int id)
        {
            return $"Product {id} removed!";
        }
    }
}
