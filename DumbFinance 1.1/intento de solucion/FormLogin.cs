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
   public partial class FormLogin : Form
{
    private Form2 paginaInicio;  // referencia al formulario inicial

    public FormLogin(Form2 pagInicio)
    {
        InitializeComponent();
        this.paginaInicio = pagInicio;
    }
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void atras_Click(object sender, EventArgs e)
        {
            paginaInicio.Show(); 
            this.Close();         
        }
    }
}
