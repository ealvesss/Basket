using Orders.Domain.Entities.Products;

namespace Orders.Infra.Interfaces
{
    public interface IImpactRepository
    {
        Task<List<Product>> GetAllProducts();

    }
}
