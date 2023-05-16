using Lesson1.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
//using Newtonsoft.Json;
using System.Net;
//using Nancy.Json;
using System.Net.Sockets;
using System.Text;
using System.Collections;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;
using System.Text.Json;
using System.Threading;
using System.Reflection.Metadata;
using System.Diagnostics.Metrics;
using System.Timers;

namespace Lesson1

{
    class Tutorial  //Η class είναι ένα container που μπορώ να γράψω κώδικα
    {
        #region Comments1

        //static void Main(string[] args) //Method or function 
        //{

        //        /*
        //        string username = "";

        //        Console.WriteLine("Give me your name:");

        //        username = Console.ReadLine();

        //        Console.WriteLine("My name is " + username);
        //        Console.ReadLine();
        //        */

        //        //Console.WriteLine(4 - 5);

        //        /*int x = 0 ;
        //        x++;
        //        Console.WriteLine(x);
        //        */


        //        //float ximeia, istoria, mo;

        //        //Console.WriteLine("Dwse vathmo ximeias");
        //        //ximeia = float.Parse(Console.ReadLine());

        //        //Console.WriteLine("Dwse vathmo istorias");
        //        //istoria = float.Parse(Console.ReadLine());

        //        //mo = istoria + ximeia;

        //        //Console.WriteLine("O mesos oros einai: " + mo/2);


        //        //Console.WriteLine(Math.Max(8, 10)); //Έυρεση μέγιστου
        //        //Console.WriteLine(Math.Min(8, 10)); //Έυρεση ελάχιστου
        //        //Console.WriteLine(Math.Sqrt(1024)); //Έυρεση ρίζας
        //        //Console.WriteLine(Math.Abs(-5.6)); //Απόλυτη τιμή
        //        //Console.WriteLine(Math.Round(4.5)); //Στρογγυλοποίηση

        //        //Console.WriteLine("\ttesttesttesttesttest"); //\t κενό
        //        //Console.WriteLine("\ntesttesttesttesttest"); //\n αλλαγή γραμμής

        //        //string phrase = "test";
        //        //Console.WriteLine(phrase.Length);  //Length = μήκος string

        //        //Console.WriteLine(phrase[3]);

        //        //Console.WriteLine(phrase.Substring(1)); //Αφαιρεί το γράμμα που δηλώνω

        //        //Console.WriteLine(phrase.Contains("e")); //Αν περιέχει η λέξη test το γράμμα e τότε θα επιστρέψει true


        //        //bool flag;

        //        //int a = 4;
        //        //int b = 5;

        //        //if (a == 4 || b == 5)
        //        //{
        //        //    Console.WriteLine(a);
        //        //}

        //        Console.ReadLine();



        //    }
        //}

        //public class Person //Καλώ αυτή τη class στη κύρια class Program όπου θα εκτελεστεί ότι υλοποίησα σε αυτή (Person)
        //{
        //    public string Name;
        //    public int Age;
        //    public bool HasPet;


        //    public void Greetings() //Βάζω το void όταν η method δεν θα επιστρέψει κάποια τιμή
        //    {
        //        //Console.WriteLine("Den epistrefw kapoia timh = void");
        //        Console.WriteLine("Hi my name is: " + Name + " and my age is " + Age);
        //    }

        //    //public int calc(int x, int y) //Σε αυτή τη method που επιστρέφω μια τιμή (number) δεν βάζω το void 
        //    //{
        //    //    int number = x + y;
        //    //    return number;
        //    //}
        //}

        //public class Student
        //{
        //    public string name
        //    {
        //        get;
        //        set;
        //    }
        //}
        //public class Universities
        //{
        //    public string university
        //    {
        //        get;
        //        set;
        //    }
        //    public IList<Student> students
        //    {
        //        get;
        //        set;
        //    }
        //}
        //public class ClassUniversities
        //{
        //    public Universities universities
        //    {
        //        get;
        //        set;
        //    }
        //}

        //public class Department
        //{
        //    public int DeptId { get; set; }
        //    public string DepartmentName { get; set; }
        //}

        #endregion

        class Program
        {
            [DllImport("user32.dll", EntryPoint = "MessageBox")]
            public static extern int ShowMessageBox(int hWnd, string text, string caption, uint type);

            private static System.Timers.Timer timer;

