using Basket.Domain.Entities.Products;

namespace Basket.Domain.Interfaces
{
    public interface IProductRepo
    {
        Task<IEnumerable<Product>> GetAll();
    }
}
