using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    public class Person
    {

        private int Age;

        public int getAge()
        {
            return Age;
        }

        public void setAge(int newAge)
        {
            Age = newAge;
        }


        //Οι static methods μπορούν να χρησμιποιηθούν κατευθείαν απο μια class, Person.greet
        static public void greet()
        {
            Console.WriteLine("Hello!");
        }



    }
}
