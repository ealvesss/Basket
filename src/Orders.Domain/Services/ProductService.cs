
using Orders.Domain.Entities.Products;
using Orders.Domain.Interfaces;
using Orders.Domain.Products.Interfaces;

namespace Orders.Domain.Service.ProductService
{
    public class ProductService : IProductService
    {
        readonly IProductClient _repository;

        public ProductService(IProductClient repo)
        {
            _repository = repo;
        }


        public async Task<IEnumerable<Product>> GetProducts()
        {

            var result = await _repository.GetAllProducts();
            return result;
        }
    }
}
