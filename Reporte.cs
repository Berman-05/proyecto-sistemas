using modulo_inventario;
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
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
            Estado_cuenta_Load(null,null);
            Cargaringresos();
            CargarEgresos();
        }
        public static decimal ganancias = 0;
        private void Estado_cuenta_Load(object sender, EventArgs e)
        {
            textBox1.Text = Ventas.neto.ToString("F2");
            textBox2.Text = ganancias.ToString("F2");
        }
        public static List<Productos> ingresos = new List<Productos>();
        private void CargarEgresos()
        {
            // Crear una lista anónima con los atributos deseados
            var productosFiltrados = Productos.ComprasRealizadas
                .Select(p => new
                {
                    p.Nombre,
                    p.Cantidad,
                    p.Precio
                }).ToList();

            // Asignar la lista filtrada al DataGridView
            dataGridView2.DataSource = productosFiltrados;
        }
        private void Cargaringresos()
        {
            // Crear una lista anónima con los atributos deseados
            var productosFiltrados = Reporte.ingresos
                .Select(p => new
                {
                    p.Nombre,
                    p.Cantidad,
                    p.PrecioVenta
                }).ToList();

            // Asignar la lista filtrada al DataGridView
            dataGridView1.DataSource = productosFiltrados;
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
