using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // List<Empleados> Test = new EmpleadosControllers().Listar();

            // Empleados oempleados = new EmpleadosControllers().Listar().Where(u => u.Documento == txtusuario.Text && u.Clave == txtcontraseña.Text).FirstOrDefault();

            Inicio inicio = new Inicio();
            inicio.FormClosed += (s, args) => this.Show(); // Cuando se cierre Inicio, volver a mostrar Login
            inicio.Show();
            this.Hide();

        }

        private void  frm_clossing(object sender, FormClosingEventArgs e)
        {
            txtusuario.Text = "";
            txtcontraseña.Text = "";

            this.Show();
        }
    }
}
