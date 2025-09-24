using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int numero = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }
            for (int i = numero - 1; i >= 1; i--)
            {
                Console.Write(i + " x ");
            }
            Console.WriteLine("1 = " + factorial);

            Console.WriteLine("El factorial de " + numero + " es: " + factorial);
            Console.ReadKey(); //Para ver el resultado antes de que se cierre la consola
        }
    }
}
