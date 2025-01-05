using Microsoft.AspNetCore.Mvc;
using UtilsApp.Services;
using UtilsApp.Utils;
using Web.Models;

namespace Web.Controllers
{
    public class UserController : Controller
    {
        private readonly UserServices userServices;
        public UserController(UserServices userServices)
        {
            this.userServices = userServices;
        }

        public IActionResult Authentication()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(AuthDTO auth)
        {
            if (ModelState.IsValid)
            {
                var user = await userServices.Login(auth.Login, auth.Password);

                if (user == null)
                {
                    Response.toClearCookieUser();
                    ModelState.AddModelError(string.Empty, "Nome de usuário ou senha inválidos.");
                    return View("Authentication");
                }

                Response.toSaveCookieUser(user);

                return RedirectToAction("Index", "Product");
            }

            return View("Authentication");
        }
    }
}
