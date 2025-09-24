using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numeros = new Stack<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Introduce un número por teclado: ");
                int num = int.Parse(Console.ReadLine());

                numeros.Push(num);
            }

            Console.Write("Mostramos todos los números introducidos: ");
            foreach (int i in numeros)
            {
                Console.Write(i + " ");
            }

            numeros.Pop();
            numeros.Pop();
            Console.Write("\nMostramos todos los números excepto los dos últimos: ");
            foreach (int i in numeros)
            {
                Console.Write(i + " ");
            }
        }
    }
}
