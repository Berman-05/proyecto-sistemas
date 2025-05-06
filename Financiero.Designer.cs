namespace proyecto_sistemas
{
    partial class Financiero
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
            panel2 = new Panel();
            label1 = new Label();
            IBtnMin = new FontAwesome.Sharp.IconButton();
            IBtnExit = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            panel5 = new Panel();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            botonRedondo1 = new BotonRedondo();
            btnVentas = new BotonRedondo();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(IBtnMin);
            panel2.Controls.Add(IBtnExit);
            panel2.Controls.Add(iconButton1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(176, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(667, 50);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(231, -1);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(203, 51);
            label1.TabIndex = 4;
            label1.Text = "Finanzas";
            label1.Click += label1_Click;
            // 
            // IBtnMin
            // 
            IBtnMin.BackColor = Color.Transparent;
            IBtnMin.Dock = DockStyle.Right;
            IBtnMin.FlatAppearance.BorderSize = 0;
            IBtnMin.FlatStyle = FlatStyle.Flat;
            IBtnMin.IconChar = FontAwesome.Sharp.IconChar.Subtract;
            IBtnMin.IconColor = Color.Black;
            IBtnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBtnMin.IconSize = 35;
            IBtnMin.Location = new Point(582, 0);
            IBtnMin.Margin = new Padding(0);
            IBtnMin.Name = "IBtnMin";
            IBtnMin.Size = new Size(40, 50);
            IBtnMin.TabIndex = 2;
            IBtnMin.UseVisualStyleBackColor = false;
            IBtnMin.Click += IBtnMin_Click;
            // 
            // IBtnExit
            // 
            IBtnExit.BackColor = Color.Transparent;
            IBtnExit.Dock = DockStyle.Right;
            IBtnExit.FlatAppearance.BorderSize = 0;
            IBtnExit.FlatStyle = FlatStyle.Flat;
            IBtnExit.IconChar = FontAwesome.Sharp.IconChar.Close;
            IBtnExit.IconColor = Color.Black;
            IBtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IBtnExit.IconSize = 35;
            IBtnExit.Location = new Point(622, 0);
            IBtnExit.Margin = new Padding(0);
            IBtnExit.Name = "IBtnExit";
            IBtnExit.Size = new Size(45, 50);
            IBtnExit.TabIndex = 1;
            IBtnExit.UseVisualStyleBackColor = false;
            IBtnExit.Click += IBtnExit_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackgroundImageLayout = ImageLayout.None;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.Dock = DockStyle.Left;
            iconButton1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.House;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 25;
            iconButton1.Location = new Point(0, 0);
            iconButton1.Margin = new Padding(2);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(82, 50);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "Inicio ";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(176, 501);
            panel1.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(iconButton6);
            panel5.Controls.Add(iconButton5);
            panel5.Controls.Add(iconButton4);
            panel5.Controls.Add(iconButton3);
            panel5.Controls.Add(iconButton2);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 125);
            panel5.Name = "panel5";
            panel5.Size = new Size(176, 376);
            panel5.TabIndex = 1;
            // 
            // iconButton6
            // 
            iconButton6.Cursor = Cursors.Hand;
            iconButton6.Dock = DockStyle.Top;
            iconButton6.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.PersonCircleCheck;
            iconButton6.IconColor = Color.Black;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.IconSize = 30;
            iconButton6.Location = new Point(0, 207);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(176, 69);
            iconButton6.TabIndex = 4;
            iconButton6.Text = "Recursos Humanos";
            iconButton6.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton6.UseVisualStyleBackColor = true;
            iconButton6.Click += iconButton6_Click;
            // 
            // iconButton5
            // 
            iconButton5.Dock = DockStyle.Bottom;
            iconButton5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            iconButton5.IconColor = Color.Black;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 30;
            iconButton5.Location = new Point(0, 319);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(176, 57);
            iconButton5.TabIndex = 3;
            iconButton5.Text = "Salir";
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = true;
            iconButton5.Click += iconButton5_Click;
            // 
            // iconButton4
            // 
            iconButton4.Cursor = Cursors.Hand;
            iconButton4.Dock = DockStyle.Top;
            iconButton4.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 30;
            iconButton4.Location = new Point(0, 138);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(176, 69);
            iconButton4.TabIndex = 2;
            iconButton4.Text = "Ventas";
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click;
            // 
            // iconButton3
            // 
            iconButton3.Cursor = Cursors.Hand;
            iconButton3.Dock = DockStyle.Top;
            iconButton3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 30;
            iconButton3.Location = new Point(0, 69);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(176, 69);
            iconButton3.TabIndex = 1;
            iconButton3.Text = "Compras";
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            // 
            // iconButton2
            // 
            iconButton2.Cursor = Cursors.Hand;
            iconButton2.Dock = DockStyle.Top;
            iconButton2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.ForeColor = SystemColors.ControlText;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.Location = new Point(0, 0);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(176, 69);
            iconButton2.TabIndex = 0;
            iconButton2.Text = "Inventario";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(176, 125);
            panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoMainPolloRey;
            pictureBox1.Location = new Point(3, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(botonRedondo1);
            panel3.Controls.Add(btnVentas);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(176, 50);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(667, 451);
            panel3.TabIndex = 4;
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
            botonRedondo1.Location = new Point(362, 144);
            botonRedondo1.Margin = new Padding(2);
            botonRedondo1.Name = "botonRedondo1";
            botonRedondo1.Size = new Size(250, 150);
            botonRedondo1.TabIndex = 4;
            botonRedondo1.Text = "Reporte\r\ngeneral";
            botonRedondo1.TextColor = Color.Black;
            botonRedondo1.UseVisualStyleBackColor = false;
            botonRedondo1.Click += botonRedondo1_Click;
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
            btnVentas.Location = new Point(54, 144);
            btnVentas.Margin = new Padding(2);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(250, 150);
            btnVentas.TabIndex = 3;
            btnVentas.Text = "Estado de\r\ncuenta";
            btnVentas.TextColor = Color.Black;
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // Financiero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 501);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Financiero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Financiero";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private FontAwesome.Sharp.IconButton IBtnMin;
        private FontAwesome.Sharp.IconButton IBtnExit;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel1;
        private Panel panel5;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton6;
        private BotonRedondo botonRedondo1;
        private BotonRedondo btnVentas;
    }
}