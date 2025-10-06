using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_Ejercicio5
{
    internal class Juego
    {
        int vidas;

        public Juego(int vidas)
        {
            this.vidas = vidas;
        }

        public void MuestraVidasRestantes()
        {
            Console.WriteLine("Vidas restantes: " + vidas);
        }

        public void setVidas(int v)
        {
            vidas = v;
        }

        public int getVidas()
        {
            return vidas;
        }
    }
}
