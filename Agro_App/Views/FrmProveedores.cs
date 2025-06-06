using Agro_App.Controllers;
using Agro_App.DataAccess;
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

namespace Agro_App.Views
{
    public partial class FrmProveedores : Form
    {
        private int? idProveedorSeleccionado = null;
        private readonly ProveedorDAO proveedorDAO;
        public FrmProveedores()
        {
            InitializeComponent();
            proveedorDAO = new ProveedorDAO(new ConexionDB().GetConnectionString());

        }

        private void menucasa_Click(object sender, EventArgs e)
        {
            // Assuming "empleado" is an instance of the Empleados class that needs to be passed to Inicio
            Empleados empleado = new Empleados(); // Create or retrieve an instance of Empleados
            Inicio inicioForm = new Inicio(empleado); // Pass the required parameter
            inicioForm.Show();
            this.Close();
        }

        private void menuusuarios_Click(object sender, EventArgs e)
        {
            FrmEmpleados empleadosForm = new FrmEmpleados();
            empleadosForm.Show(); // Muestra el formulario frmEmpleados
            this.Hide(); // Oculta el formulario actual (Inicio), si no quieres que siga visible
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedor proveedor = new Proveedor
                {
                    Documento = txtDocumento.Text,
                    RazonSocial = txtRazonSocial.Text,
                    Correo = txtCorreo.Text,
                    Telefono = txtTelefono.Text,
                    NombreEncargado = txtNombreEncargado.Text,
                    Estado = comboEstado.SelectedItem.ToString() == "Activo"
                };

                proveedorDAO.InsertarProveedor(proveedor);
                MessageBox.Show("Proveedor registrado exitosamente.");
                LimpiarCampos();
                CargarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar proveedor: " + ex.Message);
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (idProveedorSeleccionado == null)
            {
                MessageBox.Show("Seleccione un proveedor para editar.");
                return;
            }

            try
            {
                Proveedor proveedor = new Proveedor
                {
                    IdProovedor = idProveedorSeleccionado.Value,
                    Documento = txtDocumento.Text,
                    RazonSocial = txtRazonSocial.Text,
                    Correo = txtCorreo.Text,
                    Telefono = txtTelefono.Text,
                    NombreEncargado = txtNombreEncargado.Text,
                    Estado = comboEstado.SelectedItem.ToString() == "Activo"
                };

                proveedorDAO.EditarProveedor(proveedor);
                MessageBox.Show("Proveedor actualizado exitosamente.");
                LimpiarCampos();
                CargarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar proveedor: " + ex.Message);
            }
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            comboEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            comboEstado.SelectedIndex = 0;
        }

        private void CargarProveedores()
        {
            var lista = proveedorDAO.ObtenerProveedores();
            dataGridView1.DataSource = lista.Select(p => new
            {
                p.IdProovedor,
                p.Documento,
                p.RazonSocial,
                p.Correo,
                p.Telefono,
                p.Direccion,
                p.NombreEncargado,
                Estado = p.Estado ? "Activo" : "Inactivo",
                p.FechaRegistro
            }).ToList();

            dataGridView1.Columns["IdProovedor"].HeaderText = "ID";
        }

        private void LimpiarCampos()
        {
            txtDocumento.Text = "";
            txtRazonSocial.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtNombreEncargado.Text = "";
            comboEstado.SelectedIndex = 0;
            idProveedorSeleccionado = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                // Suponiendo que las columnas están en este orden:
                txtDocumento.Text = fila.Cells["Documento"].Value?.ToString();
                txtRazonSocial.Text = fila.Cells["RazonSocial"].Value?.ToString();
                txtCorreo.Text = fila.Cells["Correo"].Value?.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value?.ToString();
                txtNombreEncargado.Text = fila.Cells["NombreEncargado"].Value?.ToString();

                // El combobox espera "Activo" o "Inactivo"
                bool estado = Convert.ToBoolean(fila.Cells["Estado"].Value);
                comboEstado.SelectedItem = estado ? "Activo" : "Inactivo";

                // Guardar el Id para cuando se edite
                idProveedorSeleccionado = Convert.ToInt32(fila.Cells["IdProovedor"].Value);
            }
        }
    }
}
