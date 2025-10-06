using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Juego j = new Juego(5);

            j.MuestraVidasRestantes();

            j.setVidas(j.getVidas() - 1);

            Juego i = new Juego(5);
            i.MuestraVidasRestantes();
            j.MuestraVidasRestantes();
        }
    }
}
