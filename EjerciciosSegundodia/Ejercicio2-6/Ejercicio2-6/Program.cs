using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El numero random entre 10 y 30 es: " + new Random().Next(10, 31));
        }
    }
}
