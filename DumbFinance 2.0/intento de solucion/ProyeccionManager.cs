using System;
using System.IO;
using System.Windows.Forms;

namespace intento_de_solucion
{
    public static class ProyeccionManager
    {
        private static string GetUserFile()
        {
            string usersDir = Path.Combine(Application.StartupPath, "Users");
            return Path.Combine(usersDir, $"{UserSession.Username}.txt");
        }

        public static void GuardarProyeccion(
            string actual,
            string nuevo,
            string tipo,
            string moneda)
        {
            string file = GetUserFile();

            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLine("[Proyeccion]");
                sw.WriteLine("Actual=" + actual);
                sw.WriteLine("Nuevo=" + nuevo);
                sw.WriteLine("Tipo=" + tipo);
                sw.WriteLine("Moneda=" + moneda);
                sw.WriteLine("");
            }
        }
    }
}
