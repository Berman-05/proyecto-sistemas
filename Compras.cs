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
    public partial class Compras : Form
    {
        public static List<Productos> existencias = new List<Productos>();
        public Compras()
        {
            InitializeComponent();
        }

        private void Compras_Load(object sender, EventArgs e)
        {

        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            string nombreProducto = textBox1.Text; // TextBox para el nombre del producto
            string proveedor = comboBox1.SelectedItem.ToString(); // ComboBox para el proveedor
            int cantidadComprada = (int)numericUpDown1.Value; // NumericUpDown para la cantidad
            decimal precio = decimal.Parse(textBox2.Text); // Precio del producto
            decimal precioVenta = precio + (precio * 0.5m); // Precio de venta del producto
            int codigo = int.Parse(txtCodigo.Text); // Código del producto

            // Verificar si ya existe el producto en el inventario
            Productos productoExistente = existencias.FirstOrDefault(p => p.Nombre == nombreProducto);
            Productos codigoExistente = existencias.FirstOrDefault(p => p.Codigo == codigo);

            if (codigoExistente != null && productoExistente != null)
            {
                // Si el producto existe, actualizar la cantidad y el precio
                if (codigoExistente.Codigo == codigo)
                {
                    productoExistente.Cantidad += cantidadComprada;
                    Financiero.dinero = Financiero.dinero - (precio *= cantidadComprada); // Restar el dinero del inventario
                }
                else
                {
                    MessageBox.Show("El producto ya existe en el inventario");
                }

            }
            else if (codigoExistente == null)
            {
                // Si el producto no existe, agregarlo al inventario con el precio
                Productos nuevoProducto = new Productos(codigo, nombreProducto, proveedor, precio, precioVenta, cantidadComprada);
                existencias.Add(nuevoProducto);
            }

            // Agregar el producto a la lista de compras realizadas (con el precio correcto)
            Productos.ComprasRealizadas.Add(new Productos(codigo, nombreProducto, proveedor, precio, precioVenta, cantidadComprada));

            // Actualizar el DataGridView con la lista de productos actualizada
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = existencias;

            MessageBox.Show("Compra realizada con éxito");
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
            RecursosHumanos nuevoFormulario = new RecursosHumanos();
            nuevoFormulario.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

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
