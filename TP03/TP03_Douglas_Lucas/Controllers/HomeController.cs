using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TP03_Douglas_Lucas.Models;
using TP03_Douglas_Lucas.Models.SqlContext;
using TP03_Douglas_Lucas.Repository.Interface;

namespace TP03_Douglas_Lucas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
