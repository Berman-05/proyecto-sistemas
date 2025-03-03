namespace proyecto_sistemas
{
    partial class RecursosHumanos
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
            panel5 = new Panel();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            IBtnMin = new FontAwesome.Sharp.IconButton();
            IBtnExit = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 626);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(iconButton5);
            panel5.Controls.Add(iconButton4);
            panel5.Controls.Add(iconButton3);
            panel5.Controls.Add(iconButton2);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 156);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(220, 470);
            panel5.TabIndex = 1;
            // 
            // iconButton5
            // 
            iconButton5.Dock = DockStyle.Bottom;
            iconButton5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            iconButton5.IconColor = Color.Black;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 30;
            iconButton5.Location = new Point(0, 399);
            iconButton5.Margin = new Padding(4);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(220, 71);
            iconButton5.TabIndex = 3;
            iconButton5.Text = "Salir";
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = true;
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
            iconButton4.Location = new Point(0, 172);
            iconButton4.Margin = new Padding(4);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(220, 86);
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
            iconButton3.Location = new Point(0, 86);
            iconButton3.Margin = new Padding(4);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(220, 86);
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
            iconButton2.Margin = new Padding(4);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(220, 86);
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
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(220, 156);
            panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoMainPolloRey;
            pictureBox1.Location = new Point(4, 9);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(IBtnMin);
            panel2.Controls.Add(IBtnExit);
            panel2.Controls.Add(iconButton1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(220, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(834, 62);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(167, -2);
            label1.Name = "label1";
            label1.Size = new Size(501, 62);
            label1.TabIndex = 4;
            label1.Text = "Recursos Humanos";
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
            IBtnMin.Location = new Point(728, 0);
            IBtnMin.Margin = new Padding(0);
            IBtnMin.Name = "IBtnMin";
            IBtnMin.Size = new Size(50, 62);
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
            IBtnExit.Location = new Point(778, 0);
            IBtnExit.Margin = new Padding(0);
            IBtnExit.Name = "IBtnExit";
            IBtnExit.Size = new Size(56, 62);
            IBtnExit.TabIndex = 1;
            IBtnExit.UseVisualStyleBackColor = false;
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
            iconButton1.Size = new Size(102, 62);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "Inicio ";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(220, 62);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(834, 564);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // RecursosHumanos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 626);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "RecursosHumanos";
            Text = "RecursosHumanos";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel5;
        private Panel panel4;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton IBtnMin;
        private FontAwesome.Sharp.IconButton IBtnExit;
        private Label label1;
    }
}