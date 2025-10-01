using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double precioH = 3;
            const double precioP = 2;
            const double precioB = 1;
            int hamburguesas, patatas, bebidas;

            Console.Write("Escribe el número de hamburguesas que se han consumido: ");
            hamburguesas = int.Parse(Console.ReadLine());
            Console.Write("\nEscribe el número de patatas que se han consumido: ");
            patatas = int.Parse(Console.ReadLine());
            Console.Write("\nEscribe el número de bebidas que se han consumido: ");
            bebidas = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEl precio total a pagar es de: " + ((hamburguesas * precioH) + (patatas * precioP) + (bebidas * precioB)));
        
        }
    }
}
