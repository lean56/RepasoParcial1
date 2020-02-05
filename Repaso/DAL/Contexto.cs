using Microsoft.EntityFrameworkCore;
using Repaso.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repaso.DAL
{
    public class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=EMIL56\SQLEXPRESS; Database=RepasoDB; trusted_connection=true");
        }
        public DbSet<Prestamos> Prestamos { get; set; }
    }
}
