using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tarea.Dominio.Contrato.RP;
using Tarea.Dominio.Entidades;
using Tarea.Infrastructura.Contexto;

namespace Tarea.Infrastructura.Repositorio
{
    public class EliminarPersonaRP : IEliminarPersonaRP
    {

        readonly PersonaContext _employeeContext;

        public EliminarPersonaRP(PersonaContext context)
        {
            _employeeContext = context;
        }
        public bool ejecutar(string persona) {
            var query = (from p in _employeeContext.Persona
                         where p.Cedula == persona
                         select p).Single();

            _employeeContext.Persona.Remove(query);
            _employeeContext.SaveChanges();

            return true;
        }

    }
}
