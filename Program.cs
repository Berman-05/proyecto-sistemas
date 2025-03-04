using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace proyecto_sistemas
{
    public partial class Inventario : Form
    {
        public List<Producto> Productos { get; set; } = new List<Producto>();

        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            ActualizarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("NombreProducto", "Nombre del Producto");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
            dataGridView1.Columns.Add("PrecioUnitario", "Precio Unitario");
            dataGridView1.Columns.Add("Total", "Total");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void ActualizarDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var producto in Productos)
            {
                dataGridView1.Rows.Add(
                    producto.Nombre,
                    producto.Cantidad,
                    producto.PrecioUnitario,
                    producto.Cantidad * producto.PrecioUnitario
                );
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Compras nuevoFormulario = new Compras(this);
            nuevoFormulario.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecursosHumanos nuevoFormulario = new RecursosHumanos();
            nuevoFormulario.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventas nuevoFormulario = new Ventas();
            nuevoFormulario.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Lógica de pintura del panel (si es necesario)
        }
    }
}
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace proyecto_sistemas
{
    public partial class Inventario : Form
    {
        public List<Producto> Productos { get; set; } = new List<Producto>();

        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            ActualizarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("NombreProducto", "Nombre del Producto");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
            dataGridView1.Columns.Add("PrecioUnitario", "Precio Unitario");
            dataGridView1.Columns.Add("Total", "Total");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void ActualizarDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var producto in Productos)
            {
                dataGridView1.Rows.Add(
                    producto.Nombre,
                    producto.Cantidad,
                    producto.PrecioUnitario,
                    producto.Cantidad * producto.PrecioUnitario
                );
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Compras nuevoFormulario = new Compras(this);
            nuevoFormulario.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecursosHumanos nuevoFormulario = new RecursosHumanos();
            nuevoFormulario.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventas nuevoFormulario = new Ventas();
            nuevoFormulario.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Lógica de pintura del panel (si es necesario)
        }
    }
}
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace proyecto_sistemas
{
    public partial class Inventario : Form
    {
        public List<Producto> Productos { get; set; } = new List<Producto>();

        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            ActualizarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("NombreProducto", "Nombre del Producto");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
            dataGridView1.Columns.Add("PrecioUnitario", "Precio Unitario");
            dataGridView1.Columns.Add("Total", "Total");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void ActualizarDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var producto in Productos)
            {
                dataGridView1.Rows.Add(
                    producto.Nombre,
                    producto.Cantidad,
                    producto.PrecioUnitario,
                    producto.Cantidad * producto.PrecioUnitario
                );
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Compras nuevoFormulario = new Compras(this);
            nuevoFormulario.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecursosHumanos nuevoFormulario = new RecursosHumanos();
            nuevoFormulario.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventas nuevoFormulario = new Ventas();
            nuevoFormulario.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Lógica de pintura del panel (si es necesario)
        }//comentario
    }
}


