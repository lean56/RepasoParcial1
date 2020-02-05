using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrestamoRepaso.DAL;
using PrestamoRepaso.Entidad;

namespace PrestamoRepaso.Controllers
{
    public class PrestamoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

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
            Prestamos prestamo = new Prestamos();

            try
            {
                prestamo = db.Prestamos.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return prestamo;
        }

        public bool Eliminar(int id)
        {
            Contexto db = new Contexto();
            bool paso = false;
            Prestamos prestamo = new Prestamos();

            try
            {
                prestamo = db.Prestamos.Find(id);
                db.Entry(prestamo).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }


    }
}