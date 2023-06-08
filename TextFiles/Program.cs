using System;
using System.IO;
using System.Text.Json;
using TextFiles;

namespace ObjectToJSONConversion
{
    class Program
    {
        public static void Main()
        {
            string filepath = @"C:\Users\User\Desktop\Test.txt";


            //List<string> lines = File.ReadAllLines(filepath).ToList();

            //foreach(string line in lines)
            //{
            //    Console.WriteLine(line);
            //}
            //lines.Add("Test3Test3Test3Test3Test3");
            //File.WriteAllLines(filepath, lines);



            List<Person> people = new List<Person>();
            List<string> lines = File.ReadAllLines(filepath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');
                Person newPerson = new Person();
                newPerson.FirstName = entries[0];
                newPerson.LastName = entries[1];
                newPerson.Url = entries[2];
                people.Add(newPerson);
            }
            Console.WriteLine("Start read from text file");
            foreach (var person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} {person.Url}");
            }
            Console.WriteLine("End read from text file");

            people.Add(new Person { FirstName = "Despoina", LastName = "Taskoudi", Url = "despoina@gmail.com" });

            List<string> output = new List<string>();
            foreach (var person in people)
            {
                output.Add($"{person.FirstName}, {person.LastName}, {person.Url}");
            }
            Console.WriteLine("Writing to text file");
            File.WriteAllLines(filepath, output);
            Console.WriteLine("All entries written");
            Console.ReadLine();

        }


        private void Write(string path)
        {
            using (TextWriter writer = new StreamWriter(path))
            {
                writer.Write(true);
            }
        }

        private void Read(string path)
        {
            using (TextReader read = new StreamReader(path))
            {
                read.Read();
            }

        }
    }
}
