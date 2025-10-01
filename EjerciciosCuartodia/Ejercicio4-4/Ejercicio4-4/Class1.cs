using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_4
{
    internal class CD
    {
        public Cancion[] canciones;
        public int numCanciones;
        public CD()
        {
            canciones = new Cancion[10];
            numCanciones = 0;
        }
        public int numeroDeCanciones()
        {
            return numCanciones;
        }
        public Cancion dameCancion(int numCancion)
        {
            if (numCancion < 0 || numCancion >= numCanciones)
            {
                return null;
            }
            return canciones[numCancion];
        }
        public void grabaCancion(int pocision, Cancion c)
        {
            if (pocision < 0 || pocision >= canciones.Length)
            {
                Console.WriteLine("Posicion no valida");
                return;
            }
            canciones[pocision] = c;
            Console.WriteLine("Cancion grabada en la posicion " + pocision);
            if (pocision >= numCanciones)
            {
                numCanciones = pocision + 1;
            }
        }
        public void agrega(Cancion c)
        {
            if (numCanciones >= canciones.Length)
            {
                Console.WriteLine("No se pueden agregar mas canciones");
                return;
            }
            canciones[numCanciones] = c;
            numCanciones++;
            Console.WriteLine("Cancion agregada");
        }

        public void elimina(int pocision)
        {
            if (pocision < 0 || pocision >= numCanciones)
            {
                Console.WriteLine("Posicion no valida");
                return;
            }
            for (int i = pocision; i < numCanciones - 1; i++)
            {
                canciones[i] = canciones[i + 1];
            }
            canciones[numCanciones - 1] = null;
            numCanciones--;
            Console.WriteLine("Cancion eliminada");
        }
        static void Main(string[] args)
        {
            Cancion c1 = new Cancion("Song1", "Author1");
            Cancion c2 = new Cancion("Song2", "Author2");
            CD cd = new CD();
            cd.agrega(c1);
            cd.agrega(c2);
            Console.WriteLine("Numero de canciones: " + cd.numeroDeCanciones());
            for (int i = 0; i < cd.numeroDeCanciones(); i++)
            {
                Cancion c = cd.dameCancion(i);
                Console.WriteLine("Cancion " + i + ": " + c.dameTitulo() + " - " + c.dameAutor());
            }
            cd.elimina(0);
            Console.WriteLine("Numero de canciones despues de eliminar: " + cd.numeroDeCanciones());
            for (int i = 0; i < cd.numeroDeCanciones(); i++)
            {
                Cancion c = cd.dameCancion(i);
                Console.WriteLine("Cancion " + i + ": " + c.dameTitulo() + " - " + c.dameAutor());
            }


        }


    }
}