            static void Main(string[] args)
            {

                #region Comments

                //ClassUniversities university1 = new ClassUniversities();

                //university1.universities = new Universities();
                //university1.universities.university = "South Carolina StateUniversity";

                //List<Student> listStudent = new List<Student>();
                //Student student1 = new Student {
                //    name = "Dimitris"
                //};
                //Student student2 = new Student {
                //    name = "Despoina"
                //};
                //Student student3 = new Student {
                //    name = "Katerina"
                //};
                //Student student4 = new Student {
                //    name = "Teo"
                //};

                //listStudent.Add(student1);
                //listStudent.Add(student2);
                //listStudent.Add(student3);
                //listStudent.Add(student4);

                //university1.universities.students = listStudent;
                //string json = JsonConvert.SerializeObject(university1);

                //Console.WriteLine(json);


                //string jsonData = "{\"DeptId\": 101, \"DepartmentName\": \"IT\"}";

                //JavaScriptSerializer json_serializer = new JavaScriptSerializer();


                //Person person = new Person(); //Store off some memory inside the app

                //person.Name = "Dimitris";
                //person.Age = 27;
                //person.HasPet = true;


                //person.Greetings();




                //string phrase = "Girrafe";
                //char grade = 'A';
                //int age = 14;
                ////Τρεις τύποι μεταβλητών για τη δήλωση δεκαδικών
                ////float, double, decimal
                //double gpa = 3.2;
                //bool isMale = true;
                //Console.WriteLine(age);
                //Console.ReadLine();


                //string str = "Girrafe";
                ////Console.WriteLine(str.ToUpper());
                //string str = "Girrafe";
                //Console.WriteLine(str.ToLower());


                //string str = "Girrafe";
                //Console.WriteLine(str.Contains("Girrafe"));


                //string str = "Girrafe";
                //Console.WriteLine(str[2]);


                ////Βρίσκει από ποιο index ξεκινάει η λέξη ή το γράμμα που του έχω βάλει να ψάξει
                //string str = "Girrafe";
                //Console.WriteLine(str.IndexOf("Girrafe"));

                ////Επιστρέφει από το 4ο στοιχείο και μετά τη λέξη
                //string str = "Girrafe";
                //Console.WriteLine(str.Substring(4));

                ////Μπορώ να του θέσω όριο για τα γράμματα της λέξης που θέλω να εκτυπώσω
                //string str = "Girrafe";
                //Console.WriteLine(str.Substring(4,2));


                //int num = 6;
                //num++;
                //int num2 = 5;
                //num2--;

                //Console.WriteLine(num);
                //Console.WriteLine(num2);


                //Console.WriteLine("Please write your name: ");
                //string name = Console.ReadLine();
                //Console.WriteLine("and your age");
                //string age = Console.ReadLine();
                //Console.WriteLine("Hello " + name + ". Your age is: " + age);


                ////Υπολογίζω τη πρόσθεση δύο int που δίνει ο χρήστης
                //Console.WriteLine("Please enter a number: ");
                ////Το Console.ReadLine δέχεται ότι γράψει ο χρήστης στη console και επιστρέφει πάντα string, για αυτό με το Convert.ToInt32 το κάνουμε Int
                //int num1 = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Please enter another number: ");
                //int num2 = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine(num1 + num2);



                ////Υπολογίζω τη πρόσθεση δύο double που δίνει ο χρήστης
                //Console.WriteLine("Please enter a number: ");
                ////Το Console.ReadLine δέχεται ότι γράψει ο χρήστης στη console και επιστρέφει πάντα string, για αυτό με το Convert.ToInt32 το κάνουμε Int
                //double num1 = Convert.ToDouble(Console.ReadLine());

                //Console.WriteLine("Please enter another number: ");
                //double num2 = Convert.ToDouble(Console.ReadLine());

                //Console.WriteLine(num1 + num2);




                ////Create a Madlib
                //string color, pluralNoun, celebrity;

                //Console.WriteLine("Enter a color: ");
                //color = Console.ReadLine();

                //Console.WriteLine("Enter a pluralNoun: ");
                //pluralNoun = Console.ReadLine();

                //Console.WriteLine("Enter a celebrity: ");
                //celebrity = Console.ReadLine();

                //Console.WriteLine("Roses are " + color);
                //Console.WriteLine(pluralNoun + "are blue");
                //Console.WriteLine("I love " + celebrity);


                ////Δημιουργία arrays
                //int[] luckkynumber = {4, 15, 16, 21, 19 };

                ////Δημιουργία array string με 5 στοιχεία
                //string[] friends = new string[5];
                //friends[0] = "Teo Savvidis";
                //friends[1] = "Fotis Simopoulos";

                //Console.WriteLine(luckkynumber[0]);

                ////Καλώ τη method όσες φορές θέλω, βάζοντας διάφορες μεταβλητές
                //SayHi("Mike", 13);
                //SayHi("Tom", 26);
                //SayHi("John", 29);





                //Console.WriteLine(cube(1));

                //bool isMale = true;
                //bool isTale = false;

                //if (isMale && isTale)
                ////if (isMale || isTale)
                //{
                //    Console.WriteLine("You are male and tall!");
                //} 
                //else if(isMale && !isTale) {
                //    Console.WriteLine("You are male or you are tall!");

                //}
                //else
                //{
                //    Console.WriteLine("You are not male!"); 
                //}


                //Call method if states
                //Console.WriteLine(GetMax(4, 3));



                ////Build calculator
                //Console.WriteLine("Enter a number: ");
                //double num1 = Convert.ToDouble(Console.ReadLine());

                //Console.WriteLine("Enter operator: ");
                //string op = Console.ReadLine(); 

                //Console.WriteLine("Enter a number: ");
                //double num2 = Convert.ToDouble(Console.ReadLine());

                //if (op == "+")
                //{
                //    Console.WriteLine(num1 + num2);
                //}
                //else if (op == "-")
                //{
                //    Console.WriteLine((num1 - num2));
                //}
                //else if (op == "/")
                //{
                //    Console.WriteLine((num1/num2));
                //}
                //else if (op == "*")
                //{
                //    Console.WriteLine((num1 * num2));
                //}
                //else
                //{
                //    Console.WriteLine("Invalid oparetor");
                //}



                ////Call GetDay method (switch tutorial)
                //Console.WriteLine(GetDay(90));

                // Εκτελείται ο κώδικας μέσα στη while loop μέχρι το index <= να γίνει false
                //int index = 1;
                //while (index <= 5)
                //{
                //    Console.WriteLine(index);
                //    index++;
                //}


                ////Εκτελείται τουλάχιστον μια φορά ο κώδικας μέσα στη while loop
                //int index = 6;
                //do
                //{
                //    Console.WriteLine(index);
                //    index++;
                //}while (index <= 5);




                ////Build guess game
                //string secretWord = "Giraffe";
                //string guess = "";
                //int guessCount = 0;
                //int guessLimit = 3;
                //bool  outOfGuesses = false;  



                //while (guess != secretWord && !outOfGuesses)
                //{
                //    if (guessCount < guessLimit)
                //    {
                //        Console.WriteLine("Enter a guess: ");
                //        guess = Console.ReadLine();
                //        guessCount++;
                //    }
                //    else
                //    {
                //        outOfGuesses = true;
                //    }
                //}
                //if (outOfGuesses)
                //{
                //    Console.WriteLine("You lose!");
                //}
                //else
                //{
                //    Console.WriteLine("You win!");
                //}




                //int i = 0;
                //while (i <= 5)
                //{
                //    Console.WriteLine(i);
                //    i++;
                //}

                ////For loop
                //int[] luckynumbers = { 10, 21, 31, 13, 41 };

                //for (int i = 0; i <= luckynumbers.Length; i++)
                //{
                //    Console.WriteLine(luckynumbers[i]);
                //}



                ////Call exponend method
                //Console.WriteLine(GetPow(3, 2));




                ////Build 2d array
                //int[,] numGrid = { 
                //    {4, 3}, 
                //    {1, 2}, 
                //    {7, 5} };

                //Console.WriteLine(numGrid[2, 1]);

                ////Αν δεν ξέρω τι στοιχεία θα βάλω σε έναν πίνακα, δηλώνω απλά τον πίνακα και το πλήθος των rows, columns
                //int[,] myArray = new int[2, 3];





                ////try catch όταν σκάει η εφαρμογή που τρέχω
                //try
                //{
                //    Console.WriteLine("Enter a number: ");
                //    int num1 = Convert.ToInt32(Console.ReadLine());

                //    Console.WriteLine("Enter another number: ");
                //    int num2 = Convert.ToInt32(Console.ReadLine());

                //    Console.WriteLine(num1 - num2);
                //}
                //catch(Exception e) //Υπάρχουν και άλλα exceptions, DivideByZeroException, FormatException
                //{
                //    Console.WriteLine(e.Message);
                //}



                //Δημιουργία objects από άλλη class (Book)
                //Book book1 = new Book("Mike");
                //book1.title = "Harry Potter";
                //book1.author = "JK Rowling";
                //book1.pages = 400;

                //Console.WriteLine(book1.title);

                //Book book2 = new Book("John");
                //book2.title = "Lord of the Rings";
                //book2.author = "Tolkein";
                //book2.pages = 500;

                //Console.WriteLine(book2.title);





                ////The same code but with constructors
                //Book book1 = new Book("Harry Potter", "JK Rowling", 400);
                //Book book2 = new Book("Lord of the Rings", "Tolkein", 500);

                //Console.WriteLine(book1.title);
                //Console.WriteLine(book2.title);

                //book1.title = "The Hobbit";

                //Console.WriteLine(book1.title);

                ////Call constructor without parameters but with the same name
                //Book book3 = new Book();




                //Student student1 = new Student("Jim", "Business", 2.8);
                //Student student2 = new Student("Pam", "Art", 3.6);

                //Call method HasHonor
                //Console.WriteLine(student1.HasHonor());
                //Console.WriteLine(student2.HasHonor());




                //// Θέλω να μπορούν να περαστούν μόνο συγκεκριμένες τιμές στο object movie, πχ rating = G, PG, PG-13, R, NR
                //// Για αυτό χρησιμοποιούμε getters - setters
                //Movie movie1 = new Movie("Avengares", "Joss Whedon", "test");
                //Movie movie2 = new Movie("Shrek", "Adam Adamson", "PG");

                //Console.WriteLine(movie1.Rating);





                //Song song1 = new Song("Holiday", "Green Day", 400);
                //Console.WriteLine(Song.songCount);
                //Song song2 = new Song("Kashmir", "led Zepelin", 200);

                //Console.WriteLine(song1.title);
                //Console.WriteLine(song2.title); 

                ////το songCount ειναι class attribute και όχι object attribute
                //Console.WriteLine(Song.songCount);

                ////Καλούμε τη συνάρτηση getSongCount για να πάρουμε το static attribute songCount για συγκεκριμένο object (song2)
                //Console.WriteLine(song2.getSongCount());



                ////Η static method ανήκει σε μια συγκεκριμένη class
                //UsefulTools.SayHi("Dimitri");




                //Chef chef = new Chef();
                //chef.MakeSpecialDish();


                ////Λόγω του inheritance το object italianchef μπορεί να εκτελέσει ότι και η class Chef κληρωνομόντας όλες τις methods, function etc.
                //ItalianChef italianchef = new ItalianChef();
                //italianchef.MakeSpecialDish();

                //italianchef.MakePasta();

                //Console.ReadLine();
                ////The following code returns the path to the equivalent of the Windows My Documents folder, or the user's HOME directory for any operating system, even if the code is running on Linux.
                //string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                //Console.WriteLine(docPath);
                //Console.WriteLine(Directory.GetCurrentDirectory());

                ////.NET automatically interprets that field into the separator character that's applicable to the operating system when you need to build a path manually.
                //Console.WriteLine($"stores{Path.DirectorySeparatorChar}201");


                ////The Path class works with the concept of file and folder paths, which are just strings. You can use the Path class to automatically build correct paths for specific operating systems.
                ////For instance, if you want to get the path to the stores/ 201 folder, you can use the Path.Combine function to do that.
                //Console.WriteLine(Path.Combine("stores", "201")); // outputs: stores/201

                ////The Path class can also tell you the extension of a filename. If you have a file and you want to know if it's a JSON file, you can use the Path.GetExtension function.
                //Console.WriteLine(Path.GetExtension("sales.json")); // outputs: .json

                ////The Path class contains many different methods that do various things. You can get the most information about a directory or a file by using the DirectoryInfo or FileInfo classes, respectively.
                //string fileName = $"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales{Path.DirectorySeparatorChar}sales.json";

                //FileInfo info = new FileInfo(fileName);

                //Console.WriteLine($"Full Name: {info.FullName}{Environment.NewLine}Directory: {info.Directory}{Environment.NewLine}Extension: {info.Extension}{Environment.NewLine}Create Date: {info.CreationTime}"); // And many more


                ////In this exercise, you'll use the Path class and Directory.GetCurrentDirectory to improve the program so it will find any file with a .json or .txt extension.
                //var currentDirectory = Directory.GetCurrentDirectory();
                //var storesDirectory = Path.Combine(currentDirectory, "stores");

                //var salesFiles = FindFiles(storesDirectory);

                //foreach (var file in salesFiles)
                //{
                //    Console.WriteLine(file);
                //}

                //IEnumerable<string> FindFiles(string folderName)
                //{
                //    List<string> salesFiles = new List<string>();

                //    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

                //    foreach (var file in foundFiles)
                //    {
                //        var extension = Path.GetExtension(file);
                //        if (extension == ".json")
                //        {
                //            salesFiles.Add(file);
                //        }
                //    }

                //    return salesFiles;
                //}

                ////Sometimes, you'll need to check if a directory already exists.
                //bool doesDirectoryExist = Directory.Exists(Directory.GetCurrentDirectory());


                ////Use the Directory.CreateDirectory method to create directories. The following method creates a new folder called newDir inside the 201 folder:
                //Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "stores", "201", "newDir"));


                ////You can create files by using the File.WriteAllText method. This method takes in a path to the file and the data you want to write to the file.If the file already exists, it will be overwritten.
                //File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "greeting.txt"), "Hello World!");




                ////Create the SalesTotals directory
                ////Write the totals.txt file
                //var currentDirectory = Directory.GetCurrentDirectory();
                //var storesDirectory = Path.Combine(currentDirectory, "stores");

                //var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
                //Directory.CreateDirectory(salesTotalDir);
                //var salesFiles = FindFiles(storesDirectory);

                //File.WriteAllText(Path.Combine(salesTotalDir, "totals.txt"), String.Empty);

                //IEnumerable<string> FindFiles(string folderName)
                //{
                //    List<string> salesFiles = new List<string>();

                //    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

                //    foreach (var file in foundFiles)
                //    {
                //        var extension = Path.GetExtension(file);
                //        if (extension == ".json")
                //        {
                //            salesFiles.Add(file);
                //        }
                //    }

                //    return salesFiles;
                //}

                ////Files are read through the ReadAllText method on the File class.
                //File.ReadAllText($"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales.json");


                ////Parse data in files
                //var salesJson = File.ReadAllText($"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales.json");
                //var salesData = JsonConvert.DeserializeObject<SalesTotal>(salesJson);

                //Console.WriteLine(salesData.Total);

                //var data = JsonConvert.DeserializeObject<SalesTotal>(salesJson);

                //File.WriteAllText($"salesTotalDir{Path.DirectorySeparatorChar}totals.txt", data.Total.ToString());

                //// totals.txt
                //// 22385.32


                ////Append data to files
                //var data2 = JsonConvert.DeserializeObject<SalesTotal>(salesJson);

                //File.AppendAllText($"salesTotalDir{Path.DirectorySeparatorChar}totals.txt", $"{data2.Total}{Environment.NewLine}");

                // totals.txt
                // 22385.32
                // 22385.32

                //Directory.EnumerateDirectories and Directory.EnumerateFiles accept a parameter that allows you to specify a search condition for names to return, and a parameter to recursively traverse all child directories.
                //System.Environment.SpecialFolder is an enumeration that lets you access system - defined folders, such as the desktop or user profile, in a cross-platform manner without having to memorize the exact path for each operating system.
                //If you need to parse other file types, check out the packages on nuget.org.For example, you can use the CsvHelper package for .csv files.



                ////arrays
                //int[] inventory = { 200, 450, 700, 175, 250 };
                //int sum = 0;
                //int bin = 0;
                //foreach (int items in inventory)
                //{
                //    sum += items;
                //    bin++;
                //    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
                //}
                //Console.WriteLine($"We have {sum} items in inventory.");
                //Console.WriteLine("Test");




                //string[] names = { "B123", "C234", "A345", "B177", "C235" };

                //foreach(var name in names)
                //{
                //    if (name.StartsWith("B"))
                //    {
                //        Console.WriteLine(name);
                //    }
                //}


                ////Test create 2nd Thread
                //Console.WriteLine("Start counting...");
                //StartCounting();
                //Console.WriteLine("Press any key to exit...");
                //Console.ReadKey();
                //Console.WriteLine("Exiting...");


                ////Trim 
                //string test1 = "    Test1";
                //string test2 = "Test2";
                //Console.WriteLine(test1.Trim());
                //Console.WriteLine(test2.Trim());

                //string s4 = "     Test0000";
                //Console.WriteLine("Before:" + s4);
                //Console.WriteLine("After:" + s4.Trim('0'));

                //char[] charsToTrim3 = { 'T', 'e', 's', 't' };
                //string s3 = "Test3Test4";
                //Console.WriteLine("Before:" + s3);
                //Console.WriteLine("After:" + s3.Trim(charsToTrim3));

                ////StringBuilder
                //StringBuilder sb1 = new StringBuilder();
                //sb1.Append("Test1");
                //sb1.AppendLine("Test1");
                //Console.WriteLine(sb1);

                //StringBuilder sb2 = new StringBuilder("Hello World2!");
                //sb2.Insert(5, "C#");
                //Console.WriteLine(sb2);

                //StringBuilder sb3 = new StringBuilder("Hello World3!");
                //sb3.Remove(5, 6);
                //Console.WriteLine(sb3);


                ////Array
                //int[] integ = new int[5];
                //for (int i = 0; i < 5; i++)
                //{
                //    integ[i] = i;
                //    Console.WriteLine(integ[i]);
                //}

                //string[] str = new string[] { "Test1", "Test2", "Test3" };
                //foreach(var item in str)
                //{
                //    Console.WriteLine(item);
                //}

                ////Linq methods
                //int max = integ.Max();
                //int min = integ.Min();
                //int sum = integ.Sum();
                //double avg = integ.Average();
                //Console.WriteLine(max);
                //Console.WriteLine(min);
                //Console.WriteLine(sum);
                //Console.WriteLine(avg);

                //int[] integ2 = new int[10];
                //for(int j = 0; j < 9; j++)
                //{
                //    integ2[j] = j;
                //}

                //int[] integ3 = new int[4] { 6, 1, 5, 3 };

                //Array.Sort(integ3);
                //Array.ForEach(integ3, n => Console.WriteLine(n));

                //Array.Fill(integ3,5);
                //Array.ForEach(integ3, n => Console.WriteLine(n));

                //Array.Reverse(integ3);
                //Array.ForEach(integ3, n => Console.WriteLine(n));

                //Array.BinarySearch(integ3, 3);// binary search 
                //Array.ForEach(integ3, n => Console.WriteLine(n));

                //string[] findMethod = new string[4] { "Test1", "Test2", "Test3", "Test4" };
                //var result = Array.Find(findMethod, n => n.Contains("Test1"));
                //Console.WriteLine(result);

                //var result = Array.FindLast(findMethod, n => n.Contains("Test"));
                //Console.WriteLine(result);

                ////Multidimensional Arrays
                //int[,] arr2d = new int[3, 2]
                //{
                //    { 1,2},{ 2,3}, {1,3}
                //};
                //// three-dimensional array
                //int[,,] arr3d = new int[1, 2, 2]
                //{
                //    { { 1, 2}, { 3, 4} }
                //};
                //// four-dimensional array
                //int[,,,] arr4d = new int[3, 2, 3, 4];
                //// five-dimensional array
                //int[,,,,] arr5d = new int[3, 2, 3, 4, 2]; 

                ////String.Join
                //string[] data = { "Test1", "Test2", "Test3", "Test4" };
                //var data2 = String.Join(", ", data);
                //Console.WriteLine(data2);

                //List<string> data3 = new List<string>();
                //data3.Add("Test1");
                //data3.Add("Test2");
                //data3.Add("Test3");
                //var data4 = String.Join(", ", data3);
                //Console.WriteLine(data4);

                ////String.Format
                //string data5 = "Test1";
                //string data6 = String.Format("Hello {0}", data5);
                //Console.WriteLine(data6);

                //int data7 = 7;
                //Console.WriteLine($"Hello {data7}");

                ////0 and 1 represent the first and second objects in the method ("Test1" and "Test2")
                ////-20 and - 14 represent the width of "Test1" and "Test2" respectively.
                ////Since - 20 and - 14 are negative numbers, "Test1" and "Test2" are left-aligned.
                //string data8 = string.Format("{0, -20} {1, -14}", "Test1", "Test2");
                //Console.WriteLine(data8);



                //var arrList = new ArrayList();
                //arrList.Add("Test1");
                //arrList.Add(1);
                //arrList.Add(true);
                //arrList.Add(null);
                //arrList.Add(4.5);
                //for(int i =0; i<arrList.Count; i++)
                //{
                //    Console.WriteLine(arrList[i]);
                //}

                //int[] data9 = new int[3] { 1,2,3};
                //arrList.AddRange(data9);
                //for (int i = 0; i < arrList.Count; i++)
                //{
                //    Console.WriteLine(arrList[i]);
                //}

                //insert an element at the specified index
                //arrList.Insert(1, "Test2");
                //for (int i = 0; i < arrList.Count; i++)
                //{
                //    Console.WriteLine(arrList[i]);
                //}

                ////insert a collection
                //ArrayList arlist2 = new ArrayList()
                //{
                //    300, 400, 500
                //};
                //arrList.InsertRange(1, arlist2);
                //for (int i = 0; i < arrList.Count; i++)
                //{
                //    Console.WriteLine(arrList[i]);
                //}

                //arrList.Remove(null); //Removes first occurance of null
                //arrList.RemoveAt(4); //Removes element at index 4
                //arrList.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)

                ////Contains
                //Console.WriteLine(arrList.Contains(null));


                ////IndexOf
                //string stop = " ";
                //string Name = "Dimitris Taskoudis";
                //int findStop = Name.IndexOf(stop);
                //string FirstName = Name.Substring(0, findStop);
                //string LastName = Name.Substring(findStop);
                //Console.WriteLine("LastName is : " + LastName.Trim());
                //Console.WriteLine("FirstName is : " + FirstName.Trim());


                ////List
                //var list = new List<string>();
                //list.Add("Test1");
                //list.Add("Test2");
                //list.Add("Test3");
                ////foreach (var item in list)
                ////{
                ////    Console.WriteLine(item);
                ////}

                ////Fist, Last
                //Console.WriteLine(list.Last());
                //Console.WriteLine(list.First());

                //var list = new List<string>();
                //list.Add("Test1");
                //list.Add("Test2");
                //list.Add("Test3");
                //string[] cities = new string[3] { "Mumbai", "London", "New York" };
                //list.AddRange(cities);
                ////foreach (var item in list)
                ////{
                ////    Console.WriteLine(item);
                ////}
                ////list.ForEach(n => Console.WriteLine(n + ", "));

                ////Insert
                //list.Insert(4, "Test4"); //inserts Test4 at 4rd index
                //list.ForEach(n => Console.WriteLine(n + ", "));

                //list.Remove("Test1");
                //list.ForEach(n => Console.WriteLine(n + ", "));

                //////removes the 2nd element
                //list.RemoveAt(2);
                //list.ForEach(n => Console.WriteLine(n + ", "));

                //Dictionary
                //Dictionary<int, string> dict = new Dictionary<int, string>();
                //dict.Add(1, "Test1");
                //dict.Add(2, "Test2");
                //dict.Add(3, "Test3");
                //foreach(KeyValuePair<int,string> item in dict)
                //{
                //    Console.WriteLine("Key {0} and Value {1}", item.Key, item.Value);
                //}

                ////use ContainsKey() to check for an unknown key
                //if (dict.ContainsKey(2))
                //{
                //    Console.WriteLine(dict[2]);

                //}
                //string result;
                //if (dict.TryGetValue(2, out result))
                //{
                //    dict[2] = "Test4";
                //    Console.WriteLine(result);
                //    Console.WriteLine(dict[2]);
                //}

                //if (dict.ContainsKey(1))
                //{
                //    dict.Remove(1);
                //}
                //foreach (KeyValuePair<int, string> item in dict)
                //{
                //    Console.WriteLine("Key {0} and Value {1}", item.Key, item.Value);
                //}

                //TestInterface test = new UsefulTools();
                //test.PTheory();
                //test.test();
                //Console.ReadLine();
                #endregion



                ////Type
                //int numInt = 500;

                //// get type of numInt
                //Type n = numInt.GetType();

                //// Implicit Conversion
                //double numDouble = numInt;

                //// get type of numDouble
                //Type n1 = numDouble.GetType();

                //string str = numInt.ToString();
                //Type n2 = str.GetType();


                //// Value before conversion
                //Console.WriteLine("numInt value: " + numInt);
                //Console.WriteLine("numInt Type: " + n);

                //// Value after conversion
                //Console.WriteLine("numDouble value: " + numDouble);
                //Console.WriteLine("numDouble Type: " + n1);

                //// Value before conversion
                //Console.WriteLine("numInt value: " + str);
                //Console.WriteLine("numInt Type: " + n2);

                //Console.ReadLine();


                ////Attribute
                //var test = from t in Assembly.GetExecutingAssembly().GetTypes()
                //           where t.GetCustomAttributes(false).Any(a => a is TestAttribute)
                //           select t;
                //foreach(Type t in test)
                //{
                //    Console.WriteLine(t.Name);
                //}


                //Bytes
                //string: Encoding.ASCII.GetBytes() or Encoding.UTF8.GetBytes()
                //int, float, double, long, short, byte: BitConverter.GetBytes()
                //bool: BitConverter.GetBytes() or new byte[] { value ? (byte)1 : (byte)0 }
                //DateTime: BitConverter.GetBytes() or DateTime.ToBinary() and BitConverter.GetBytes()


                ////Convert string/int to bytes
                //string str = "Test";
                //byte[] dataString = Encoding.ASCII.GetBytes(str);
                //byte[] dataString2 = Encoding.UTF8.GetBytes(str);

                //int Int = 10;
                //byte[] dataInt = BitConverter.GetBytes(Int);


                ////Convert bytes to string/int
                //byte[] intBytes = new byte[] { 0x01, 0x00, 0x00, 0x00 }; // Represents the integer value 1
                //int myInt = BitConverter.ToInt32(intBytes, 0);

                //byte[] messageBytes = new byte[] { 72, 101, 108, 108, 111, 44, 32, 119, 111, 114, 108, 100, 33 };
                //string message = Encoding.UTF8.GetString(messageBytes);


                ////Json
                ////Serialize
                //Person person = new Person { Name = "John", Age = 30 };
                //string jsonString = JsonSerializer.Serialize(person);


                ////Deserialize
                //string jsonString = "{\"Name\":\"John\",\"Age\":30}";
                //Person person2 = JsonSerializer.Deserialize<Person>(jsonString);


                //string jsonString3 = "{\"Name\":\"John\",\"Age\":30}";
                //using (JsonDocument document = JsonDocument.Parse(jsonString3))
                //{
                //    JsonElement root = document.RootElement;
                //    string name = root.GetProperty("Name").GetString();
                //    int age = root.GetProperty("Age").GetInt32();
                //    Console.WriteLine($"Name: {name}, Age: {age}");
                //}


                ////Lock
                //for (int i = 0; i < 10; i++)
                //{
                //    ThreadStart start = new ThreadStart(TestLock);
                //    new Thread(start).Start();
                //}


                ////Monitor
                //Thread[] Threads = new Thread[3];
                //for (int i = 0; i < 3; i++)
                //{
                //    Threads[i] = new Thread(new ThreadStart(PrintNumbers));
                //    Threads[i].Name = "Child " + i;
                //}
                //foreach (Thread t in Threads)
                //    t.Start();


                //////Task class
                /////the Task.Run method to start a background task that performs some work. The Main method also continues doing some work on the main thread while the background task is running. 

                //Console.WriteLine("Main Thread is running!");

                //Task.Run(() =>
                //{
                //    Console.WriteLine("Background task is started!");
                //    for (int i = 0; i < 10; i++)
                //    {
                //        Console.WriteLine($"Background task iteration {i}.");
                //        Task.Delay(1000).Wait();
                //    }
                //    Console.WriteLine("Background task completed.");
                //});

                //// Continue doing some work on the main thread while the background task is running
                //for (int i = 0; i < 3; i++)
                //{
                //    Console.WriteLine($"Main thread iteration {i}.");
                //    Task.Delay(500).Wait();
                //}
                //Console.WriteLine("Main thread completed.");

                //Json to bytes

                ////Timer
                //timer = new System.Timers.Timer(5000);
                //timer.Elapsed += TimerElapsed;
                //timer.Start();
                //Console.ReadLine();
                ////When I want to stop the execute
                //timer.Stop();


                Console.ReadLine();

            }

