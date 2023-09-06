namespace Batch16InMemoryMVC.Dtos
{
    public class ProductDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SKI { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
    }

    public class CreateProductRequestModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
    public class UpdateProductRequestModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
