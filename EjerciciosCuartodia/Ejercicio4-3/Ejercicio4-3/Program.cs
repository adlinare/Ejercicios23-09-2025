using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_3
{
    public class Cancion
    {
        private string titulo;
        private string autor;

        public Cancion(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
        }

        public Cancion()
        {
            this.titulo = "";
            this.autor = "";
        }

        public string dameTitulo()
        {
            return this.titulo;
        }
        public string dameAutor()
        {
            return this.autor;
        }
        public void ponTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public void ponAutor(string autor)
        {
            this.autor = autor;
        }

        static void Main(string[] args)
        {
        }
    }
}
