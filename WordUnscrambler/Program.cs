﻿
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using WordUnscrambler.Workers;
using WordUnscrambler.Data;
using System.Linq;


namespace WordUnscrambler
{
    public class Program
    {

        ////Το const κάνει τη class static. Μπορώ να γράψω Program.someText
        //public const string someText = "This is some text";
        ////Το readonly κάνει τη class non static
        //public static readonly string someOtherText = "This is some other text";
        ////Μπορώ να κάνω και static readonly
        //public static readonly string someOtherText2 = "This is some other text2";

        private static readonly FileReader _fileReader = new FileReader();
        private static readonly WordMatcher _wordMatcher = new WordMatcher();
        private const string wordListFileName = "wordlist.txt";

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



            //Read/Write Files
            //string path = "C:/Users/User/Desktop";
            //string[] lines = { "This is the first line", "This is the second line", "This is the third line" };
            //File.WriteAllLines("MyFirstFile.txt", lines);

            //string[] fileContents = File.ReadAllLines("MyFirstFile.txt");

            //foreach(string line in fileContents)
            //{
            //    Console.WriteLine(line);
            //}




            //Dry 
            //Its repeat code
            //string[] lines = { "Test1", "Test2", "Test3" };
            //string[] formattedLines = new string[lines.Length];

            //for (int i = 0; i < formattedLines.Length; i++)
            //{
            //    formattedLines[i] = string.Format("{0} {1} {2}", lines[i]);
            //}
            //File.WriteAllLines("MySecondFile.txt", formattedLines);



            //string[] otherlines = { "Test1", "Test2", "Test3" };
            //string[] otherformattedLines = new string[lines.Length];

            //for (int i = 0; i < otherformattedLines.Length; i++)
            //{
            //    otherformattedLines[i] = string.Format("{0} {1} {2}", otherlines[i]);
            //}
            //File.WriteAllLines("AnotherMySecondFile.txt", otherformattedLines);


            ////Insteat of repeat code I can write the follow:
            //string[] lines = { "Test1", "Test2", "Test3" };
            //File.WriteAllLines("MySecondFile.txt", formatLines(lines));

            //string[] otherlines = { "Test1", "Test2", "Test3" };
            //File.WriteAllLines("AnotherMySecondFile.txt", formatLines(otherlines));

            //static string[] formatLines(string[] unformattedLines)
            //{
            //    string[] formattedLines = new string[unformattedLines.Length];

            //    for (int i = 0; i < unformattedLines.Length; i++)
            //    {
            //        formattedLines[i] = string.Format("{0} {1} {2}", unformattedLines[i]);  
            //    }
            //    return unformattedLines;
            //}




            bool continueWordScrumble = true;
            do
            {
                Console.WriteLine("Please enter the option - F for File and M for Manual");
                var option = Console.ReadLine() ?? String.Empty;
                switch (option.ToUpper())
                {
                    case "F":
                        Console.WriteLine("Enter scrambled workds file name: ");
                        ExecuteScrambledWordsFile();
                        break;
                    case "M":
                        Console.WriteLine("Enter scrambled workds manually: ");
                        ExecuteScrambledWordsManual();
                        break;
                    default:
                        Console.WriteLine("Option was not recogneized.");
                        break;
                }


                var continueDecision = string.Empty;
                do
                {
                    Console.WriteLine("Do you continue? Y/N");
                    continueDecision = (Console.ReadLine() ?? string.Empty);
                } while (!continueDecision.Equals("Y", StringComparison.OrdinalIgnoreCase) && !continueDecision.Equals("N", StringComparison.OrdinalIgnoreCase));

                continueWordScrumble = continueDecision.Equals("Y", StringComparison.OrdinalIgnoreCase);


            } while (continueWordScrumble);




        }

        private static void ExecuteScrambledWordsManual()
        {
            var manualInput = Console.ReadLine() ?? String.Empty;
            string[] scrambledWords = manualInput.Split(',');
            DisplayMatchedUnscrambledWords(scrambledWords);


        }
        private static void ExecuteScrambledWordsFile()
        {
            var filename = Console.ReadLine() ?? String.Empty;
            string[] scrambledWords = _fileReader.Read(filename);
            DisplayMatchedUnscrambledWords(scrambledWords);
        }


        private static void DisplayMatchedUnscrambledWords(string[] scrambledWords)
        {
            string[] wordList = _fileReader.Read(wordListFileName);
            List<MatchedWord> matchedWords = _wordMatcher.Match(scrambledWords, wordList);
        
            if (matchedWords.Any())
            {
                foreach (var matchedWord in matchedWords)
                {
                    Console.WriteLine("Match found for {0}: {1}", matchedWord.ScrambledWord, matchedWord.Word);
                }
            }
            else
            {
                Console.WriteLine("No matches have been found.");
            }
        
        }



    }
}