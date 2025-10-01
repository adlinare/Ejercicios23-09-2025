using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_5
{
    public class Juego
    {
        public int vidas;

        public Juego(int vidas)
        {
            this.vidas = vidas;
        }

        public void mostrarVidas()
        {
            Console.WriteLine($"Vidas restantes: {vidas}");
        }


        static void Main(string[] args)
        {
            Juego juego = new Juego(5);
            juego.mostrarVidas();
            juego.vidas -= 1;
            juego.mostrarVidas();
            Juego juego2 = new Juego(5);
            juego2.mostrarVidas();
            juego.mostrarVidas();
            Console.ReadKey();
        }
    }
}
