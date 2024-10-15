using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TP02_Comex.Models;

namespace TP02_Comex.Controllers
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
    }
}
