using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer numero para saber si son multiplos:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo numero para saber si son multiplos:");
            int num2 = int.Parse(Console.ReadLine());
            if (SonMultiplos(num1, num2))
            {
                Console.WriteLine($"El numero {num1} es multiplo del {num2}");
            }
            else if (SonMultiplos(num2, num1))
            {
                Console.WriteLine($"El numero {num2} es multiplo del {num1}");
            }
            else
            {
                Console.WriteLine($"El numero {num1} y {num2} no son multiplos");
            }
        }
        public static bool SonMultiplos(int num1, int num2)
        {
            if (num1 % num2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
