using Orders.Domain.Entities.Products;

namespace Orders.Application.Interfaces
{
    public interface IImpactRepository
    {
        Task<List<Product>> GetAllProducts();
    }
}
