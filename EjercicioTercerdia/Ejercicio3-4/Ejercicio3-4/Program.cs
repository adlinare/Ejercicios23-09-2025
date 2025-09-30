using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingre el numero para comprobar si es primo:");
            int numero = int.Parse(Console.ReadLine());
            if (EsPrimo(numero))
            {
                Console.WriteLine("El numero es primo");
            }
            else
            {
                Console.WriteLine("El numero no es primo");
            }
        }
        static bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }
    }
}
