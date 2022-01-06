using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1_ConsoleUI
{
    public class PersonModel
    {
        public string FirstName { private get; set; }
        public string LastName { get; private set; }

        public string FullName
        {
            get { return $"{ FirstName} {LastName}"; }
        }

        private string _password;
        public string Password
        {
            set { _password = value; }
        }

        //public int Age { get; set; }
        private int _age; //private backing fielad
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0 && value < 126)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Age", "Age need to be in a valid range.");
                }
            }
        }

        //public string SSN { get; set; } //Social Security Number 123-45-6789
        private string _ssn;

        public string SSN
        {
            get
            {
                string output = "***-**-" + _ssn.Substring(_ssn.Length - 4);
                return output;
            }
            set { _ssn = value; }
        }

        public AddressModel Address { get; set; }
        public PersonModel()
        {

        }
        public PersonModel(string lastName)
        {
            LastName = lastName;
        }
    }
}
