using System;
using System.IO;
using System.Windows.Forms;

namespace intento_de_solucion
{
    public partial class Form12 : Form
    {
        private Form2 paginaInicio;

        public Form12(Form2 pagInicio)
        {
            InitializeComponent();
            paginaInicio = pagInicio;
        }

        private void AtrasFecha_Click(object sender, EventArgs e)
        {
            paginaInicio?.Show();
            this.Hide();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            string usersDir = Path.Combine(Application.StartupPath, "Users");
            string file = Path.Combine(usersDir, $"{UserSession.Username}.txt");

            if (!File.Exists(file))
            {
                MessageBox.Show("No hay proyecciones guardadas.");
                return;
            }

            string actual = "", nuevo = "", tipo = "", moneda = "";

            foreach (var line in File.ReadAllLines(file))
            {
                if (line.StartsWith("[Proyeccion]"))
                {
                    actual = nuevo = tipo = moneda = "";
                }
                else if (line.StartsWith("Actual="))
                    actual = line.Replace("Actual=", "");
                else if (line.StartsWith("Nuevo="))
                    nuevo = line.Replace("Nuevo=", "");
                else if (line.StartsWith("Tipo="))
                    tipo = line.Replace("Tipo=", "");
                else if (line.StartsWith("Moneda="))
                    moneda = line.Replace("Moneda=", "");
                else if (line.Trim() == "")
                {
                    if (actual != "" && nuevo != "" && tipo != "" && moneda != "")
                    {
                        dataGridView1.Rows.Add(actual, nuevo, tipo, moneda);
                    }
                }
            }
        }
    }
}
