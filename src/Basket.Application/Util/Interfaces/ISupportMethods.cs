using Basket.Domain.Entities.Products;

namespace Basket.Domain.Util.Interfaces
{
    public interface ISupportMethods
    {
        Task<IEnumerable<T>> GetPaginatedItens<T>(IEnumerable<T> result, int page, int pageSize);
        int GetTotalPages(int totalProducts, int pageSize);
    }
}
