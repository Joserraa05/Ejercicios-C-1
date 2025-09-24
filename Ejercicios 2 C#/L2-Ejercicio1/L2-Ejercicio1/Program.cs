using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String estado = "";

            Console.WriteLine("Introduzca su estado civil, [C] [S] [V] [D]");
            char opc = char.Parse(Console.ReadLine());

            switch (opc)
            {
                case 'C':
                    estado = "Casado";
                    Console.WriteLine("Su estado civil es: " + estado);
                    break;

                case 'S':
                    estado = "Soltero";
                    Console.WriteLine("Su estado civil es: " + estado);
                    break;

                case 'V':
                    estado = "Viudo";
                    Console.WriteLine("Su estado civil es: " + estado);
                    break;

                case 'D':
                    estado = "Divorciado";
                    Console.WriteLine("Su estado civil es: " + estado);
                    break;

                default:
                    Console.WriteLine("La opción que has escrito no es válida, saliendo del programa...");
                    break;
            }
        }
    }
}
