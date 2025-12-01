using System;
using System.Windows.Forms;

namespace intento_de_solucion
{
    public partial class FormUser : Form
    {
        private Form2 paginaInicio;   // ← Guardar referencia a Form2

        string usuarioActual;

        public FormUser(string usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }


        public FormUser(Form2 pagInicio)
        {
            InitializeComponent();
            this.paginaInicio = pagInicio;
        }

        private void FormUser_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void AtrasFecha_Click(object sender, EventArgs e)
        {
            paginaInicio?.Show();  // Regresar al Form2
            this.Hide();           // Ocultar este formulario
        }
    }
}
