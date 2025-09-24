using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce la longitud que quieres que tenga la lista de números: ");
            int l = int.Parse(Console.ReadLine());

            if (l > 0)
            {
                int[] lista = new int[l];

                for (int i = 0; i<l; i++)
                {
                    Console.Write("Introduce el número para escribir en la posición " + i + ": ");
                    lista[i] = int.Parse(Console.ReadLine());
                }

                for (int j = 0; j<l; j++)
                {
                    if (lista[j] % 2 == 0)
                    {
                        Console.WriteLine("El número " + lista[j] + " que está en la posición " + j + " es PAR");
                    }
                    else
                    {
                        Console.WriteLine("El número " + lista[j] + " que está en la posición " + j + " es IMPAR");
                    }
                }
            }
            else
            {
                Console.WriteLine("La longitud debe ser mayor a 0, saliendo del programa...");
            }
        }
    }
}
