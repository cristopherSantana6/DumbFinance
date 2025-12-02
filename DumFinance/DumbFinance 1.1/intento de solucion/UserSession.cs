using System;

namespace intento_de_solucion
{
    public static class UserSession
    {
        public static bool IsLogged { get; set; } = false;
        public static string Username { get; set; } = "";

        public static void Logout()
        {
            IsLogged = false;
            Username = "";
        }
    }
}
