using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lista = { 5, 35, 6, 5, 3, 2, 1, -9, 2, 56, 87, 8 };
            Console.WriteLine(" El número menor de la lista es: " + PosicionMinimo(lista));
        }

        static int PosicionMinimo(int[] lista)
        {
            int min = lista[0];

            foreach (int i in lista)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }
    }
}
