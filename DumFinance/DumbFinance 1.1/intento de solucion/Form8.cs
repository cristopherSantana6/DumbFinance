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
    public partial class AjustPresu : Form
    {
        private Form2 paginaInicio;   // ← Guardar referencia a Form2

        public AjustPresu()
        {
            InitializeComponent();
        }

        public AjustPresu(Form2 pagInicio)
        {
            InitializeComponent();     // ← muy importante
            this.paginaInicio = pagInicio;
        }

        private void AtrasFlecha_Click(object sender, EventArgs e)
        {
            paginaInicio?.Show();   // Regresar al Form2
            this.Hide();            // Ocultar este formulario
        }
    }
}