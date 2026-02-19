using System.Diagnostics;
using Licență_sper.Models;
using Microsoft.AspNetCore.Mvc;

namespace Licență_sper.Controllers
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

        public IActionResult AboutGame()
        {
            ViewData["Title"] = "About the Game";
            return View();
        }

        public IActionResult Play()
        {
            ViewData["Title"] = "Play";
            return View();
        }

        public IActionResult AboutGalaxy()
        {
            ViewData["Title"] = "About the Galaxy";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
