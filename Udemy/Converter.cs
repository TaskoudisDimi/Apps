using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    public class Converter
    {

        public int convert(string input)
        {
            try
            {
                int converted;
                bool isSuccessfully = int.TryParse(input, out converted);


                if (!isSuccessfully)
                {
                    throw new Exception("Wrong Convertion");
                }
                return converted;

            }
            catch (Exception ex)
            {
                //Console.WriteLine("There was en error with convertion {0}", ex.Message);
                throw;
            }
        }


       
    }
}
