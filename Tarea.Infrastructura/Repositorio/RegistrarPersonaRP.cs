using System;
using System.Collections.Generic;
using System.Text;
using Tarea.Dominio.Contrato.RP;
using Tarea.Dominio.Entidades;
using Tarea.Infrastructura.Contexto;

namespace Tarea.Infrastructura.Repositorio
{
    public class RegistrarPersonaRP : IRegistrarPersonaRP
    {
        readonly PersonaContext _employeeContext;

        public RegistrarPersonaRP(PersonaContext context)
        {
            _employeeContext = context;
        }
        public bool ejecutar(Persona persona)
        {

            string temp = persona.Cedula;
            _employeeContext.Persona.Add(persona);
            _employeeContext.SaveChanges();

            return true;
        }


    }
}
