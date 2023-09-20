using Basket.Application.Dtos;
using Basket.Application.Dtos.Responses;
using Basket.Application.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Basket.Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        readonly IProductAppService _prodService;
        readonly ILogger<ProductController> _logger;

        public ProductController(IProductAppService prodService, ILogger<ProductController> logger)
        {
            _prodService = prodService;
            _logger = logger;
        }

        // top 100 ranked products
        [HttpGet("TopRanked")]
        public async Task<IEnumerable<ProductDto>> GetTopRanked()
        {
            var resultDto = await _prodService.GetTopRanked();
            
            return resultDto;
        }


        //Return paginated results of the product catalog ordered by price in ascending order and properly paginated
        [HttpGet("Paginated")]
        public async Task<ProductsResponseDto<ProductDto>> GetPaginated(int page, int pageSize)
        {
            return await _prodService.GetPaginated(page, pageSize);
        }
    }
}
