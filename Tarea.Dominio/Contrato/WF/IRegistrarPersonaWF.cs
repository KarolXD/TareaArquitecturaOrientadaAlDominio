using System;
using System.Collections.Generic;
using System.Text;
using Tarea.Dominio.Entidades;

namespace Tarea.Dominio.Contrato.WF
{
    public interface IRegistrarPersonaWF
    {

        bool ejecutar(Persona persona); 
        

    }
}
