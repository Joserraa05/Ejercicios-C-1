using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lista = { 4, 7, 5, 9, 6, 3, 8, 1, 0, 2 };

            System.Array.Sort(lista);
            Console.WriteLine("Lista ordenada: ");

            for (int i=0; i<10; i++)
            {
                Console.Write(lista[i] + " ");
            }
        }
    }
}
