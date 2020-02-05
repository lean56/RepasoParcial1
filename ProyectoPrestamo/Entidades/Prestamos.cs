using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoPrestamo.Entidades
{
    public class Prestamos
    {
        [Key]
        public int PrestamosId { get; set; }
        public DateTime Fecha { get; set; }
        [Required]
        public int Monto { get; set; }
        [Required]
        public int Semanas { get; set; }
        [Required]
        public string Concepto { get; set; }
        public Prestamos()
        {
            PrestamosId = 0;
            Fecha = DateTime.Now;
            Monto = 0;
            Semanas = 0;
            Concepto = string.Empty;
        }

    }
}
