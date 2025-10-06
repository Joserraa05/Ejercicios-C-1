using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contacto c1 = new Contacto("Pepe", 123456789);
            Contacto c2 = new Contacto("Paco", 987654321);
            Contacto c3 = new Contacto("Luis", 135792468);
            Contacto c4 = new Contacto("Javi", 246813579);
            Contacto c5 = new Contacto("Pepe", 975318642);
            Contacto c6 = new Contacto("Joni", 864297531);

            Agenda a = new Agenda();

            a.contactoAdd(c1);
            a.contactoAdd(c2);
            a.contactoAdd(c3);
            a.contactoAdd(c4);
            a.contactoAdd(c5);

            a.contactoList();

            a.contactoFind("Paco");

            a.contactoRemove(c1);
            a.contactoRemove(c6);
        }
    }
}
