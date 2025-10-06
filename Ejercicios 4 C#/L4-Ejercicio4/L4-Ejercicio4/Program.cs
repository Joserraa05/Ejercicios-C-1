using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CD disco = new CD();

            Cancion c1 = new Cancion("Los llantos de Adrián", "Kirri");
            Cancion c2 = new Cancion("Gran noche", "Adrián");
            Cancion c3 = new Cancion("El kadjar me lo dio todo", "Kirri");
            Cancion c4 = new Cancion("Como la cerveza", "Adrián");
            Cancion c5 = new Cancion("Malegro, hermano mio", "Kirri");

            disco.agregaCancion(c1);
            disco.agregaCancion(c2);
            disco.agregaCancion(c3);
            disco.agregaCancion(c4);

            Console.WriteLine("El número de canciones en el CD son: " + disco.numeroCanciones());

            Console.WriteLine("La cacnion en la posicion 1 es: " + disco.dameCancion(1).ToString());

            Console.WriteLine("La cacnion en la posicion 3 es: " + disco.dameCancion(3).ToString());
            Console.WriteLine("Grabamos una cacion distinta en la posicion 3...");
            disco.grabaCancion(3, c5);
            Console.WriteLine("La cacnion en la posicion 3 es: " + disco.dameCancion(3).ToString());

            disco.elimina(3);
        }
    }
}
