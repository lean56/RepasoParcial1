using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoPrestamo.BLL2
{
    interface IRepository<T> where T : class
    {
        public bool Guardar(T entity);

    }
}
