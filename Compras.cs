using System;
using System.Linq;
using System.Windows.Forms;

namespace proyecto_sistemas
{
    public partial class Compras : Form
    {
        private Inventario inventarioForm;

        public Compras(Inventario inventario)
        {
            InitializeComponent();
            inventarioForm = inventario;
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Producto productoComprado = new Producto
                {
                    Nombre = textBox1.Text,
                    Cantidad = (int)numericUpDown1.Value,
                    PrecioUnitario = decimal.Parse(textBox2.Text)
                };

                AgregarAlInventario(productoComprado);
                MessageBox.Show("Compra realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
        }

        private void AgregarAlInventario(Producto producto)
        {
            var productoExistente = inventarioForm.Productos.FirstOrDefault(p => p.Nombre == producto.Nombre);
            if (productoExistente != null)
            {
                productoExistente.Cantidad += producto.Cantidad;
            }
            else
            {
                inventarioForm.Productos.Add(producto);
            }

            inventarioForm.ActualizarDataGridView();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor que 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(textBox2.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El precio unitario debe ser un valor positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            textBox1.Clear();
            numericUpDown1.Value = 1;
            textBox2.Clear();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            inventarioForm.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lógica para manejar clics en el DataGridView
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            // Lógica para cargar el formulario
        }


        //comentario


    }
}
