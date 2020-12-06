using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace E_Blood.Model
{
    class PersonDB
    {
        private static ObservableCollection<Person> Persons = new ObservableCollection<Person>();
       
        static PersonDB()
        {
            Persons.Add(new Person("Ahmed lahmar", "mahdi@gmail.com", "A+", "20202020", "Sfax", "1234"));
            Persons.Add(new Person("Marwen mejri", "ali@gmail.com", "A-", "20254020", "Sousse", "1234"));
            Persons.Add(new Person("Mohamed Sleh", "Mo@gmail.com", "AB-", "550213201", "Sfax", "1234"));
            Persons.Add(new Person("Lamia Limem", "lami.lo@gmail.com", "AB+", "92303265", "Jendouba", "1234"));
            Persons.Add(new Person("Mahdi Louati", "Louati@gmail.com", "O-", "20254020", "Tunis", "1234"));
            Persons.Add(new Person("Hammadi Abid", "Hammadi@gmail.com", "B-", "98666323", "Monastir", "1234"));
            Persons.Add(new Person("Achraf Habbesi", "Ach95@gmail.com", "B+", "50521254", "Nabeul", "1234"));
            Persons.Add(new Person("Samar Walha", "samar.walha@gmail.com", "O+", "22323614", "Sfax", "1234"));
            Persons.Add(new Person("Bochra Khammeri", "boch23@gmail.com", "A+", "32302654", "Mednin", "1234"));
            Persons.Add(new Person("Yessin Masmoudi", "mas.yass@gmail.com", "B-", "99212365", "Gabes", "1234"));
            Persons.Add(new Person("Mariam Fakhfakh", "maryam95@gmail.com", "O+", "20254020", "Sousse", "1234"));
            Persons.Add(new Person("Mahmoud Masri", "miha@yahoo.com", "AB-", "20301201", "Kasserine", "1234"));
            Persons.Add(new Person("Nadia chaari", "Nadi.cc@gmail.com", "AB+", "20254020", "Sousse", "1234"));
            Persons.Add(new Person("Aladain Triki", "Aloulou@gmail.com", "A-", "20254020", "Kebeli", "1234"));
            Persons.Add(new Person("Marwa Loumini", "Alu@gmail.com", "B-", "50254020", "Ariana", "1234"));
            Persons.Add(new Person("Racem Naifar", "Racem.Na@gmail.com", "B+", "50203040", "Mahdia", "1234"));
            Persons.Add(new Person("Helmi Ghorbel", "G.helmi@gmail.com", "O-", "44203444", "Bizerte", "1234"));
        }

        public static ObservableCollection<Person> listPersons()
        {
            return Persons;        }
           
    }
}
