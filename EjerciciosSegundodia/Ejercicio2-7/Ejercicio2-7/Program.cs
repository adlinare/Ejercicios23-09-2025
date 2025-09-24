using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tamaño del array:");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Ingrese el elemento {i + 1}:");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i  < size; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine($"El elemento {array[i]} es par.");
                }
                else
                {
                    Console.WriteLine($"El elemento {array[i]} es impar.");
                }
            }
        }
    }
}
