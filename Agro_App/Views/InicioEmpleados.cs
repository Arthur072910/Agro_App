using System;
using System;
using System.Windows.Forms;
using Agro_App.Model;

namespace Agro_App.Views
{
    public partial class InicioEmpleados : Form
    {
        private Empleados empleadoActual;

        public InicioEmpleados(Empleados empleado)
        {
            InitializeComponent();
            empleadoActual = empleado;
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login(); // Instancia Login
            loginForm.Show(); // Muestra Login
            this.Hide(); // Oculta Inicio en lugar de cerrarlo
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria categoriaForm = new FrmCategoria();
            categoriaForm.Show();
            this.Hide();
        }

        private void submenuregistrar_Click(object sender, EventArgs e)
        {
            FrmRegistrarVenta ventasForm = new FrmRegistrarVenta();
            ventasForm.Show();
            this.Hide();
        }

        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            FrmDetalleVentas ventasForm = new FrmDetalleVentas();
            ventasForm.Show();
            this.Hide();
        }

        private void registrarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompras comprasForm = new FrmCompras();
            comprasForm.Show();

            this.Hide();
        }

        private void detalleCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuproveedores_Click(object sender, EventArgs e)
        {
            FrmProveedores proveedoresForm = new FrmProveedores();
            proveedoresForm.Show();
            this.Hide();
        }
    }
}
