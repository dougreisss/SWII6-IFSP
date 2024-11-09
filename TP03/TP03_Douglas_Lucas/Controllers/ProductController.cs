using Microsoft.AspNetCore.Mvc;
using TP03_Douglas_Lucas.Models;
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

            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = _productRepository.GetById(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product); 
        }

        public IActionResult Create() 
        {
            return View(); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id, Name, Price, Unit, Description, CategoryName")] Product product)
        {
            if (ModelState.IsValid)
            {
                _productRepository.Insert(product);
                return RedirectToAction(nameof(Index));
            }

            return View(product);
        }

        public IActionResult Edit(int id) 
        {
            var product = _productRepository.GetById(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("Id, Name, Price, Unit, Description, CategoryName")] Product product) 
        {
            if (ModelState.IsValid) 
            {
                var result = _productRepository.Update(product);

                if (!result)
                {
                    return BadRequest();
                }

                return RedirectToAction(nameof(Index));
            }

            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var product = _productRepository.GetById(id);

            if (product == null)
            {
                return NotFound();
            }

            var result = _productRepository.Delete(product);

            if (!result)
            {
                return BadRequest();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
