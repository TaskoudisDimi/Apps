using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class ItalianChef : Chef //Inheritance
    {
        //Override τη method MakeSpecialDish από τη superclass (Chef)
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes checken parm");
        }


        //Η class ItalianChef θέλω να μπορεί να εκτελέσει ότι περιλαμβάνει η class chef
        public void MakePasta()
        {
            Console.WriteLine("The chef makes pasta");
        }

    }
}
