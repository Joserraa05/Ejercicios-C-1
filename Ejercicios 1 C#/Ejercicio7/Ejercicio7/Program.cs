using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double precio;
            int cantidad;

            Console.WriteLine("Introduce el precio del artículo comprado: ");
            precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la cantidad de artículos comprados: ");
            cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("El total del precio a pagar es: " + (precio * cantidad));
        }
    }
}
