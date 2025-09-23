using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numeor 1/4");
            string opcion =  Console.ReadLine();
            Console.WriteLine("Ingrese el numero 2/4");
            string opcion2 = Console.ReadLine();
            Console.WriteLine("Ingrese el numero 3/4");
            string opcion3 = Console.ReadLine();
            Console.WriteLine("Ingrese el numero 4/4");
            string opcion4 = Console.ReadLine();

            double num1 = double.Parse(opcion);
            double num2 = double.Parse(opcion2);
            double num3 = double.Parse(opcion3);
            double num4 = double.Parse(opcion4);

            double suma = num1 + num2 + num3 + num4;
            double producto = num1 * num2 * num3 * num4;
            Console.WriteLine("El resultado de la suma es: " + suma);
            Console.WriteLine("El resultado del producto es: " + producto);
        }
    }
}
