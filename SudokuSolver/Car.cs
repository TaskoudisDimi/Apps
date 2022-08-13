using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    //Base class 
    //Η abstract class μπορεί να μοιραστεί functions, ένα interface δεν μπορεί
    abstract class Car
    {
        protected bool _on;

        public void TurnOff()
        {
            _on = !_on;
            Console.WriteLine(_on ? "The car is on" : "The car is off");
        }

        public abstract void Driver();
    }
}
