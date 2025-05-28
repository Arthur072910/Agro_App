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
            String username = txtusuario.Text.Trim();
            String password = txtcontraseña.Text.Trim();

            ConexionDB conexion = new ConexionDB();
            LoginControllers controller = new LoginControllers(conexion.GetConnection().ConnectionString);

            Empleados empleado = controller.IniciarSesion(username, password);

            if (empleado != null)
            {
                MessageBox.Show("Bienvenido, " + empleado.Nombre + "!");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}
