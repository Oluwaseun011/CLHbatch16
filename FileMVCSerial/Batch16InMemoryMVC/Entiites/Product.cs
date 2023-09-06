namespace Batch16InMemoryMVC.Entiites
{
    public class Product
    {
        public string Id { get; set; } = Guid.NewGuid().ToString().Substring(1,3);
        public string Name { get; set; }
        public string SKI { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
