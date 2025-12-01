using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intento_de_solucion
{
    public partial class FormRegistro : Form
    {
        private Form2 paginaInicio;  // referencia al formulario inicial

        public FormRegistro(Form2 pagInicio)
        {
            InitializeComponent();
            this.paginaInicio = pagInicio;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContra.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmar.Text))
            {
                MessageBox.Show("Rellene todos los campos primero", "Aun no has terminado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que teléfono sean solo números
            if (!int.TryParse(txtTelefono.Text, out _))
            {
                MessageBox.Show("En Telefono no se aceptan otra cosa más que números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar coincidencia de contraseñas
            if (txtContra.Text != txtConfirmar.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear carpeta Users si no existe
            string usersDir = Path.Combine(Application.StartupPath, "Users");
            if (!Directory.Exists(usersDir))
                Directory.CreateDirectory(usersDir);

            // Archivo por usuario
            string userFile = Path.Combine(usersDir, $"{txtUsuario.Text}.txt");

            // Verificar si ya existe un usuario con ese nombre
            if (File.Exists(userFile))
            {
                MessageBox.Show("Este usuario ya existe, elija otro nombre de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Guardar datos
            using (StreamWriter sw = new StreamWriter(userFile))
            {
                sw.WriteLine($"Nombre={txtNombre.Text}");
                sw.WriteLine($"Apellido={txtApellido.Text}");
                sw.WriteLine($"Correo={txtCorreo.Text}");
                sw.WriteLine($"Telefono={txtTelefono.Text}");
                sw.WriteLine($"Usuario={txtUsuario.Text}");
                sw.WriteLine($"Contrasena={txtContra.Text}");
            }

            MessageBox.Show("Cuenta creada exitosamente", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Regresar al Form2
            Form2 f = new Form2();
            f.Show();
            this.Close();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            paginaInicio.Show();
            this.Close();
        }

        private void AtrasFlecha_Click(object sender, EventArgs e)
        {
            paginaInicio.Show();
            this.Close();
        }
    }
}
