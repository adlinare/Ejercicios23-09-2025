using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_10
{
    public class Cliente
    {
        private string Nombre;
        private double catidadTotal;

        public Cliente(string nombre)
        {
           Nombre = nombre;
           catidadTotal = 0;

        }
        public void Ingresar(double cantidad)
        {
            if (cantidad > 0)
            {
                catidadTotal += cantidad;
            }
        }
        public void Sacar(double cantidad)
        {
            if (cantidad > 0 && cantidad <= catidadTotal)
            {
                catidadTotal -= cantidad;
            }
        }
        public double GetCantidadTotal()
        {
            return catidadTotal;
        }
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Cantidad Total: {catidadTotal}");
        }

    }
    public class Banco 
    { 
        private List<Cliente> clientes;
        public Banco(string name)
        {
            clientes = new List<Cliente>();
            clientes.Add(new Cliente(name));
            clientes.Add(new Cliente("María"));
            clientes.Add(new Cliente("Pedro"));
        }

        public void Operar()
        {
            clientes[0].Ingresar(1000);
            clientes[1].Ingresar(500);
            clientes[2].Ingresar(2000);
            clientes[0].Sacar(200);
            clientes[1].Sacar(100);
            clientes[2].Sacar(500);
        }

        public void ObtenerEstado()
        {
            double total = 0;
            foreach (var cliente in clientes)
            {
                total += cliente.GetCantidadTotal();
            }
            Console.WriteLine($"Cantidad total en el banco: {total}");
            foreach (var cliente in clientes)
            {
                cliente.MostrarInformacion();
            }
        }
        static void Main(string[] args)
        {
            Banco banco = new Banco("Juan");
            banco.Operar();
            banco.ObtenerEstado();
        }

    }
}
