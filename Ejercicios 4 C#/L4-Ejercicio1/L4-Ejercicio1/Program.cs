using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta c = new Cuenta("pepe");

            c.Ingresar(-100);
            Console.WriteLine(c.ToString());
            c.Ingresar(1000);
            Console.WriteLine(c.ToString());
            c.Retirar(500);
            Console.WriteLine(c.ToString());
            c.Retirar(1000);
            Console.WriteLine(c.ToString());
        }
    }
}
