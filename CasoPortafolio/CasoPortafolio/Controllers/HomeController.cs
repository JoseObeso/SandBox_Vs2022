using System.Diagnostics;
using CasoPortafolio.Models;
using Microsoft.AspNetCore.Mvc;

namespace CasoPortafolio.Controllers
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
            var personasTotal = new Personas()
            {
                Id = 1,
                Nombre = "Juan",
                Sex = "Masculino"
            };

            

            return View(personasTotal);
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
