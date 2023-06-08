using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    //Delegates are useful in scenarios where you want to decouple the caller from the implementation of a method.
    //They provide a way to define a contract or callback mechanism, allowing one piece of code to invoke another piece of code
    //without knowing the exact implementation details.
    public delegate void PrintDelegate(string message);
    public class Printer
    {
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

    }
}
