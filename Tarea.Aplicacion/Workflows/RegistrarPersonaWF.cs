using System;
using System.Collections.Generic;
using System.Text;
using Tarea.Dominio.Contrato.RP;
using Tarea.Dominio.Contrato.WF;
using Tarea.Dominio.Entidades;

namespace Tarea.Aplicacion.Workflows
{
    public class RegistrarPersonaWF : IRegistrarPersonaWF
    {
        IRegistrarPersonaRP _registrarPersonaRP;
        public RegistrarPersonaWF(IRegistrarPersonaRP registrarPersonaRP) 
        {
            _registrarPersonaRP = registrarPersonaRP;

        }

        public bool ejecutar(Persona persona)
        {
            return _registrarPersonaRP.ejecutar(persona);
        }
    }
}
