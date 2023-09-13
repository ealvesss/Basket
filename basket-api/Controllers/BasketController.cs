using basket_api.Service.Products.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;

namespace basket_api.Controllers
{

    //Todo: use the restSharp lib to consumes the Restful API to return the products.
    //Todo: use System.Linq.Async to create pagination to the products.
    [ApiController]
    [Route("[controller]")]
    public class BasketController : ControllerBase
    {
        private readonly IProduct _productService;

        public BasketController(IProduct productService) { 
            this._productService = productService;
        }

        [HttpPost("addProduct/")]
        public string AddProduct(int id)
        {
            return  _productService.AddProductToBasket(id);
        }

        [HttpDelete("removeProduct/")]
        public string RemoveProduct(int id)
        {
           return _productService.RemoveProductFromBasket(id);
        }

        [HttpPost("increaseQuantity/")]
        public string  IncreaseQuantity(int quantity, int productId)
        {
            return _productService.IncreaseQuantity(quantity, productId);
        }

        [HttpDelete("decreaseQuantity/")]
        public string DecreaseQuantity(int quantity, int productId)
        {
            return _productService.DecreaseQuantity(quantity, productId);
        }
    }
}
