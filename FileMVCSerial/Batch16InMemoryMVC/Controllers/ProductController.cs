using Batch16InMemoryMVC.Entiites;
using Batch16InMemoryMVC.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Batch16InMemoryMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var products = _productRepository.GetAll();
            return View(products);
        }

        [HttpGet]
        public IActionResult AddProduct() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product) 
        {
            var isSuccessful = _productRepository.Add(product);
            if(isSuccessful)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
