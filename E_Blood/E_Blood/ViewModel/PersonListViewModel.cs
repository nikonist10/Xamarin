using E_Blood.Model;
using E_Blood.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace E_Blood.ViewModel
{
    public class PersonListViewModel
    {
        public ObservableCollection<Person> Persons { get; set; }


        public PersonListViewModel()
        {
            Persons = PersonDB.listPersons();

            

            MessagingCenter.Subscribe<SignUpPage, Person>(this, "SignUp",
                  ( SignUpPage, person) =>
                  {
                        Persons.Add(person);
                  });
        }
    }
}
