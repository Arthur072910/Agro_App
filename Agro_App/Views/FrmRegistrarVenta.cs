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
    public partial class FrmRegistrarVenta : Form
    {
        private readonly string connectionString =
     ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
        SqlDataAdapter adapt;
        public FrmRegistrarVenta()
        {
            InitializeComponent();
            obtenerLista();
        }
        private void obtenerLista()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                adapt = new SqlDataAdapter("SELECT * FROM Ventas", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            FrmDetalleVentas ventasForm = new FrmDetalleVentas();
            ventasForm.Show();
            this.Hide();
        }

        private void submenuregistrarventa_Click(object sender, EventArgs e)
        {
            FrmRegistrarVenta ventasForm = new FrmRegistrarVenta();
            ventasForm.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuusuarios_Click(object sender, EventArgs e)
        {
            FrmEmpleados empleadosForm = new FrmEmpleados();
            empleadosForm.Show(); // Muestra el formulario frmEmpleados

            this.Hide();
        }

        private void menucompras_Click(object sender, EventArgs e)
        {


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

        private void menucasa_Click(object sender, EventArgs e)
        {
            // Assuming "empleado" is an instance of the Empleados class that needs to be passed to Inicio
            Empleados empleado = new Empleados(); // Create or retrieve an instance of Empleados
            Inicio inicioForm = new Inicio(empleado); // Pass the required parameter
            inicioForm.Show();
            this.Close();
        }

        private void lblfecha_Click(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(txtidcliente.Text) ||
                string.IsNullOrWhiteSpace(txtidempleado.Text) ||
                string.IsNullOrWhiteSpace(lblfecha.Text) ||  // La fecha está en el label
                string.IsNullOrWhiteSpace(txttotal.Text) ||
                string.IsNullOrWhiteSpace(txttipodocumento.Text) ||
                string.IsNullOrWhiteSpace(txtnumerodocumento.Text))
            {
                MessageBox.Show("Por favor completa todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar campos numéricos
            if (!int.TryParse(txtidcliente.Text, out int idCliente))
            {
                MessageBox.Show("Id Cliente debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtidempleado.Text, out int idEmpleado))
            {
                MessageBox.Show("Id Empleado debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParse(lblfecha.Text, out DateTime fecha))
            {
                MessageBox.Show("Fecha inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txttotal.Text, out decimal total))
            {
                MessageBox.Show("Total debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tipoDocumento = txttipodocumento.Text.Trim();
            string numeroDocumento = txtnumerodocumento.Text.Trim();

            // Insertar en la base de datos
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Ventas 
                         (IdCliente, IdEmpleado, Fecha, Total, TipoDocumento, NumeroDocumento) 
                         VALUES (@IdCliente, @IdEmpleado, @Fecha, @Total, @TipoDocumento, @NumeroDocumento)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                    cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                    cmd.Parameters.AddWithValue("@Fecha", fecha); // Asegúrate de que la columna en SQL es datetime
                    cmd.Parameters.AddWithValue("@Total", total); // Asegúrate de que la columna en SQL es decimal o money
                    cmd.Parameters.AddWithValue("@TipoDocumento", tipoDocumento);
                    cmd.Parameters.AddWithValue("@NumeroDocumento", numeroDocumento);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            MessageBox.Show("Venta registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            obtenerLista(); // Recargar lista

            // Limpiar campos
            txtidcliente.Clear();
            txtidempleado.Clear();
            txttotal.Clear();
            txttipodocumento.Clear();
            txtnumerodocumento.Clear();
        }


        private void FrmRegistrarVenta_Load(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }




}
