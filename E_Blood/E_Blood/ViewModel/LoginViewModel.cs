using E_Blood.Model;
using E_Blood.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;


namespace E_Blood.ViewModel
{
    class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public LoginViewModel()
        {
        }
        bool flag = false;
        private string email;
        public string Email


        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        private string password;
        public ObservableCollection<Person> Persons = PersonDB.listPersons();

        

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }
        public Command LoginCommand
        {
            get
            {
                return new Command(Login);
            }
        }
        public ICommand ForgotPasswordCommand => new Command(SignIn);
        private async void SignIn()
        {
            await App.Current.MainPage.Navigation.PushAsync(new SignUpPage());
        }
        private void Login()
        {


            //null or empty field validation, check weather email and password is null or empty 
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                App.Current.MainPage.DisplayAlert("Empty Values", "Please enter Email and Password" + Email, "OK");
            }
            else
            {
                for (int i = 0; i < Persons.Count; i++)
                {
                    if (Email == Persons[i].Email && Password == Persons[i].Password)
                    {
                        App.Current.MainPage.DisplayAlert("Login Success", "", "Ok");
                        //Navigate to Wellcom page after successfully login 
                        App.Current.MainPage.Navigation.PushAsync(new PersonListView());
                        flag = true;
                    }
                    
                    
                }
                if (flag == false)
                {
                    App.Current.MainPage.DisplayAlert("Login Fail", "Please enter correct Email and Password", "OK");


                }


            }
        }
    }
}


