namespace Agro_App.Views
{
    partial class FrmProductos
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
            label1 = new Label();
            menu = new MenuStrip();
            menuusuarios = new FontAwesome.Sharp.IconMenuItem();
            menumantenedor = new FontAwesome.Sharp.IconMenuItem();
            categoriaToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            menuventas = new FontAwesome.Sharp.IconMenuItem();
            submenuregistrar = new FontAwesome.Sharp.IconMenuItem();
            submenuverdetalleventa = new FontAwesome.Sharp.IconMenuItem();
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            dataVisualizacionProductos = new DataGridView();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            txtStock = new TextBox();
            label9 = new Label();
            comboCategoria = new ComboBox();
            btnEditarProducto = new Button();
            btnAgregarProducto = new Button();
            dataMantenedorProductos = new DataGridView();
            txtDescripcionProducto = new TextBox();
            txtUnidadMedida = new TextBox();
            txtPrecioVenta = new TextBox();
            txtPrecioCompra = new TextBox();
            txtNombreProducto = new TextBox();
            txtCodigoProducto = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabPage3 = new TabPage();
            groupBox3 = new GroupBox();
            dataGestioActividad = new DataGridView();
            btnDesactivarProducto = new Button();
            btnActivarProducto = new Button();
            menu.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataVisualizacionProductos).BeginInit();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataMantenedorProductos).BeginInit();
            tabPage3.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGestioActividad).BeginInit();
            SuspendLayout();
            // 
            // menutitulo
            // 
            menutitulo.AutoSize = false;
            menutitulo.BackColor = Color.ForestGreen;
            menutitulo.ImageScalingSize = new Size(20, 20);
            menutitulo.Location = new Point(0, 0);
            menutitulo.Name = "menutitulo";
            menutitulo.Padding = new Padding(9, 1, 0, 1);
            menutitulo.RightToLeft = RightToLeft.Yes;
            menutitulo.Size = new Size(2356, 194);
            menutitulo.TabIndex = 2;
            menutitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.ForestGreen;
            label1.Font = new Font("Arial Rounded MT Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 75);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(946, 60);
            label1.TabIndex = 3;
            label1.Text = "Sistema de Agroservicio - Productos";
            // 
            // menu
            // 
            menu.BackColor = Color.White;
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { menuusuarios, menumantenedor, menuventas, menucompras, menuclientes, menuproveedores, menureportes, menuacercade, menucasa });
            menu.Location = new Point(0, 194);
            menu.Name = "menu";
            menu.Padding = new Padding(9, 1, 0, 1);
            menu.RightToLeft = RightToLeft.No;
            menu.Size = new Size(2356, 181);
            menu.TabIndex = 5;
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
            menuusuarios.Size = new Size(166, 179);
            menuusuarios.Text = "Usuarios";
            menuusuarios.TextImageRelation = TextImageRelation.ImageAboveText;
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
            menumantenedor.Size = new Size(166, 179);
            menumantenedor.Text = "Mantenedor";
            menumantenedor.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(195, 34);
            categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(195, 34);
            productosToolStripMenuItem.Text = "Productos";
            // 
            // menuventas
            // 
            menuventas.DropDownItems.AddRange(new ToolStripItem[] { submenuregistrar, submenuverdetalleventa });
            menuventas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            menuventas.IconColor = Color.Black;
            menuventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuventas.IconSize = 150;
            menuventas.ImageScaling = ToolStripItemImageScaling.None;
            menuventas.Name = "menuventas";
            menuventas.Size = new Size(166, 179);
            menuventas.Text = "Ventas";
            menuventas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenuregistrar
            // 
            submenuregistrar.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuregistrar.IconColor = Color.Black;
            submenuregistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuregistrar.Name = "submenuregistrar";
            submenuregistrar.Size = new Size(217, 34);
            submenuregistrar.Text = "Registrar";
            // 
            // submenuverdetalleventa
            // 
            submenuverdetalleventa.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuverdetalleventa.IconColor = Color.Black;
            submenuverdetalleventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuverdetalleventa.Name = "submenuverdetalleventa";
            submenuverdetalleventa.Size = new Size(217, 34);
            submenuverdetalleventa.Text = "Detalle Venta";
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
            menucompras.Size = new Size(166, 179);
            menucompras.Text = "Compras";
            menucompras.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // registrarCompraToolStripMenuItem
            // 
            registrarCompraToolStripMenuItem.Name = "registrarCompraToolStripMenuItem";
            registrarCompraToolStripMenuItem.Size = new Size(252, 34);
            registrarCompraToolStripMenuItem.Text = "Registrar Compra";
            // 
            // detalleCompraToolStripMenuItem
            // 
            detalleCompraToolStripMenuItem.Name = "detalleCompraToolStripMenuItem";
            detalleCompraToolStripMenuItem.Size = new Size(252, 34);
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
            menuclientes.Size = new Size(166, 179);
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
            menuproveedores.Size = new Size(166, 179);
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
            menureportes.Size = new Size(166, 179);
            menureportes.Text = "Reportes";
            menureportes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // reporteComprasToolStripMenuItem
            // 
            reporteComprasToolStripMenuItem.Name = "reporteComprasToolStripMenuItem";
            reporteComprasToolStripMenuItem.Size = new Size(253, 34);
            reporteComprasToolStripMenuItem.Text = "Reporte Compras";
            // 
            // reporteVentasToolStripMenuItem
            // 
            reporteVentasToolStripMenuItem.Name = "reporteVentasToolStripMenuItem";
            reporteVentasToolStripMenuItem.Size = new Size(253, 34);
            reporteVentasToolStripMenuItem.Text = "Reporte Ventas";
            // 
            // menuacercade
            // 
            menuacercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            menuacercade.IconColor = Color.Black;
            menuacercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuacercade.IconSize = 150;
            menuacercade.ImageScaling = ToolStripItemImageScaling.None;
            menuacercade.Name = "menuacercade";
            menuacercade.Size = new Size(166, 179);
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
            menucasa.Size = new Size(166, 179);
            menucasa.Text = "Inicio";
            menucasa.TextImageRelation = TextImageRelation.ImageAboveText;
            menucasa.Click += menucasa_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(tabControl1);
            panel1.Location = new Point(56, 483);
            panel1.Name = "panel1";
            panel1.Size = new Size(2212, 795);
            panel1.TabIndex = 6;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(28, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(2114, 718);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(2106, 680);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Visualizacio";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataVisualizacionProductos);
            groupBox1.Location = new Point(60, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1979, 596);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Categorias Actuales";
            // 
            // dataVisualizacionProductos
            // 
            dataVisualizacionProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataVisualizacionProductos.Location = new Point(51, 51);
            dataVisualizacionProductos.Name = "dataVisualizacionProductos";
            dataVisualizacionProductos.RowHeadersWidth = 62;
            dataVisualizacionProductos.Size = new Size(1872, 502);
            dataVisualizacionProductos.TabIndex = 0;
            dataVisualizacionProductos.CellContentClick += dataVisualizacionProductos_CellContentClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(2106, 680);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mantenedor";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtStock);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(comboCategoria);
            groupBox2.Controls.Add(btnEditarProducto);
            groupBox2.Controls.Add(btnAgregarProducto);
            groupBox2.Controls.Add(dataMantenedorProductos);
            groupBox2.Controls.Add(txtDescripcionProducto);
            groupBox2.Controls.Add(txtUnidadMedida);
            groupBox2.Controls.Add(txtPrecioVenta);
            groupBox2.Controls.Add(txtPrecioCompra);
            groupBox2.Controls.Add(txtNombreProducto);
            groupBox2.Controls.Add(txtCodigoProducto);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(2086, 668);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gestion de Productos";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(251, 432);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(150, 31);
            txtStock.TabIndex = 19;
            txtStock.TextChanged += txtStock_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(51, 432);
            label9.Name = "label9";
            label9.Size = new Size(59, 25);
            label9.TabIndex = 18;
            label9.Text = "Stock:";
            // 
            // comboCategoria
            // 
            comboCategoria.FormattingEnabled = true;
            comboCategoria.Location = new Point(251, 380);
            comboCategoria.Name = "comboCategoria";
            comboCategoria.Size = new Size(175, 33);
            comboCategoria.TabIndex = 17;
            comboCategoria.SelectedIndexChanged += comboCategoria_SelectedIndexChanged;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.Location = new Point(744, 595);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(142, 49);
            btnEditarProducto.TabIndex = 16;
            btnEditarProducto.Text = "Editar";
            btnEditarProducto.UseVisualStyleBackColor = true;
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(604, 594);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(134, 50);
            btnAgregarProducto.TabIndex = 15;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // dataMantenedorProductos
            // 
            dataMantenedorProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataMantenedorProductos.Location = new Point(604, 90);
            dataMantenedorProductos.Name = "dataMantenedorProductos";
            dataMantenedorProductos.RowHeadersWidth = 62;
            dataMantenedorProductos.Size = new Size(1416, 499);
            dataMantenedorProductos.TabIndex = 14;
            dataMantenedorProductos.CellContentClick += dataMantenedorProductos_CellContentClick;
            // 
            // txtDescripcionProducto
            // 
            txtDescripcionProducto.Location = new Point(251, 494);
            txtDescripcionProducto.Multiline = true;
            txtDescripcionProducto.Name = "txtDescripcionProducto";
            txtDescripcionProducto.Size = new Size(282, 150);
            txtDescripcionProducto.TabIndex = 13;
            txtDescripcionProducto.TextChanged += txtDescripcionProducto_TextChanged;
            // 
            // txtUnidadMedida
            // 
            txtUnidadMedida.Location = new Point(251, 315);
            txtUnidadMedida.Name = "txtUnidadMedida";
            txtUnidadMedida.Size = new Size(150, 31);
            txtUnidadMedida.TabIndex = 11;
            txtUnidadMedida.TextChanged += txtUnidadMedida_TextChanged;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(251, 254);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(150, 31);
            txtPrecioVenta.TabIndex = 10;
            txtPrecioVenta.TextChanged += txtPrecioVenta_TextChanged;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(251, 192);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(150, 31);
            txtPrecioCompra.TabIndex = 9;
            txtPrecioCompra.TextChanged += txtPrecioCompra_TextChanged;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(251, 132);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(150, 31);
            txtNombreProducto.TabIndex = 8;
            txtNombreProducto.TextChanged += txtNombreProducto_TextChanged;
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Location = new Point(251, 71);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(150, 31);
            txtCodigoProducto.TabIndex = 7;
            txtCodigoProducto.TextChanged += txtCodigoProducto_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(51, 254);
            label8.Name = "label8";
            label8.Size = new Size(138, 25);
            label8.TabIndex = 6;
            label8.Text = "Precio de Venta:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 192);
            label7.Name = "label7";
            label7.Size = new Size(158, 25);
            label7.TabIndex = 5;
            label7.Text = "Precio de Compra:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 315);
            label6.Name = "label6";
            label6.Size = new Size(163, 25);
            label6.TabIndex = 4;
            label6.Text = "Unidad de Medida:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 380);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 3;
            label5.Text = "Categoria:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 494);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 2;
            label4.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 132);
            label3.Name = "label3";
            label3.Size = new Size(185, 25);
            label3.TabIndex = 1;
            label3.Text = "Nombre de Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 71);
            label2.Name = "label2";
            label2.Size = new Size(178, 25);
            label2.TabIndex = 0;
            label2.Text = "Codigo de Producto:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(2106, 680);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Gestion de Actividad";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGestioActividad);
            groupBox3.Controls.Add(btnDesactivarProducto);
            groupBox3.Controls.Add(btnActivarProducto);
            groupBox3.Location = new Point(6, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(2097, 658);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Gestion para Activar y Desactivar categorias";
            // 
            // dataGestioActividad
            // 
            dataGestioActividad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGestioActividad.Location = new Point(230, 74);
            dataGestioActividad.Name = "dataGestioActividad";
            dataGestioActividad.RowHeadersWidth = 62;
            dataGestioActividad.Size = new Size(1782, 496);
            dataGestioActividad.TabIndex = 2;
            dataGestioActividad.CellContentClick += dataGestioActividad_CellContentClick;
            // 
            // btnDesactivarProducto
            // 
            btnDesactivarProducto.Location = new Point(31, 311);
            btnDesactivarProducto.Name = "btnDesactivarProducto";
            btnDesactivarProducto.Size = new Size(159, 87);
            btnDesactivarProducto.TabIndex = 1;
            btnDesactivarProducto.Text = "Desactivar";
            btnDesactivarProducto.UseVisualStyleBackColor = true;
            btnDesactivarProducto.Click += btnDesactivarProducto_Click;
            // 
            // btnActivarProducto
            // 
            btnActivarProducto.Location = new Point(31, 127);
            btnActivarProducto.Name = "btnActivarProducto";
            btnActivarProducto.Size = new Size(159, 87);
            btnActivarProducto.TabIndex = 0;
            btnActivarProducto.Text = "Activar";
            btnActivarProducto.UseVisualStyleBackColor = true;
            btnActivarProducto.Click += btnActivarProducto_Click;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(2356, 1410);
            Controls.Add(panel1);
            Controls.Add(menu);
            Controls.Add(label1);
            Controls.Add(menutitulo);
            Name = "FrmProductos";
            Text = "FrmProductos";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataVisualizacionProductos).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataMantenedorProductos).EndInit();
            tabPage3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGestioActividad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menutitulo;
        private Label label1;
        private MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menuusuarios;
        private FontAwesome.Sharp.IconMenuItem menumantenedor;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem submenuregistrar;
        private FontAwesome.Sharp.IconMenuItem submenuverdetalleventa;
        private FontAwesome.Sharp.IconMenuItem menucompras;
        private ToolStripMenuItem registrarCompraToolStripMenuItem;
        private ToolStripMenuItem detalleCompraToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem menuclientes;
        private FontAwesome.Sharp.IconMenuItem menuproveedores;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private ToolStripMenuItem reporteComprasToolStripMenuItem;
        private ToolStripMenuItem reporteVentasToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem menuacercade;
        private FontAwesome.Sharp.IconMenuItem menucasa;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private DataGridView dataVisualizacionProductos;
        private Button btnEditarProducto;
        private Button btnAgregarProducto;
        private DataGridView dataMantenedorProductos;
        private TextBox txtDescripcionProducto;
        private TextBox txtUnidadMedida;
        private TextBox txtPrecioVenta;
        private TextBox txtPrecioCompra;
        private TextBox txtNombreProducto;
        private TextBox txtCodigoProducto;
        private GroupBox groupBox3;
        private DataGridView dataGestioActividad;
        private Button btnDesactivarProducto;
        private Button btnActivarProducto;
        private ComboBox comboCategoria;
        private TextBox txtStock;
        private Label label9;
    }
}