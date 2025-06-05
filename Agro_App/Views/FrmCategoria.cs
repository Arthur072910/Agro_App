using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Agro_App.Views
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
            CargarCategorias();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio inicioForm = new Inicio(null);
            inicioForm.Show();
            this.Hide();
        }

        private void CargarCategorias()
        {
            using (SqlConnection con = new ConexionDB().GetConnection())
            {
                string query = "SELECT IdCategoria AS ID, Nombre_Categoria AS NombreCategoria, Estado, FechaRegistro FROM Categorias_Productos";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataMantenedorCategorias.DataSource = dt;
            }
        }


        private void menumantenedor_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre de categoría.");
                return;
            }

            using (SqlConnection con = new ConexionDB().GetConnection())
            {
                string query = "INSERT INTO Categorias_Productos (Nombre_Categoria) VALUES (@Nombre)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Categoría agregada.");
            txtNombre.Clear();
            CargarCategorias();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (DataMantenedorCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para editar.");
                return;
            }

            int id = Convert.ToInt32(DataMantenedorCategorias.SelectedRows[0].Cells["ID"].Value);
            string nuevoNombre = Microsoft.VisualBasic.Interaction.InputBox("Nuevo nombre de categoría:", "Editar Categoría", DataMantenedorCategorias.SelectedRows[0].Cells["NombreCategoria"].Value.ToString());

            if (string.IsNullOrWhiteSpace(nuevoNombre))
            {
                MessageBox.Show("Nombre inválido.");
                return;
            }

            using (SqlConnection con = new ConexionDB().GetConnection())
            {
                string query = "UPDATE Categorias_Productos SET Nombre_Categoria = @Nombre WHERE IdCategoria = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nombre", nuevoNombre);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Categoría actualizada.");
            CargarCategorias();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DataMantenedorCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
                return;
            }

            int id = Convert.ToInt32(DataMantenedorCategorias.SelectedRows[0].Cells["ID"].Value);

            var confirm = MessageBox.Show("¿Está seguro de eliminar esta categoría?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            using (SqlConnection con = new ConexionDB().GetConnection())
            {
                string query = "DELETE FROM Categorias_Productos WHERE IdCategoria = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Categoría eliminada.");
            CargarCategorias();
        }










        private void DataMantenedorCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompras comprasForm = new FrmCompras();
            comprasForm.Show();

            this.Hide();
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
