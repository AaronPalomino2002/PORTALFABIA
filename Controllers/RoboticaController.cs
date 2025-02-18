using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PORTALFABIA.Data;
using PORTALFABIA.Models;

namespace PORTALFABIA.Controllers
{
    public class RoboticaController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<RoboticaController> _logger;

        public RoboticaController(ApplicationDbContext context, ILogger<RoboticaController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet, HttpPost]
        public async Task<IActionResult> Index(RegistroRobotica model)
        {
            if (HttpContext.Request.Method == "POST")  // Solo procesar si es una solicitud POST
            {
                _logger.LogInformation("Datos recibidos: {@Model}", model);

            

                try
                {
                    var nuevoRegistro = new RegistroRobotica
                    {
                        numMatricula = Guid.NewGuid().ToString(),
                        Nombre = model.Nombre,
                        Apellidos = model.Apellidos,
                        Correo = model.Correo,
                        Edad = model.Edad,
                        Semana = model.Semana,
                        Horario = model.Horario,
                        Distrito = model.Distrito
                    };

                    _context.DataRobo.Add(nuevoRegistro);
                    await _context.SaveChangesAsync();

                    TempData["Mensaje"] = "Registro exitoso";
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error al registrar el usuario");
                    ModelState.AddModelError(string.Empty, "Ocurrió un error al procesar su solicitud.");
                }
            }

            ViewBag.Carreras = await _context.DataCarrera.ToListAsync();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error");
        }
    }
}
