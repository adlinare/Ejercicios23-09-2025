using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_2
{
    public class Agenda
    {
        public Contacto[] Contactos;
        public int NumeroContactos;

        public Agenda()
        {
            Contactos = new Contacto[10];
            NumeroContactos = 0;
        }

        public  Agenda(int size)
        {
            Contactos = new Contacto[size];
            NumeroContactos = 0;
        }

        public void anadirContacto(Contacto contac) {
            if (NumeroContactos < Contactos.Length) {
                if (contac.Nombre == null) {
                    Console.WriteLine("El contacto no es válido");
                    return;
                }
                for (int i = 0; i < NumeroContactos; i++) {
                    if (Contactos[i].Nombre == contac.Nombre) {
                        Console.WriteLine("El contacto ya existe");
                        return;
                    }
                }
                Contactos[NumeroContactos] = contac;
                Console.WriteLine("Contacto añadido");
                NumeroContactos++;
            }else{
                Console.WriteLine("No se pueden añadir más contactos");
            }
        }
        public bool existeContacto(string nombre) {
            for (int i = 0; i < NumeroContactos; i++) {
                if (Contactos[i].Nombre == nombre) {
                    return true;
                }
            }
            return false;
        }
        public void buscarContacto(string nombre) {
            for (int i = 0; i < NumeroContactos; i++) {
                if (Contactos[i].Nombre == nombre) {
                    Console.WriteLine("El teléfono de " + nombre + " es " + Contactos[i].Telefono);
                    return;
                }
            }
            Console.WriteLine("El contacto no existe");
        }
        public void eliminarContacto(string nombre) {
            for (int i = 0; i < NumeroContactos; i++) {
                if (Contactos[i].Nombre == nombre) {
                    for (int j = i; j < NumeroContactos - 1; j++) {
                        Contactos[j] = Contactos[j + 1];
                    }
                    Contactos[NumeroContactos - 1] = null;
                    NumeroContactos--;
                    Console.WriteLine("Contacto eliminado");
                    return;
                }
            }
            Console.WriteLine("El contacto no existe");
        }
        public bool agendaLlena() {
            return NumeroContactos == Contactos.Length;
        }
        public int huecosLibres() {
            return Contactos.Length - NumeroContactos;
        }


        static void Main(string[] args)
        {
            Agenda agenda = new Agenda(3);
            Contacto contacto1 = new Contacto();
            contacto1.Nombre = "Juan";
            contacto1.Telefono = "123456789";
            Contacto contacto2 = new Contacto();
            contacto2.Nombre = "Ana";
            contacto2.Telefono = "987654321";
            Contacto contacto3 = new Contacto();
            contacto3.Nombre = "Luis";
            contacto3.Telefono = "555555555";
            Contacto contacto4 = new Contacto();
            contacto4.Nombre = "Maria";
            contacto4.Telefono = "444444444";
            agenda.anadirContacto(contacto1);
            agenda.anadirContacto(contacto2);
            agenda.anadirContacto(contacto3);
            agenda.anadirContacto(contacto4); // No se puede añadir
            Console.WriteLine("¿Existe el contacto Juan? " + agenda.existeContacto("Juan"));
            Console.WriteLine("¿Existe el contacto Pedro? " + agenda.existeContacto("Pedro"));
            agenda.buscarContacto("Ana");
            agenda.buscarContacto("Pedro");
            agenda.eliminarContacto("Luis");
            agenda.eliminarContacto("Pedro");
            Console.WriteLine("¿La agenda está llena? " + agenda.agendaLlena());
            Console.WriteLine("Huecos libres en la agenda: " + agenda.huecosLibres());
        }
    }
}
