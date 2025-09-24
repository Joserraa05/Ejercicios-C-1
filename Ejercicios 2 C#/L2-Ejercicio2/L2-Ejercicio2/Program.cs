using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un número entre 1 y 9 para mostrar la tabla de multiplicar: ");
            int num = int.Parse(Console.ReadLine());

            if (num > 0 && num < 10)
            {
                for (int i=0; i<11 ; i++)
                {
                    Console.WriteLine(num + " x " + i + " = " + num*i);
                }
            }
            else
            {
                Console.WriteLine("El número que has introducido no está entre 0 y 9");
            }
        }
    }
}
