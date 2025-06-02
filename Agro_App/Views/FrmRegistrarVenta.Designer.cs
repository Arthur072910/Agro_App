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
            label1 = new Label();
            textBox10 = new TextBox();
            textBox5 = new TextBox();
            label14 = new Label();
            label13 = new Label();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            textBox9 = new TextBox();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            menu.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            menutitulo.Size = new Size(1199, 32);
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
            menu.Size = new Size(1199, 171);
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
            reporteComprasToolStripMenuItem.Size = new Size(180, 22);
            reporteComprasToolStripMenuItem.Text = "Reporte Compras";
            reporteComprasToolStripMenuItem.Click += reporteComprasToolStripMenuItem_Click;
            // 
            // reporteVentasToolStripMenuItem
            // 
            reporteVentasToolStripMenuItem.Name = "reporteVentasToolStripMenuItem";
            reporteVentasToolStripMenuItem.Size = new Size(180, 22);
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
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 203);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1199, 546);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox10);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(textBox9);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(190, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(910, 465);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(261, 37);
            label1.TabIndex = 19;
            label1.Text = "Registrar Venta";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(782, 383);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(98, 23);
            textBox10.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(782, 328);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(98, 23);
            textBox5.TabIndex = 17;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(782, 365);
            label14.Name = "label14";
            label14.Size = new Size(77, 15);
            label14.TabIndex = 16;
            label14.Text = "Total a pagar:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(782, 310);
            label13.Name = "label13";
            label13.Size = new Size(77, 15);
            label13.TabIndex = 15;
            label13.Text = "Total a pagar:";
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Wpforms;
            iconButton2.IconColor = Color.Green;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(782, 412);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(98, 48);
            iconButton2.TabIndex = 14;
            iconButton2.Text = "Crear Venta";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(782, 284);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(98, 23);
            textBox9.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(782, 266);
            label12.Name = "label12";
            label12.Size = new Size(77, 15);
            label12.TabIndex = 12;
            label12.Text = "Total a pagar:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(244, 266);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(442, 172);
            dataGridView1.TabIndex = 11;
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
            // groupBox3
            // 
            groupBox3.Controls.Add(iconButton4);
            groupBox3.Controls.Add(iconButton1);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(numericUpDown1);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(29, 146);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(851, 103);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Información Producto";
            // 
            // iconButton4
            // 
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 20;
            iconButton4.Location = new Point(164, 68);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(33, 23);
            iconButton4.TabIndex = 16;
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconButton1.IconColor = Color.Green;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(770, 31);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(75, 61);
            iconButton1.TabIndex = 15;
            iconButton1.Text = "Agregar";
            iconButton1.TextAlign = ContentAlignment.BottomCenter;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(512, 69);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(88, 23);
            textBox8.TabIndex = 13;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(393, 69);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(94, 23);
            textBox7.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(215, 68);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(161, 23);
            textBox6.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(635, 68);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(635, 41);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 8;
            label11.Text = "Cantidad:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(512, 41);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 7;
            label10.Text = "Stock:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(393, 41);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 6;
            label8.Text = "Precio:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(19, 67);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(133, 23);
            textBox4.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(215, 41);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 1;
            label6.Text = "Producto: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 41);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 0;
            label7.Text = "Cod Producto:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(iconButton3);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(498, 40);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(382, 90);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información Cliente";
            // 
            // iconButton3
            // 
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 20;
            iconButton3.Location = new Point(125, 48);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(36, 26);
            iconButton3.TabIndex = 5;
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(179, 48);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(189, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(19, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(176, 19);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 1;
            label4.Text = "Nombre Completo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 19);
            label5.Name = "label5";
            label5.Size = new Size(123, 15);
            label5.TabIndex = 0;
            label5.Text = "Número Documento: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(29, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(405, 90);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información Venta";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(200, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 23);
            comboBox1.TabIndex = 2;
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
            // FrmRegistrarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 749);
            Controls.Add(panel1);
            Controls.Add(menu);
            Controls.Add(label9);
            Controls.Add(menutitulo);
            Name = "FrmRegistrarVenta";
            Text = "FrmRegistrarVenta";
            WindowState = FormWindowState.Maximized;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private NumericUpDown numericUpDown1;
        private Label label11;
        private Label label10;
        private Label label8;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
        private GroupBox groupBox2;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
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
    }
}