using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.servicios;
using Portafolio.Servicios;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos repositorioProyectos;
        private readonly IServicioEmail servicioEmail;
        

        public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorioProyectos, IServicioEmail servicioEmail)
        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
            this.servicioEmail = servicioEmail;
            this.servicioEmail = servicioEmail;
        }

        public IActionResult Index()
        {
            
            var proyectos = repositorioProyectos.ObtenerProyecto().Take(3).ToList();
            var model = new HomeIndexViewModel() { Proyectos = proyectos };
            //ViewBag.Nombre = "";
            return View(model);
        }

        //llamar el mismo archvo con IActionResult home/Proyectos
        public IActionResult proyectos()
        {
            var ProyectosCompletos = repositorioProyectos.ObtenerProyecto();
            return View(ProyectosCompletos);
        }
       
        public IActionResult Contacto()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Contacto(ContactoViewModel contactoViewModel)
        {
            await servicioEmail.Enviar(contactoViewModel);
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