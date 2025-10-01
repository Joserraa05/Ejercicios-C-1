using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace L3_Ejercicio10
{
    class Cliente
    {
        String nombre;
        double cantidadTotal;

        public Cliente(String nombre)
        {
            this.nombre = nombre;
            this.cantidadTotal = 0;
        }
        public void Ingresar(double cantidad)
        {
            if (cantidad > 0)
            {
                cantidadTotal += cantidad;
            }
            else
            {
                Console.WriteLine("La cantidad a ingresar debe ser mayor que 0.");
            }
        }
        public void Retirar(double cantidad)
        {
            if (cantidad > cantidadTotal || cantidad < 0)
            {
                cantidadTotal -= cantidad;
            }
            else
            {
                Console.WriteLine("Error al retirar, cantidad no válida");
            }
        }
        public double GetCantidadTotal()
        {
            return cantidadTotal;
        }
        public String GetNombre()
        {
            return nombre;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("El cliente " + nombre + " tiene " + cantidadTotal + "$ en la cuenta.");
        }
    }
    class Banco
    {
        Cliente cliente1;
        Cliente cliente2;
        Cliente cliente3;
        public Banco(string nombre1, String nombre2, String nombre3)
        {
            this.cliente1 = new Cliente(nombre1);
            this.cliente2 = new Cliente(nombre2);
            this.cliente3 = new Cliente(nombre3);
        }
        public void Operar()
        {
            cliente1.Ingresar(1000);
            cliente2.Ingresar(2000);
            cliente3.Ingresar(3000);
        }
        public void ObtenerEstado()
        {
            Console.WriteLine("El total ingresado por los tres clientes es: " + (cliente1.GetCantidadTotal() + cliente2.GetCantidadTotal() + cliente3.GetCantidadTotal()) + "$.");
            Console.WriteLine("El cliente " + cliente1.GetNombre() + " ha ingresado: " + cliente1.GetCantidadTotal() + "$.");
            Console.WriteLine("El cliente " + cliente2.GetNombre() + " ha ingresado: " + cliente2.GetCantidadTotal() + "$.");
            Console.WriteLine("El cliente " + cliente3.GetNombre() + " ha ingresado: " + cliente3.GetCantidadTotal() + "$.");
        }
    }   
    internal class Program
    {
        static void Main(string[] args)
        {
            Banco b = new Banco("pepe", "luis", "paco");

            b.Operar();
            b.ObtenerEstado();
        }
    }
}
