﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    //Μια abstract κλάση δηλώνεται χρησιμοποιώντας τη λέξη-κλειδί abstract.
    //Μια abstract τάξη μπορεί να περιέχει ένα μείγμα από κανονικά(συγκεκριμένα) και αφηρημένα μέλη.
    //Μια abstract κλάση δεν μπορεί να δημιουργηθεί απευθείας χρησιμοποιώντας τη new λέξη-κλειδί.
    //Οι abstract κλάσεις μπορούν να έχουν κατασκευαστές και συνήθως χρησιμοποιούνται για την προετοιμασία της βασικής κλάσης των παραγόμενων κλάσεων.
    //Μια κλάση μπορεί να κληρονομήσει μόνο από μια αφηρημένη κλάση
    public abstract class Shape
    {

        //Τα αφηρημένα μέλη δηλώνονται σε μια κλάση abstract και δεν παρέχουν υλοποίηση.
        //Τα μέλη της περίληψης δηλώνονται χρησιμοποιώντας τη λέξη-κλειδί αφηρημένη και πρέπει να υλοποιηθούν στις παραγόμενες κλάσεις.
        //Τα αφηρημένα μέλη μπορούν να περιλαμβάνουν μεθόδους, ιδιότητες, ευρετήρια και συμβάντα.
        //Οι παραγόμενες κλάσεις που κληρονομούν από μια αφηρημένη κλάση πρέπει να παρέχουν υλοποιήσεις για όλα τα αφηρημένα μέλη.
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

        public void PrintDetails()
        {
            Console.WriteLine("Shape Details");
            Console.WriteLine($"Area {CalculateArea()}");
            Console.WriteLine($"Area {CalculatePerimeter()}");
        }
    }
}
