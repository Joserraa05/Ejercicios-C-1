using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Introduce otro número y comprobaremos si alguno es múltiplo del otro: ");
            int num2 = int.Parse(Console.ReadLine());

            if (EsMultiplo(num1, num2)) Console.WriteLine("El número " + num1 + " es múltiplo de " + num2);
            else Console.WriteLine("El número " + num1 + " NO es múltiplo de " + num2);
           
            if (EsMultiplo(num2, num1)) Console.WriteLine("El número " + num2 + " es múltiplo de " + num1);
            else Console.WriteLine("El número " + num2 + " NO es múltiplo de " + num1);
        }
        static bool EsMultiplo(int num1, int num2)
        {
            if (num1 % num2 == 0) return true;
            else return false;
        }
    }
}
