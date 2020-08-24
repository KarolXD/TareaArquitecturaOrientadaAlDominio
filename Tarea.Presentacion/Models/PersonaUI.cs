using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea.Presentacion.Models
{
    public class PersonaUI
    {
       
        public int PersonaId { set; get; }
        public string Cedula { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public DateTime FechaNacimiento { set; get; }
        public string Sexo { set; get; }
    }
}
