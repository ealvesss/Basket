using Basket.Domain.Util.Interfaces;


namespace Basket.Domain.Util
{
    public class SupportMethods : ISupportMethods
    {
        public SupportMethods()
        { }

        public async Task<IEnumerable<T>> GetPaginatedItens<T>(IEnumerable<T> result, int page, int pageSize)
        {
            return await Task.FromResult(result.Skip((page - 1) * pageSize).Take(pageSize));
        }

        public int GetTotalPages(int totalProducts, int pageSize)
        {
            return (int)Math.Ceiling((decimal)totalProducts / pageSize);
        }
    }
}