            //Timer
            private static void TimerElapsed(object sender, ElapsedEventArgs e)
            {
                //Do something
                Console.WriteLine("Time to elapsed..." + e.SignalTime);
            }


            //static readonly object _object = new object();

            ////Lock
            //static void TestLock()
            //{

            //    lock (_object)
            //    {
            //        Thread.Sleep(100);
            //        Console.WriteLine(Environment.TickCount);
            //    }
            //}

            ////Queue, Lock statement
            //static Queue<int> que = new Queue<int>();
            //static readonly object locker = new object();

            //private static void Consumer(object? obj)
            //{
            //    for(int i = 0; i <= 10; i++)
            //    {
            //        lock (locker)
            //        {
            //            que.Enqueue(i);
            //            Console.WriteLine($"Enqueued: {i}");
            //        }
            //        Thread.Sleep(1000);
            //    }


            //}

            //private static void Producer(object? obj)
            //{
            //    while (true)
            //    {
            //        lock (locker)
            //        {
            //            if (que.Count > 0)
            //            {
            //                int value = que.Dequeue();
            //                Console.WriteLine($"Dequeued: {value}");
            //            }
            //        }

            //        Thread.Sleep(1000);
            //    }

            //}



            //Threads
            //static void DoWork2()
            //{
            //    Console.WriteLine("Worker 2 thread started...");
            //    // Do some work...
            //    Thread.Sleep(5000);
            //    Console.WriteLine("Worker 2 thread finished...");
            //}
            //static void DoWork()
            //{
            //    Console.WriteLine("Worker 1 thread started...");
            //    // Do some work...
            //    Thread.Sleep(5000);
            //    Console.WriteLine("Worker 1 thread finished...");
            //}



        }

