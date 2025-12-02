using System;
using System.IO;
using System.Windows.Forms;

namespace intento_de_solucion
{
    public partial class Form11 : Form
    {
        private Form2 paginaInicio;

        public Form11()
        {
            InitializeComponent();
        }

        public Form11(Form2 pagInicio)
        {
            InitializeComponent();
            this.paginaInicio = pagInicio;
        }

        private void AtrasFecha_Click(object sender, EventArgs e)
        {
            paginaInicio?.Show();
            this.Hide();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            string usersDir = Path.Combine(Application.StartupPath, "Users");
            string userFile = Path.Combine(usersDir, $"{UserSession.Username}.txt");

            if (!File.Exists(userFile))
            {
                MessageBox.Show("No se encontraron gastos registrados.");
                return;
            }

            string[] lines = File.ReadAllLines(userFile);

            string monto = "";
            string fecha = "";
            string moneda = "";
            string categoria = "";

            foreach (string line in lines)
            {
                if (line.StartsWith("[Gasto]"))
                {
                    monto = fecha = moneda = categoria = "";
                }
                else if (line.StartsWith("Monto="))
                    monto = line.Replace("Monto=", "");
                else if (line.StartsWith("Fecha="))
                    fecha = line.Replace("Fecha=", "");
                else if (line.StartsWith("Moneda="))
                    moneda = line.Replace("Moneda=", "");
                else if (line.StartsWith("Categoria="))
                    categoria = line.Replace("Categoria=", "");
                else if (line.Trim() == "")
                {
                    if (monto != "" && fecha != "" && moneda != "" && categoria != "")
                    {
                        dataGridView1.Rows.Add(monto, fecha, moneda, categoria);
                    }
                }
            }
        }
    }
}
