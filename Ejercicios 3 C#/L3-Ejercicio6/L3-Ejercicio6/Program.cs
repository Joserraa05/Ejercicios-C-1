using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String user, password;
            int cont = 3;

            while (cont > 0)
            {
                Console.Write("Introduce el usuario: ");
                user = Console.ReadLine();
                Console.Write("Introduce la contraseña: ");
                password = Console.ReadLine();

                if (ControlarLogin(user, password))
                {
                    Console.WriteLine("Login correcto, accediendo al sistema... ");
                    break;
                }
                else
                {
                    cont--;
                    Console.WriteLine("Login incorrecto, quedan " + cont + " intentos.");
                }
            }
        }
        static bool ControlarLogin(String user, String password)
        {
            if (user.Equals("usuario2DAM") && password.Equals("pass2DAM")) return true;
            else return false;
        }
    }
}
