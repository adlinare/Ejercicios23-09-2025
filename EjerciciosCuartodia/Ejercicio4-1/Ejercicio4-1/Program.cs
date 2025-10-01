using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_1
{
    internal class Cuenta
    {
        private string titular;
        private double cantidad;
        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public Cuenta(string titular)
        {
            this.titular = titular;
            this.cantidad = 0;
        }
        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }
        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public void Ingresar(double cantidads)
        {
            if (cantidads > 0)
            {
                cantidad += cantidads;
            }
        }
        public void Retirar(double cantidads)
        {
            if (cantidads > 0)
            {
                cantidad -= cantidads;
                if (cantidad < 0)
                {
                    cantidad = 0;
                }
            }
        }
        public override string ToString()
        {
            return $"Titular: {titular}, Cantidad: {cantidad}";
        }
        public static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Juan Perez", 1000);
            Console.WriteLine(cuenta1.ToString());
            cuenta1.Ingresar(500);
            Console.WriteLine(cuenta1.ToString());
            cuenta1.Retirar(2000);
            Console.WriteLine(cuenta1.ToString());
        }

    }
    
}
