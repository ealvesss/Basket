using basket_api.domain.Products;

namespace basket_api.Service.Products.Interfaces
{
    public interface IProduct
    {
        string AddProductToBasket(int id);
        string RemoveProductFromBasket(int id);
        string IncreaseQuantity(int quantity, int productId);
        string DecreaseQuantity(int quantity, int productId);
        Task<List<Product>> GetProducts();
    }
}
