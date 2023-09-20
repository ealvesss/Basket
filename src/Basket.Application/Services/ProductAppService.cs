using AutoMapper;
using Basket.Application.Dtos;
using Basket.Application.Dtos.Responses;
using Basket.Application.Services.Interfaces;
using Basket.Domain.Entities.Products;
using Basket.Domain.Products.Interfaces;
using Basket.Domain.Util.Interfaces;


namespace Basket.Application.Services
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

        public async Task<IEnumerable<ProductDto>> GetTopRanked()
        {
            Product prodEntity = new Product();

            var prodResult = await _productService.GetAll();
            var topRankedResult = await prodEntity.TopRanked(prodResult);
            var responseDto = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductDto>>(topRankedResult);

            return await Task.FromResult(responseDto);

        }

        public async Task<ProductsResponseDto<ProductDto>> GetPaginated(int page, int pageSize)
        {
            if (pageSize > 1000) return await Task.FromResult(new ProductsResponseDto<ProductDto>() { error = new Error() { Message = "Page size should be lower than 1000" } });

            var prodResult = await _productService.GetAll();
            
            var totalPages = _supportMethods.GetTotalPages(prodResult.Count(), pageSize);
            var paginatedResult = await _supportMethods.GetPaginatedItens(prodResult, page, pageSize);

            var responseDto = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductDto>>(paginatedResult);

            return await Task.FromResult(new ProductsResponseDto<ProductDto>()
            {
                pageSize = pageSize,
                totalItems = prodResult.Count(),
                totalPages = totalPages,
                Items = responseDto,
                page = page
            });
        }
    }
}