        //Lock statement
        //By using the lock statement, we ensure that only one thread can access the Increment and Decrement methods at a time,
        //preventing race conditions and other synchronization issues that could arise if multiple threads tried to access the shared count variable simultaneously.
        //public class Counter
        //{
        //    private int count = 0;
        //    private readonly object lockObject = new object();

        //    public void Increment()
        //    {
        //        lock (lockObject)
        //        {
        //            count++;
        //            Console.WriteLine($"Incremented count to {count}");
        //        }
        //    }

        //    public void Decrement()
        //    {
        //        lock (lockObject)
        //        {
        //            count--;
        //            Console.WriteLine($"Decremented count to {count}");
        //        }
        //    }
        //}

        
        ////Delegate
        //public delegate int Calculate(int x, int y);
        //public delegate string StringJoin(string a, string b);

        //public class StringJoins
        //{
        //    public static string AddStr(string a, string b)
        //    {
        //        return string.Join(", ",  a + b);
        //    }
        //}


        //public class Calculator
        //{
        //    public static int Add(int x, int y)
        //    {
        //        return x + y;
        //    }

        //    public static int Subtract(int x, int y)
        //    {
        //        return x - y;
        //    }
        //}

        //public class Person
        //{
        //    public string Name { get; set; }
        //    public int Age { get; set; }
        //}


