using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 14, 23, 36, 444, 56, 62, 75, 85, 9, 10 };
            Console.WriteLine("El numero menor tienen la pocision: " + pocisionmenor(array) + " y tiene el valor de: " + array[pocisionmenor(array)]);


        }
        static int pocisionmenor(int[] array)
        {
            int menor = array[0];
            int pocision = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < menor)
                {
                    menor = array[i];
                    pocision = i;
                }
            }
            return pocision;
        }
    }
}
