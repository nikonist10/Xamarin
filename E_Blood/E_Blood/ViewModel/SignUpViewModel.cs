using E_Blood.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Blood.ViewModel
{
    public class SignUpViewModel
    {
        public Person Person { get; set; }

        public SignUpViewModel()
        {
            Person = new Person();
        }
    }
    
}
