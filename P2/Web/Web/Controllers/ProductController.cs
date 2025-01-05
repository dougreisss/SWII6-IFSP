using Microsoft.AspNetCore.Mvc;
using UtilsApp.Services;
using UtilsApp.Utils;

namespace Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductServices productServices;
        public ProductController(ProductServices productServices)
        {
            this.productServices = productServices;
        }

        public async Task<IActionResult> Index()
        {
            var user = Request.getCookieUser();

            if (user?.Id == null || user.Id <= 0)
            {
                return RedirectToAction("", "Authentication");
            }

            var products = await productServices.GetAll();

            return View(products);
        }
    }
}
