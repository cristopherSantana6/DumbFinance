using System;
using System.Windows.Forms;

namespace intento_de_solucion
{
    public partial class Form11 : Form
    {
        private Form2 paginaInicio;  // ← Guardar referencia

        public Form11()
        {
            InitializeComponent();
        }

        public Form11(Form2 pagInicio)
        {
            InitializeComponent();
            this.paginaInicio = pagInicio;
        }

        private void AtrasFecha_Click(object sender, EventArgs e)
        {
            paginaInicio?.Show();  // Regresa al Form2
            this.Hide();           // Oculta este formulario
        }
    }
}
