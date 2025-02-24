using Microsoft.AspNetCore.Mvc;

namespace PORTALFABIA.Controllers
{
    public class NosotrosController : Controller
    {
        [HttpGet("/nosotros")]
        public IActionResult MostrarPagina()
        {
            ViewData["Nosotros"] = "Sobre Nosotros - Laboratorio de IA y Robótica";
            ViewData["Descripcion"] = "Somos un laboratorio innovador de la Facultad de Ingeniería y Arquitectura (FIA) de la Universidad San Martín de Porres (USMP), Lima. Nos especializamos en inteligencia artificial, robótica y fabricación digital, combinando investigación y aprendizaje práctico.";
            return View("SobreNosotros");
        }
    }
}
