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
    public partial class PerUser1 : Form
    {
        private Form2 paginaInicio;   // Guardar referencia al Form2

        public PerUser1(Form2 pagInicio)
        {
            InitializeComponent();     // Esto SIEMPRE debe ir
            this.paginaInicio = pagInicio;
        }

        private void flecha_Click(object sender, EventArgs e)
        {
            paginaInicio.Show();  // Volver a Form2
            this.Hide();          // Ocultar este formulario
        }

        private void AtrasFlecha_Click(object sender, EventArgs e)
        {
            paginaInicio.Show();
            this.Close();
        }
    }
}
