namespace Orders.Domain.Entities.Products
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public double Size { get; set; }
        public int Stars { get; set; }
    }

}
