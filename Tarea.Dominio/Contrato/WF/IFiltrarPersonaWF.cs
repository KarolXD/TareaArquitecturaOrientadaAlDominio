using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tarea.Dominio.Entidades;

namespace Tarea.Dominio.Contrato.WF
{
    public interface IFiltrarPersonaWF
    {
        Persona ejecutar(string cedulaPersona);
      // IEnumerable <Persona> ejecutar(string cedulaPersona);


    }
}
