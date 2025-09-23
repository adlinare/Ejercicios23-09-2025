using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double precioHamburguesa = 5.50;
            const double precioPapas = 3.00;
            const double precioBebida = 2.00;
            Console.WriteLine("Introduzca la cantidad de hamburguesas:");
            int ham = OpcionesProcesadas();
            Console.WriteLine("Introduzca la cantidad de papas:");
            int pap = OpcionesProcesadas();
            Console.WriteLine("Introduzca la cantidad de bebidas:");
            int beb = OpcionesProcesadas();
            double total = (ham * precioHamburguesa) + (pap * precioPapas) + (beb * precioBebida);
            Console.WriteLine("El total a pagar es: " + total);
        }
        public static int OpcionesProcesadas()
        {
            string valorDeLectura = Console.ReadLine();
            //Convertir a numero
            int opcion = 0;
            bool error = false;
            for (int i = 0; i < valorDeLectura.Length; i++)
            {
                if (valorDeLectura[i] <= '0' || valorDeLectura[i] >= '9')
                    error = true;
            }
            if (error == false)
                opcion = Convert.ToInt32(valorDeLectura);
            return opcion;
        }
    }
}
