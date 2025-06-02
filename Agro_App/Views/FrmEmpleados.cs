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
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
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


        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {



        }

        private void submenuregistrar_Click(object sender, EventArgs e)
        {
            FrmRegistrarVenta ventasForm = new FrmRegistrarVenta();
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
            FrmDetalleCompra DetallecompraForm = new FrmDetalleCompra();
            DetallecompraForm.Show();

            this.Hide();
        }

        private void reporteComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteCompras ReporteComprasForm = new frmReporteCompras();
            ReporteComprasForm.Show();

            this.Hide();
        }

        private void reporteVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteDeVenta ReporteDeVentaForm = new frmReporteDeVenta();
            ReporteDeVentaForm.Show();

            this.Hide();
        }
    }
}
