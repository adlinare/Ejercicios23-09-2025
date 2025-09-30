using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Introduce el usuario:");
                string usuario = Console.ReadLine();
                Console.WriteLine("Introduce la contrasena:");
                string contrasena = Console.ReadLine();
                if (inicioSesion(usuario, contrasena))
                {
                    Console.WriteLine("Inicio de sesion correcto");
                    break;
                }
                else
                {
                    Console.WriteLine("Inicio de sesion incorrecto");

                }
            }
 
        }
        static bool inicioSesion(string usuario, string contrasena)
        {
            bool resultado = false;
            if (usuario == "usuario2DAM" && contrasena == "pass2DAM")
            {
                resultado = true;
            }
            return resultado;
        }
    }
}
