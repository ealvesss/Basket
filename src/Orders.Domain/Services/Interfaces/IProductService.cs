using Orders.Domain.Entities.Products;

namespace Orders.Domain.Products.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts();
    }
}
