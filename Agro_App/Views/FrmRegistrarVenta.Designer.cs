namespace Agro_App.Views
{
    partial class FrmRegistrarVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menutitulo = new MenuStrip();
            label9 = new Label();
            menu = new MenuStrip();
            menuusuarios = new FontAwesome.Sharp.IconMenuItem();
            menumantenedor = new FontAwesome.Sharp.IconMenuItem();
            categoriaToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            menuventas = new FontAwesome.Sharp.IconMenuItem();
            submenuregistrarventa = new FontAwesome.Sharp.IconMenuItem();
            submenuverdetalleventa = new FontAwesome.Sharp.IconMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            menucompras = new FontAwesome.Sharp.IconMenuItem();
            registrarCompraToolStripMenuItem = new ToolStripMenuItem();
            detalleCompraToolStripMenuItem = new ToolStripMenuItem();
            menuclientes = new FontAwesome.Sharp.IconMenuItem();
            menuproveedores = new FontAwesome.Sharp.IconMenuItem();
            menureportes = new FontAwesome.Sharp.IconMenuItem();
            reporteComprasToolStripMenuItem = new ToolStripMenuItem();
            reporteVentasToolStripMenuItem = new ToolStripMenuItem();
            menuacercade = new FontAwesome.Sharp.IconMenuItem();
            menucasa = new FontAwesome.Sharp.IconMenuItem();
            panel1 = new Panel();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            groupBox3 = new GroupBox();
            txtnumerodocumento = new TextBox();
            txtidcliente = new TextBox();
            lblfecha = new Label();
            txttipodocumento = new TextBox();
            label2 = new Label();
            label3 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            txtidempleado = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label10 = new Label();
            txttotal = new TextBox();
            menu.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // menutitulo
            // 
            menutitulo.AutoSize = false;
            menutitulo.BackColor = Color.ForestGreen;
            menutitulo.ImageScalingSize = new Size(20, 20);
            menutitulo.Location = new Point(0, 0);
            menutitulo.Name = "menutitulo";
            menutitulo.Padding = new Padding(6, 1, 0, 1);
            menutitulo.RightToLeft = RightToLeft.Yes;
            menutitulo.Size = new Size(1370, 32);
            menutitulo.TabIndex = 4;
            menutitulo.Text = "menuStrip2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.ForestGreen;
            label9.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Info;
            label9.Location = new Point(0, 5);
            label9.Name = "label9";
            label9.Size = new Size(256, 24);
            label9.TabIndex = 2;
            label9.Text = "Sistema de Agroservicio";
            // 
            // menu
            // 
            menu.BackColor = Color.White;
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { menuusuarios, menumantenedor, menuventas, menucompras, menuclientes, menuproveedores, menureportes, menuacercade, menucasa });
            menu.Location = new Point(0, 32);
            menu.Name = "menu";
            menu.Padding = new Padding(6, 1, 0, 1);
            menu.RightToLeft = RightToLeft.No;
            menu.Size = new Size(1370, 171);
            menu.TabIndex = 6;
            menu.Text = "menuStrip1";
            // 
            // menuusuarios
            // 
            menuusuarios.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            menuusuarios.IconColor = Color.Black;
            menuusuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuusuarios.IconSize = 150;
            menuusuarios.ImageScaling = ToolStripItemImageScaling.None;
            menuusuarios.Name = "menuusuarios";
            menuusuarios.Size = new Size(162, 169);
            menuusuarios.Text = "Usuarios";
            menuusuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            menuusuarios.Click += menuusuarios_Click;
            // 
            // menumantenedor
            // 
            menumantenedor.DropDownItems.AddRange(new ToolStripItem[] { categoriaToolStripMenuItem, productosToolStripMenuItem });
            menumantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            menumantenedor.IconColor = Color.Black;
            menumantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menumantenedor.IconSize = 150;
            menumantenedor.ImageScaling = ToolStripItemImageScaling.None;
            menumantenedor.Name = "menumantenedor";
            menumantenedor.Size = new Size(162, 169);
            menumantenedor.Text = "Mantenedor";
            menumantenedor.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(128, 22);
            categoriaToolStripMenuItem.Text = "Categoria";
            categoriaToolStripMenuItem.Click += categoriaToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(128, 22);
            productosToolStripMenuItem.Text = "Productos";
            // 
            // menuventas
            // 
            menuventas.DropDownItems.AddRange(new ToolStripItem[] { submenuregistrarventa, submenuverdetalleventa, ventasToolStripMenuItem });
            menuventas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            menuventas.IconColor = Color.Black;
            menuventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuventas.IconSize = 150;
            menuventas.ImageScaling = ToolStripItemImageScaling.None;
            menuventas.Name = "menuventas";
            menuventas.Size = new Size(162, 169);
            menuventas.Text = "Ventas";
            menuventas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenuregistrarventa
            // 
            submenuregistrarventa.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuregistrarventa.IconColor = Color.Black;
            submenuregistrarventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuregistrarventa.Name = "submenuregistrarventa";
            submenuregistrarventa.Size = new Size(142, 22);
            submenuregistrarventa.Text = "Registrar";
            submenuregistrarventa.Click += submenuregistrarventa_Click;
            // 
            // submenuverdetalleventa
            // 
            submenuverdetalleventa.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuverdetalleventa.IconColor = Color.Black;
            submenuverdetalleventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuverdetalleventa.Name = "submenuverdetalleventa";
            submenuverdetalleventa.Size = new Size(142, 22);
            submenuverdetalleventa.Text = "Detalle Venta";
            submenuverdetalleventa.Click += submenuverdetalleventa_Click;
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(142, 22);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // menucompras
            // 
            menucompras.DropDownItems.AddRange(new ToolStripItem[] { registrarCompraToolStripMenuItem, detalleCompraToolStripMenuItem });
            menucompras.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed;
            menucompras.IconColor = Color.Black;
            menucompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menucompras.IconSize = 150;
            menucompras.ImageScaling = ToolStripItemImageScaling.None;
            menucompras.Name = "menucompras";
            menucompras.Size = new Size(162, 169);
            menucompras.Text = "Compras";
            menucompras.TextImageRelation = TextImageRelation.ImageAboveText;
            menucompras.Click += menucompras_Click;
            // 
            // registrarCompraToolStripMenuItem
            // 
            registrarCompraToolStripMenuItem.Name = "registrarCompraToolStripMenuItem";
            registrarCompraToolStripMenuItem.Size = new Size(166, 22);
            registrarCompraToolStripMenuItem.Text = "Registrar Compra";
            registrarCompraToolStripMenuItem.Click += registrarCompraToolStripMenuItem_Click;
            // 
            // detalleCompraToolStripMenuItem
            // 
            detalleCompraToolStripMenuItem.Name = "detalleCompraToolStripMenuItem";
            detalleCompraToolStripMenuItem.Size = new Size(166, 22);
            detalleCompraToolStripMenuItem.Text = "Detalle Compra";
            // 
            // menuclientes
            // 
            menuclientes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            menuclientes.IconColor = Color.Black;
            menuclientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuclientes.IconSize = 150;
            menuclientes.ImageScaling = ToolStripItemImageScaling.None;
            menuclientes.Name = "menuclientes";
            menuclientes.Size = new Size(162, 169);
            menuclientes.Text = "Clientes";
            menuclientes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuproveedores
            // 
            menuproveedores.IconChar = FontAwesome.Sharp.IconChar.Vcard;
            menuproveedores.IconColor = Color.Black;
            menuproveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuproveedores.IconSize = 150;
            menuproveedores.ImageScaling = ToolStripItemImageScaling.None;
            menuproveedores.Name = "menuproveedores";
            menuproveedores.Size = new Size(162, 169);
            menuproveedores.Text = "Proveedores";
            menuproveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menureportes
            // 
            menureportes.DropDownItems.AddRange(new ToolStripItem[] { reporteComprasToolStripMenuItem, reporteVentasToolStripMenuItem });
            menureportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            menureportes.IconColor = Color.Black;
            menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menureportes.IconSize = 150;
            menureportes.ImageScaling = ToolStripItemImageScaling.None;
            menureportes.Name = "menureportes";
            menureportes.Size = new Size(162, 169);
            menureportes.Text = "Reportes";
            menureportes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // reporteComprasToolStripMenuItem
            // 
            reporteComprasToolStripMenuItem.Name = "reporteComprasToolStripMenuItem";
            reporteComprasToolStripMenuItem.Size = new Size(166, 22);
            reporteComprasToolStripMenuItem.Text = "Reporte Compras";
            reporteComprasToolStripMenuItem.Click += reporteComprasToolStripMenuItem_Click;
            // 
            // reporteVentasToolStripMenuItem
            // 
            reporteVentasToolStripMenuItem.Name = "reporteVentasToolStripMenuItem";
            reporteVentasToolStripMenuItem.Size = new Size(166, 22);
            reporteVentasToolStripMenuItem.Text = "Reporte Ventas";
            reporteVentasToolStripMenuItem.Click += reporteVentasToolStripMenuItem_Click;
            // 
            // menuacercade
            // 
            menuacercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            menuacercade.IconColor = Color.Black;
            menuacercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuacercade.IconSize = 150;
            menuacercade.ImageScaling = ToolStripItemImageScaling.None;
            menuacercade.Name = "menuacercade";
            menuacercade.Size = new Size(162, 169);
            menuacercade.Text = "Acerca de ";
            menuacercade.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menucasa
            // 
            menucasa.IconChar = FontAwesome.Sharp.IconChar.House;
            menucasa.IconColor = Color.Black;
            menucasa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menucasa.IconSize = 150;
            menucasa.ImageScaling = ToolStripItemImageScaling.None;
            menucasa.Name = "menucasa";
            menucasa.Size = new Size(162, 169);
            menucasa.Text = "Inicio";
            menucasa.TextImageRelation = TextImageRelation.ImageAboveText;
            menucasa.Click += menucasa_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 203);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1370, 546);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(groupBox3);
            panel2.Location = new Point(51, 17);
            panel2.Name = "panel2";
            panel2.Size = new Size(806, 465);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(164, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(580, 150);
            dataGridView1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 2);
            label1.Name = "label1";
            label1.Size = new Size(261, 37);
            label1.TabIndex = 19;
            label1.Text = "Registrar Venta";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txttotal);
            groupBox3.Controls.Add(txtnumerodocumento);
            groupBox3.Controls.Add(txtidcliente);
            groupBox3.Controls.Add(lblfecha);
            groupBox3.Controls.Add(txttipodocumento);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(iconButton1);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtidempleado);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(107, 59);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(637, 193);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            // 
            // txtnumerodocumento
            // 
            txtnumerodocumento.Location = new Point(222, 147);
            txtnumerodocumento.Name = "txtnumerodocumento";
            txtnumerodocumento.Size = new Size(133, 23);
            txtnumerodocumento.TabIndex = 22;
            // 
            // txtidcliente
            // 
            txtidcliente.Location = new Point(222, 67);
            txtidcliente.Name = "txtidcliente";
            txtidcliente.Size = new Size(133, 23);
            txtidcliente.TabIndex = 21;
            // 
            // lblfecha
            // 
            lblfecha.Location = new Point(477, 65);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new Size(100, 23);
            lblfecha.TabIndex = 20;
            // 
            // txttipodocumento
            // 
            txttipodocumento.Location = new Point(19, 147);
            txttipodocumento.Name = "txttipodocumento";
            txttipodocumento.Size = new Size(133, 23);
            txttipodocumento.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 121);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 17;
            label2.Text = "Numero Documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 129);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 16;
            label3.Text = "Tipo Documento:";
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconButton1.IconColor = Color.Green;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(545, 110);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(75, 61);
            iconButton1.TabIndex = 15;
            iconButton1.Text = "Agregar";
            iconButton1.TextAlign = ContentAlignment.BottomCenter;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(472, 41);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 6;
            label8.Text = "Fecha:";
            // 
            // txtidempleado
            // 
            txtidempleado.Location = new Point(19, 67);
            txtidempleado.Name = "txtidempleado";
            txtidempleado.Size = new Size(133, 23);
            txtidempleado.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(235, 41);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 1;
            label6.Text = "Id Cliente:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 41);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 0;
            label7.Text = "Id Empleado:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(435, 97);
            label10.Name = "label10";
            label10.Size = new Size(35, 15);
            label10.TabIndex = 40;
            label10.Text = "Total:";
            // 
            // txttotal
            // 
            txttotal.Location = new Point(420, 150);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(100, 23);
            txttotal.TabIndex = 39;
            // 
            // FrmRegistrarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel1);
            Controls.Add(menu);
            Controls.Add(label9);
            Controls.Add(menutitulo);
            Name = "FrmRegistrarVenta";
            Text = "FrmRegistrarVenta";
            WindowState = FormWindowState.Maximized;
            Load += FrmRegistrarVenta_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menutitulo;
        private Label label9;
        private MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menuusuarios;
        private FontAwesome.Sharp.IconMenuItem menumantenedor;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem submenuregistrarventa;
        private FontAwesome.Sharp.IconMenuItem submenuverdetalleventa;
        private FontAwesome.Sharp.IconMenuItem menucompras;
        private FontAwesome.Sharp.IconMenuItem menuclientes;
        private FontAwesome.Sharp.IconMenuItem menuproveedores;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private FontAwesome.Sharp.IconMenuItem menuacercade;
        private FontAwesome.Sharp.IconMenuItem menucasa;
        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private TextBox textBox9;
        private Label label12;
        private GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox textBox7;
        private TextBox textBox6;
        private NumericUpDown numericUpDown1;
        private Label label11;
        private Label label8;
        private TextBox txtidempleado;
        private Label label6;
        private Label label7;
        private GroupBox groupBox2;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private TextBox textBox10;
        private TextBox textBox5;
        private Label label14;
        private Label label13;
        private Label label1;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem registrarCompraToolStripMenuItem;
        private ToolStripMenuItem detalleCompraToolStripMenuItem;
        private ToolStripMenuItem reporteComprasToolStripMenuItem;
        private ToolStripMenuItem reporteVentasToolStripMenuItem;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox txttipodocumento;
        private Label label2;
        private Label label3;
        private Label lblfecha;
        private TextBox txtnumerodocumento;
        private TextBox txtidcliente;
        private Label label10;
        private TextBox txttotal;
    }
}