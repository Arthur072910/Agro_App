namespace Agro_App.Views
{
    partial class Login
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
            panel1 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            bntcancelar = new FontAwesome.Sharp.IconButton();
            btningresar = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            label3 = new Label();
            txtcontraseña = new TextBox();
            txtusuario = new TextBox();
            panel2 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Fondo;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 553);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(iconPictureBox2);
            panel3.Controls.Add(bntcancelar);
            panel3.Controls.Add(btningresar);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtcontraseña);
            panel3.Controls.Add(txtusuario);
            panel3.Location = new Point(390, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(503, 478);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 60);
            label2.Name = "label2";
            label2.Size = new Size(277, 54);
            label2.TabIndex = 7;
            label2.Text = "Bienvenido";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.Transparent;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 100;
            iconPictureBox2.Location = new Point(361, 14);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(121, 100);
            iconPictureBox2.TabIndex = 6;
            iconPictureBox2.TabStop = false;
            // 
            // bntcancelar
            // 
            bntcancelar.BackColor = Color.Firebrick;
            bntcancelar.Cursor = Cursors.Hand;
            bntcancelar.FlatAppearance.BorderColor = Color.White;
            bntcancelar.ForeColor = Color.White;
            bntcancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            bntcancelar.IconColor = Color.White;
            bntcancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntcancelar.IconSize = 21;
            bntcancelar.Location = new Point(270, 368);
            bntcancelar.Name = "bntcancelar";
            bntcancelar.Size = new Size(161, 42);
            bntcancelar.TabIndex = 5;
            bntcancelar.Text = "Cancelar";
            bntcancelar.TextAlign = ContentAlignment.MiddleRight;
            bntcancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            bntcancelar.UseVisualStyleBackColor = false;
            bntcancelar.Click += bntcancelar_Click;
            // 
            // btningresar
            // 
            btningresar.BackColor = Color.ForestGreen;
            btningresar.Cursor = Cursors.Hand;
            btningresar.FlatAppearance.BorderColor = Color.White;
            btningresar.ForeColor = Color.White;
            btningresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btningresar.IconColor = Color.White;
            btningresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btningresar.IconSize = 21;
            btningresar.Location = new Point(43, 368);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(161, 42);
            btningresar.TabIndex = 4;
            btningresar.Text = "Ingresar";
            btningresar.TextAlign = ContentAlignment.MiddleRight;
            btningresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btningresar.UseVisualStyleBackColor = false;
            btningresar.Click += btningresar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(43, 233);
            label4.Name = "label4";
            label4.Size = new Size(150, 27);
            label4.TabIndex = 3;
            label4.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(43, 150);
            label3.Name = "label3";
            label3.Size = new Size(106, 27);
            label3.TabIndex = 2;
            label3.Text = "Usuario:";
            // 
            // txtcontraseña
            // 
            txtcontraseña.Location = new Point(43, 263);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.PasswordChar = '*';
            txtcontraseña.Size = new Size(388, 27);
            txtcontraseña.TabIndex = 1;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(43, 180);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(388, 27);
            txtusuario.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.ForestGreen;
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(100, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 478);
            panel2.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.ForestGreen;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Seedling;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 210;
            iconPictureBox1.Location = new Point(44, 84);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(210, 245);
            iconPictureBox1.TabIndex = 4;
            iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.ForestGreen;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 359);
            label1.Name = "label1";
            label1.Size = new Size(284, 27);
            label1.TabIndex = 3;
            label1.Text = "Sistema de Agroservicio";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private TextBox txtcontraseña;
        private TextBox txtusuario;
        private FontAwesome.Sharp.IconButton bntcancelar;
        private FontAwesome.Sharp.IconButton btningresar;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}