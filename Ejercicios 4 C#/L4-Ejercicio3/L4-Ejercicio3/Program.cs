using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cancion c1 = new Cancion("Vista al mar", "Quevedo");
            Cancion c2 = new Cancion();

            Console.WriteLine("El título de la cación es: " + c1.getTitulo() + " y su autor es: " + c1.getAutor());

            c2.setAutor("Paco");
            c2.setTitulo("Las lágrimas de un chorizo");

            Console.WriteLine("El título de la cación es: " + c2.getTitulo() + " y su autor es: " + c2.getAutor());
        }
    }
}
