using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una cadena de texto por teclado para hacer distintas acciones: ");
            String cadena = Console.ReadLine();

            Console.WriteLine("La longitud de la cadena es: " + cadena.Length);
            Console.WriteLine("La cadena contiene HOLA: " + cadena.Contains("HOLA"));
            Console.WriteLine("Reemplazamos las [a] de la cadena por [4]: " + cadena.Replace("a", "4"));
            Console.WriteLine("Convertimos toda la cadena a mayúsculas: " + cadena.ToUpper());
            Console.WriteLine("Convertimos toda la cadena a minúsculas: " + cadena.ToLower());
            Console.WriteLine("Eliminamos el carácter en la posición 2: " + cadena.Remove(2, 1));
            Console.WriteLine("Obtenemos la cadena desde la posición 3 a la 5: " + cadena.Substring(3, 3));
        }
    }
}
