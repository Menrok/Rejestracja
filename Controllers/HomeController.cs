using Microsoft.AspNetCore.Mvc;
using Rejestracja.Models;
using System.Diagnostics;

namespace Rejestracja.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Rejestracja()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Rejestracja(RejestracjaModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Rejestracja zakoñczona pomyœlnie.";
                return View();
            }
            return View(model);
        }
    }
}
