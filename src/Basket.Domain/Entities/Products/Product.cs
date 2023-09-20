
namespace Basket.Domain.Entities.Products
{
    public class Product
    {
        public Product()
        {
            Name = string.Empty;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        //As I take a look in products, it loooks like size is an int
        public int Size { get; set; }

        public int Stars { get; set; }


        public async Task<IEnumerable<Product>> TopRanked(IEnumerable<Product> entity)
        {
            return await Task.FromResult(entity.OrderByDescending(x => x.Stars).Take(100));
        }
    }

}
