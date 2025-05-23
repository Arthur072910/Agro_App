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
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void menucasa_Click(object sender, EventArgs e)
        {
        
            Inicio inicioForm = new Inicio();
            inicioForm.Show();
            this.Close();


         }
    }
}
