using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    public class InputConverter
    {


        public double ConvertInputToNumeric(string argTextInput)
        {
            double converterNumber;
            if (!double.TryParse(argTextInput, out converterNumber)) throw new ArgumentException("Excepted a numeric value!");
            return converterNumber;

        }

    }
}
