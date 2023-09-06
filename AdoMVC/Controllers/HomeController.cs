using Microsoft.AspNetCore.Mvc;
using StudentMgtApp.Models;
using System.Diagnostics;

namespace StudentMgtApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Startup _startup;

        public HomeController(ILogger<HomeController> logger, Startup startup)
        {
            _logger = logger;
            _startup = startup;
        }

        public IActionResult Index()
        {
            _startup.Run();
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