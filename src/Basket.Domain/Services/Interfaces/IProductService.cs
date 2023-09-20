using Basket.Domain.Entities.Products;

namespace Basket.Domain.Products.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAll();
    }
}
