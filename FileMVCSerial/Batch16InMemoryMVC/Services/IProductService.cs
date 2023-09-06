using Batch16InMemoryMVC.Dtos;

namespace Batch16InMemoryMVC.Services
{
    public interface IProductService
    {
        ProductDto Create(CreateProductRequestModel request);
        ProductDto Update(string id, UpdateProductRequestModel request);
        ProductDto Get(string id);
        List<ProductDto> GetAll();  
        bool Delete(string id);
    }
}
