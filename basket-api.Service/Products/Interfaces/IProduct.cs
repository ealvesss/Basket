using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basket_api.Service.Products.Interfaces
{
    public interface IProduct
    {
        string AddProductToBasket(int id);
        string RemoveProductFromBasket(int id);
        string IncreaseQuantity(int quantity, int productId);
        string DecreaseQuantity(int quantity, int productId);
    }
}
