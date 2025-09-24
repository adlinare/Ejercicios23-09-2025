using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            numeros[0] = 5;
            numeros[1] = 8;
            numeros[2] = 12;
            numeros[3] = 3;
            numeros[4] = 7;
            numeros[5] = 9;
            numeros[6] = 1;
            numeros[7] = 4;
            numeros[8] = 6;
            numeros[9] = 10;

            System.Array.Sort(numeros);
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
