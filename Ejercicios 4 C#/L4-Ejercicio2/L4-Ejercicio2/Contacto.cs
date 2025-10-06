using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_Ejercicio2
{
    internal class Contacto
    {
        protected String nombre;
        protected int tlf;

        public Contacto(String nombre, int tlf) {
            this.nombre = nombre;
            this.tlf = tlf;
        }
        public String getNombre()
        {
            return nombre;
        }
        public int getTlf()
        {
            return tlf;
        }
    }
}
