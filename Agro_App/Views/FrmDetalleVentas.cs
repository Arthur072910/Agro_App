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
    public partial class FrmDetalleVentas : Form
    {
        public FrmDetalleVentas()
        {
            InitializeComponent();
        }

        private void menuusuarios_Click(object sender, EventArgs e)
        {
            FrmEmpleados empleadosForm = new FrmEmpleados();
            empleadosForm.Show(); // Muestra el formulario frmEmpleados

            this.Hide(); // Oculta el formulario actual (Inicio), si no quieres que siga visible
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRegistrarVenta ventasForm = new FrmRegistrarVenta();
            ventasForm.Show();
            this.Hide();
        }

        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            FrmEmpleados empleadosForm = new FrmEmpleados();
            empleadosForm.Show(); // Muestra el formulario frmEmpleados

            this.Hide(); // Oculta el formulario actual (Inicio), si no quieres que siga visible
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
