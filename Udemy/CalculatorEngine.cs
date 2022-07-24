using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    public class CalculatorEngine
    {

        public double Calculate(string operation, double argFirstNumber, double argSecondNumber)
        {
            double result;
            switch (operation.ToLower())
            {
                //Μπορώ να βάλω δυο cases μαζί για το ίδιο result
                case "add":
                case "+":
                    result = argFirstNumber + argSecondNumber;
                    break;
                case "subtract":
                case "-":
                    result = argFirstNumber - argSecondNumber;
                    break;
                case "multiply":
                case "*":
                    result = argFirstNumber * argSecondNumber;
                    break;
                case "divide":
                case "/":
                    result = argFirstNumber / argSecondNumber;
                    break;
                default:
                    throw new InvalidOperationException("Specified operation is not recognized");
            }
            return result;
        }



    }
}
