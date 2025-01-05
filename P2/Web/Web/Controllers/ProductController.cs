using Microsoft.AspNetCore.Mvc;
using UtilsApp.DTOs;
using UtilsApp.Services;
using UtilsApp.Utils;

namespace Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductServices productServices;
        private readonly UserServices userServices;
        public ProductController(ProductServices productServices, UserServices userServices)
        {
            this.productServices = productServices;
            this.userServices = userServices;
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

        public IActionResult Create()
        {
            var user = Request.getCookieUser();

            if (user?.Id == null || user.Id <= 0)
            {
                return RedirectToAction("", "Authentication");
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id, Name, Price, Status, CreatedByUserId, UpdatedByUserId")]  ProductDTO product)
        {
            if (ModelState.IsValid)
            {

                var user = Request.getCookieUser();

                product.CreatedByUserId = user.Id;
                product.Status = true;

                await productServices.Create(product);

                return RedirectToAction(nameof(Index));
            }

            return View(product);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var user = Request.getCookieUser();

            if (user?.Id == null || user.Id <= 0)
            {
                return RedirectToAction("", "Authentication");
            }

            var products = await productServices.GetById(id);

            return View(products);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("Id, Name, Price, Status, CreatedByUserId, UpdatedByUserId")]  ProductDTO product)
        {
            if (ModelState.IsValid)
            {
                var user = Request.getCookieUser();

                product.UpdatedByUserId = user.Id;
                await productServices.Update(product);

                return RedirectToAction(nameof(Index));
            }

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await productServices.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
