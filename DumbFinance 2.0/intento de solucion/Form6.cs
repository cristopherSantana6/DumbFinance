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
    public partial class EditCont : Form
    {
        private Form2 paginaInicio;   // ← ESTO FALTABA

        public EditCont(Form2 pagInicio)
        {
            InitializeComponent();
            this.paginaInicio = pagInicio;
        }

        private void AtrasFecha_Click(object sender, EventArgs e)
        {
            paginaInicio.Show();  // volver a Form2
            this.Hide();          // ocultar este form (mejor que Close)
        }
    }
}
