using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double num1, num2, num3, num4;

            Console.WriteLine("Introduce un número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce otro número: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce otro número: ");
            num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce otro número para realizar la suma y el promedio de todos: ");
            num4 = double.Parse(Console.ReadLine());

            double suma = num1 + num2 + num3 + num4;

            Console.WriteLine("La suma de todos los números es: " + suma);
            Console.WriteLine("El promedio de todos los números es: " + (suma / 4));
        }
    }
}
