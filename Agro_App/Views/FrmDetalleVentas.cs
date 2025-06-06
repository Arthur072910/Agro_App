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
                    "SELECT * from detalle_ventas", con);

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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmDetalleVentas_Load(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtcantidad.TextChanged += txtCantidad_TextChanged;
            txtpreciounitario.TextChanged += txtPrecioUnitario_TextChanged;

        }

        private void btnRegistrarDetalle_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtidventa.Text) ||
                string.IsNullOrWhiteSpace(txtidproducto.Text) ||
                string.IsNullOrWhiteSpace(txtcantidad.Text) ||
                string.IsNullOrWhiteSpace(txtpreciounitario.Text) ||
                string.IsNullOrWhiteSpace(txtsubtotal.Text) ||
                string.IsNullOrWhiteSpace(lblfecha.Text))
            {
                MessageBox.Show("Por favor completa todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtidventa.Text, out int idVenta) ||
                !int.TryParse(txtidproducto.Text, out int idProducto) ||
                !decimal.TryParse(txtcantidad.Text, out decimal cantidad) ||
                !decimal.TryParse(txtpreciounitario.Text, out decimal precioUnitario) ||
                !decimal.TryParse(txtsubtotal.Text, out decimal subTotal) ||
                !DateTime.TryParse(lblfecha.Text, out DateTime fechaRegistro))
            {
                MessageBox.Show("Uno o más campos tienen valores inválidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO detalle_ventas 
                        (IdVenta, IdProducto, Cantidad, Precio_Unitario, Sub_Total, FechaRegistro)
                         VALUES (@IdVenta, @IdProducto, @Cantidad, @PrecioUnitario, @SubTotal, @FechaRegistro)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IdVenta", idVenta);
                    cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@PrecioUnitario", precioUnitario);
                    cmd.Parameters.AddWithValue("@SubTotal", subTotal);
                    cmd.Parameters.AddWithValue("@FechaRegistro", fechaRegistro);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            MessageBox.Show("Detalle de venta registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            obtenerLista(); // recargar DataGrid

            // Limpiar campos
            txtidventa.Clear();
            txtidproducto.Clear();
            txtcantidad.Clear();
            txtpreciounitario.Clear();
            txtsubtotal.Clear();
        }
        private void CalcularSubTotal()
        {
            if (decimal.TryParse(txtcantidad.Text, out decimal cantidad) &&
                decimal.TryParse(txtpreciounitario.Text, out decimal precio))
            {
                decimal subtotal = cantidad * precio;
                txtsubtotal.Text = subtotal.ToString("0.00");
            }
        }
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            CalcularSubTotal();
        }

        private void txtPrecioUnitario_TextChanged(object sender, EventArgs e)
        {
            CalcularSubTotal();
        }



    }
}
