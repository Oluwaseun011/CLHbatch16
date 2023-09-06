using Batch16InMemoryMVC.Data;
using Batch16InMemoryMVC.Entiites;
using System.Text.Json;

namespace Batch16InMemoryMVC.Repos
{
    public class ProductRepo : IProductRepo
    {
        public ProductRepo() 
        { 
            ReadAllFromFile();
        }
      
        string path = @"C:\Users\user\Desktop\Batch16InMemoryMVC\Files\Products.txt";

        public bool Check(string name)
        {
            return ProductContext.Products.Any(p => p.Name == name);
        }

        public Product Create(Product product)
        {
            var obj = JsonSerializer.Serialize(product);
            using(var str = new StreamWriter(path, true))
            {
                str.WriteLine(obj);
            }
            ProductContext.Products.Add(product);
            return product;
        }

        public Product Get(string id)
        {
            var product = ProductContext.Products.SingleOrDefault(p => p.Id == id);
            return product;
        }

        public IEnumerable<Product> GetAll()
        {
            return ProductContext.Products;
        }

        public void ReadAllFromFile()
        {
            var products = File.ReadAllLines(path);
            foreach (var product in products)
            {
                var a = JsonSerializer.Deserialize<Product>(product);
                ProductContext.Products.Add(a);
            }
        }

        public void RefreshFile()
        {
            using(var str = new StreamWriter(path, false))
            {
                foreach (var item in ProductContext.Products)
                {
                    var a = JsonSerializer.Serialize(item);
                    str.WriteLine(a);
                }
            }
            
        }

        public Product Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
