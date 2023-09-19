using Microsoft.AspNetCore.Mvc;
using Orders.Application.Dtos.Responses;
using Orders.Application.Services.Interfaces;

namespace Orders.Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        readonly IProductAppService _prodService;
        readonly ILogger<ProductController> _logger;

        public ProductController(IProductAppService prodService, ILogger<ProductController> logger)
        {
            _prodService = prodService;
            _logger = logger;
        }

        [HttpPost("getProducts")]
        public async Task<ProductsResponseDto> SubmitOrder(int page, int pageSize)
        {
            var result = await _prodService.GetProducts(page, pageSize);
            _logger.LogInformation($"{ DateTime.UtcNow }: GetProducts called with result of { result.Items!.Count() } products. page: { page }, pageSize: { pageSize }");
            return result;
        }
    }
}
