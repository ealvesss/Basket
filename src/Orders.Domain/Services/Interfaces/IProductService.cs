using Orders.Domain.Entities.Products;

namespace basket_api.Service.Products.Interfaces
{
    public interface IProductService
    {
        /* string AddProductToBasket(int id);
         string RemoveProductFromBasket(int id);
         string IncreaseQuantity(int quantity, int productId);
         string DecreaseQuantity(int quantity, int productId);*/
        Task<List<Product>> GetProducts();
    }
}
