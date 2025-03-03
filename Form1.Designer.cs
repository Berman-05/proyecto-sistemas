namespace proyecto_sistemas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            roundPanel1 = new RoundPanel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            botonRedondo1 = new BotonRedondo();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            roundPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 600);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(roundPanel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(900, 469);
            panel3.TabIndex = 3;
            // 
            // roundPanel1
            // 
            roundPanel1.BackColor = Color.White;
            roundPanel1.Controls.Add(botonRedondo1);
            roundPanel1.Controls.Add(label1);
            roundPanel1.Controls.Add(textBox2);
            roundPanel1.Controls.Add(textBox1);
            roundPanel1.CornerRadius = 20;
            roundPanel1.Location = new Point(227, 34);
            roundPanel1.Name = "roundPanel1";
            roundPanel1.Size = new Size(435, 398);
            roundPanel1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(41, 247);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Contraseña";
            textBox2.Size = new Size(350, 31);
            textBox2.TabIndex = 1;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 153);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Usuario";
            textBox1.Size = new Size(350, 31);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 131);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(850, 12);
            button1.Name = "button1";
            button1.Size = new Size(38, 34);
            button1.TabIndex = 4;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pollo_rey_vector_logo;
            pictureBox1.Location = new Point(27, -34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 54);
            label1.Name = "label1";
            label1.Size = new Size(291, 43);
            label1.TabIndex = 2;
            label1.Text = "Inicio de sesión";
            // 
            // botonRedondo1
            // 
            botonRedondo1.BackColor = SystemColors.HotTrack;
            botonRedondo1.BackgroundColor = SystemColors.HotTrack;
            botonRedondo1.BorderColor = Color.Cyan;
            botonRedondo1.BorderRadius = 20;
            botonRedondo1.BorderSize = 0;
            botonRedondo1.FlatAppearance.BorderSize = 0;
            botonRedondo1.FlatStyle = FlatStyle.Flat;
            botonRedondo1.ForeColor = Color.White;
            botonRedondo1.Location = new Point(127, 325);
            botonRedondo1.Name = "botonRedondo1";
            botonRedondo1.Size = new Size(161, 38);
            botonRedondo1.TabIndex = 4;
            botonRedondo1.Text = "Iniciar Sesión";
            botonRedondo1.TextColor = Color.White;
            botonRedondo1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            roundPanel1.ResumeLayout(false);
            roundPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox1;
        private RoundPanel roundPanel1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private BotonRedondo botonRedondo1;
    }
}
