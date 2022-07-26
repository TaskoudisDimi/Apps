using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;




namespace WordUnscrambler
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();

            //list.Add(10);
            //list.Add(5);
            //list.Add(20);

            //Console.WriteLine(list.Count());

            //int[] Array = new int[10];

            //var secondList = new List<int>();

            //secondList.Add(5);

            //Console.WriteLine(secondList[0]);

            int[] array = { 7, 8, 4, 5, 15 };
            Array.Sort(array);


            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(i);
            }





        
        }
    }
}
