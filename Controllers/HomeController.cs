using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Services;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RepositorioProyectos proyectos;

        public HomeController(ILogger<HomeController> logger, RepositorioProyectos proyectos)
        {
            _logger = logger;
            this.proyectos = proyectos;
        }  

        public IActionResult Index()
        {
            HomeIndexViewModel model = new HomeIndexViewModel() { proyectos = proyectos.GetProyectos().Take(2).ToList() };
            return View( model );
        }

        public IActionResult Proyectos()
        {
            List<Proyecto> model = proyectos.GetProyectos() ;

            return View(model);
        }

        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contacto( ContactoModel contactoModel )
        {
            return RedirectToAction("Gracias");
        }

        public IActionResult Gracias()
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
