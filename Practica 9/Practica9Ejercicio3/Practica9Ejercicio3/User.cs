using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica9Ejercicio3
{
    public class User
    {
        public string Name { get; set; }

        public int Age { get; set; }


        public string City { get; set; }


        public DateTime RegistrationDate { get; set; }


        public User(string name, int age, string city, DateTime registrationDate)
        {
            Name = name;
            Age = age;
            City = city;
            RegistrationDate = registrationDate;
        }
    }
}
