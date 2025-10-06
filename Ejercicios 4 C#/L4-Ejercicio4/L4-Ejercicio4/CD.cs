using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_Ejercicio4
{
    internal class CD
    {
        Cancion[] canciones;
        int contador = 0;

        public CD()
        {
            this.canciones = new Cancion[10];
        }

        public int numeroCanciones()
        {
            return contador;
        }

        public Cancion dameCancion(int posicion)
        {
            return canciones[posicion];
        }

        public void grabaCancion(int posicion, Cancion c)
        {
            canciones[posicion] = c;
        }

        public void agregaCancion(Cancion c)
        {
            if (contador == 11) return;

            canciones[contador] = c;
            contador++;
        }

        public void elimina(int posicion)
        {
            canciones[posicion] = null;
        }
    }
}
