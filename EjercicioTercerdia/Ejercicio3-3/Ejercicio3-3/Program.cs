using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero para calcular su factorial:");
            int numero = int.Parse(Console.ReadLine());
            if (numero > 0)
            {
                int resultado = factorial(numero);
                Console.WriteLine($"El factorial de {numero} es {resultado}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El numero debe ser positivo");
                Console.ReadKey();
            }
        }
        static int factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n * factorial(n - 1);
        }
    }
}
