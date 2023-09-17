using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Orders.Application.Dtos;
using Orders.Application.Services.Interfaces;

namespace basket_api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class ProductController : Controller
    {
        readonly IProductAppService _prodService;

        public ProductController(IProductAppService prodService)
        {
            _prodService = prodService;
        }

        [HttpPost("getProducts")]
        public Task<List<ProductDto>> SubmitOrder()
        {
            //todo: make way better to return data
            return _prodService.GetProducts();
        }
    }
}
