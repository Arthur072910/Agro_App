namespace Agro_App.Views
{
    partial class FrmDetalleCompra
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
            menucompras = new FontAwesome.Sharp.IconMenuItem();
            registrarCompraToolStripMenuItem = new ToolStripMenuItem();
            detalleCompraToolStripMenuItem = new ToolStripMenuItem();
            menuclientes = new FontAwesome.Sharp.IconMenuItem();
            menuproveedores = new FontAwesome.Sharp.IconMenuItem();
            menureportes = new FontAwesome.Sharp.IconMenuItem();
            menuacercade = new FontAwesome.Sharp.IconMenuItem();
            menucasa = new FontAwesome.Sharp.IconMenuItem();
            panel1 = new Panel();
            panel2 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            textBox9 = new TextBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            txtnumerodocumento = new TextBox();
            txtnombreproveedor = new TextBox();
            txtdocproveedor = new TextBox();
            label5 = new Label();
            label13 = new Label();
            groupBox1 = new GroupBox();
            txtusuario = new TextBox();
            txttipodocumento = new TextBox();
            label4 = new Label();
            txtfecha = new TextBox();
            label3 = new Label();
            label2 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            label12 = new Label();
            label1 = new Label();
            menu.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
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
            menutitulo.TabIndex = 11;
            menutitulo.Text = "menuStrip2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.ForestGreen;
            label9.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(0, 5);
            label9.Name = "label9";
            label9.Size = new Size(256, 24);
            label9.TabIndex = 13;
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
            menu.TabIndex = 14;
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
            menuventas.DropDownItems.AddRange(new ToolStripItem[] { submenuregistrarventa, submenuverdetalleventa });
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
            // 
            // registrarCompraToolStripMenuItem
            // 
            registrarCompraToolStripMenuItem.Name = "registrarCompraToolStripMenuItem";
            registrarCompraToolStripMenuItem.Size = new Size(180, 22);
            registrarCompraToolStripMenuItem.Text = "Registrar Compra";
            registrarCompraToolStripMenuItem.Click += registrarCompraToolStripMenuItem_Click;
            // 
            // detalleCompraToolStripMenuItem
            // 
            detalleCompraToolStripMenuItem.Name = "detalleCompraToolStripMenuItem";
            detalleCompraToolStripMenuItem.Size = new Size(180, 22);
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
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(textBox9);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(txtbusqueda);
            panel2.Controls.Add(iconButton4);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(187, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(809, 504);
            panel2.TabIndex = 1;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Wpforms;
            iconButton2.IconColor = Color.Green;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 20;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(650, 463);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(108, 28);
            iconButton2.TabIndex = 33;
            iconButton2.Text = "Descargar PDF";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(136, 467);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(98, 23);
            textBox9.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 472);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 32;
            label6.Text = "Monto Total:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(37, 277);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(442, 172);
            dataGridView1.TabIndex = 30;
            // 
            // Column1
            // 
            Column1.HeaderText = "Producto";
            Column1.Name = "Column1";
            // 
            // Column3
            // 
            Column3.HeaderText = "Precio Compra";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Cantidad";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Subtotal";
            Column5.Name = "Column5";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtnumerodocumento);
            groupBox2.Controls.Add(txtnombreproveedor);
            groupBox2.Controls.Add(txtdocproveedor);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label13);
            groupBox2.Location = new Point(37, 181);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(699, 90);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información Poveedor";
            // 
            // txtnumerodocumento
            // 
            txtnumerodocumento.Location = new Point(508, 48);
            txtnumerodocumento.Name = "txtnumerodocumento";
            txtnumerodocumento.Size = new Size(138, 23);
            txtnumerodocumento.TabIndex = 27;
            // 
            // txtnombreproveedor
            // 
            txtnombreproveedor.Location = new Point(179, 48);
            txtnombreproveedor.Name = "txtnombreproveedor";
            txtnombreproveedor.Size = new Size(189, 23);
            txtnombreproveedor.TabIndex = 4;
            // 
            // txtdocproveedor
            // 
            txtdocproveedor.Location = new Point(19, 49);
            txtdocproveedor.Name = "txtdocproveedor";
            txtdocproveedor.Size = new Size(100, 23);
            txtdocproveedor.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(176, 19);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 1;
            label5.Text = "Razón Social:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(19, 19);
            label13.Name = "label13";
            label13.Size = new Size(123, 15);
            label13.TabIndex = 0;
            label13.Text = "Número Documento: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtusuario);
            groupBox1.Controls.Add(txttipodocumento);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtfecha);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(37, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(699, 90);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información Compra";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(393, 49);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(124, 23);
            txtusuario.TabIndex = 6;
            txtusuario.TextChanged += txtusuario_TextChanged;
            // 
            // txttipodocumento
            // 
            txttipodocumento.Location = new Point(200, 49);
            txttipodocumento.Name = "txttipodocumento";
            txttipodocumento.Size = new Size(145, 23);
            txttipodocumento.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(430, 19);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 4;
            label4.Text = "Usuario:";
            // 
            // txtfecha
            // 
            txtfecha.Location = new Point(31, 49);
            txtfecha.Name = "txtfecha";
            txtfecha.Size = new Size(121, 23);
            txtfecha.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 19);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 1;
            label3.Text = "Tipo Documento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 19);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 0;
            label2.Text = "Fecha: ";
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(666, 30);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(70, 23);
            iconButton1.TabIndex = 27;
            iconButton1.Text = "Limpiar";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(416, 31);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(138, 23);
            txtbusqueda.TabIndex = 26;
            // 
            // iconButton4
            // 
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 20;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(577, 30);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(70, 23);
            iconButton4.TabIndex = 25;
            iconButton4.Text = "Buscar ";
            iconButton4.TextAlign = ContentAlignment.MiddleRight;
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(318, 34);
            label12.Name = "label12";
            label12.Size = new Size(92, 15);
            label12.TabIndex = 24;
            label12.Text = "No.Documento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(259, 37);
            label1.TabIndex = 19;
            label1.Text = "Detalle Compra";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmDetalleCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel1);
            Controls.Add(menu);
            Controls.Add(label9);
            Controls.Add(menutitulo);
            Name = "FrmDetalleCompra";
            Text = "FrmDetalleCompra";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private ToolStripMenuItem registrarCompraToolStripMenuItem;
        private ToolStripMenuItem detalleCompraToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem menuclientes;
        private FontAwesome.Sharp.IconMenuItem menuproveedores;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private FontAwesome.Sharp.IconMenuItem menuacercade;
        private FontAwesome.Sharp.IconMenuItem menucasa;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox txtbusqueda;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Label label12;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtfecha;
        private Label label3;
        private Label label2;
        private TextBox txtusuario;
        private TextBox txttipodocumento;
        private GroupBox groupBox2;
        private TextBox txtnombreproveedor;
        private TextBox txtdocproveedor;
        private Label label5;
        private Label label13;
        private TextBox txtnumerodocumento;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TextBox textBox9;
        private Label label6;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}