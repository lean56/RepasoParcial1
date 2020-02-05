using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Repaso2.DAL;
using Repaso2.Entidades;

namespace Repaso2.Controllers
{
    public class PrestamoController : Controller
    {
       public bool Guardar(Prestamos prestamo)
        {
            Contexto db = new Contexto();
            bool paso = false;

            db.Prestamos.Add(prestamo);
            paso = db.SaveChanges() > 0;
            return paso;
        }

        public List<Prestamos> GetPrestamos(Expression<Func<Prestamos, bool>> expression)
        {
            List<Prestamos> lista = new List<Prestamos>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Set<Prestamos>().Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return lista;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}