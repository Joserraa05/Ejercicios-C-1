using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace L2_Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un número para calcular su factorial: ");
            int num = int.Parse(Console.ReadLine());

            for (int i=num-1; i>1; i--)
            {
                num *= i;
            }

            Console.WriteLine("El factorial del número introducido es: " + num);
        }
    }
}
