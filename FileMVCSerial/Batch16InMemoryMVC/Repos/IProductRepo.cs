using Batch16InMemoryMVC.Entiites;

namespace Batch16InMemoryMVC.Repos
{
    public interface IProductRepo
    {
        public Product Create(Product product);
        public void RefreshFile();
        public void ReadAllFromFile();

        Product Update(Product product);
        Product Get(string id);
        IEnumerable<Product> GetAll();
        bool Check(string name);
    }
}
