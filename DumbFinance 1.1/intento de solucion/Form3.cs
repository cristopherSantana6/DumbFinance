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
    public partial class Form3 : Form
    {
        private Form2 ventanaAnterior;
        public Form3(Form2 formAnterior)
        {
            InitializeComponent();
            ventanaAnterior = formAnterior;
        }
        public Form3()
        {
            InitializeComponent();
            ventanaAnterior = null;
        }



        private void AtrasFlecha_Click(object sender, EventArgs e)
        {
            if (ventanaAnterior != null)
            {
                ventanaAnterior.Show();
            }
            this.Close();
        }

        private void PerUser1_Load(object sender, EventArgs e)
        {

        }
    }
}
