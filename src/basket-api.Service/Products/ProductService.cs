using basket_api.Service.Products.Interfaces;
using basket_api.domain.Products;
using basket_api.data.Dao;

namespace basket_api.Service.Products
{
    public class ProductService : IProduct
    {
        private readonly IImpactDAO _dao;

        public ProductService(IImpactDAO dao)
        {
            _dao = dao;
        }

        public string AddProductToBasket(int id)
        {
            return $"Product {id} added!";
        }

        public string DecreaseQuantity(int quantity, int productId)
        {
            return $"decreased {quantity} from the product {productId}";
        }

        public string IncreaseQuantity(int quantity, int productId)
        {
            return $"added {quantity} to the product {productId}";
        }

        public string RemoveProductFromBasket(int id)
        {
            return $"Product {id} removed!";
        }

        public Task<List<Product>> GetProducts()
        {

            var test = await _dao.GetAllProducts();
            return null;
        }
    }
}
