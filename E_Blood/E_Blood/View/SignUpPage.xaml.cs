
using E_Blood.Model;
using E_Blood.ViewModel;
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
    public partial class SignUpPage : ContentPage
    {
        public ObservableCollection<Person> Persons = PersonDB.listPersons();
        public SignUpPage()
        {
            InitializeComponent();
            BTypePicker.Items.Add("A+");
            BTypePicker.Items.Add("A-");
            BTypePicker.Items.Add("B+");
            BTypePicker.Items.Add("B-");
            BTypePicker.Items.Add("AB+");
            BTypePicker.Items.Add("AB-");
            BTypePicker.Items.Add("O+");
            BTypePicker.Items.Add("O-");
        }
        private void BTypePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = BTypePicker.Items[BTypePicker.SelectedIndex];
            DisplayAlert(type, "Selected Blood Type", "Ok");
        }
        private  void Button_clicked(object sender, EventArgs e)
        {
            var name = Name.Text; var mail = Email.Text; var pwd = Password.Text; var city = City.Text;
            var num = Number.Text; 
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(mail) ||  string.IsNullOrEmpty(pwd) ||
                 string.IsNullOrEmpty(city) || string.IsNullOrEmpty(num)) {
                DisplayAlert("Empty Values", "Please fill all the fields", "OK");
            }
            else { 
                Person person = ((SignUpViewModel)BindingContext).Person;
                Persons.Add(person);
                // MessagingCenter.Send(this, "SignUp", person);

                Navigation.PushAsync(new PersonListView());
          
        }
        }


    }
}