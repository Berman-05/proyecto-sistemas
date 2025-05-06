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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
            CargarCompras();
        }
        private void CargarCompras()
        {
            // Asignar la lista de productos comprados al DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Productos.ComprasRealizadas;
        }
        private void Inventario_Load(object sender, EventArgs e)
        {

        }
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtBuscar.Text.ToLower(); // Obtener el texto en minúsculas

            // Filtrar las compras realizadas según el nombre del producto o proveedor
            var productosFiltrados = Productos.ComprasRealizadas.Where(p =>
                p.Nombre.ToLower().Contains(searchTerm) || // Filtrar por nombre
                p.Proveedor.ToLower().Contains(searchTerm)  // Filtrar por proveedor
            ).ToList();

            // Actualizar el DataGridView con los productos filtrados
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productosFiltrados;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecursosHumanos nuevoFormulario = new RecursosHumanos();
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

        private void IBtnMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu nuevoFormulario = new Menu();
            nuevoFormulario.Show();
        }

        private void IBtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio nuevoFormulario = new Inicio();
            nuevoFormulario.Show();
        }
    }
}
