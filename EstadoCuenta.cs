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
    public partial class EstadoCuenta : Form
    {
        public EstadoCuenta()
        {
            InitializeComponent();
            Estado_cuenta_Load(null, null);
        }
        decimal mostrarDinero = Financiero.dinero;
        private void Estado_cuenta_Load(object sender, EventArgs e)
        {
            textBox1.Text = mostrarDinero.ToString("F2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal deposito = decimal.Parse(textBox2.Text);
            Financiero.dinero += deposito;
            textBox1.Text = Financiero.dinero.ToString("F2");
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

    
        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Financiero nuevoFormulario = new Financiero();
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
