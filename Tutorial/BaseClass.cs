using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    // Βασική κλάση
    class BaseClass
    {
        // Προστατευμένη μέθοδος που θέλουμε να αντικαταστήσουμε
        public virtual void Display()
        {
            Console.WriteLine("Base Class Display Method");
        }

    }
}
