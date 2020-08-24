using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tarea.Dominio.Contrato.RP;
using Tarea.Dominio.Entidades;
using Tarea.Infrastructura.Contexto;

namespace Tarea.Infrastructura.Repositorio
{
    public class FiltrarPersonaRP: IFiltrarPersonaRP
    {


        readonly PersonaContext _employeeContext;

        public FiltrarPersonaRP(PersonaContext context)
        {
            _employeeContext = context;
        }


        //    public Persona ejecutar(string cedulaPersona)
        public Persona ejecutar(string cedulaPersona)
        {

            //var query = (from p in _employeeContext.Persona
            //             where p.Cedula == cedulaPersona
            //             select p).Single();


            // return query;

            return _employeeContext.Persona
                              .FirstOrDefault(e => e.Cedula == cedulaPersona);

        }
    }
}
