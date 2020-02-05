using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrestamoProyecto.Entidades
{
    public class Prestamos
    {
        [Key]
        public int PrestamosId { get; set; }
        [Required]
        public int Monto { get; set; }
        [Required]
        public int Semanas { get; set; }
        [Required]
        public string Concepto { get; set; }
        public DateTime Fecha { get; set; }
        public Prestamos()
        {
            PrestamosId = 0;
            Monto = 0;
            Semanas = 0;
            Concepto = string.Empty;
            Fecha = DateTime.Now;
        }
    }
}
