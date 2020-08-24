using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Unicode;
using System.Threading;
using System.Threading.Tasks;
using Tarea.Presentacion.Models;

namespace Tarea.Presentacion.EnvioDato
{
    public class EnvioDatoPersona
    {

        public async Task<bool> modificarPersonaAsync(PersonaUI persona)
        {
            bool respuesta = false;

            using (var httpClient = new HttpClient())
            {
                StringContent contenido = new StringContent(JsonConvert.SerializeObject(persona), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync(Constantes.Constantes.URLParaEnvioDatosPersona, contenido))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    respuesta = JsonConvert.DeserializeObject<bool>(apiResponse);
                }
            }
            return respuesta;
        }
        public async Task<bool> registrarPersonaAsync(PersonaUI persona)
        {
            bool respuesta = false;

            using (var httpClient = new HttpClient())
            {
                StringContent contenido = new StringContent(JsonConvert.SerializeObject(persona), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync(Constantes.Constantes.URLParaEnvioDatosPersona,contenido))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    respuesta = JsonConvert.DeserializeObject<bool>(apiResponse);
                }
            }
            return respuesta;
        }
        
        public async System.Threading.Tasks.Task<PersonaUI> filtrandoPersonaAsync(string personaId)
        {
            using (var httpClient = new HttpClient())
            {
              
                string url = string.Concat(Constantes.Constantes.URLParaEnvioDatosPersona, "/" + personaId);
                using (var response = await httpClient.GetAsync(url))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    //var respuesta = JsonConvert.DeserializeObject<PersonaUI>(apiResponse);
                  var respuesta = JsonConvert.DeserializeObject<PersonaUI>(apiResponse);
                  return respuesta;
                }
            }
        }

        private List<PersonaUI> listandoPersonaAsync = new List<PersonaUI>();
        public async System.Threading.Tasks.Task<IEnumerable<PersonaUI>> listarPersonaAsync()
        {
            using (var httpClient = new HttpClient())
            {
               using (var response = await httpClient.GetAsync(Constantes.Constantes.URLParaEnvioDatosPersona))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                   var respuesta = JsonConvert.DeserializeObject<List<PersonaUI>>(apiResponse);
                    return respuesta;
                }
            }
        }
        
        public async Task<bool> eliminarPersonaAsync(string persona)
        {
            bool respuesta = false;
            using (var httpClient = new HttpClient())
            {
              // var contenido = new StringContent(JsonConvert.SerializeObject(persona.Cedula), Encoding.UTF8, "application/json");
                string url = string.Concat(Constantes.Constantes.URLParaEnvioDatosPersona, "?persona=" + persona);

                using (var response = await httpClient.DeleteAsync(url))
                //  using (var response = await httpClient.DeleteAsync(Constantes.Constantes.URLParaEnvioDatosPersona))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    respuesta = JsonConvert.DeserializeObject<bool>(apiResponse);
                         return respuesta;
        }
                }
            }
            

    }
}
