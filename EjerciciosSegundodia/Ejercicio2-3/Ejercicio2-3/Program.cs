using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Introduce una cadena de texto");
            String cadena = Console.ReadLine();
            Console.WriteLine("Longitud de la cadena: " + cadena.Length);
            Console.WriteLine("Introduce una subcadena a buscar");
            String subcadena = Console.ReadLine();
            if (cadena.Contains(subcadena))
            {
                Console.WriteLine("La cadena contiene la subcadena");
            }
            else
            {
                Console.WriteLine("La cadena no contiene la subcadena");
            }
            Console.WriteLine("Introduce la letra a reemplazar");
            char letra1 = Console.ReadLine()[0];
            Console.WriteLine("Introduce la letra por la que reemplazar");
            char letra2 = Console.ReadLine()[0];
            cadena = cadena.Replace(letra1, letra2);
            Console.WriteLine("Cadena con letras reemplazadas: " + cadena);
            Console.WriteLine("Cadena en mayúsculas: " + cadena.ToUpper());
            Console.WriteLine("Cadena en minúsculas: " + cadena.ToLower());
            Console.WriteLine("Introduce la posición del carácter a eliminar (0 a " + (cadena.Length - 1) + ") en: "+cadena);
            int posicion = int.Parse(Console.ReadLine());
            Console.WriteLine("Cadena con carácter eliminado: " + cadena.Remove(posicion, 1));
            Console.WriteLine("Introduce la posición inicial para extraer una subcadena (0 a " + (cadena.Length - 1) + ") de: "+cadena);
            int posicionInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la longitud de la subcadena a extraer para :"+cadena);
            int longitud = int.Parse(Console.ReadLine());
            Console.WriteLine("Subcadena extraída: " + cadena.Substring(posicionInicial, longitud));
        }
    }
}
