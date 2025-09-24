using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace L2_Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int num = random.Next(10, 31);
            Console.WriteLine("El número aleatorio generado es: " + num);
        }
    }
}
