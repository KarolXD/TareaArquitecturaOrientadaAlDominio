using System;
using System.Collections.Generic;
using System.Text;
using Tarea.Dominio.Entidades;

namespace Tarea.Dominio.Contrato.RP
{
    public interface IRegistrarPersonaRP
    {
        bool ejecutar(Persona Persona);
    }
}
