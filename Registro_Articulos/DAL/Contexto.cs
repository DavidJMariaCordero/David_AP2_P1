using Microsoft.EntityFrameworkCore;
using Registro_Articulos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registro_Articulos.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite(@"Data Source=Data\Productos.db");
        }
    }
}
