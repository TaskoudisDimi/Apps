using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public interface ICar
    {
        //Ένα Interface μας λεει τι χρειάζεται να υλοποιηθεί
        //Μία class μπορεί να κληρονομήσει τα στοιχεία πολλών intefarces
        void TurnOff();
        void Driver();



    }
}
