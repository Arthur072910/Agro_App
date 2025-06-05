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
    public partial class FrmDetalleVentas : Form
    {
        private readonly string connectionString =
     ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
        SqlDataAdapter adapt;
        public FrmDetalleVentas()
        {
            InitializeComponent();
            obtenerLista();
        }
        private void obtenerLista()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open(); 
                adapt = new SqlDataAdapter(
                    "SELECT P.Nombre_Producto, DV.Cantidad, DV.Precio_Unitario, DV.Sub_Total " +
                    "FROM Detalle_ventas DV " +
                    "INNER JOIN Productos P ON DV.IdProducto = P.IdProducto", con);

                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

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

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria categoriaForm = new FrmCategoria();
            categoriaForm.Show();
            this.Hide();
        }

        private void menucompras_Click(object sender, EventArgs e)
        {

        }



        private void detalleCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDetalleCompra DetallecompraForm = new FrmDetalleCompra();
            DetallecompraForm.Show();

            this.Hide();
        }

        private void registrarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompras comprasForm = new FrmCompras();
            comprasForm.Show();

            this.Hide();
        }
    }
}
