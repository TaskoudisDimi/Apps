using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    //public class Ferrari : ICar
    class Ferrari : Car
    {

        //public bool _on;

        //public void TurnOff()
        //{
        //    _on = !_on;
        //    Console.WriteLine(_on ? "The Ferrari is on" : "The Ferrari is off");
        //}

        //public void Driver()
        //{
        //    if (_on)
        //    {
        //        Console.WriteLine("Drive Ferrari");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not drive Ferrari");
        //    }
        //}

        public override void Driver()
        {
            if (_on)
            {
                Console.WriteLine("Drive Ferrari");
            }
            else
            {
                Console.WriteLine("Not drive Ferrari");
            }
        }
    }
}
