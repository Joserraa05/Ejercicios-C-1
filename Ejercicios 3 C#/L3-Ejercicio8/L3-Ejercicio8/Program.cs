using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un número para calcular la suma de sus dígitos: ");
            int num = int.Parse(Console.ReadLine());

            SumaDeDigitos(num);
        }

        static void SumaDeDigitos(int num)
        {
            int suma = 0;

            for (int i=num; i>0; i/=10)
            {
                suma += i%10;
            }
            Console.WriteLine("La suma de los dígitos es " + suma);
        }
    }
}
