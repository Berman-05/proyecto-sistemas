using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace proyecto_sistemas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.White;
            this.Padding = new Padding(0);
            this.Load += Form1_Load;
            this.Resize += Form1_Resize;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AplicarFormaRedondeada(30);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            AplicarFormaRedondeada(30); // Redibuja la forma en caso de cambio de tama�o
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

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
