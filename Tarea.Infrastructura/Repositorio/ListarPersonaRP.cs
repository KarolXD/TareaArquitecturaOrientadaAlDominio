using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Tarea.Dominio.Contrato.RP;
using Tarea.Dominio.Entidades;
using Tarea.Infrastructura.Contexto;

namespace Tarea.Infrastructura.Repositorio
{
    public class ListarPersonaRP : IListarPersonaRP
    {

        readonly PersonaContext _employeeContext;

        public ListarPersonaRP(PersonaContext context)
        {
            _employeeContext = context;
        }

        public IEnumerable<Persona> ejecutar()
        {
            return _employeeContext.Persona.ToList();
        }
    }
}
