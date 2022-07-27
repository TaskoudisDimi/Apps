using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;




namespace WordUnscrambler
{
    public class Program
    {

        //Το const κάνει τη class static. Μπορώ να γράψω Program.someText
        public const string someText = "This is some text";
        //Το readonly κάνει τη class non static
        public static readonly string someOtherText = "This is some other text";
        //Μπορώ να κάνω και static readonly
        public static readonly string someOtherText2 = "This is some other text2";

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

            //int[] array = { 7, 8, 4, 5, 15 };
            //Array.Sort(array);


            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //List<string> stringList = new List<string>();
            //stringList.Add("Test");
            //stringList.Add("Test1");

            //for(int i = 0; i < stringList.Count; i++)
            //{
            //    Console.WriteLine(stringList[i]);

            //}


            //Person person1 = new Person();
            //person1.FirstName = "Dimitris";
            //person1.LastName = "Taskoudis";

            //ChangeName(person1);
            //Console.WriteLine(person1.FirstName);
            //Console.WriteLine(person1.LastName);



            ////Value Types and Reference Types
            ////Value types: bool, byte, char, decimal, double, enum, float, int, long, sbyte, short, structure, uint, ulong, ushort
            ////Reference Types: class, interface, delegate, object, string, indexers
            ////Όλα τα value types αποθηκεύονται σε Stack
            ////Όλα τα references types(classes) αποθηκεύονται σε Heap
            ////Variables of reference types store references to their data(objects),
            ////while variables of value types directly contain their data.
            ////With reference types, two variables can reference the same object
            ////therefore, operations on one variable can affect the object referenced by the other variable.
            //static void ChangeName(Person personToChange)
            //{
            //    personToChange.FirstName = "Despoina";
            //    personToChange.LastName = "Taskoudi";
            //}


            ////Με ref, out μπορώ να μετατρέψω τη value type μεταβλητή σε reference type
            ////Με το out δεν χρειάζεται να γινει initialize η μεταβλητή,
            ////Με το ref πρέπει να έχουμε δώσει αρχική τιμή στην μεταβλητή
            //int a;
            //ChangeNumber(out a);
            //Console.WriteLine(a);

            //static void ChangeNumber (out  int a)
            //{
            //    a = 90;
            //}


            
        }
    }
}
