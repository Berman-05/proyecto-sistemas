using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_sistemas
{
    public partial class Financiero : Form
    {
        public Financiero()
        {
            InitializeComponent();
        }
        public static decimal dinero = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventario nuevoFormulario = new Inventario();
            nuevoFormulario.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Compras nuevoFormulario = new Compras();
            nuevoFormulario.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventas nuevoFormulario = new Ventas();
            nuevoFormulario.Show();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecursosHumanos nuevoFormulario = new RecursosHumanos();
            nuevoFormulario.Show();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio nuevoFormulario = new Inicio();
            nuevoFormulario.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            EstadoCuenta nuevoFormulario = new EstadoCuenta();
            nuevoFormulario.Show();
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reporte nuevoFormulario = new Reporte();
            nuevoFormulario.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu nuevoFormulario = new Menu();
            nuevoFormulario.Show();
        }

        private void IBtnMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void IBtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
