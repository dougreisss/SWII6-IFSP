using Microsoft.AspNetCore.Mvc;
using UtilsApp.Services;

namespace Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductServices productServices;
        public ProductController(ProductServices productServices)
        {
            this.productServices = productServices;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
