using System;
using System.IO;
using System.Windows.Forms;

namespace intento_de_solucion
{
    public static class GastoManager
    {
        public static void GuardarGasto(string monto, string fecha, string moneda, string categoria)
        {
            string usersDir = Path.Combine(Application.StartupPath, "Users");
            string userFile = Path.Combine(usersDir, $"{UserSession.Username}.txt");

            using (StreamWriter sw = new StreamWriter(userFile, true))
            {
                sw.WriteLine("[Gasto]");
                sw.WriteLine($"Monto={monto}");
                sw.WriteLine($"Fecha={fecha}");
                sw.WriteLine($"Moneda={moneda}");
                sw.WriteLine($"Categoria={categoria}");
                sw.WriteLine();
            }
        }
    }
}
