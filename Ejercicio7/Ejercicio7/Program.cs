using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca la nota del primer examen");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca la nota del segundo examen");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            double media = (nota1 + nota2) / 2;
            Console.WriteLine("Introduzca la nota d elos trabajos de clase");
            double notaTrabajos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce la nota de la actitud");
            double notaActitud = Convert.ToDouble(Console.ReadLine());
            double notaFinal = media * 0.5 + notaTrabajos * 0.3 + notaActitud * 0.2;
            Console.WriteLine("La nota final es: " + notaFinal);
        }
    }
}
