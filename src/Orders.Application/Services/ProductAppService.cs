using AutoMapper;
using Orders.Application.Dtos;
using Orders.Application.Dtos.Responses;
using Orders.Application.Services.Interfaces;
using Orders.Domain.Entities.Products;
using Orders.Domain.Products.Interfaces;
using Orders.Infra.Util.Interfaces;

namespace Orders.Application.Services
{
    public class ProductAppService : IProductAppService
    {
        readonly IProductService _productService;
        readonly IMapper _mapper;
        readonly ISupportMethods _supportMethods;

        public ProductAppService(IProductService productService, IMapper map, ISupportMethods suppMethods)
        {
            _productService = productService;
            _mapper = map;
            _supportMethods = suppMethods;
        }

        public async Task<ProductsResponseDto> GetProducts(int page, int pageSize)
        {
            var resultItems = await _productService.GetProducts();
            var productsDto = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductDto>>(resultItems);
            var paginatedItems = await _supportMethods.GetPaginatedItens(productsDto, page, pageSize);

            return new ProductsResponseDto(
                pageSize,
                productsDto.Count(),
                _supportMethods.GetTotalPages(productsDto.Count(), pageSize),
                paginatedItems,
                page);

        }
    }
}
