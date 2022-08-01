using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraper
{
    public class SuperPerson: Person
    {
        private string FirstName;
        private string LastName;

        public SuperPerson(string firstName, string lastName)
        {
            firstName = FirstName;
            lastName = LastName;

        }
        public void Walk()
        {
            Console.WriteLine("Walk");
        }


    }
}
