using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaExamen.Entidades
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }
        public int Monto { get; set; }
        public int Semanas { get; set; }
        public int Cuota { get; set; }
        public DateTime Fecha { get; set; }
    }
}
