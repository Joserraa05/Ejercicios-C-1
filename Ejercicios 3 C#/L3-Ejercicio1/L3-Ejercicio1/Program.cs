using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            double media = 0;

            Console.WriteLine("Introduce el tamaño de un array de enteros: ");
            int[] lista = new int[int.Parse(Console.ReadLine())];

            foreach (int i in lista)
            {
                Console.WriteLine("Introduce el número de la posición " + i + ": ");
                lista[i] = int.Parse(Console.ReadLine());
                suma += lista[i];
            }
            media = suma / lista.Length;

            Console.WriteLine("La suma de todos los números es: " + suma);
            Console.WriteLine("La media de todos los números es: " + media);
        }
    }
}
