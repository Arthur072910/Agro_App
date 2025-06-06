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
using Agro_App.DataAccess;

namespace Agro_App.Views
{
    public partial class FrmEmpleados : Form
    {
        private int? idEmpleadoSeleccionado = null;

        private readonly string connectionString =
        ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
        SqlDataAdapter adapt;
        public FrmEmpleados()
        {
            InitializeComponent();
            obtenerLista();
            CargarCombos();

            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

        }


        private void obtenerLista()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"
            SELECT 
                E.IdEmpleado,
                E.Nombre,
                E.Apellido,
                E.Telefono,
                E.Email,
                E.IdCargo,
                C.Nombre_Cargo AS Cargo,
                E.Estado,
                E.Documento
            FROM Empleados E
            INNER JOIN Cargos C ON E.IdCargo = C.IdCargo";

                SqlDataAdapter adapt = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;

                // Opcional: ajustar el ancho o encabezados si lo deseas
                dataGridView1.Columns["IdEmpleado"].HeaderText = "ID";
                dataGridView1.Columns["Nombre"].HeaderText = "Nombre";
                dataGridView1.Columns["Apellido"].HeaderText = "Apellido";
                dataGridView1.Columns["Telefono"].HeaderText = "Teléfono";
                dataGridView1.Columns["Email"].HeaderText = "Email";
                dataGridView1.Columns["IdCargo"].HeaderText = "ID Cargo";
                dataGridView1.Columns["Cargo"].HeaderText = "Cargo";
                dataGridView1.Columns["Estado"].HeaderText = "Estado";
                dataGridView1.Columns["Documento"].HeaderText = "Documento";
            }
        }



        private void CargarCombos()
        {
            // Combo de cargos
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT IdCargo, Nombre_Cargo FROM Cargos";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboCargo.DisplayMember = "Nombre_Cargo";
                comboCargo.ValueMember = "IdCargo";
                comboCargo.DataSource = dt;
            }

            // Combo de estado (activo/inactivo)
            comboEstado.Items.Clear();
            comboEstado.Items.Add("Activo");
            comboEstado.Items.Add("Inactivo");
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

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (comboCargo.SelectedItem == null || comboEstado.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un cargo y un estado.");
                return;
            }

            int idCargo = Convert.ToInt32(comboCargo.SelectedValue);
            bool estado = comboEstado.SelectedItem.ToString() == "Activo";

            Empleados nuevoEmpleado = new Empleados()
            {
                Documento = txtDocumento.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                Clave = txtClave.Text,
                IdCargo = idCargo,
                Estado = estado,
                FechaRegistro = DateTime.Now
            };

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Empleados 
                         (Documento, Nombre, Apellido, Telefono, Email, Clave, IdCargo, Estado, FechaRegistro)
                         VALUES 
                         (@Documento, @Nombre, @Apellido, @Telefono, @Email, @Clave, @IdCargo, @Estado, @FechaRegistro)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Documento", nuevoEmpleado.Documento);
                    cmd.Parameters.AddWithValue("@Nombre", nuevoEmpleado.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", nuevoEmpleado.Apellido);
                    cmd.Parameters.AddWithValue("@Telefono", nuevoEmpleado.Telefono);
                    cmd.Parameters.AddWithValue("@Email", nuevoEmpleado.Email);
                    cmd.Parameters.AddWithValue("@Clave", nuevoEmpleado.Clave);
                    cmd.Parameters.AddWithValue("@IdCargo", nuevoEmpleado.IdCargo);
                    cmd.Parameters.AddWithValue("@Estado", nuevoEmpleado.Estado);
                    cmd.Parameters.AddWithValue("@FechaRegistro", nuevoEmpleado.FechaRegistro);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Empleado guardado correctamente.");
            obtenerLista();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (idEmpleadoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un empleado de la tabla para editar.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"
            UPDATE Empleados
            SET Nombre = @Nombre,
                Apellido = @Apellido,
                Telefono = @Telefono,
                Email = @Email,
                Clave = @Clave,
                IdCargo = @IdCargo,
                Estado = @Estado,
                Documento = @Documento
            WHERE IdEmpleado = @IdEmpleado";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Clave", "1234"); // puedes omitir si no quieres cambiarla
                    cmd.Parameters.AddWithValue("@IdCargo", comboCargo.SelectedValue);
                    cmd.Parameters.AddWithValue("@Estado", comboEstado.SelectedItem.ToString() == "Activo");
                    cmd.Parameters.AddWithValue("@Documento", txtDocumento.Text);
                    cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleadoSeleccionado);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Empleado actualizado correctamente.");
                obtenerLista(); // Actualizar la tabla
                limpiarCampos();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                idEmpleadoSeleccionado = Convert.ToInt32(fila.Cells["IdEmpleado"].Value);
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtApellido.Text = fila.Cells["Apellido"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                txtEmail.Text = fila.Cells["Email"].Value.ToString();
                txtDocumento.Text = fila.Cells["Documento"].Value.ToString();

                string nombreCargo = fila.Cells["Cargo"].Value.ToString();
                comboCargo.SelectedIndex = comboCargo.FindStringExact(nombreCargo);

                string estadoTexto = fila.Cells["Estado"].Value.ToString();
                comboEstado.SelectedIndex = estadoTexto == "Activo" ? 0 : 1;
            }

        }

        private void limpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDocumento.Clear();
            comboCargo.SelectedIndex = -1;
            comboEstado.SelectedIndex = -1;
            idEmpleadoSeleccionado = null;
        }

    }
}
