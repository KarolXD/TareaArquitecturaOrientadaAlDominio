using System;
using System.Collections.Generic;
using System.Text;
using Tarea.Dominio.Contrato.RP;
using Tarea.Dominio.Contrato.WF;
using Tarea.Dominio.Entidades;

namespace Tarea.Aplicacion.Workflows
{
   public class ModificarPersonaWF: IModificarPersonaWF
    {

        IModificarPersonaRP _modificarPersonaRP;
        public ModificarPersonaWF(IModificarPersonaRP modificarPersonaRP)
        {
            _modificarPersonaRP = modificarPersonaRP;

        }

        public bool ejecutar(Persona persona)
        {
            return _modificarPersonaRP.ejecutar(persona);
        }
    }
}
