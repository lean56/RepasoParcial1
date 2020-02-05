using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Repaso.Entidades
{
    public class Prestamos
    {
        [Key]
        public int PrestamosId { get; set; }
        [Range(100,10000)]
        public int Monto { get; set; }
        [Range(1,52)]
        public int Semanas { get; set; }
        public int Cuota { get; set; }
        [Required]
        public string Concepto { get; set; }
        public Prestamos()
        {
            PrestamosId = 0;
            Monto = 0;
            Semanas = 0;
            Cuota = 0;
            Concepto = string.Empty;
        }
    }
}
