using System;
using System.Windows.Forms;

namespace intento_de_solucion
{
    public partial class AjustPresu : Form
    {
        private Form2 paginaInicio;
        private string tipoProyeccion = "";
        private string moneda = "";

        public AjustPresu() { InitializeComponent(); }

        public AjustPresu(Form2 pagInicio)
        {
            InitializeComponent();
            paginaInicio = pagInicio;
        }

        private void AtrasFlecha_Click(object sender, EventArgs e)
        {
            paginaInicio?.Show();
            this.Hide();
        }

        // Selección de tipo
        private void Semanal_Click(object sender, EventArgs e)
        {
            tipoProyeccion = "Semanal";
        }

        private void Mensual_Click(object sender, EventArgs e)
        {
            tipoProyeccion = "Mensual";
        }

        private void Anual_Click(object sender, EventArgs e)
        {
            tipoProyeccion = "Anual";
        }

        // Selección de moneda
        private void Córdobas_Click(object sender, EventArgs e)
        {
            moneda = "Córdobas";
        }

        private void Dólares_Click(object sender, EventArgs e)
        {
            moneda = "Dólares";
        }

        // Guardar presupuesto
        private void DefPresNew_Click(object sender, EventArgs e)
        {
            string actual = textBox1.Text;
            string nuevo = textBox2.Text;
            string confirmar = textBox3.Text;

            if (string.IsNullOrWhiteSpace(actual) ||
                string.IsNullOrWhiteSpace(nuevo) ||
                string.IsNullOrWhiteSpace(confirmar))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            if (nuevo != confirmar)
            {
                MessageBox.Show("El presupuesto nuevo no coincide con la confirmación.");
                return;
            }

            if (tipoProyeccion == "")
            {
                MessageBox.Show("Seleccione un tipo de proyección.");
                return;
            }

            if (moneda == "")
            {
                MessageBox.Show("Seleccione una moneda.");
                return;
            }

            // Guardar en archivo del usuario
            ProyeccionManager.GuardarProyeccion(actual, nuevo, tipoProyeccion, moneda);

            MessageBox.Show("Proyección guardada con éxito.");

            paginaInicio?.Show();
            this.Hide();
        }

        private void AjustPresu_Load(object sender, EventArgs e)
        {

        }
    }
}
