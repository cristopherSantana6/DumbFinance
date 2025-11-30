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
    public partial class AjusPres : Form
    {
        private Form2 paginaInicio;

        public AjusPres()
        {
            InitializeComponent();
        }

        public AjusPres(Form2 pagInicio)
        {
            InitializeComponent();
            this.paginaInicio = pagInicio;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            paginaInicio?.Show();
            this.Hide();
        }
    }
}

