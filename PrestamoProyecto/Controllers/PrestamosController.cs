using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrestamoProyecto.Entidades;
using PrestamoProyecto.DAL;

namespace PrestamoProyecto.Controllers
{
    public class PrestamosController : Controller
    {
        public bool Guardar(Prestamos prestamo)
        {
            Contexto db = new Contexto();
            bool paso = false;

            db.Prestamos.Add(prestamo);
            paso = db.SaveChanges() >0;
            return paso;
        }
       
        public IActionResult Index()
        {
            return View();
        }
    }
}