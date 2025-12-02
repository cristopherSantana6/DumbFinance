using System;
using System.IO;
using System.Windows.Forms;

namespace intento_de_solucion
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Vacío, solo para que el diseñador esté contento
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // No hace nada (puedes dejarlo vacío)
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // No hace nada
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuarioLogin.Text;
            string contra = txtContraLogin.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contra))
            {
                MessageBox.Show("Ingrese usuario y contraseña", "Error en campos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string usersDir = Path.Combine(Application.StartupPath, "Users");
            string userFile = Path.Combine(usersDir, $"{usuario}.txt");

            if (!File.Exists(userFile))
            {
                MessageBox.Show("Cuenta no encontrada", "Error de autenticación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] lines = File.ReadAllLines(userFile);

            string usuarioGuardado = "";
            string contrasenaGuardada = "";

            foreach (string line in lines)
            {
                if (line.StartsWith("Usuario="))
                    usuarioGuardado = line.Replace("Usuario=", "");

                if (line.StartsWith("Contrasena="))
                    contrasenaGuardada = line.Replace("Contrasena=", "");
            }

            if (usuario == usuarioGuardado && contra == contrasenaGuardada)
            {
                UserSession.IsLogged = true;
                UserSession.Username = usuario;

                FormUser f = new FormUser(usuario);
                f.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de autenticación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void atras_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Close();
        }
    }
}
