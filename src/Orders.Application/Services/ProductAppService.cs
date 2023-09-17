using basket_api.Service.Products.Interfaces;
using Orders.Application.Dtos;
using Orders.Application.Services.Interfaces;

namespace Orders.Application.Services
{
    public class ProductAppService : IProductAppService
    {
        readonly IProductService _productService;

        public ProductAppService(IProductService productService)
        {
            _productService = productService;
        }

        public Task<List<ProductDto>> GetProducts()
        {
            var test = _productService.GetProducts();

            return null;
        }
    }
}
