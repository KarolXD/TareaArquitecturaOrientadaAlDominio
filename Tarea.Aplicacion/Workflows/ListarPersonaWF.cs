using System;
using System.Collections.Generic;
using System.Text;
using Tarea.Dominio.Contrato.RP;
using Tarea.Dominio.Contrato.WF;
using Tarea.Dominio.Entidades;

namespace Tarea.Aplicacion.Workflows
{
    public class ListarPersonaWF: IListarPersonaWF
    {
        IListarPersonaRP _listarPersonaRP;
        public ListarPersonaWF(IListarPersonaRP listarPersonaRP)
        {
            _listarPersonaRP = listarPersonaRP;

        }

        public IEnumerable<Persona> ejecutar()
        {
            return _listarPersonaRP.ejecutar();
        }
    }
}
