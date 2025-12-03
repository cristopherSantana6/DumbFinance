using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intento_de_solucion
{
    public partial class AnaCuen1 : Form
    {
        private Form2 paginaInicio;   // ← guardar referencia al Form2

        public AnaCuen1()
        {
            InitializeComponent();
        }

        public AnaCuen1(Form2 form2)
        {
            InitializeComponent();     // ← NECESARIO para mostrar el diseño
            this.paginaInicio = form2; // ← guardar referencia
        }

        private void AtrasFlecha_Click(object sender, EventArgs e)
        {
            paginaInicio.Show();  // volver al Form2
            this.Hide();          // ocultar este formulario
        }

        private void AnaCuen1_Load(object sender, EventArgs e)
        {

        }
    }
}
