using System;
using System.Windows.Forms;

namespace intento_de_solucion
{
    public partial class Misión : Form
    {
        public Misión()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Aquí va la lógica si quieres hacer algo al dar clic en label2
        }

        private void Visión_Click(object sender, EventArgs e)
        {
            // Aquí va la lógica si quieres hacer algo al dar clic en la etiqueta Visión
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Código a ejecutar al cargar el formulario
        }

        private void IniSe_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin(this); 
            login.Show();
            this.Hide();

        }

        private void RegUsu_Click(object sender, EventArgs e)
        {
            FormRegistro login = new FormRegistro(this);
            login.Show();
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
