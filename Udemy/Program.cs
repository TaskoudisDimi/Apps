
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

            //string input = Console.ReadLine();

            //int convertedInputNumber;
            //int.TryParse(input, out convertedInputNumber);

            //int number = 90;
            //int result = 10 + 1000 - number + convertedInputNumber;
            //Console.WriteLine(result);  



            //Work with strings
            //string someText = "Here is some text";
            //string someText2 = "Here is Some text";

            ////bool isEqual = someText.Equals(someText2);
            //bool isEqual = someText.Equals(someText2, StringComparison.OrdinalIgnoreCase);

            //string formattedString = string.Format("{0} {1} Here is the last text", someText, someText2);
            //Console.WriteLine(formattedString);


            //Console.WriteLine(someText.Length);
            //Console.WriteLine(someText[8]);

            //Console.WriteLine(someText.Substring(8,4));

            //Console.WriteLine(someText.ToUpper());
            //Console.WriteLine(someText.ToLower());


            //string empty = string.Empty;

            //string replace = someText.Replace("text", "string");
            //Console.WriteLine(replace);






            //string username = Console.ReadLine();
            //string password = Console.ReadLine();

            //if (username.Equals("test") && password.Equals("1234"))
            //{
            //    Console.WriteLine("Test");
            //}
            //else if (username.Equals("test2") && password.Equals("4321"))
            //{
            //    Console.WriteLine("Test2");
            //}
            //else
            //{
            //    Console.WriteLine("Test3");
            //}


            ////Όταν θέλω να ελέγξω μια παράμετρο με πολλές πιθανότητες χρησιμοποιώ το switch case 
            //switch (username)
            //{
            //    case "test":
            //        Console.WriteLine("Test");
            //        break;
            //    case "test2":
            //        Console.WriteLine("test2");
            //        break;
            //    default:
            //        Console.WriteLine("test3");
            //            break;
            //}




            //Person person1 = new Person();
            //Console.WriteLine(person1.GetType());
            //person1.setAge(1);
            //Console.WriteLine(person1.getAge());

            //Person.greet();




            //Υπάρχουν exceptions που μπορούμε να τα κρατήσουμε (handle) και θέλουμε να συνεχίσει να τρέχει το πρόγραμμα και
            //exceptions που όταν σμυβαίνουν δεν θέλουμε να συνεχίσει το πρόγραμμα
            //try
            //{

            //    string input = Console.ReadLine();
            //    try
            //    {
            //        Converter converter = new Converter();
            //        converter.convert(input);

            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("There was en error with convertion {0}", ex.Message);

            //    }

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("There was an error {0}", ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("The rest app running");
            //}




            //APP - Simple Calculator
            //try
            //{
            //    InputConverter inputConverter = new InputConverter();
            //    CalculatorEngine calculateEngine = new CalculatorEngine();

            //    double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
            //    double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
            //    string operation = Console.ReadLine();  


            //    double result = calculateEngine.Calculate(operation, firstNumber, secondNumber);

            //    Console.WriteLine(result);

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}













        }
    }
}