using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrestamoRepaso.Entidad
{
    public class Prestamos
    {
        [Key]
        public int PrestamosId { get; set; }
        [Range(minimum:100,maximum:50000)]
        public int Monto { get; set; }
        [Range(minimum: 1, maximum: 52)]

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
