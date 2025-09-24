using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero del 1 al 9:");
            int numero = int.Parse(Console.ReadLine());
            if (numero > 0 && numero < 10)
            {
                Console.WriteLine("1x"+numero+"="+ (numero * 1));
                Console.WriteLine("2x" + numero + "=" + (numero * 2));
                Console.WriteLine("3x" + numero + "=" + (numero * 3));
                Console.WriteLine("4x" + numero + "=" + (numero * 4));
                Console.WriteLine("5x" + numero + "=" + (numero * 5));
                Console.WriteLine("6x" + numero + "=" + (numero * 6));
                Console.WriteLine("7x" + numero + "=" + (numero * 7));
                Console.WriteLine("8x" + numero + "=" + (numero * 8));
                Console.WriteLine("9x" + numero + "=" + (numero * 9));
                Console.WriteLine("10x" + numero + "=" + (numero * 10));
            }
            else
            {
                Console.WriteLine("El numero no es valido");
            }
        }
    }
}
