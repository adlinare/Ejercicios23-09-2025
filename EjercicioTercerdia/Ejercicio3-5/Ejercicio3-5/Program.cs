using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero de la base:");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero del exponente:");
            int exp = int.Parse(Console.ReadLine());
            int resultado = 1;
            for (int i = 0; i < exp; i++)
            {
                resultado *= baseNum;
            }
            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
