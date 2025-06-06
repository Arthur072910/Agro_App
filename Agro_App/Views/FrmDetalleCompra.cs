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
using System.Globalization;


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
                string query = @"
            SELECT 
                P.Nombre_Producto AS Productos,
                DC.Precio_Unitario,
                DC.Cantidad,
                DC.Sub_Total,
                DC.FechaRegistro
            FROM Detalle_Compra DC
            INNER JOIN Productos P ON DC.IdProducto = P.IdProducto";

                adapt = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
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

        private void txtpreciounitario_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtfecharegistro_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmDetalleCompra_Load(object sender, EventArgs e)
        {
            lblFechaRegistro.Text = DateTime.Now.ToString("dd/MM/yyyy"); 
        } 

        private int idCompra; 

        public FrmDetalleCompra(int idCompra)
        {
            InitializeComponent();
            this.idCompra = idCompra;
            obtenerLista();
        }


        private void btnagregar_Click(object sender, EventArgs e)
        {
            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(txtproducto.Text) ||
                string.IsNullOrWhiteSpace(txtcantidad.Text) ||
                string.IsNullOrWhiteSpace(txtpreciounitario.Text))
            {
                MessageBox.Show("Por favor completa todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Variables para almacenar valores convertidos
            int cantidad;
            decimal precioUnitario;
            int idProducto;

            // Mostrar el texto ingresado en precio unitario (para debug)
            string precioTexto = txtpreciounitario.Text.Trim();
            MessageBox.Show($"Precio ingresado: '{precioTexto}'", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Intentar parsear los valores con configuración regional actual
            bool cantidadValida = int.TryParse(txtcantidad.Text, out cantidad);
            bool productoValido = int.TryParse(txtproducto.Text, out idProducto);
            bool precioValido = decimal.TryParse(precioTexto, System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.CurrentCulture, out precioUnitario);

            if (!cantidadValida || !productoValido || !precioValido)
            {
                MessageBox.Show("Cantidad, producto o precio unitario tienen formato incorrecto. Usa números válidos, y usa punto o coma según configuración regional.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar rangos, opcional
            if (cantidad <= 0)
            {
                MessageBox.Show("Cantidad debe ser mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (precioUnitario <= 0 || precioUnitario > 999.99m)
            {
                MessageBox.Show("Precio unitario debe ser mayor que cero y menor a 999.99.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calcular subtotal
            decimal subTotal = cantidad * precioUnitario;

            // Insertar en la base de datos
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Detalle_Compra 
                         (IdCompra, IdProducto, Cantidad, Precio_Unitario, Sub_Total)
                         VALUES (@IdCompra, @IdProducto, @Cantidad, @Precio_Unitario, @Sub_Total)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IdCompra", idCompra);
                    cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@Precio_Unitario", precioUnitario);
                    cmd.Parameters.AddWithValue("@Sub_Total", subTotal);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            // Mensaje éxito y actualizar tabla
            MessageBox.Show("Detalle agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            obtenerLista();

            // Limpiar campos
            txtproducto.Clear();
            txtcantidad.Clear();
            txpreciounitario.Clear();
        }



    }
}
