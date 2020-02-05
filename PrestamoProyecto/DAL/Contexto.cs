using Microsoft.EntityFrameworkCore;
using PrestamoProyecto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrestamoProyecto.DAL
{
    public class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server = EMIL56\SQLEXPRESS; Database = PrestamosDB; Trusted_Connection = true");
        }
        public DbSet<Prestamos> Prestamos { get; set; }
    }
}
