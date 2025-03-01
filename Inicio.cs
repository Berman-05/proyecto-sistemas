using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyecto_sistemas
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.White;
            this.Padding = new Padding(0);
            this.Load += Inicio_Load;
            this.Resize += Inicio_Resize;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            AplicarFormaRedondeada(30);
        }

        private void Inicio_Resize(object sender, EventArgs e)
        {
            AplicarFormaRedondeada(30); // Redibuja la forma en caso de cambio de tamaño
        }

        private void AplicarFormaRedondeada(int radioBorde)
        {
            using (GraphicsPath path = ObtenerRutaRedondeada(radioBorde))
            {
                this.Region = new Region(path);
            }
        }

        private GraphicsPath ObtenerRutaRedondeada(int radioBorde)
        {
            int ancho = this.Width;
            int alto = this.Height;
            GraphicsPath path = new GraphicsPath();

            if (ancho > 0 && alto > 0)
            {
                path.StartFigure();
                path.AddArc(0, 0, radioBorde, radioBorde, 180, 90); // Esquina superior izquierda
                path.AddArc(ancho - radioBorde, 0, radioBorde, radioBorde, 270, 90); // Esquina superior derecha
                path.AddArc(ancho - radioBorde, alto - radioBorde, radioBorde, radioBorde, 0, 90); // Esquina inferior derecha
                path.AddArc(0, alto - radioBorde, radioBorde, radioBorde, 90, 90); // Esquina inferior izquierda
                path.CloseFigure();
            }

            return path;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            string user = userBox.Text;
            string password = passwordtxt.Text;
            if (user == "Usuario1" && password == "123")
            {
                MessageBox.Show("Sesión iniciada");
                Menu nuevoFormulario = new Menu();
                nuevoFormulario.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }
    }
}
