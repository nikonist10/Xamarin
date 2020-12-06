using E_Blood.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace E_Blood.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonListView : ContentPage

    {
        public ObservableCollection<Person> Persons = PersonDB.listPersons();
        public PersonListView()
        {
            InitializeComponent();
            
            PersonView.ItemsSource = PersonDB.listPersons();
            
         
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            try {
            var sr = Persons.Where(p => p.BloodType.ToLower().Contains(Search.Text.ToLower()));
            PersonView.ItemsSource = sr;
            }
            catch (Exception ex)
            {
            }
        }

        private async void PersonView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var person = e.Item as Person; 
            await DisplayAlert("More details:", ("Mr/Mrs: "+person.Name +"                  Phone Number: " + person.Number + "             City: " + person.City), "Ok");
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Log Out", "Are you sure you want to exit ?", "Yes", "No"); 
            if (result == true) 
            {
              await  Navigation.PushAsync(new LoginPage());
            }
            else 
            {
                return; 
            }

        }
    }
}
        
 