using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repaso.DAL;
using Repaso.Entidades;

namespace Repaso.Controllers
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

        public bool Modificar(Prestamos prestamo)
        {
            Contexto db = new Contexto();
            bool paso = false;

            db.Prestamos.Add(prestamo).State = EntityState.Modified;
            paso = db.SaveChanges() > 0;
            return paso;

        }

        public Prestamos Buscar(int id)
        {
            Contexto db = new Contexto();
            Prestamos prestamos = new Prestamos();

            try
            {
                prestamos = db.Prestamos.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return prestamos;
        }


        public List<Prestamos> Listado(Expression<Func<Prestamos, bool>> expression)
        {
            Contexto db = new Contexto();
            List<Prestamos> lista = new List<Prestamos>();

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