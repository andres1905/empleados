using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpleadosWeb
{
    public class EmpleadoManager
    {
        private TallerDataContext _contexto = new TallerDataContext();

        public void CrearEmpleado(Empleado empleado)
        {
            _contexto.Empleados.InsertOnSubmit(empleado);
            _contexto.SubmitChanges();
        }

        public Empleado BuscarPorID (int id)
        {
            var empleado = from e in _contexto.Empleados
                           where e.Id == id
                           select e;

            return empleado.SingleOrDefault();
        }

        public List<Empleado> BuscarPorNombre(string nombre)
        {
            var empleados = _contexto.Empleados.Where(e => e.Nombre.Contains(nombre));
            return empleados.ToList();
        }

        public void EliminarEmpleado(Empleado empleado)
        {
            _contexto.Empleados.DeleteOnSubmit(empleado);
            _contexto.SubmitChanges();
        }

        public void ActualizarEmpleado()
        {
            _contexto.SubmitChanges();
        }
    }
}