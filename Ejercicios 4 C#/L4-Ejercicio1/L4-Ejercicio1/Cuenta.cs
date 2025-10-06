using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_Ejercicio1
{
    internal class Cuenta
    {
        private String titular;
        private double cantidad;

        public string Titular { get => titular; set => titular=value; }
        public double Cantidad { get => cantidad; set => cantidad=value; }

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public Cuenta(string titular)
        {
            this.titular = titular;
            this.cantidad = 0;
        }
        public void Ingresar(double ingreso)
        {
            if (ingreso > 0)
            {
                cantidad += ingreso;
            }
            else
            {
                Console.WriteLine("La cantidad a ingresar tiene que ser mayor que 0.");
            }
        }
        public void Retirar(double retiro)
        {
            if (retiro > 0)
            {
                cantidad -= retiro;
                if (cantidad < 0) cantidad = 0;
            }
            else
            {
                Console.WriteLine("Error, cantidad a retirar no válida.");
            }
        }

        override
        public String ToString()
        {
            return "El saldo del titular " + titular + " es: " + cantidad + "$";
        }
    }
}
