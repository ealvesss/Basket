using Basket.Application.Dtos;
using Basket.Application.Dtos.Responses;

namespace Basket.Application.Services.Interfaces
{
    public interface IProductAppService
    {
        Task<IEnumerable<ProductDto>> GetTopRanked();
        Task<ProductsResponseDto<ProductDto>> GetPaginated(int page, int pageSize);
    }
}