        //class SalesTotal
        //{
        //    public double Total { get; set; }
        //}

        ////Δημιυοργία μιας method
        //static void SayHi(string name, int age)
        //{
        //    Console.WriteLine("Hello " + name + "  your age is " +  age);
        //}


        //static int cube(int num)
        //{
        //    int result = num * num * num;
        //    return result;
        //}

        //static int[] cube(int num)
        //{
        //    int[] result = new int[2];
        //    result[0] = num;
        //    result[1] = num*2;
        //    return result;
        //}



        //Method If states
        //static int GetMax(int num1, int num2)
        //{
        //    int result;
        //    if (num1 > num2)
        //    {
        //        result = num1;
        //    }
        //    else
        //    {
        //        result = num2;
        //    }
        //    return result;
        //}



        //// Ελέγχει τα cases και όποιο ειναι true το εκτελεί. Το break σταματάει την εκτέλεση από το switch
        //static string GetDay(int dayNum)
        //{
        //    string dayName;
        //    switch (dayNum)
        //    {
        //        case 0:
        //            dayName = "Sunday";
        //            break;
        //        case 1:
        //            dayName = "Monday";
        //            break;
        //        case 2:
        //            dayName = "Tuesday";
        //            break;
        //        case 3:
        //            dayName = "Wednesday";
        //            break;
        //        case 4:
        //            dayName = "Thursday";
        //            break;
        //        case 5:
        //            dayName = "Friday";
        //            break;
        //        case 6:
        //            dayName = "Saturday";
        //            break;
        //        default:
        //            dayName = "Invalid Name";
        //            break;
        //    }

        //    return dayName;
        //}




        ////Build exponend method
        //static int GetPow(int baseNum, int powNum)
        //{
        //    int result = 1;

        //    //Τρέχει το for loop powNum φορές
        //    for(int i = 0; i < powNum; i++)
        //    {
        //        result = result * baseNum;
        //    }


        //    return result;
        //}



        //private static void StartCounting()
        //{
        //    //The thread is end when loop is end
        //    var thread = new Thread(() =>
        //    {
        //        for (var x = 0; x < 10; x++)
        //        {
        //            Console.Write("{0}... ", x);
        //            Thread.Sleep(1000);
        //        }
        //    });
        //    thread.Start();

        //}


        //class TestAttribute : Attribute { }

        //[TestAttribute]
        //class MyTest
        //{

        //}

    }
}

