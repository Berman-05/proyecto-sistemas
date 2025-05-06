namespace proyecto_sistemas
{
    partial class Menu
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
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panelBotones = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            btnVentas = new BotonRedondo();
            btnInventario = new BotonRedondo();
            btnCompras = new BotonRedondo();
            btnRecursos = new BotonRedondo();
            botonRedondo1 = new BotonRedondo();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panelBotones.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoMainPolloRey;
            pictureBox1.Location = new Point(316, 91);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.Controls.Add(panelBotones);
            panel2.Location = new Point(0, -2);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(885, 641);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(botonRedondo1);
            panelBotones.Controls.Add(panel1);
            panelBotones.Controls.Add(btnVentas);
            panelBotones.Controls.Add(btnInventario);
            panelBotones.Controls.Add(pictureBox1);
            panelBotones.Controls.Add(btnCompras);
            panelBotones.Controls.Add(btnRecursos);
            panelBotones.Dock = DockStyle.Fill;
            panelBotones.Location = new Point(0, 0);
            panelBotones.Margin = new Padding(2);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(885, 641);
            panelBotones.TabIndex = 4;
            panelBotones.Paint += panelBotones_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(885, 34);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(851, 0);
            label1.Name = "label1";
            label1.Size = new Size(34, 34);
            label1.TabIndex = 4;
            label1.Text = "X";
            // 
            // btnVentas
            // 
            btnVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnVentas.AutoSize = true;
            btnVentas.BackColor = Color.Gold;
            btnVentas.BackgroundColor = Color.Gold;
            btnVentas.BorderColor = Color.MidnightBlue;
            btnVentas.BorderRadius = 20;
            btnVentas.BorderSize = 3;
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            btnVentas.ForeColor = Color.Black;
            btnVentas.Location = new Point(358, 385);
            btnVentas.Margin = new Padding(2);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(160, 160);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ventas";
            btnVentas.TextColor = Color.Black;
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnInventario
            // 
            btnInventario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnInventario.AutoSize = true;
            btnInventario.BackColor = Color.Gold;
            btnInventario.BackgroundColor = Color.Gold;
            btnInventario.BorderColor = Color.MidnightBlue;
            btnInventario.BorderRadius = 20;
            btnInventario.BorderSize = 3;
            btnInventario.Cursor = Cursors.Hand;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            btnInventario.ForeColor = Color.Black;
            btnInventario.Location = new Point(11, 385);
            btnInventario.Margin = new Padding(2);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(161, 160);
            btnInventario.TabIndex = 0;
            btnInventario.Text = "Inventario";
            btnInventario.TextColor = Color.Black;
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnCompras
            // 
            btnCompras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCompras.AutoSize = true;
            btnCompras.BackColor = Color.Gold;
            btnCompras.BackgroundColor = Color.Gold;
            btnCompras.BorderColor = Color.MidnightBlue;
            btnCompras.BorderRadius = 20;
            btnCompras.BorderSize = 3;
            btnCompras.Cursor = Cursors.Hand;
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            btnCompras.ForeColor = Color.Black;
            btnCompras.Location = new Point(185, 385);
            btnCompras.Margin = new Padding(2);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(160, 160);
            btnCompras.TabIndex = 1;
            btnCompras.Text = "Compras";
            btnCompras.TextColor = Color.Black;
            btnCompras.UseVisualStyleBackColor = false;
            btnCompras.Click += btnCompras_Click;
            // 
            // btnRecursos
            // 
            btnRecursos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRecursos.AutoSize = true;
            btnRecursos.BackColor = Color.Gold;
            btnRecursos.BackgroundColor = Color.Gold;
            btnRecursos.BorderColor = Color.MidnightBlue;
            btnRecursos.BorderRadius = 20;
            btnRecursos.BorderSize = 3;
            btnRecursos.Cursor = Cursors.Hand;
            btnRecursos.FlatAppearance.BorderSize = 0;
            btnRecursos.FlatStyle = FlatStyle.Flat;
            btnRecursos.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            btnRecursos.ForeColor = Color.Black;
            btnRecursos.Location = new Point(531, 385);
            btnRecursos.Margin = new Padding(2);
            btnRecursos.Name = "btnRecursos";
            btnRecursos.Size = new Size(164, 160);
            btnRecursos.TabIndex = 3;
            btnRecursos.Text = "Recursos\r\nHumanos";
            btnRecursos.TextColor = Color.Black;
            btnRecursos.UseVisualStyleBackColor = false;
            btnRecursos.Click += btnRecursos_Click;
            // 
            // botonRedondo1
            // 
            botonRedondo1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            botonRedondo1.AutoSize = true;
            botonRedondo1.BackColor = Color.Gold;
            botonRedondo1.BackgroundColor = Color.Gold;
            botonRedondo1.BorderColor = Color.MidnightBlue;
            botonRedondo1.BorderRadius = 20;
            botonRedondo1.BorderSize = 3;
            botonRedondo1.Cursor = Cursors.Hand;
            botonRedondo1.FlatAppearance.BorderSize = 0;
            botonRedondo1.FlatStyle = FlatStyle.Flat;
            botonRedondo1.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            botonRedondo1.ForeColor = Color.Black;
            botonRedondo1.Location = new Point(710, 385);
            botonRedondo1.Margin = new Padding(2);
            botonRedondo1.Name = "botonRedondo1";
            botonRedondo1.Size = new Size(164, 160);
            botonRedondo1.TabIndex = 6;
            botonRedondo1.Text = "Financiero";
            botonRedondo1.TextColor = Color.Black;
            botonRedondo1.UseVisualStyleBackColor = false;
            botonRedondo1.Click += botonRedondo1_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 639);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panelBotones.ResumeLayout(false);
            panelBotones.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private BotonRedondo btnRecursos;
        private BotonRedondo btnVentas;
        private BotonRedondo btnCompras;
        private BotonRedondo btnInventario;
        private PictureBox pictureBox1;
        private Panel panelBotones;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Label label1;
        private Panel panel1;
        private BotonRedondo botonRedondo1;
    }
}