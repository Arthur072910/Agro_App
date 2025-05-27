using Agro_App.Views;
using FontAwesome.Sharp;

namespace Agro_App
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuusuarios_Click(object sender, EventArgs e)
        {
            FrmEmpleados empleadosForm = new FrmEmpleados();
            empleadosForm.Show(); // Muestra el formulario frmEmpleados

            this.Hide(); // Oculta el formulario actual (Inicio), si no quieres que siga visible
        }

        private void menumantenedor_Click(object sender, EventArgs e)
        {
            ConexionDB connection = new ConexionDB();
            var conn = connection.GetConnection();

            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Conexión exitosa a la base de datos.");
            }
            else
            {
                MessageBox.Show("Error al conectar a la base de datos.");
            }
        }

        private void menuventas_Click(object sender, EventArgs e)
        {



        }

        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            FrmDetalleVentas ventasForm = new FrmDetalleVentas();
            ventasForm.Show();
            this.Hide();


        }

        private void submenuregistrar_Click(object sender, EventArgs e)
        {
            FrmRegistrarVenta ventasForm = new FrmRegistrarVenta();
            ventasForm.Show();
            this.Hide();
        }
    }
}
