using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica10Ejercicio4
{
    class Empleado
    {
        private string nombre;
        private int horasExtra;
        private decimal salario;

        public string Nombre { get => nombre; set => nombre = value; }
        public int HorasExtra { get => horasExtra; set => horasExtra = value; }
        public decimal Salario { get => salario; set => salario = value; }

        public Empleado(string nombre, decimal salario)
        {
            this.Nombre = nombre;
            this.Salario = salario;
            this.HorasExtra = 0;
        }

        public void HaceHorasExtra(int horas)
        {
            this.HorasExtra += horas;
        }

        public decimal CalcularSalario()
        {
            decimal pagoHorasExtra = HorasExtra * 25;
            return Salario + pagoHorasExtra;
        }



    }
}
