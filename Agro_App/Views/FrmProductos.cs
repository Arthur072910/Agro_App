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
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;



namespace Agro_App.Views
{
    public partial class FrmProductos : Form
    {
        private bool modoEdicion = false;
        private int idProductoEdicion = 0;
        public FrmProductos()
        {
            InitializeComponent();
            CargarCategorias();
            CargarProductos();
            CargarTodosLosProductos();
            LimpiarCampos();
            CargarProductosGestionActividad(); 

        }
        private void CargarCategorias()
        {
            try
            {
                using (SqlConnection conn = new ConexionDB().GetConnection())
                {
                    string query = "SELECT IdCategoria, Nombre_Categoria FROM Categorias_Productos WHERE Estado = 1";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Crear lista para el ComboBox
                    List<KeyValuePair<int, string>> categorias = new List<KeyValuePair<int, string>>();
                    categorias.Add(new KeyValuePair<int, string>(0, "-- Seleccione una categoría --"));

                    while (reader.Read())
                    {
                        categorias.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
                    }

                    // Configurar ComboBox (ajusta el nombre según tu Designer)
                    comboCategoria.DataSource = categorias;
                    comboCategoria.DisplayMember = "Value";
                    comboCategoria.ValueMember = "Key";
                    comboCategoria.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            txtCodigoProducto.Text = "";
            txtNombreProducto.Text = "";
            txtDescripcionProducto.Text = "";
            txtUnidadMedida.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            txtStock.Text = "";
            comboCategoria.SelectedIndex = 0;

            if (modoEdicion)
            {
                ResetearModoEdicion();
            }
        }

        private void CargarTodosLosProductos()
        {
            try
            {
                using (SqlConnection conn = new ConexionDB().GetConnection())
                {
                    string query = @"SELECT 
                                        p.IdProducto AS ID,
                                        p.Codigo,
                                        p.Nombre_Producto AS NombreProducto,
                                        p.Descripcion,
                                        c.Nombre_Categoria AS Categoria,
                                        p.Unidad_Medida AS UnidadMedida,
                                        p.Stock,
                                        p.PrecioCompra,
                                        p.PrecioVenta,
                                        p.Estado,
                                        p.FechaRegistro
                                    FROM Productos p 
                                    INNER JOIN Categorias_Productos c ON p.IdCategoria = c.IdCategoria 
                                    ORDER BY p.Nombre_Producto";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);

                    // Para el DataGridView de gestión (todos los productos)
                    dataVisualizacionProductos.DataSource = tabla;
                    ConfigurarDataGridView(dataVisualizacionProductos);

                    // Colorear filas según estado
                    foreach (DataGridViewRow row in dataVisualizacionProductos.Rows)
                    {
                        bool estado = Convert.ToBoolean(row.Cells["Estado"].Value);
                        if (!estado) // Si está inactivo
                        {
                            row.DefaultCellStyle.BackColor = Color.LightGray;
                            row.DefaultCellStyle.ForeColor = Color.DarkGray;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar todos los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView(DataGridView dgv)
        {
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
































        private void menucasa_Click(object sender, EventArgs e)
        {
            Empleados empleado = new Empleados(); // Create or retrieve an instance of Empleados
            Inicio inicioForm = new Inicio(empleado); // Pass the required parameter
            inicioForm.Show();
            this.Close();
        }

        private void dataVisualizacionProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCodigoProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecioCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUnidadMedida_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcionProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataMantenedorProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoProducto.Text) ||
       string.IsNullOrWhiteSpace(txtNombreProducto.Text) ||
       string.IsNullOrWhiteSpace(txtPrecioCompra.Text) ||
       string.IsNullOrWhiteSpace(txtPrecioVenta.Text) ||
       string.IsNullOrWhiteSpace(txtUnidadMedida.Text) ||
       comboCategoria.SelectedIndex <= 0)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Validar precios
                if (!decimal.TryParse(txtPrecioCompra.Text, out decimal precioCompra) || precioCompra <= 0)
                {
                    MessageBox.Show("Ingrese un precio de compra válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtPrecioVenta.Text, out decimal precioVenta) || precioVenta <= 0)
                {
                    MessageBox.Show("Ingrese un precio de venta válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
                {
                    MessageBox.Show("Ingrese un stock válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // DECIDIR SI ACTUALIZAR O AGREGAR
                if (modoEdicion)
                {
                    ActualizarProducto(precioCompra, precioVenta, stock);
                }
                else
                {
                    AgregarNuevoProducto(precioCompra, precioVenta, stock);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (dataMantenedorProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para editar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // ACTIVAR MODO EDICIÓN
                modoEdicion = true;

                // Obtener datos del producto seleccionado
                idProductoEdicion = Convert.ToInt32(dataMantenedorProductos.SelectedRows[0].Cells["ID"].Value);

                // Llenar campos con datos actuales
                txtCodigoProducto.Text = dataMantenedorProductos.SelectedRows[0].Cells["Codigo"].Value.ToString();
                txtNombreProducto.Text = dataMantenedorProductos.SelectedRows[0].Cells["NombreProducto"].Value.ToString();
                txtDescripcionProducto.Text = dataMantenedorProductos.SelectedRows[0].Cells["Descripcion"].Value?.ToString() ?? "";
                txtUnidadMedida.Text = dataMantenedorProductos.SelectedRows[0].Cells["UnidadMedida"].Value.ToString();
                txtStock.Text = dataMantenedorProductos.SelectedRows[0].Cells["Stock"].Value.ToString();
                txtPrecioCompra.Text = dataMantenedorProductos.SelectedRows[0].Cells["PrecioCompra"].Value.ToString();
                txtPrecioVenta.Text = dataMantenedorProductos.SelectedRows[0].Cells["PrecioVenta"].Value.ToString();

                // Seleccionar categoría en ComboBox
                string categoria = dataMantenedorProductos.SelectedRows[0].Cells["Categoria"].Value.ToString();
                for (int i = 0; i < comboCategoria.Items.Count; i++)
                {
                    KeyValuePair<int, string> item = (KeyValuePair<int, string>)comboCategoria.Items[i];
                    if (item.Value == categoria)
                    {
                        comboCategoria.SelectedIndex = i;
                        break;
                    }
                }

                // CAMBIAR TEXTO DEL BOTÓN
                btnAgregarProducto.Text = "Actualizar Producto";

                MessageBox.Show("Producto cargado para edición. Modifique los campos y presione 'Actualizar Producto'.", "Modo Edición", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos para edición: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActivarProducto_Click(object sender, EventArgs e)
        {
            if (dataGestioActividad.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para activar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idProducto = Convert.ToInt32(dataGestioActividad.SelectedRows[0].Cells["ID"].Value);
                bool estadoActual = Convert.ToBoolean(dataGestioActividad.SelectedRows[0].Cells["EstadoBool"].Value);
                string nombreProducto = dataGestioActividad.SelectedRows[0].Cells["NombreProducto"].Value.ToString();

                if (estadoActual)
                {
                    MessageBox.Show($"El producto '{nombreProducto}' ya está activo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    $"¿Está seguro que desea activar el producto '{nombreProducto}'?",
                    "Confirmar Activación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    using (SqlConnection conn = new ConexionDB().GetConnection())
                    {
                        string query = "UPDATE Productos SET Estado = 1 WHERE IdProducto = @IdProducto";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@IdProducto", idProducto);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show($"Producto '{nombreProducto}' activado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Actualizar todas las vistas
                            CargarProductosGestionActividad();
                            CargarProductos(); // Para el mantenedor (solo activos)
                            CargarTodosLosProductos(); // Para la visualización general
                        }
                        else
                        {
                            MessageBox.Show("No se pudo activar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al activar producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesactivarProducto_Click(object sender, EventArgs e)
        {
            if (dataGestioActividad.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para desactivar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idProducto = Convert.ToInt32(dataGestioActividad.SelectedRows[0].Cells["ID"].Value);
                bool estadoActual = Convert.ToBoolean(dataGestioActividad.SelectedRows[0].Cells["EstadoBool"].Value);
                string nombreProducto = dataGestioActividad.SelectedRows[0].Cells["NombreProducto"].Value.ToString();

                if (!estadoActual)
                {
                    MessageBox.Show($"El producto '{nombreProducto}' ya está inactivo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    $"¿Está seguro que desea desactivar el producto '{nombreProducto}'?\n\nEsto ocultará el producto del mantenedor principal.",
                    "Confirmar Desactivación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    using (SqlConnection conn = new ConexionDB().GetConnection())
                    {
                        string query = "UPDATE Productos SET Estado = 0 WHERE IdProducto = @IdProducto";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@IdProducto", idProducto);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show($"Producto '{nombreProducto}' desactivado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Actualizar todas las vistas
                            CargarProductosGestionActividad();
                            CargarProductos(); // Para el mantenedor (solo activos)
                            CargarTodosLosProductos(); // Para la visualización general
                        }
                        else
                        {
                            MessageBox.Show("No se pudo desactivar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al desactivar producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGestioActividad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarProductos()
        {
            try
            {
                using (SqlConnection conn = new ConexionDB().GetConnection())
                {
                    string query = @"SELECT 
                                        p.IdProducto AS ID,
                                        p.Codigo,
                                        p.Nombre_Producto AS NombreProducto,
                                        p.Descripcion,
                                        c.Nombre_Categoria AS Categoria,
                                        p.Unidad_Medida AS UnidadMedida,
                                        p.Stock,
                                        p.PrecioCompra,
                                        p.PrecioVenta,
                                        p.FechaRegistro
                                    FROM Productos p 
                                    INNER JOIN Categorias_Productos c ON p.IdCategoria = c.IdCategoria 
                                    WHERE p.Estado = 1
                                    ORDER BY p.Nombre_Producto";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);

                    // Para el DataGridView de productos activos
                    dataMantenedorProductos.DataSource = tabla;
                    ConfigurarDataGridView(dataMantenedorProductos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }










        








        private void ActualizarProducto(decimal precioCompra, decimal precioVenta, int stock)
        {
            string codigo = txtCodigoProducto.Text.Trim();
            string nombre = txtNombreProducto.Text.Trim();
            string descripcion = txtDescripcionProducto.Text.Trim();
            string unidadMedida = txtUnidadMedida.Text.Trim();
            int idCategoria = Convert.ToInt32(((KeyValuePair<int, string>)comboCategoria.SelectedItem).Key);

            using (SqlConnection conn = new ConexionDB().GetConnection())
            {
                // Verificar si el código ya existe en otro producto
                string checkQuery = "SELECT COUNT(*) FROM Productos WHERE Codigo = @Codigo AND IdProducto != @IdProducto";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@Codigo", codigo);
                checkCmd.Parameters.AddWithValue("@IdProducto", idProductoEdicion);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Ya existe otro producto con ese código.", "Código duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Actualizar producto
                string query = @"UPDATE Productos SET 
                        Codigo = @Codigo, 
                        Nombre_Producto = @Nombre, 
                        Descripcion = @Descripcion, 
                        IdCategoria = @IdCategoria, 
                        Unidad_Medida = @Unidad, 
                        Stock = @Stock, 
                        PrecioCompra = @PrecioCompra, 
                        PrecioVenta = @PrecioVenta
                        WHERE IdProducto = @IdProducto";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdProducto", idProductoEdicion);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Descripcion", string.IsNullOrEmpty(descripcion) ? DBNull.Value : (object)descripcion);
                cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
                cmd.Parameters.AddWithValue("@Unidad", unidadMedida);
                cmd.Parameters.AddWithValue("@Stock", stock);
                cmd.Parameters.AddWithValue("@PrecioCompra", precioCompra);
                cmd.Parameters.AddWithValue("@PrecioVenta", precioVenta);

                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetearModoEdicion();
                    LimpiarCampos();
                    CargarProductos();
                    CargarTodosLosProductos();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 5. Agregar este nuevo método para agregar (tu lógica actual):
        private void AgregarNuevoProducto(decimal precioCompra, decimal precioVeta, int stock)
        {
            string codigo = txtCodigoProducto.Text.Trim();
            string nombre = txtNombreProducto.Text.Trim();
            string descripcion = txtDescripcionProducto.Text.Trim();
            string unidadMedida = txtUnidadMedida.Text.Trim();
            int idCategoria = Convert.ToInt32(((KeyValuePair<int, string>)comboCategoria.SelectedItem).Key);

            // Verificar si el código ya existe
            using (SqlConnection conn = new ConexionDB().GetConnection())
            {
                string checkQuery = "SELECT COUNT(*) FROM Productos WHERE Codigo = @Codigo";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@Codigo", codigo);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Ya existe un producto con ese código.", "Código duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insertar producto
                string query = @"INSERT INTO Productos (Codigo, Nombre_Producto, Descripcion, IdCategoria, Unidad_Medida, Stock, PrecioCompra, PrecioVenta, Estado) 
                        VALUES (@Codigo, @Nombre, @Descripcion, @IdCategoria, @Unidad, @Stock, @PrecioCompra, @PrecioVenta, 1)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Descripcion", string.IsNullOrEmpty(descripcion) ? DBNull.Value : (object)descripcion);
                cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
                cmd.Parameters.AddWithValue("@Unidad", unidadMedida);
                cmd.Parameters.AddWithValue("@Stock", stock);
                cmd.Parameters.AddWithValue("@PrecioCompra", precioCompra);
                cmd.Parameters.AddWithValue("@PrecioVenta", precioVeta);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
            CargarProductos();
            CargarTodosLosProductos();
        }

        // 6. Agregar este método para resetear el modo edición:
        private void ResetearModoEdicion()
        {
            modoEdicion = false;
            idProductoEdicion = 0;
            btnAgregarProducto.Text = "Agregar Producto";
        }

























        private void CargarProductosGestionActividad()
        {
            try
            {
                using (SqlConnection conn = new ConexionDB().GetConnection())
                {
                    string query = @"SELECT 
                                p.IdProducto AS ID,
                                p.Codigo,
                                p.Nombre_Producto AS NombreProducto,
                                p.Descripcion,
                                c.Nombre_Categoria AS Categoria,
                                p.Unidad_Medida AS UnidadMedida,
                                p.Stock,
                                p.PrecioCompra,
                                p.PrecioVenta,
                                CASE 
                                    WHEN p.Estado = 1 THEN 'Activo'
                                    ELSE 'Inactivo'
                                END AS Estado,
                                p.Estado AS EstadoBool,
                                p.FechaRegistro
                            FROM Productos p 
                            INNER JOIN Categorias_Productos c ON p.IdCategoria = c.IdCategoria 
                            ORDER BY p.Estado DESC, p.Nombre_Producto";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);

                    // Para el DataGridView de gestión de actividad (todos los productos)
                    dataGestioActividad.DataSource = tabla;
                    ConfigurarDataGridView(dataGestioActividad);

                    // Colorear filas según estado
                    foreach (DataGridViewRow row in dataGestioActividad.Rows)
                    {
                        bool estado = Convert.ToBoolean(row.Cells["EstadoBool"].Value);
                        if (!estado) // Si está inactivo
                        {
                            row.DefaultCellStyle.BackColor = Color.LightCoral;
                            row.DefaultCellStyle.ForeColor = Color.DarkRed;
                        }
                        else // Si está activo
                        {
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            row.DefaultCellStyle.ForeColor = Color.DarkGreen;
                        }
                    }

                    // Ocultar la columna EstadoBool ya que solo la usamos para colorear
                    if (dataGestioActividad.Columns["EstadoBool"] != null)
                    {
                        dataGestioActividad.Columns["EstadoBool"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos para gestión de actividad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void AlternarEstadoProducto()
        {
            if (dataGestioActividad.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para cambiar su estado.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idProducto = Convert.ToInt32(dataGestioActividad.SelectedRows[0].Cells["ID"].Value);
                bool estadoActual = Convert.ToBoolean(dataGestioActividad.SelectedRows[0].Cells["EstadoBool"].Value);
                string nombreProducto = dataGestioActividad.SelectedRows[0].Cells["NombreProducto"].Value.ToString();

                string accion = estadoActual ? "desactivar" : "activar";
                string estadoNuevo = estadoActual ? "inactivo" : "activo";

                DialogResult resultado = MessageBox.Show(
                    $"¿Está seguro que desea {accion} el producto '{nombreProducto}'?",
                    $"Confirmar {char.ToUpper(accion[0]) + accion.Substring(1)}",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    using (SqlConnection conn = new ConexionDB().GetConnection())
                    {
                        string query = "UPDATE Productos SET Estado = @NuevoEstado WHERE IdProducto = @IdProducto";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                        cmd.Parameters.AddWithValue("@NuevoEstado", !estadoActual);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show($"Producto '{nombreProducto}' {accion}do correctamente. Ahora está {estadoNuevo}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Actualizar todas las vistas
                            CargarProductosGestionActividad();
                            CargarProductos();
                            CargarTodosLosProductos();
                        }
                        else
                        {
                            MessageBox.Show($"No se pudo {accion} el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cambiar estado del producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
