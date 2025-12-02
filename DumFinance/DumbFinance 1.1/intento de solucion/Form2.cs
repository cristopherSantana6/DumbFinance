using System;
using System.Windows.Forms;

namespace intento_de_solucion
{
    public partial class Form2 : Form
    {

        public Form2()
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
            if (!UserSession.IsLogged)
            {
                // 🔒 Estado sin sesión

                menuStrip1.Enabled = false;

                IniSe.Enabled = true;
                IniSe.Visible = true;

                RegUsu.Enabled = true;
                RegUsu.Visible = true;

                cerrarsesion.Visible = false;
                cerrarsesion.Enabled = false;
            }
            else
            {
                // 🔓 Estado con sesión activa

                menuStrip1.Enabled = true;

                IniSe.Enabled = false;
                IniSe.Visible = false;

                RegUsu.Enabled = false;
                RegUsu.Visible = false;

                cerrarsesion.Visible = true;
                cerrarsesion.Enabled = true;
            }
        }

        private void IniSe_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }


        private void RegUsu_Click(object sender, EventArgs e)
        {
            FormRegistro reg = new FormRegistro();
            reg.Show();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void editarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCont login = new EditCont(this);
            login.Show();
            this.Hide();
        }

        private void añadirCuentaNuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaCuen1 login = new AnaCuen1(this);
            login.Show();
            this.Hide();
        }

        private void dumbFinanceAspiraASerLaAplicaciónDeFinanzasPersonalesMásAccesibleSencillaYFiableParaEstudiantesUniversitariosSuObjetivoEsAyudarALosUsuariosATomarDecisionesFinancierasSaludablesMedianteAnálisisClarosRecordatoriosInteligentesYProyeccionesComprensiblesAlTiempoQuePromueveHábitosDeGastoResponsablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReGastoAtra regast = new ReGastoAtra(this);
            regast.Show();
            this.Hide();
        }

        private void registrarUnGastoNeuvoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegGastNew newgasto = new RegGastNew(this);
            newgasto.Show();
            this.Hide();
        }

        private void consultarGastosRealizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 consultar = new Form11(this);
            consultar.Show();
            this.Hide();
        }

        private void semanalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjusPres ajuspre = new AjusPres(this);
            ajuspre.Show();
            this.Hide();
        }

        private void mensualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjusPres ajuspre = new AjusPres(this);
            ajuspre.Show();
            this.Hide();
        }

        private void anualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjusPres ajuspre = new AjusPres(this);
            ajuspre.Show();
            this.Hide();
        }

        private void exportarEnExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporte reporte = new FormReporte(this);
            reporte.Show();
            this.Hide();
        }

        private void exportarEnPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporte reporte = new FormReporte(this);
            reporte.Show();
            this.Hide();
        }

        private void ajustarPresupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjustPresu ajuste = new AjustPresu(this);
            ajuste.Show();
            this.Hide();
        }

        private void alertasYRecordatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void corroElectronicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerUser1 perfil = new PerUser1(this);
            perfil.Show();
            this.Hide();

        }

        private void nombreDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerUser1 perfil = new PerUser1(this);
            perfil.Show();
            this.Hide();
        }

        private void númeroDeTelefonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerUser1 perfil = new PerUser1(this);
            perfil.Show();
            this.Hide();
        }

        private void nombreDeUsuarioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PerUser1 perfil = new PerUser1(this);
            perfil.Show();
            this.Hide();
        }

        private void númeroDeTelefonoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PerUser1 perfil = new PerUser1(this);
            perfil.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) // botón Cerrar sesión
        {
            UserSession.Logout();

            Form2 f = new Form2();
            f.Show();
            this.Close();
        }


    }
}
