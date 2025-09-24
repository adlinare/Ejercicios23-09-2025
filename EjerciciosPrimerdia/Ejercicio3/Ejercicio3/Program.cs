using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el valor de uno de los lados del cuadrado:");
            string lado = Console.ReadLine();
            double ladoDouble = double.Parse(lado);
            double perimetro = ladoDouble * 4;
            Console.WriteLine("El perimetro del cuadrado es: " + perimetro);
        }
       
    }
}
