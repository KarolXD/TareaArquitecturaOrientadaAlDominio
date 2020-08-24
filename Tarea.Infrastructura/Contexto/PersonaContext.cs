using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Tarea.Dominio.Entidades;

namespace Tarea.Infrastructura.Contexto
{
    public class PersonaContext : DbContext
    {
        public PersonaContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Persona> Persona { get; set; }



    }
}
