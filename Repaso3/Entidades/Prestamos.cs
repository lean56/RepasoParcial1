using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Repaso3.Entidades
{
    public class Prestamos
    {
        [Key]
        public int PrestamosId { get; set; }
        public int Monto { get; set; }
        public int Semanas { get; set; }
        public int Cuota { get; set; }

        public Prestamos()
        {
            PrestamosId = 0;
            Monto = 0;
            Semanas = 0;
            Cuota = 0;
        }
    }
}
