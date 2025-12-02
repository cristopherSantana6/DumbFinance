using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
