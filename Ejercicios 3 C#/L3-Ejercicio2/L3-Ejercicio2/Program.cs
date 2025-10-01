using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace L3_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String cadena;
            Console.WriteLine("Introduce una frase para contar el número de espacios que contiene: ");
            cadena = Console.ReadLine();

            Console.WriteLine("El número de espacios que contiene la cadena introducida es de: " + ContarEspacio(cadena));
            
        }
        static int ContarEspacio(String s)
        {
            int cont = 0;
            foreach (var item in s)
            {
                if (item.Equals(' '))
                {
                    cont++;
                }
            }
        return cont; }
    }
}
