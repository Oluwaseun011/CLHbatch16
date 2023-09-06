using Batch16InMemoryMVC.Data;
using Batch16InMemoryMVC.Dtos;
using Batch16InMemoryMVC.Entiites;
using Batch16InMemoryMVC.Repos;

namespace Batch16InMemoryMVC.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;
        public ProductService(IProductRepo productRepo) 
        { 
            _productRepo = productRepo;
        }
        public ProductDto Create(CreateProductRequestModel request)
        {
            var exists = _productRepo.Check(request.Name);
            if (exists)
            {
                return null;
            }
            var product = new Product()
            {
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
                SKI = $"CLH-{new Random().Next(100, 999)}-PRD-{new Random().Next(100, 999)}"
            };
            _productRepo.Create(product);

            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                SKI = product.SKI,
                DateCreated = product.DateCreated,
                IsDeleted = product.IsDeleted,
            };
        }

        public bool Delete(string id)
        {
            var product = _productRepo.Get(id);
            if(product == null)
            {
                return false;
            }
            product.IsDeleted = true;
            _productRepo.RefreshFile();
            return true;
        }

        public ProductDto Get(string id)
        {
            var product = _productRepo.Get(id);
            if(product == null)
            {
                return null;
            }
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                SKI = product.SKI,
                DateCreated = product.DateCreated,
                IsDeleted = product.IsDeleted,
            };
        }

        public List<ProductDto> GetAll()
        {
            var products = _productRepo.GetAll();
            var listOfProducts = products.Select(product => new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                SKI = product.SKI,
                DateCreated = product.DateCreated,
                IsDeleted = product.IsDeleted,
            }).ToList();

            return listOfProducts;
        }

        public ProductDto Update(string id, UpdateProductRequestModel request)
        {
            var product = _productRepo.Get(id);
            product.Name = request.Name;
            product.Description = request.Description;

            _productRepo.RefreshFile();
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                SKI = product.SKI,
                DateCreated = product.DateCreated,
                IsDeleted = product.IsDeleted,
            };

        }
    }
}
