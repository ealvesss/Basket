using Microsoft.AspNetCore.Mvc;

namespace basket_api.Controllers
{
    public class BasketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
