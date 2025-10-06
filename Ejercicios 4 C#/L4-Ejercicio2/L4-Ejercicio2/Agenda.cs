using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace L4_Ejercicio2
{
    internal class Agenda
    {
        protected List<Contacto> cList;

        public Agenda() { 
            this.cList = new List<Contacto>();
        }

        public void contactoAdd(Contacto c)
        {
            if (!contactoExists(c)) cList.Add(c);
            else Console.WriteLine("El contacto no se puede almacenar porque el nombre está repetido...");
        }

        public bool contactoExists(Contacto c)
        {
            foreach (Contacto cGuardado in cList)
            {
                if (cGuardado.getNombre().Equals(c.getNombre())) return true;
                else return false;
            }
            return false;
        }

        public void contactoList()
        {
            foreach (Contacto c in cList)
            {
                Console.WriteLine("- Nombre: " + c.getNombre() + " Teléfono: " + c.getTlf());
            }
        }

        public void contactoFind(String nombre)
        {
            foreach (Contacto c in cList)
            {
                if (contactoExists(c))
                {
                    Console.WriteLine("Busqueda exitosa, el teléfono de " + c.getNombre() + " es: " + c.getTlf());
                    break;
                }
            }
            Console.WriteLine("No se ha encontrado el contacto...");
        }

        public void contactoRemove(Contacto c)
        {
            if (contactoExists(c)) {
                cList.Remove(c);
                contactoList();
            } 
            else Console.WriteLine("No se ha encontrado el contacto para eliminar...");
        }
    }
}
