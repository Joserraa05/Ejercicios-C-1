using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escribe un número por teclado: ");
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine("El valor absoluto del número " + num + " es: " + Math.Abs(num));
            Console.WriteLine("La potencia al cubo del número " + num + " es: " + Math.Pow(num, 3));
            Console.WriteLine("La raíz cuadrada del número " + num + " es: " + Math.Sqrt(num));
            Console.WriteLine("El seno del número " + num + " es: " + Math.Sin(num));
            Console.WriteLine("El coseno del número " + num + " es: " + Math.Cos(num));
            Console.WriteLine("El número máximo entre " + num + " y 5 es: " + Math.Max(num, 5));
            Console.WriteLine("El número mínimo entre " + num + " y 5 es: " + Math.Min(num, 5));
        }
    }
}
