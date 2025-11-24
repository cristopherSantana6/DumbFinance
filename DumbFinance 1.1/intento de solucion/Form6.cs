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
    public partial class Form6 : Form
    {
        private Form2 ventanaAnterior;  
        public Form6(Form2 formAnterior)
        {
            InitializeComponent();
            ventanaAnterior = formAnterior;
        }

      
        public Form6()
        {
            InitializeComponent();
        }

        private void EditCont_Load(object sender, EventArgs e)
        {
           
        }

        private void AtrasFecha_Click(object sender, EventArgs e)
        {
          
            if (ventanaAnterior != null)
            {
                ventanaAnterior.Show();
            }

            this.Close(); 
        }
    }
}

