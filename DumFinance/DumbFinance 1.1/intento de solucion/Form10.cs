using System;
using System.IO;
using System.Windows.Forms;

namespace intento_de_solucion
{
    public partial class RegGastNew : Form
    {
        private Form2 paginaInicio;
        private string monedaSeleccionada = "";

        public RegGastNew()
        {
            InitializeComponent();
        }

        public RegGastNew(Form2 pagInicio)
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
        }

        private void Dólares_Click(object sender, EventArgs e)
        {
            monedaSeleccionada = "Dólares";
        }

        private void RegGasto_Click(object sender, EventArgs e)
        {
            string monto = textBox1.Text;  // monto REAL
            string fecha = DateTime.Now.ToString("yyyy-MM-dd"); // fecha automática
            string categoria = listBox1.SelectedItem != null ? listBox1.SelectedItem.ToString() : "";
            string moneda = monedaSeleccionada;

            // Validaciones
            if (string.IsNullOrWhiteSpace(monto) ||
                string.IsNullOrWhiteSpace(moneda) ||
                string.IsNullOrWhiteSpace(categoria))
            {
                MessageBox.Show("Complete todos los campos.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(monto, out _))
            {
                MessageBox.Show("El monto debe ser un número válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar gasto
            GastoManager.GuardarGasto(monto, fecha, moneda, categoria);

            MessageBox.Show("Gasto registrado correctamente.", "Éxito");

            Form2 f = new Form2();
            f.Show();
            this.Close();
        }
    }
}
