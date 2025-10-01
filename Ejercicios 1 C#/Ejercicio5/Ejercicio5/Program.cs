using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1, num2, num3, num4;

            Console.WriteLine("Introduce un número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce otro número para realizar la suma con el primero: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("La suma de los números " + num1 + " y " + num2 + " es: " + (num1 + num2));

            Console.WriteLine("Introduce otro número: ");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce otro número para realizar el producto con el anterior: ");
            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("El producto de los números " + num3 + " y " + num4 + " es: " + (num3 * num4));
        }
    }
}
