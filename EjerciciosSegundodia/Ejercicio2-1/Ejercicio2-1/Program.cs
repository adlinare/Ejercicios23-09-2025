using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu estado civil: C=Casado, S=Soltero, V=Viudo, D=Divorciado");
            char estadoCivil = Char.ToUpper(Console.ReadKey().KeyChar);
            switch (estadoCivil)
            {
                case 'C':
                    Console.WriteLine("\nTu estado civil es casado");
                    break;
                case 'S':
                    Console.WriteLine("\nTu estado civil es soltero");
                    break;
                case 'V':
                    Console.WriteLine("\nTu estado civil es viudo");
                    break;
                case 'D':
                    Console.WriteLine("\ntu estado civil es divorciado");
                    break;
                default:
                    Console.WriteLine("\nEstado civil no reconocido");
                    break;
            }
        }
    }
}
