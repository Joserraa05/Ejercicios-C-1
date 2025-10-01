using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un número para calcular la potencia: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Introduce un número para calcular la : ");
            int pot = int.Parse(Console.ReadLine());

            Console.WriteLine("La potencia calculada de forma incremental es: " + CalcularPotenciaI(num, pot));
            Console.WriteLine("La potencia calculada de forma recursiva es: " + CalcularPotenciaI(num, pot));
        }
        static int CalcularPotenciaI(int num, int pot)
        {
            for (int i=1; i<pot; i++)
            {
                num *= num;
            }
            return num;
        }
        static int CalcularPotenciaR(int num, int pot)
        {
            if (pot == 0) return num;
            num = CalcularPotenciaR(num, pot-1);
            return num;
        }
    }
}
