using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una cadena de texto:");
            string input = Console.ReadLine();
            int numeroDeEspacios = contarEspacios(input);
            Console.WriteLine($"La cadena ingresada tiene {numeroDeEspacios} espacios.");
            Console.ReadKey();
        }
        static int contarEspacios(string cadena)
        {
            int contador = 0;
            foreach (char c in cadena)
            {
                if (c == ' ')
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}
