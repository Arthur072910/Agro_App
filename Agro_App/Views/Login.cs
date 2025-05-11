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
            Inicio form = new Inicio();
            form.Show();
            this.Hide();


            form.FormClosing += frm_clossing;

        }

        private void  frm_clossing(object sender, FormClosingEventArgs e)
        {
            txtusuario.Text = "";
            txtcontraseña.Text = "";

            this.Show();
        }
    }
}
