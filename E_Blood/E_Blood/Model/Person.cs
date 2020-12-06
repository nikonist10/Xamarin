using System;
using System.Collections.Generic;
using System.Text;

namespace E_Blood.Model
{
    public class Person
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public string BloodType { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string Password { get; set; }
   
    public Person(string name, string email, string bloodType, string number, string city, string password)
    {
        Name = name;
        Email = email;
        BloodType = bloodType;
        Number = number;
        City = city;
        Password = password;
    }

        public Person()
        {
        }
    }
}
