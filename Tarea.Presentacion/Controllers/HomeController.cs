using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Tarea.Presentacion.EnvioDato;
using Tarea.Presentacion.Models;

namespace Tarea.Presentacion.Controllers
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

        [HttpPost]
        public async Task<JsonResult> registrarPersona([FromBody] PersonaUI persona)
        {
            EnvioDatoPersona envioDatoPersona = new EnvioDatoPersona();
            
            bool respuesta = await envioDatoPersona.registrarPersonaAsync(persona);

            return Json(respuesta);
        }

       [HttpPost]
        public async Task<IActionResult> modificarPersona(PersonaUI persona)
        {
            EnvioDatoPersona envioDatoPersona = new EnvioDatoPersona();
            bool respuesta = await envioDatoPersona.modificarPersonaAsync(persona);
            ViewBag.mensaje = respuesta;

            return View("filtrarPersona", await envioDatoPersona.filtrandoPersonaAsync(persona.Cedula));
        }


        [HttpGet]
        public async Task<IActionResult> listarPersona()
        {
            EnvioDatoPersona envioDatoPersona = new EnvioDatoPersona();

            var respuesta = await envioDatoPersona.listarPersonaAsync();

            return View(respuesta);
        }

        [HttpGet]
        public async Task<IActionResult> filtrarPersona(string id)
        {
            EnvioDatoPersona envioDatoPersona = new EnvioDatoPersona();
            PersonaUI respuesta = await envioDatoPersona.filtrandoPersonaAsync(id);

            return View(respuesta);
        }
      
        public async Task<IActionResult> EliminarPersona(string persona)
        {
            EnvioDatoPersona envioDatoPersona = new EnvioDatoPersona();
            bool respuesta=   await envioDatoPersona.eliminarPersonaAsync(persona);
        

            return View("listarPersona", await envioDatoPersona.listarPersonaAsync());
        }



    }
}
