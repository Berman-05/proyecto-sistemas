namespace proyecto_sistemas
{
    partial class Compras
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
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            label5 = new Label();
            IBtnMin = new FontAwesome.Sharp.IconButton();
            IBtnExit = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            botonRedondo1 = new BotonRedondo();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(176, 501);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(iconButton6);
            panel3.Controls.Add(iconButton5);
            panel3.Controls.Add(iconButton4);
            panel3.Controls.Add(iconButton3);
            panel3.Controls.Add(iconButton2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(176, 376);
            panel3.TabIndex = 1;
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
            iconButton5.TabIndex = 7;
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
            iconButton4.TabIndex = 6;
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
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.PersonCircleCheck;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 30;
            iconButton3.Location = new Point(0, 69);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(176, 69);
            iconButton3.TabIndex = 5;
            iconButton3.Text = "Recursos Humanos";
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
            iconButton2.TabIndex = 4;
            iconButton2.Text = "Inventario";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(176, 125);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoMainPolloRey;
            pictureBox1.Location = new Point(4, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(IBtnMin);
            panel4.Controls.Add(IBtnExit);
            panel4.Controls.Add(iconButton1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(176, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(667, 50);
            panel4.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(222, 0);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(216, 51);
            label5.TabIndex = 6;
            label5.Text = "Compras";
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
            IBtnMin.TabIndex = 5;
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
            IBtnExit.TabIndex = 4;
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
            iconButton1.TabIndex = 3;
            iconButton1.Text = "Inicio ";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(dataGridView1);
            panel5.Controls.Add(botonRedondo1);
            panel5.Controls.Add(comboBox1);
            panel5.Controls.Add(numericUpDown1);
            panel5.Controls.Add(textBox2);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(textBox1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(176, 50);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(667, 451);
            panel5.TabIndex = 3;
            panel5.Paint += panel5_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 233);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(623, 206);
            dataGridView1.TabIndex = 9;
            // 
            // botonRedondo1
            // 
            botonRedondo1.BackColor = Color.Gold;
            botonRedondo1.BackgroundColor = Color.Gold;
            botonRedondo1.BorderColor = Color.Cyan;
            botonRedondo1.BorderRadius = 20;
            botonRedondo1.BorderSize = 0;
            botonRedondo1.FlatAppearance.BorderSize = 0;
            botonRedondo1.FlatStyle = FlatStyle.Flat;
            botonRedondo1.ForeColor = Color.Black;
            botonRedondo1.Location = new Point(508, 173);
            botonRedondo1.Name = "botonRedondo1";
            botonRedondo1.Size = new Size(134, 40);
            botonRedondo1.TabIndex = 8;
            botonRedondo1.Text = "Comprar";
            botonRedondo1.TextColor = Color.Black;
            botonRedondo1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(469, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(174, 28);
            comboBox1.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(193, 121);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(146, 27);
            numericUpDown1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(469, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 27);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(349, 124);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 4;
            label4.Text = "Precio unitario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(375, 51);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 3;
            label3.Text = "Proveedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(109, 124);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 2;
            label2.Text = "Cantidad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 51);
            label1.Name = "label1";
            label1.Size = new Size(168, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre del producto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(193, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 27);
            textBox1.TabIndex = 0;
            // 
            // iconButton6
            // 
            iconButton6.Cursor = Cursors.Hand;
            iconButton6.Dock = DockStyle.Top;
            iconButton6.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.PiggyBank;
            iconButton6.IconColor = Color.Black;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.IconSize = 30;
            iconButton6.Location = new Point(0, 207);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(176, 69);
            iconButton6.TabIndex = 8;
            iconButton6.Text = "Finanzas";
            iconButton6.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton6.UseVisualStyleBackColor = true;
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 501);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Compras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compras";
            Load += Compras_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton IBtnMin;
        private FontAwesome.Sharp.IconButton IBtnExit;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private BotonRedondo botonRedondo1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label5;
        private FontAwesome.Sharp.IconButton iconButton6;
    }
}