using Agro_App.Model;
using Agro_App.Views;
using FontAwesome.Sharp;

namespace Agro_App
{
    public partial class Inicio : Form
    {
        public Inicio(Model.Empleados empleado)
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

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria categoriaForm = new FrmCategoria();
            categoriaForm.Show();
            this.Hide();
        }

        private void menucompras_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos n3 = new FrmProductos();
            n3.Show();
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

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login(); // Instancia Login
            loginForm.Show(); // Muestra Login
            this.Hide(); // Oculta Inicio en lugar de cerrarlo
        }

        private void menuclientes_Click(object sender, EventArgs e)
        {

        }

        private void menuproveedores_Click(object sender, EventArgs e)
        {
            FrmProveedores proveedoresForm = new FrmProveedores();
            proveedoresForm.Show();
            this.Hide();
        }
    }
}
