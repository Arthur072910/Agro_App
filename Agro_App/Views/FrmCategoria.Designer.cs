﻿namespace Agro_App.Views
{
    partial class FrmCategoria
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            menutitulo = new MenuStrip();
            label2 = new Label();
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
            tabPage1 = new TabPage();
            DataListadoCategorias = new DataGridView();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            DataMantenedorCategorias = new DataGridView();
            label1 = new Label();
            txtNombre = new TextBox();
            btnEditar = new Button();
            btnAgregar = new Button();
            tabPage3 = new TabPage();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            menu.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataListadoCategorias).BeginInit();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataMantenedorCategorias).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            menutitulo.Size = new Size(1958, 194);
            menutitulo.TabIndex = 2;
            menutitulo.Text = "menuStrip2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.ForestGreen;
            label2.Font = new Font("Arial Rounded MT Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(56, 75);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(963, 60);
            label2.TabIndex = 3;
            label2.Text = "Sistema de Agroservicio - Categorias\r\n";
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
            menu.Size = new Size(1958, 181);
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
            menuusuarios.Size = new Size(166, 179);
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
            menumantenedor.Size = new Size(166, 179);
            menumantenedor.Text = "Mantenedor";
            menumantenedor.TextImageRelation = TextImageRelation.ImageAboveText;
            menumantenedor.Click += menumantenedor_Click;
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
            registrarCompraToolStripMenuItem.Click += registrarCompraToolStripMenuItem_Click;
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
            reporteComprasToolStripMenuItem.Click += reporteComprasToolStripMenuItem_Click;
            // 
            // reporteVentasToolStripMenuItem
            // 
            reporteVentasToolStripMenuItem.Name = "reporteVentasToolStripMenuItem";
            reporteVentasToolStripMenuItem.Size = new Size(253, 34);
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
            // tabPage1
            // 
            tabPage1.Controls.Add(DataListadoCategorias);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(2, 4, 2, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 4, 2, 4);
            tabPage1.Size = new Size(1043, 463);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Listado de Categorias";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // DataListadoCategorias
            // 
            DataListadoCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            DataListadoCategorias.DefaultCellStyle = dataGridViewCellStyle5;
            DataListadoCategorias.Location = new Point(191, 19);
            DataListadoCategorias.Margin = new Padding(2, 4, 2, 4);
            DataListadoCategorias.Name = "DataListadoCategorias";
            DataListadoCategorias.RowHeadersWidth = 62;
            DataListadoCategorias.Size = new Size(664, 410);
            DataListadoCategorias.TabIndex = 0;
            DataListadoCategorias.CellContentClick += DataListadoCategorias_CellContentClick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(562, 499);
            tabControl1.Margin = new Padding(2, 4, 2, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1051, 501);
            tabControl1.TabIndex = 5;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(DataMantenedorCategorias);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(txtNombre);
            tabPage2.Controls.Add(btnEditar);
            tabPage2.Controls.Add(btnAgregar);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(2, 4, 2, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 4, 2, 4);
            tabPage2.Size = new Size(1043, 463);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mantendor";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // DataMantenedorCategorias
            // 
            DataMantenedorCategorias.BackgroundColor = SystemColors.Control;
            DataMantenedorCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DataMantenedorCategorias.DefaultCellStyle = dataGridViewCellStyle6;
            DataMantenedorCategorias.GridColor = SystemColors.MenuText;
            DataMantenedorCategorias.Location = new Point(282, 45);
            DataMantenedorCategorias.Margin = new Padding(2, 4, 2, 4);
            DataMantenedorCategorias.Name = "DataMantenedorCategorias";
            DataMantenedorCategorias.RowHeadersWidth = 62;
            DataMantenedorCategorias.Size = new Size(664, 374);
            DataMantenedorCategorias.TabIndex = 5;
            DataMantenedorCategorias.CellContentClick += DataMantenedorCategorias_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(44, 45);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 4;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(44, 71);
            txtNombre.Margin = new Padding(2, 4, 2, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(190, 31);
            txtNombre.TabIndex = 3;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // btnEditar
            // 
            btnEditar.ForeColor = SystemColors.ActiveCaptionText;
            btnEditar.Location = new Point(68, 260);
            btnEditar.Margin = new Padding(2, 4, 2, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(111, 34);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregar.Location = new Point(68, 168);
            btnAgregar.Margin = new Padding(2, 4, 2, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(111, 34);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1043, 463);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Manejo de actividad";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(91, 254);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "Desactivar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(91, 156);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Activar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(293, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(633, 323);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1958, 1249);
            Controls.Add(tabControl1);
            Controls.Add(menu);
            Controls.Add(label2);
            Controls.Add(menutitulo);
            ForeColor = SystemColors.Control;
            Margin = new Padding(4);
            Name = "FrmCategoria";
            Text = "FrmCategoria";
            WindowState = FormWindowState.Maximized;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataListadoCategorias).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataMantenedorCategorias).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menutitulo;
        private Label label2;
        private MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menuusuarios;
        private FontAwesome.Sharp.IconMenuItem menumantenedor;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem submenuregistrar;
        private FontAwesome.Sharp.IconMenuItem submenuverdetalleventa;
        private FontAwesome.Sharp.IconMenuItem menucompras;
        private FontAwesome.Sharp.IconMenuItem menuclientes;
        private FontAwesome.Sharp.IconMenuItem menuproveedores;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private FontAwesome.Sharp.IconMenuItem menuacercade;
        private TabPage tabPage1;
        private DataGridView DataListadoCategorias;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private DataGridView DataMantenedorCategorias;
        private Label label1;
        private TextBox txtNombre;
        private Button btnEditar;
        private Button btnAgregar;
        private ToolStripMenuItem registrarCompraToolStripMenuItem;
        private ToolStripMenuItem detalleCompraToolStripMenuItem;
        private ToolStripMenuItem reporteComprasToolStripMenuItem;
        private ToolStripMenuItem reporteVentasToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem menucasa;
        private TabPage tabPage3;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
    }
}