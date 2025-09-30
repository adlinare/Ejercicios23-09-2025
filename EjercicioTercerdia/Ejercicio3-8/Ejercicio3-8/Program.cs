using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca los digitos que se quieren suar: ");
            string digitos = Console.ReadLine();
            Console.WriteLine("La suma es: " + sumadigitos(digitos));
        }
        static int sumadigitos(string digitos)
        {
            int suma = 0;
            for (int i = 0; i < digitos.Length; i++)
            {
                suma += int.Parse(digitos[i].ToString());
            }
            return suma;
        }
    }
}
