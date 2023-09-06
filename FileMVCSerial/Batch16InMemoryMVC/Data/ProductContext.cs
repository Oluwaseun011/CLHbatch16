using Batch16InMemoryMVC.Entiites;

namespace Batch16InMemoryMVC.Data
{
    public class ProductContext
    {
        public static List<Product> Products { get; set; } = new List<Product>()
        {
            new Product{Id = "abc", Name = "Milk", Description = "Edible", Price = 100.00m},
            new Product{Id = "xyz", Name = "Tea", Description = "Edible", Price = 200.00m},
            new Product{Id = "opq", Name = "Sweet", Description = "Edible", Price = 500.00m},
        };
    }
}
