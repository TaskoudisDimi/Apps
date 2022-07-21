
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;




namespace Udemy
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            int convertedInputNumber;
            int.TryParse(input, out convertedInputNumber);

            int number = 90;
            int result = 10 + 1000 - number + convertedInputNumber;
            Console.WriteLine(result);  



        }
    }
}