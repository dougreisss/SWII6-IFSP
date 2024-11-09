using Microsoft.AspNetCore.Mvc;
using TP03_Douglas_Lucas.Repository.Interface;

namespace TP03_Douglas_Lucas.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var products = _productRepository.GetAll();
            return View(products);
        }

        public IActionResult Create() 
        {
            return View(); 
        }
    }
}
