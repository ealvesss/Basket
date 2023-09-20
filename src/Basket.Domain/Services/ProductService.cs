
using Basket.Domain.Entities.Products;
using Basket.Domain.Interfaces;
using Basket.Domain.Products.Interfaces;

namespace Basket.Domain.Service.ProductService
{
    public class ProductService : IProductService
    {
        readonly IProductRepo _repository;

        public ProductService(IProductRepo repo)
        {
            _repository = repo;
        }


        public async Task<IEnumerable<Product>> GetAll()
        {
            var products = await _repository.GetAll();

            return await Task.FromResult(products);
            
        }
    }
}
