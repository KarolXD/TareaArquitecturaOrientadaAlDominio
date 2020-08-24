using System;
using System.Collections.Generic;
using System.Text;
using Tarea.Dominio.Contrato.RP;
using Tarea.Dominio.Contrato.WF;
using Tarea.Dominio.Entidades;

namespace Tarea.Aplicacion.Workflows
{
    public class EliminarPersonaWF : IEliminarPersonaWF
    {

        IEliminarPersonaRP _eliminarPersonaRP;
        public EliminarPersonaWF(IEliminarPersonaRP eliminarPersonaRP)
        {
            _eliminarPersonaRP = eliminarPersonaRP;

        }

        public bool ejecutar(string  persona)
        {
            return _eliminarPersonaRP.ejecutar(persona);
        }

       
    }
}
