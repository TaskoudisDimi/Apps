using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The chef makes chincken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The chef makes salad");
        }


        //Με το virtual πραγματοποιείται override της method που μπορούν να εκτελέσουν οι class Chef - ItalianChef
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes bb ribs");
        }


    }
}
