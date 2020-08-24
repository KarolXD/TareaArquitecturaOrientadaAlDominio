using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tarea.Dominio.Contrato.RP;
using Tarea.Dominio.Entidades;
using Tarea.Infrastructura.Contexto;

namespace Tarea.Infrastructura.Repositorio
{
    public class ModificarPersonaRP : IModificarPersonaRP
    {

        readonly PersonaContext _employeeContext;

        public ModificarPersonaRP(PersonaContext context)
        {
            _employeeContext = context;
        }
        public bool ejecutar(Persona persona)
        {
            //var query = (from p in _employeeContext.Persona
            //             where p.Cedula == persona.Cedula
            //             select p.Cedula).Single();
            try {

                var person = _employeeContext.Persona.First(a => a.Cedula == persona.Cedula);
                person.Nombre = persona.Nombre;
                person.Apellido = persona.Apellido;
                person.FechaNacimiento = persona.FechaNacimiento;
                person.Sexo = persona.Sexo;
                _employeeContext.SaveChanges();
                return true;
            }
            catch (Exception) {
                return false;
            }


              
        }

    }
}
