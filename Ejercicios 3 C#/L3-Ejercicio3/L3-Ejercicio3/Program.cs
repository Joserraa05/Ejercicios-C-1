using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el número que desees para calcular el factorial: ");
            Console.WriteLine(CalcularFactorial(int.Parse(Console.ReadLine())));
        }
        static int CalcularFactorial(int num)
        {
            if (num == 0) return 1;
            else return num * CalcularFactorial(num-1);
        }
    }
}
