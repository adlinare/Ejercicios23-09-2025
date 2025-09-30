using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_5b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el exponente: ");
            int exponente = int.Parse(Console.ReadLine());
            int resultado = calcularExponente(numero, exponente, 1);
            Console.WriteLine($"{numero} elevado a la {exponente} es igual a {resultado}");
            Console.ReadKey();

        }
        static int calcularExponente(int numero, int exponente, int resultado)
        {
            if (exponente == 0)
            {
                return resultado;
            }
            else
            {
                resultado = resultado * numero;
                return calcularExponente(numero, exponente - 1, resultado);
            }
        }
    }
}
