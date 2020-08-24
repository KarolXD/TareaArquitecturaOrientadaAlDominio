using System;
using System.Collections.Generic;
using System.Text;
using Tarea.Dominio.Contrato.RP;
using Tarea.Dominio.Contrato.WF;
using Tarea.Dominio.Entidades;

namespace Tarea.Aplicacion.Workflows
{
    public class FiltrarPersonaWF : IFiltrarPersonaWF
    {


        IFiltrarPersonaRP _filtrarPersonaRP;
        public FiltrarPersonaWF(IFiltrarPersonaRP filtrarPersonaRP)
        {
            _filtrarPersonaRP = filtrarPersonaRP;

        }

        //  public Persona ejecutar(string cedulaPersona)
        //    public IEnumerable<Persona>  ejecutar(string cedulaPersona)
        public Persona ejecutar(string cedulaPersona)
        {
            return _filtrarPersonaRP.ejecutar(cedulaPersona);
        }


       
    }
}
