using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la uri:");
            string mensaje = Console.ReadLine();
            if (comprobarwww(mensaje))
            {
                Console.WriteLine("La uri es correcta "+ comprobarwww(mensaje));
            }
            else
            {
                Console.WriteLine("La uri es incorrecta " + comprobarwww(mensaje));
            }
        }
        static bool comprobarwww(string mensaje)
        {
            if (mensaje.Length < 4)
            {
                return false;
            }
            else
            {
                if (mensaje.Substring(0, 3) == "www")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
