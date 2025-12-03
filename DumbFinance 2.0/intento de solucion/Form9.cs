using System;
using System.IO;
using System.Windows.Forms;

namespace intento_de_solucion
{
    public partial class ReGastoAtra : Form
    {
        private Form2 paginaInicio;
        private string monedaSeleccionada = "";

        public ReGastoAtra()
        {
            InitializeComponent();
        }

        public ReGastoAtra(Form2 pagInicio)
        {
            InitializeComponent();
            this.paginaInicio = pagInicio;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            paginaInicio?.Show();
            this.Hide();
        }

        private void Córdobas_Click(object sender, EventArgs e)
        {
            monedaSeleccionada = "Córdobas";
            textBox3.Text = monedaSeleccionada;
        }

        private void Dólares_Click(object sender, EventArgs e)
        {
            monedaSeleccionada = "Dólares";
            textBox3.Text = monedaSeleccionada;
        }

        private void RegisGastAtra_Click(object sender, EventArgs e)
        {
            string fecha = textBox1.Text;  // fecha del gasto
            string monto = textBox2.Text;  // monto
            string categoria = listBox1.SelectedItem != null ? listBox1.SelectedItem.ToString() : "";
            string moneda = monedaSeleccionada;

            // Validaciones
            if (string.IsNullOrWhiteSpace(fecha) ||
                string.IsNullOrWhiteSpace(monto) ||
                string.IsNullOrWhiteSpace(moneda) ||
                string.IsNullOrWhiteSpace(categoria))
            {
                MessageBox.Show("Complete todos los campos antes de registrar.");
                return;
            }

            if (!decimal.TryParse(monto, out _))
            {
                MessageBox.Show("El monto debe ser un número válido.");
                return;
            }

            // Guardar gasto
            GastoManager.GuardarGasto(monto, fecha, moneda, categoria);

            MessageBox.Show("Gasto registrado exitosamente.");

            // Regresar a Form2
            Form2 f = new Form2();
            f.Show();
            this.Close();
        }
    }
}
