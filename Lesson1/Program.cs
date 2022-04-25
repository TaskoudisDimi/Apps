using Lesson1.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Lesson1

{


    //class Tutorial  //Η class είναι ένα container που μπορώ να γράψω κώδικα
    //{
    //    static void Main(string[] args) //Method or function 
    //    {
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




    class Program
    {

        static void Main(string[] args)
        {
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
            //// Για αυτό χρησιμοποιούμαι getters - setters
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






            Console.ReadLine();
       
        }

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




    }
}

