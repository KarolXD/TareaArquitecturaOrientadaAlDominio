using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tarea.Dominio.Entidades;

namespace Tarea.Dominio.Contrato.RP
{
   public interface IListarPersonaRP
    {
        IEnumerable<Persona> ejecutar();
    }
}
