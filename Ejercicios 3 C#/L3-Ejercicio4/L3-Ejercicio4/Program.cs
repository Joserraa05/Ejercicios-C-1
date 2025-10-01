using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace L3_Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un número por teclado para comprobar si es primo o no: ");
            int num = int.Parse(Console.ReadLine());

            if (EsPrimo(num)) Console.WriteLine("El número " + num + " no es primo");
            else Console.WriteLine("El número " + num + " es primo");
        }
        static bool EsPrimo(int num)
        {
            for (int i=2; i<num; i++)
            {
                if (num % i == 0) return true;
                else return false;
            }
            return false;
        }
    }
}
