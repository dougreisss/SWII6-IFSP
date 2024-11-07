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
        private readonly IProductRepository _produtoRepository;

        public HomeController(ILogger<HomeController> logger, IProductRepository produtoRepository)
        {
            _logger = logger;
            _produtoRepository = produtoRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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
