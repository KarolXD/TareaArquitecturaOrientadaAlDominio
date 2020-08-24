using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea.Dominio.Contrato.WF;
using Tarea.Dominio.Entidades;

namespace Tarea.Servicios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private IRegistrarPersonaWF _registrarPersonaWF;
        private IEliminarPersonaWF _eliminarPersonaWF;
        private IListarPersonaWF _listarPersonaWF;
        private IFiltrarPersonaWF _filtrarPersonaWF;
        private IModificarPersonaWF _modificarPersonaWF;
        public WeatherForecastController(IRegistrarPersonaWF registrarPersonaWF, IListarPersonaWF listarPersona,
            IFiltrarPersonaWF filtrarPersonaWF, IEliminarPersonaWF eliminarPersonaWF, IModificarPersonaWF modificarPersonaWF)
        {
            _registrarPersonaWF = registrarPersonaWF;
            _listarPersonaWF = listarPersona;
            _filtrarPersonaWF = filtrarPersonaWF;
            _eliminarPersonaWF =eliminarPersonaWF;
            _modificarPersonaWF = modificarPersonaWF;
        }

        [HttpGet]
         #pragma warning disable CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.

        public async Task<ActionResult> Get() {
            bool respuesta = false;
            try
            {
              var  respuesta1 =  _listarPersonaWF.ejecutar().ToList();
                return Ok(respuesta1);
            }
            catch
            {
                return BadRequest(respuesta);

            }
        }

        [HttpGet("{cedulaPersona}")]
#pragma warning disable CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.

        public async Task<ActionResult> Get(string cedulaPersona)  {

            try
            {
                var respuesta = _filtrarPersonaWF.ejecutar(cedulaPersona);
                return Ok(respuesta);
            }
            catch
            {
                return BadRequest(false);

            }
        }
        [HttpPost]
        #pragma warning disable CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
        public async Task<ActionResult> Post([FromBody] Persona persona)
   {

            bool respuesta = false;
            try
            {
                respuesta = _registrarPersonaWF.ejecutar(persona);
                return Ok(respuesta);
            }
            catch
            {
                return BadRequest(respuesta);

            }

        }
        [HttpPut]
#pragma warning disable CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
        public async Task<ActionResult> Put([FromBody] Persona persona)
        {

            bool respuesta = false;
            try
            {
                respuesta = _modificarPersonaWF.ejecutar(persona);
                return Ok(respuesta);
            }
            catch
            {
                return BadRequest(respuesta);

            }

        }


        [HttpDelete]
#pragma warning disable CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
        public async Task<ActionResult> Delete(string persona)
        {

            bool respuesta = false;
            try
            {
                respuesta = _eliminarPersonaWF.ejecutar(persona);
                return Ok(respuesta);
            }
            catch
            {
                return BadRequest(respuesta);

            }

        }

    }
}
