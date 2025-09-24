using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pila = new Stack<int>();

            Console.WriteLine("Ingrese cuantos valores quiere introducir");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese un valor");
                int valor = int.Parse(Console.ReadLine());
                pila.Push(valor);
            }
            Console.WriteLine("Los valores de la pila son:");
            foreach (int valor in pila)
            {
                Console.WriteLine(valor);
            }
            Console.WriteLine("Sacando los dos primeros valores de la pila:");
            for (int i = 0; i < 2; i++)
            {
                if (pila.Count > 0)
                {
                    int valorSacado = pila.Pop();
                    Console.WriteLine("Valor sacado: " + valorSacado);
                }
                else
                {
                    Console.WriteLine("La pila está vacía, no se puede sacar más valores.");
                    break;
                }
            }
            Console.WriteLine("Los valores restantes en la pila son:");
            foreach (int valor in pila)
            {
                Console.WriteLine(valor);
            }


        }
    }
}
