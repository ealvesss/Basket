using Orders.Domain.Entities.Products;

namespace Orders.Domain.Interfaces
{
    public interface IProductClient
    {
        Task<IEnumerable<Product>> GetAllProducts();
    }
}
