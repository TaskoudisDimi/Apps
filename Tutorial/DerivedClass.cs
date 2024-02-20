using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class DerivedClass: BaseClass
    {
        // Αντικατάσταση της προστατευμένης μεθόδου με νέα υλοποίηση
        public override void Display()
        {
            Console.WriteLine("Derived Class Display method");
        }

        // Μέθοδος που καλεί την αναπλαστική μέθοδο
        public void Show()
        {
            // Κλήση της αναπλαστικής μεθόδου Display
            Display();
        }

    }
}
