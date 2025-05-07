using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;
using System.IO;
using modulo_inventario;
using System.Transactions;
using Microsoft.VisualBasic;

namespace proyecto_sistemas
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();

        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Codigo";
            dataGridView1.Columns[1].Name = "Nombre";
            dataGridView1.Columns[2].Name = "Proveedor";
            dataGridView1.Columns[3].Name = "Cantidad";
            dataGridView1.Columns[4].Name = "Precio";
            dataGridView1.Columns[5].Name = "NIT";
            dataGridView1.Columns[6].Name = "NombreCliente";
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show("¿Desea realizar el pago con tarjeta?\nSeleccione una opción:",
                                                              "Método de Pago",
                                                              MessageBoxButtons.YesNo,
                                                              MessageBoxIcon.Question,
                                                              MessageBoxDefaultButton.Button1);

            // Evaluamos la opción seleccionada
            if (result == DialogResult.Yes)
            {
                // Opción de pago con tarjeta
                MessageBox.Show("Ha seleccionado pagar con tarjeta.\n¡Compra realizada!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                // Opción de pago en efectivo
                MessageBox.Show("Ha seleccionado pagar en efectivo.\n¡Compra realizada!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void buttonGenerarFactura_Click(object sender, EventArgs e)
        {
        }
        public static decimal transaccion = 0;
        public static decimal neto = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(textBox1.Text);
            Productos buscar = Compras.existencias.Find(p => p.Codigo == codigo);
            if (buscar != null)
            {
                buscar.Cantidad -= int.Parse(numericUpDown1.Text);
                CargarProductos();
                dataGridView1.Rows.Add(textBox1.Text, buscar.Nombre, buscar.Proveedor, numericUpDown1.Text, buscar.PrecioVenta,textBox3.Text,textBox2.Text); // Agregar fila
                textBox1.Clear();
                transaccion += buscar.PrecioVenta * int.Parse(numericUpDown1.Text);
                Financiero.dinero += transaccion - ((transaccion / 1.12m * 0.17m));
                Reporte.ganancias += transaccion - ((transaccion / 1.12m * 0.17m));
                Reporte.ingresos.Add(buscar);
                neto += buscar.PrecioVenta * int.Parse(numericUpDown1.Text);
                MessageBox.Show("añadido al pedido.");
               
            }
            else { MessageBox.Show("Sin existencias."); }
        }

        private void GenerarFacturaPDF(string ruta)
        {
            using (FileStream fs = new FileStream(ruta, FileMode.Create))
            {
                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, fs);
                doc.Open();

                Font tituloFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                Font normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                Font empresaFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 24);

                // Agregar logo desde archivo
                try
                {
                    string logoPath = "C:\\Users\\Bernardo Velásquez\\Source\\Repos\\pry-sistemas-final\\Resources\\LogoMainPolloRey"; // Ruta absoluta
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                    logo.ScaleToFit(100f, 100f);
                    logo.Alignment = Element.ALIGN_CENTER;
                    doc.Add(logo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el logo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Información de la empresa
                Paragraph empresa = new Paragraph("La Casa del Pollo", empresaFont)
                {
                    Alignment = Element.ALIGN_CENTER
                };
                doc.Add(empresa);

                Paragraph direccion = new Paragraph("12 ave. 7-17 zona 3 \nQuetzaltenango", normalFont)
                {
                    Alignment = Element.ALIGN_CENTER
                };
                doc.Add(direccion);

                doc.Add(new Paragraph("Factura de Venta", tituloFont));
                doc.Add(new Paragraph("\nFecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "\n\n", normalFont));

                string nitCliente = textBox3.Text.ToString() ?? "N/A";
                string nombreCliente = textBox2.Text.ToString() ?? "N/A";

                doc.Add(new Paragraph("Datos del Cliente:", tituloFont));
                doc.Add(new Paragraph("NIT: " + nitCliente, normalFont));
                doc.Add(new Paragraph("Nombre: " + nombreCliente, normalFont));
                doc.Add(new Paragraph("\n"));

                PdfPTable tabla = new PdfPTable(dataGridView1.ColumnCount - 2);

                for (int i = 0; i < dataGridView1.ColumnCount - 2; i++)
                {
                    tabla.AddCell(new Phrase(dataGridView1.Columns[i].HeaderText, normalFont));
                }

                decimal total = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        for (int i = 0; i < dataGridView1.ColumnCount - 2; i++)
                        {
                            tabla.AddCell(new Phrase(row.Cells[i].Value?.ToString() ?? "", normalFont));
                        }

                        int cantidad = Convert.ToInt32(row.Cells[3].Value);
                        decimal precio = Convert.ToDecimal(row.Cells[4].Value);
                        total += cantidad * precio;
                    }
                }

                doc.Add(tabla);
                doc.Add(new Paragraph("\nTotal: Q" + total.ToString("0.00"), tituloFont));
                doc.Close();
            }
        }
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Columns.Add("NombreProducto", "Nombre del Producto");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
            dataGridView1.Columns.Add("Precio", "Precio");
            dataGridView1.Columns.Add("Total", "Total");
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
            RecursosHumanos nuevoFormulario = new RecursosHumanos();
            nuevoFormulario.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

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
        void CargarProductos()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(numericUpDown1.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



        }
        private void iconButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio nuevoFormulario = new Inicio();
            nuevoFormulario.Show();
        }

        private void botonRedondo2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Guardar Factura";
                saveFileDialog.FileName = "Factura.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    GenerarFacturaPDF(saveFileDialog.FileName);
                    MessageBox.Show("Factura generada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
