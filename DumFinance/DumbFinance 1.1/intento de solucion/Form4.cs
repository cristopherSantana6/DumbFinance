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
    public partial class FormReporte : Form
    {
        private Form2 paginaInicio;   // ← Guardar referencia del Form2

        public FormReporte()
        {
            InitializeComponent();
        }

        public FormReporte(Form2 pagInicio)
        {
            InitializeComponent();     // ← MUY IMPORTANTE
            this.paginaInicio = pagInicio;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // ← FLECHA DE REGRESO
            paginaInicio.Show();
            this.Hide();
        }
    }
}