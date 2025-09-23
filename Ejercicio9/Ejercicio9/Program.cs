using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduce una frase, se comprobará si es un enlace o no");
            String enlace = Console.ReadLine();

            if (enlace.StartsWith("www"))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
