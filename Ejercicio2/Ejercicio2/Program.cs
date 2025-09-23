using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            string ni = Console.ReadLine();
            double n = Convert.ToDouble(ni);
            Console.WriteLine("El valor absoluto es: " + Math.Abs(n));
            Console.WriteLine("El valor al cubo es: " + Math.Pow(n, 3));
            Console.WriteLine("La raiz cuadrada es: " + Math.Sqrt(n));
            Console.WriteLine("El seno es: " + Math.Sin(n));
            Console.WriteLine("El coseno es: " + Math.Cos(n));
            Console.WriteLine("El valor maximo es: "+ Math.Max(n,23));
            Console.WriteLine("El valor minimo es: " + Math.Min(n, 23));
        }
       
    }
}
        