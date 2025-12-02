using System;
using System.Windows.Forms;

namespace intento_de_solucion
{
    public partial class FormUser : Form
    {
        string usuarioActual;

        public FormUser(string usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            // Si tienes un label con el nombre de usuario, podrías hacer:
            // username.Text = usuarioActual;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // vacío
        }

        private void username_Click(object sender, EventArgs e)
        {
            // vacío
        }

        private void AtrasFecha_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Close();
        }
    }
}
