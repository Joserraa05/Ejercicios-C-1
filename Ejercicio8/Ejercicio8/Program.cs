using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double examen, trabajo, actitud;

            Console.WriteLine("Introduce la primera nota de examen: ");
            double ex1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la segunda nota de examen: ");
            double ex2 = double.Parse(Console.ReadLine());

            examen = ((ex1 + ex2) / 2);

            Console.WriteLine("Introduce la nota de los trabajos de clase: ");
            trabajo = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la nota de actitud: ");
            actitud = double.Parse(Console.ReadLine());

            double notaFinal = (examen * 0.5) + (trabajo * 0.3) + (actitud * 0.2);

            Console.WriteLine("La nota final de el módulo es: " + notaFinal);

        }
    }
}
