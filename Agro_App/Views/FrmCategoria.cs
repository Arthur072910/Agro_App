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
using Agro_App.Model;


namespace Agro_App.Views
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
            CargarCategorias();


            CargarCategoriasActivas(); // Para el DataListadoCategorias
            CargarTodasLasCategorias();
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



                DataMantenedorCategorias.DefaultCellStyle.ForeColor = Color.Black;
                DataMantenedorCategorias.DefaultCellStyle.BackColor = Color.White;
                DataMantenedorCategorias.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                DataMantenedorCategorias.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
                DataMantenedorCategorias.ReadOnly = true;
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
            CargarCategoriasActivas();
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
            CargarCategoriasActivas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }










        private void DataMantenedorCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarCategoriasActivas();
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

        private void menucasa_Click(object sender, EventArgs e)
        {
            Empleados empleado = new Empleados(); // Create or retrieve an instance of Empleados
            Inicio inicioForm = new Inicio(empleado); // Pass the required parameter
            inicioForm.Show();
            this.Close();
        }

        private void DataListadoCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarCategoriasActivas();
        }






        private void CargarCategoriasActivas()
        {
            using (SqlConnection con = new ConexionDB().GetConnection())
            {
                // Query para obtener solo las categorías activas (Estado = 1)
                string query = "SELECT IdCategoria AS ID, Nombre_Categoria AS NombreCategoria, Estado, FechaRegistro FROM Categorias_Productos WHERE Estado = 1";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Asignar los datos al DataGridView
                DataListadoCategorias.DataSource = dt;

                // Configurar propiedades del DataGridView
                DataListadoCategorias.DefaultCellStyle.ForeColor = Color.Black;
                DataListadoCategorias.DefaultCellStyle.BackColor = Color.White;
                DataListadoCategorias.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                DataListadoCategorias.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
                DataListadoCategorias.ReadOnly = true;
                DataListadoCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DataListadoCategorias.AllowUserToAddRows = false;
                DataListadoCategorias.AllowUserToDeleteRows = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Verificar que hay una fila seleccionada
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una categoría para activar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el ID de la categoría seleccionada
            int idCategoria = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            string nombreCategoria = dataGridView1.SelectedRows[0].Cells["NombreCategoria"].Value.ToString();
            bool estadoActual = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells["Estado"].Value);

            // Verificar si ya está activa
            if (estadoActual)
            {
                MessageBox.Show($"La categoría '{nombreCategoria}' ya está activa.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Confirmar la acción
            DialogResult result = MessageBox.Show($"¿Está seguro de activar la categoría '{nombreCategoria}'?",
                                                "Confirmar Activación",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new ConexionDB().GetConnection())
                    {
                        string query = "UPDATE Categorias_Productos SET Estado = 1 WHERE IdCategoria = @Id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Id", idCategoria);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Categoría '{nombreCategoria}' activada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recargar los datos
                    CargarTodasLasCategorias();
                    CargarCategorias(); // Para actualizar el otro DataGridView también
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al activar la categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verificar que hay una fila seleccionada
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una categoría para desactivar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el ID de la categoría seleccionada
            int idCategoria = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            string nombreCategoria = dataGridView1.SelectedRows[0].Cells["NombreCategoria"].Value.ToString();
            bool estadoActual = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells["Estado"].Value);

            // Verificar si ya está inactiva
            if (!estadoActual)
            {
                MessageBox.Show($"La categoría '{nombreCategoria}' ya está desactivada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Confirmar la acción
            DialogResult result = MessageBox.Show($"¿Está seguro de desactivar la categoría '{nombreCategoria}'?",
                                                "Confirmar Desactivación",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new ConexionDB().GetConnection())
                    {
                        string query = "UPDATE Categorias_Productos SET Estado = 0 WHERE IdCategoria = @Id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Id", idCategoria);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Categoría '{nombreCategoria}' desactivada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recargar los datos
                    CargarTodasLasCategorias();
                    CargarCategorias(); // Para actualizar el otro DataGridView también
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al desactivar la categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                string nombreCategoria = row.Cells["NombreCategoria"].Value.ToString();
                bool estado = Convert.ToBoolean(row.Cells["Estado"].Value);
                string estadoTexto = estado ? "Activa" : "Inactiva";

            }
        }



        private void CargarTodasLasCategorias()
        {
            using (SqlConnection con = new ConexionDB().GetConnection())
            {
                string query = "SELECT IdCategoria AS ID, Nombre_Categoria AS NombreCategoria, Estado, FechaRegistro FROM Categorias_Productos ORDER BY IdCategoria";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Asignar los datos al DataGridView
                dataGridView1.DataSource = dt;

                // Configurar propiedades del DataGridView
                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
                dataGridView1.DefaultCellStyle.BackColor = Color.White;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;

                // Opcional: Colorear las filas según el estado
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    bool estado = Convert.ToBoolean(row.Cells["Estado"].Value);
                    if (!estado) // Si está inactivo
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                        row.DefaultCellStyle.ForeColor = Color.DarkGray;
                    }
                    else // Si está activo
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }

    }
}
