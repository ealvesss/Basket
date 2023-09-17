using basket_api.Service.Products.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace basket_api.Controllers
{

    //Todo: use the restSharp lib to consumes the Restful API to return the products.
    //Todo: use System.Linq.Async to create pagination to the products.
    [ApiController]
    [Route("[controller]")]
    public class BasketController : ControllerBase
    {
        

        public BasketController()
        {
        }
    }
}
