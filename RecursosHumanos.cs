using modulo_inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_sistemas
{
    public partial class RecursosHumanos : Form
    {
        private List<Empleado> empleados = new List<Empleado>();
        public RecursosHumanos()
        {
            InitializeComponent();
        }
        private void ConfigurarDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Apellido",
                HeaderText = "Apellido"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Telefono",
                HeaderText = "Teléfono"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "SalarioBase",
                HeaderText = "Salario Base"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Bonificacion",
                HeaderText = "Bonificación"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "SalarioFinal",
                HeaderText = "Salario Final"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Estado",
                HeaderText = "Estado"
            });
        }

        // Actualiza el DataGridView con la lista de empleados
        private void MostrarEmpleados()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = empleados;
        }

        // Limpia los TextBox después de agregar o editar
        private void LimpiarCampos()
        {
            textBox3.Clear();
            textBox2.Clear();
            textBox6.Clear();
            textBox1.Clear();
            textBox5.Clear();
            textBox4.Clear();
        }


        // Botón: Editar Empleado (datos personales)
        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text) ||
            string.IsNullOrWhiteSpace(textBox2.Text) ||
            string.IsNullOrWhiteSpace(textBox6.Text) ||
            textBox6.Text.Length != 8)  // Verificar que el teléfono tenga 8 dígitos
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos (Nombre, Apellido, Teléfono de 8 dígitos).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                Empleado empleadoSeleccionado = empleados[index];

                // Actualizar datos personales
                empleadoSeleccionado.Nombre = textBox3.Text;
                empleadoSeleccionado.Apellido = textBox2.Text;
                empleadoSeleccionado.Telefono = textBox6.Text;
                // Actualizamos la contraseña y se cifra nuevamente
                empleadoSeleccionado.Contraseña = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(textBox1.Text));

                MostrarEmpleados();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un empleado para editar.");
            }
        }



        // Botón: Alternar Estado (Activo/Desactivado)
        private void btnToggleEstado_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                Empleado empleadoSeleccionado = empleados[index];

                // Alternar el estado del empleado
                empleadoSeleccionado.ToggleEstado();
                MostrarEmpleados();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un empleado para cambiar su estado.");
            }
        }

        // Evento: Doble clic en el DataGridView para cargar los datos en los TextBox
        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < empleados.Count)
            {
                Empleado empleadoSeleccionado = empleados[e.RowIndex];

                textBox3.Text = empleadoSeleccionado.Nombre;
                textBox2.Text = empleadoSeleccionado.Apellido;
                textBox6.Text = empleadoSeleccionado.Telefono;
                // Por seguridad, se deja vacío el campo de contraseña al cargar
                textBox1.Text = "";
                textBox5.Text = empleadoSeleccionado.SalarioBase.ToString();
                textBox4.Text = empleadoSeleccionado.Bonificacion.ToString();
            }
        }
        private bool ValidarTelefono(string telefono)
        {
            // Se permite vacío si se requiere (o cambiar la lógica para que sea obligatorio)
            if (string.IsNullOrWhiteSpace(telefono))
                return false;

            // Expresión regular para 8 dígitos
            return Regex.IsMatch(telefono, @"^\d{8}$");
        }
        private void btnCambiarSalario_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                Empleado empleadoSeleccionado = empleados[index];

                try
                {
                    decimal nuevoSalarioBase = Convert.ToDecimal(textBox5.Text);
                    decimal nuevaBonificacion = string.IsNullOrWhiteSpace(textBox4.Text) ? 0 : Convert.ToDecimal(textBox4.Text);

                    // Actualizar datos salariales
                    empleadoSeleccionado.ActualizarSalario(nuevoSalarioBase, nuevaBonificacion);

                    MostrarEmpleados();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar salario: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un empleado para actualizar el salario.");
            }

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = textBox3.Text;
                string apellido = textBox2.Text;
                string telefono = textBox6.Text;
                string contraseña = textBox1.Text;
                decimal salarioBase = Convert.ToDecimal(textBox5.Text);
                decimal bonificacion = string.IsNullOrWhiteSpace(textBox4.Text) ? 0 : Convert.ToDecimal(textBox4.Text);

                // Validar el número de teléfono
                if (!ValidarTelefono(telefono))
                {
                    MessageBox.Show("El número de teléfono debe tener 8 dígitos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear nuevo empleado y agregarlo a la lista.
                // En el constructor se asigna automáticamente "Activo" a la propiedad Estado.
                Empleado nuevoEmpleado = new Empleado(nombre, apellido, telefono, contraseña, salarioBase, bonificacion);
                empleados.Add(nuevoEmpleado);

                MostrarEmpleados();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar empleado: " + ex.Message);
            }
        }
        private void RecursosHumanos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; // Maximiza el formulario al abrirse

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IBtnMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
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
