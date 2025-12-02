using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF10_Ejercicio4
{
    internal class Empleado
    {
        private String nombre;
        private double salarioSinExtras;
        private int numHorasExtra;

        public Empleado(String nombre, double salarioSinExtras)
        {
            this.nombre = nombre;
            this.salarioSinExtras = salarioSinExtras;
            this.numHorasExtra = 0;
        }

        public string Nombre { get => nombre; set => nombre=value; }
        public double SalarioSinExtras { get => salarioSinExtras; set => salarioSinExtras=value; }
        public int NumHorasExtra { get => numHorasExtra; set => numHorasExtra=value; }

        public void HaceHoraExtra(int num)
        {
            if (num < 1)
            {
                Console.WriteLine("Número de horas extras introducidas no válido, volviendo al menú...");
            }
            else numHorasExtra += num;
        }

        public double CalcularSalarioTotal()
        {
            return salarioSinExtras + 25 * numHorasExtra;
        }
    }
}