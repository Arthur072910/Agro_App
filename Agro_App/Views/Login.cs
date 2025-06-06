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
            Application.Exit();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtusuario.Text.Trim();
                string password = txtcontraseña.Text.Trim();

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Campos vacíos",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ConexionDB conexion = new ConexionDB();
                LoginControllers controller = new LoginControllers(conexion.GetConnectionString());

                Empleados empleado = controller.IniciarSesion(username, password);

                if (empleado != null)
                {
                    MessageBox.Show($"Bienvenido, {empleado.Nombre} {empleado.Apellido}!",
                                  "Login exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form formAabrir;

                    // Asumiendo que IdCargo 1 es administrador
                    if (empleado.IdCargo == 1)
                    {
                        formAabrir = new Inicio(empleado);
                    }
                    else
                    {
                        formAabrir = new InicioEmpleados(empleado);
                    }

                    formAabrir.Show();
                    this.Hide();

                    formAabrir.FormClosed += (s, args) => this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);

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
    