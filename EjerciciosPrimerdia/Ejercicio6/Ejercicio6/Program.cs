using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el precio del producto");
            string precio = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de productos");
            string cantidad = Console.ReadLine();
            Console.WriteLine("El total es de: " + (Convert.ToDecimal(precio) * Convert.ToInt32(cantidad)));
        }
        
    }
}
