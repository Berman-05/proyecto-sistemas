namespace proyecto_sistemas
{
    partial class Inicio
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
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label4 = new Label();
            botonRedondo1 = new BotonRedondo();
            passwordtxt = new TextBox();
            userBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(500, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 524);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources._4d8cee174988773_64ac37b2b5ea1;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(300, 524);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(botonRedondo1);
            panel2.Controls.Add(passwordtxt);
            panel2.Controls.Add(userBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 524);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(24, 23);
            label4.TabIndex = 8;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // botonRedondo1
            // 
            botonRedondo1.BackColor = Color.FromArgb(154, 184, 88);
            botonRedondo1.BackgroundColor = Color.FromArgb(154, 184, 88);
            botonRedondo1.BorderColor = Color.Cyan;
            botonRedondo1.BorderRadius = 20;
            botonRedondo1.BorderSize = 0;
            botonRedondo1.Cursor = Cursors.Hand;
            botonRedondo1.FlatAppearance.BorderSize = 0;
            botonRedondo1.FlatStyle = FlatStyle.Flat;
            botonRedondo1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonRedondo1.ForeColor = Color.Black;
            botonRedondo1.Location = new Point(31, 409);
            botonRedondo1.Name = "botonRedondo1";
            botonRedondo1.Size = new Size(168, 60);
            botonRedondo1.TabIndex = 7;
            botonRedondo1.Text = "Entrar";
            botonRedondo1.TextColor = Color.Black;
            botonRedondo1.UseVisualStyleBackColor = false;
            botonRedondo1.Click += botonRedondo1_Click;
            // 
            // passwordtxt
            // 
            passwordtxt.Cursor = Cursors.IBeam;
            passwordtxt.Location = new Point(31, 307);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(436, 31);
            passwordtxt.TabIndex = 6;
            // 
            // userBox
            // 
            userBox.Cursor = Cursors.IBeam;
            userBox.Location = new Point(31, 178);
            userBox.Name = "userBox";
            userBox.Size = new Size(436, 31);
            userBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 272);
            label3.Name = "label3";
            label3.Size = new Size(143, 23);
            label3.TabIndex = 4;
            label3.Text = "CONTRASEÑA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 142);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 3;
            label2.Text = "USUARIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 53);
            label1.Name = "label1";
            label1.Size = new Size(256, 38);
            label1.TabIndex = 2;
            label1.Text = "INICIAR SESIÓN";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 524);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label3;
        private Label label2;
        private BotonRedondo botonRedondo1;
        private TextBox passwordtxt;
        private TextBox userBox;
        private Label label4;
    }
}