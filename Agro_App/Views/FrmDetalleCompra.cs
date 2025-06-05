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
using System.Configuration;
using System.Data.SqlClient;


namespace Agro_App.Views
{
    public partial class FrmDetalleCompra : Form
    {
        private readonly string connectionString =
     ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
        SqlDataAdapter adapt;
        public FrmDetalleCompra()
        {
            InitializeComponent();
            obtenerLista();
        }
        private void obtenerLista()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                adapt = new SqlDataAdapter("SELECT * FROM Empleados", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }



        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompras comprasForm = new FrmCompras();
            comprasForm.Show();

            this.Hide();
        }

        private void menuusuarios_Click(object sender, EventArgs e)
        {
            FrmEmpleados empleadosForm = new FrmEmpleados();
            empleadosForm.Show(); // Muestra el formulario frmEmpleados
            this.Hide();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria categoriaForm = new FrmCategoria();
            categoriaForm.Show();
            this.Hide();
        }

        private void submenuregistrarventa_Click(object sender, EventArgs e)
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

        private void submenureportecompras_Click(object sender, EventArgs e)
        {
            frmReporteCompras ReporteComprasForm = new frmReporteCompras();
            ReporteComprasForm.Show();

            this.Hide();
        }

        private void submenureporteventas_Click(object sender, EventArgs e)
        {
            frmReporteDeVenta ReporteDeVentaForm = new frmReporteDeVenta();
            ReporteDeVentaForm.Show();

            this.Hide();
        }
    }
}
