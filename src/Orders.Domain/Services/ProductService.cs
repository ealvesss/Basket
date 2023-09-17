using basket_api.Service.Products.Interfaces;
using Orders.Application.Interfaces;
using Orders.Domain.Entities.Products;

namespace Orders.Domain.Service.ProductService
{
    public class ProductService : IProductService
    {
         readonly IImpactRepository _repository;

        public ProductService(IImpactRepository repo)
        {
            _repository = repo;
        }


        public async Task<List<Product>> GetProducts()
        {

            var test = await _repository.GetAllProducts();
            return null;
        }
    }
}
