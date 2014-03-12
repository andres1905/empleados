using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmpleadosWeb
{
    public partial class Default : System.Web.UI.Page
    {
        private EmpleadoManager _manager;

        protected void Page_Load(object sender, EventArgs e)
        {
            _manager = new EmpleadoManager();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            var nuevoEmpleado = new Empleado
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Edad = Convert.ToInt16(txtEdad.Text),
                Sueldo = Convert.ToDecimal(txtSueldo.Text)
            };

            _manager.CrearEmpleado(nuevoEmpleado);
        }
    }
}