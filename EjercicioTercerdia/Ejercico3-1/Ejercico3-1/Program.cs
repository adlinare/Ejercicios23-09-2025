using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el tamaño del array");
            int tamaño = int.Parse(Console.ReadLine());
            int[] array = new int[tamaño];
            Console.WriteLine("Introduce los valores del array");
            for (int i = 0; i < tamaño; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Los valores del array son:");
            for (int i = 0; i < tamaño; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("La media es: " + array.Average());
            Console.WriteLine("La suma es: " + array.Sum());
        }
    }
}
