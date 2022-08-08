using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraper
{
    public class PersonBuilder
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private int _eyeColor;


        public PersonBuilder()
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            _firstName = "Dimitris";
            _lastName = "Taskoudis";
            _age = 28;
            _eyeColor = 153;
        }

        public PersonBuilder FirstName(string firstName)
        {
            _firstName=firstName;
            return this;
        }

        public PersonBuilder LastName (string lastName)
        {
            _lastName = lastName;
            return this;
        }
        public PersonBuilder Age(int age)
        {
            _age = age;
            return this;
        }
        public PersonBuilder eye(int eye)
        {
            _eyeColor = eye;
            return this;
        }

        public Person Build()
        {
            Person person = new Person(_firstName, _lastName, _age, _eyeColor);
            return person;
        }



    }
}
