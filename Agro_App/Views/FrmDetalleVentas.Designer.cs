namespace Agro_App.Views
{
    partial class FrmDetalleVentas
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
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
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            lblfecha = new Label();
            label7 = new Label();
            btnRegistrarDetalle = new FontAwesome.Sharp.IconButton();
            txtcantidad = new TextBox();
            txtsubtotal = new TextBox();
            label4 = new Label();
            txtpreciounitario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtidproducto = new TextBox();
            txtidventa = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            menu.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
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
            menutitulo.TabIndex = 3;
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
            menu.TabIndex = 4;
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
            submenuregistrarventa.Click += iconMenuItem1_Click;
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
            detalleCompraToolStripMenuItem.Click += detalleCompraToolStripMenuItem_Click;
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
            panel1.Size = new Size(1199, 546);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(141, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(910, 493);
            panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(93, 255);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(745, 184);
            dataGridView1.TabIndex = 25;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblfecha);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btnRegistrarDetalle);
            groupBox2.Controls.Add(txtcantidad);
            groupBox2.Controls.Add(txtsubtotal);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtpreciounitario);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtidproducto);
            groupBox2.Controls.Add(txtidventa);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(3, 40);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(904, 209);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información Cliente";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lblfecha
            // 
            lblfecha.Location = new Point(584, 122);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new Size(129, 23);
            lblfecha.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(584, 92);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 37;
            label7.Text = "Sub Total:";
            // 
            // btnRegistrarDetalle
            // 
            btnRegistrarDetalle.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnRegistrarDetalle.IconColor = Color.Green;
            btnRegistrarDetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrarDetalle.Location = new Point(804, 65);
            btnRegistrarDetalle.Name = "btnRegistrarDetalle";
            btnRegistrarDetalle.Size = new Size(75, 61);
            btnRegistrarDetalle.TabIndex = 36;
            btnRegistrarDetalle.Text = "Agregar";
            btnRegistrarDetalle.TextAlign = ContentAlignment.BottomCenter;
            btnRegistrarDetalle.UseVisualStyleBackColor = true;
            btnRegistrarDetalle.Click += btnRegistrarDetalle_Click;
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(584, 49);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(186, 23);
            txtcantidad.TabIndex = 12;
            // 
            // txtsubtotal
            // 
            txtsubtotal.Location = new Point(326, 122);
            txtsubtotal.Name = "txtsubtotal";
            txtsubtotal.Size = new Size(199, 23);
            txtsubtotal.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(584, 19);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 10;
            label4.Text = "Cantidad:";
            // 
            // txtpreciounitario
            // 
            txtpreciounitario.Location = new Point(61, 122);
            txtpreciounitario.Name = "txtpreciounitario";
            txtpreciounitario.Size = new Size(188, 23);
            txtpreciounitario.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(326, 92);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 8;
            label3.Text = "Sub Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 92);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 7;
            label2.Text = "Precio Unitario:";
            // 
            // txtidproducto
            // 
            txtidproducto.Location = new Point(326, 49);
            txtidproducto.Name = "txtidproducto";
            txtidproducto.Size = new Size(199, 23);
            txtidproducto.TabIndex = 4;
            // 
            // txtidventa
            // 
            txtidventa.Location = new Point(61, 49);
            txtidventa.Name = "txtidventa";
            txtidventa.Size = new Size(188, 23);
            txtidventa.TabIndex = 3;
            txtidventa.TextChanged += textBox6_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(326, 19);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 1;
            label5.Text = "Id Producto:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 19);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 0;
            label6.Text = "Id Venta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(225, 37);
            label1.TabIndex = 19;
            label1.Text = "Detalle Venta";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmDetalleVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 749);
            Controls.Add(panel1);
            Controls.Add(menu);
            Controls.Add(label9);
            Controls.Add(menutitulo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmDetalleVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVentas";
            WindowState = FormWindowState.Maximized;
            Load += FrmDetalleVentas_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private MenuStrip menutitulo;
        private Label label9;
        private MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menuusuarios;
        private FontAwesome.Sharp.IconMenuItem menumantenedor;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem menucompras;
        private FontAwesome.Sharp.IconMenuItem menuclientes;
        private FontAwesome.Sharp.IconMenuItem menuproveedores;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private FontAwesome.Sharp.IconMenuItem menuacercade;
        private FontAwesome.Sharp.IconMenuItem menucasa;
        private Panel panel1;
        private FontAwesome.Sharp.IconMenuItem submenuregistrarventa;
        private FontAwesome.Sharp.IconMenuItem submenuverdetalleventa;
        private Panel panel2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtidproducto;
        private TextBox txtidventa;
        private Label label5;
        private Label label6;
        private ToolStripMenuItem registrarCompraToolStripMenuItem;
        private ToolStripMenuItem detalleCompraToolStripMenuItem;
        private DataGridView dataGridView1;
        private TextBox txtcantidad;
        private TextBox txtsubtotal;
        private Label label4;
        private TextBox txtpreciounitario;
        private Label label3;
        private Label label2;
        private Label lblfecha;
        private Label label7;
        private FontAwesome.Sharp.IconButton btnRegistrarDetalle;
    }
}