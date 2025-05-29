using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agro_App.DataAccess;
using Agro_App.Controllers;
using Agro_App.Model;

namespace Agro_App.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bntcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtusuario.Text.Trim();
                string password = txtcontraseña.Text.Trim();

                // Validar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Campos vacíos",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ConexionDB conexion = new ConexionDB();
                // Usar el método GetConnectionString() que agregamos a ConexionDB
                LoginControllers controller = new LoginControllers(conexion.GetConnectionString());

                Empleados empleado = controller.IniciarSesion(username, password);

                if (empleado != null)
                {
                    MessageBox.Show($"Bienvenido, {empleado.Nombre} {empleado.Apellido}!",
                                  "Login exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abrir el formulario Inicio y pasar el empleado
                    Form Inicio = new Inicio(empleado);
                    Inicio.Show();
                    this.Hide();

                    // Opcional: Cerrar el form de login cuando se cierre el form Inicio
                    Inicio.FormClosed += (s, args) => this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Limpiar campos
                    txtcontraseña.Text = "";
                    txtusuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar iniciar sesión: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
