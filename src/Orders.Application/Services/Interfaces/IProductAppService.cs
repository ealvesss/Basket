using Orders.Application.Dtos.Responses;

namespace Orders.Application.Services.Interfaces
{
    public interface IProductAppService
    {
        Task<ProductsResponseDto> GetProducts(int page, int size);
    }
}
