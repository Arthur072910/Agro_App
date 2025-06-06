using Agro_App.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agro_App.Views
{
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void menucasa_Click(object sender, EventArgs e)
        {
            // Assuming "empleado" is an instance of the Empleados class that needs to be passed to Inicio
            Empleados empleado = new Empleados(); // Create or retrieve an instance of Empleados
            Inicio inicioForm = new Inicio(empleado); // Pass the required parameter
            inicioForm.Show();
            this.Close();
        }

        private void menuusuarios_Click(object sender, EventArgs e)
        {
            FrmEmpleados empleadosForm = new FrmEmpleados();
            empleadosForm.Show(); // Muestra el formulario frmEmpleados
            this.Hide(); // Oculta el formulario actual (Inicio), si no quieres que siga visible
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

        }

        private void btneditar_Click(object sender, EventArgs e)
        {

        }
    }
}
