using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracticaExamen.DAL;
using PracticaExamen.Entidades;

namespace PracticaExamen.Controllers
{
    public class PrestamoController : Controller
    {
        public bool Guardar(Prestamos prestamo)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            contexto.Prestamos.Add(prestamo);

            paso = contexto.SaveChanges() > 0;
            return paso;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}