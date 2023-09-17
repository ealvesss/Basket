using Orders.Application.Dtos;

namespace Orders.Application.Services.Interfaces
{
    public interface IProductAppService
    {
        Task<List<ProductDto>> GetProducts();
    }
}
