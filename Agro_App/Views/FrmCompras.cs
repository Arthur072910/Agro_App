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
    public partial class FrmCompras : Form
    {
        private readonly string connectionString =
      ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
        SqlDataAdapter adapt;
        public FrmCompras()
        {
            InitializeComponent();
            obtenerLista();
        }
        private void obtenerLista()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                adapt = new SqlDataAdapter("SELECT  IdProveedor, IdEmpleado, Fecha_Compro, Total_Compra, TipoDocumento,NumeroDocumento FROM Compras", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }
        private void submenuregistrarventa_Click(object sender, EventArgs e)
        {
            FrmRegistrarVenta ventasForm = new FrmRegistrarVenta();
            ventasForm.Show();
            this.Hide();
        }

        private void menucompras_Click(object sender, EventArgs e)
        {

        }

        private void menuusuarios_Click(object sender, EventArgs e)
        {
            FrmEmpleados empleadosForm = new FrmEmpleados();
            empleadosForm.Show(); // Muestra el formulario frmEmpleados

            this.Hide();
        }

        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            FrmDetalleVentas ventasForm = new FrmDetalleVentas();
            ventasForm.Show();
            this.Hide();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria categoriaForm = new FrmCategoria();
            categoriaForm.Show();
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

        private void reporteVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteDeVenta ReporteDeVentaForm = new frmReporteDeVenta();
            ReporteDeVentaForm.Show();

            this.Hide();
        }

        private void reporteComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteCompras ReporteComprasForm = new frmReporteCompras();
            ReporteComprasForm.Show();

            this.Hide();
        }

        private void menucasa_Click(object sender, EventArgs e)
        {
            // Assuming "empleado" is an instance of the Empleados class that needs to be passed to Inicio
            Empleados empleado = new Empleados(); // Create or retrieve an instance of Empleados
            Inicio inicioForm = new Inicio(empleado); // Pass the required parameter
            inicioForm.Show();
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtidproveedor.Text) ||
                string.IsNullOrWhiteSpace(txtempleado.Text) ||
                string.IsNullOrWhiteSpace(txttipodocumento.Text) ||
                string.IsNullOrWhiteSpace(txtnumerodocumento.Text) ||
                string.IsNullOrWhiteSpace(txttotalcompra.Text))
            {
                MessageBox.Show("Por favor completa todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtidproveedor.Text, out int idProveedor) ||
                !int.TryParse(txtempleado.Text, out int idEmpleado) ||
                !decimal.TryParse(txttotalcompra.Text, out decimal totalCompra))
            {
                MessageBox.Show("Revisa los campos numéricos (proveedor, empleado, total).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Compras 
            (IdProveedor, IdEmpleado, Fecha_Compro, Total_Compra, TipoDocumento, NumeroDocumento) 
            VALUES (@IdProveedor, @IdEmpleado, GETDATE(), @Total_Compra, @TipoDocumento, @NumeroDocumento)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);
                    cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                    cmd.Parameters.AddWithValue("@Total_Compra", totalCompra);
                    cmd.Parameters.AddWithValue("@TipoDocumento", txttipodocumento.Text);
                    cmd.Parameters.AddWithValue("@NumeroDocumento", txtnumerodocumento.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            MessageBox.Show("Compra registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            obtenerLista(); // Recarga el DataGridView

            // Limpiar campos
            txtidproveedor.Clear();
            txtempleado.Clear();
            txttipodocumento.Clear();
            txtnumerodocumento.Clear();
            txttotalcompra.Clear();


        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            lblfechacompra.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
