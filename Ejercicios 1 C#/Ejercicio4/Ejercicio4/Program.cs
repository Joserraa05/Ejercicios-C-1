using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int l;

            Console.WriteLine("Introduce la medida de un lado del cuadrado: ");
            l = int.Parse(Console.ReadLine());

            Console.WriteLine("El perímetro del cuadrado es: " + (l * 4));
        }
    }
}
