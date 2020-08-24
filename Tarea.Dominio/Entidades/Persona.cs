using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Tarea.Dominio.Entidades
{
    public class Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long PersonaId { get; set; }
        public string Cedula {set;get;}
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public DateTime FechaNacimiento { set; get; }
        public string Sexo { set; get; }
    }
}
