using Lesson1.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using Nancy.Json;
using System.Net.Sockets;
using System.Text;

namespace Lesson1

{
    class Tutorial  //Η class είναι ένα container που μπορώ να γράψω κώδικα
    {
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



        class Program
        {
            //public delegate void AddVal(int x, int y);
            //public void SMeth(int x, int y)
            //{
            //    Console.WriteLine("[{0} + {1}] = [{2}]", x, y, x + y);
            //}

            static void Main(string[] args)
            {

                #region Comments

                //Delegate
                //// Creating the object of Program class
                //Program o = new Program();

                //// Creating object of delegate
                //AddVal obj = new AddVal(o.SMeth);

                //// Pass the values to the method
                //// Using delegate object
                //obj(190, 70);

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

                #endregion

                ////Test create 2nd Thread
                //Console.WriteLine("Start counting...");
                //StartCounting();
                //Console.WriteLine("Press any key to exit...");
                //Console.ReadKey();
                //Console.WriteLine("Exiting...");
                TcpListener serverSocket = new TcpListener(8888);
                int requestCount = 0;
                TcpClient clientSocket = default(TcpClient);
                serverSocket.Start();
                Console.WriteLine(" >> Server Started");
                clientSocket = serverSocket.AcceptTcpClient();
                Console.WriteLine(" >> Accept connection from client");
                requestCount = 0;

                while ((true))
                {
                    try
                    {
                        requestCount = requestCount + 1;
                        NetworkStream networkStream = clientSocket.GetStream();
                        byte[] bytesFrom = new byte[10025];
                        networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                        string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                        dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                        Console.WriteLine(" >> Data from client - " + dataFromClient);
                        string serverResponse = "Last Message from client" + dataFromClient;
                        Byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                        networkStream.Write(sendBytes, 0, sendBytes.Length);
                        networkStream.Flush();
                        Console.WriteLine(" >> " + serverResponse);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }

                clientSocket.Close();
                serverSocket.Stop();
                Console.WriteLine(" >> exit");
                Console.ReadLine();

            }


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


        }
    }
}

