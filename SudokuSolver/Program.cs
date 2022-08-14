using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;


namespace SudokuSolver
{
    class Program
    {

        static void Main(string[] args)
        {

            //StringBuilder string1 = new StringBuilder();
            //string1.Append("my name is");
            //string1.Append("Dimitris Taskoudis");


            ////καταλαμβάνει πολύ περισσότερο χώρο στη μνήμη αυτό από οτι το να χρησιμοποιήσω το StringBuilder Append
            //string string2 = "my name is";
            //string2 = string2 + "Dimitris Taskoudis";


            ////Το array είναι πίνακας που περιλαμβάνει άλλους πίνακες. Το κάθε στοιχείο του πίνακα μπορεί να έχει άλλο μέγεθος
            //int[][] array = new int[10][];
            //array[0] = new int[90];
            //array[1] = new int[80];

            ////Πίνακας 10,10
            //int[,] matrix = new int[10, 10];

            ////Μπορώ να χρησιμοποιώ matrix ή array που περιλαμβάνει άλλους πίνακες. To δεύτερο σε περίπτωση που έχω μεγάλο πλήθος δεδομένων
            ////Χρησιμοποιώ το δεύτερο σε περίπτωση που θέλω μεγαλύτερη απόδοση στον αλγόριμο

            ////DIY: Dependenjy Injection είναι ένα deisng pattern 
            ////Η class Person απαιτεί το car, άρα το car είναι dependency του person
            //Car car = new Car();
            //Person person = new Person(car);
            //person.Drive();



            ////Interface: Reference Type
            //Ferrari ferrari = new Ferrari();
            ////Δηλώνω ποιο αυτοκινήτο συγκεκριμένα θέλω να πάρει η class Person
            //Lambo lambo = new Lambo();
            //Person person = new Person(lambo);
            //person.Drive();


            ////Abstract class Car
            ////Δηλώνω τη base class Car
            //Car ferrari = new Ferrari();
            ////Δηλώνω ποιο αυτοκινήτο συγκεκριμένα θέλω να πάρει η class Person
            //Car lambo = new Lambo();
            //Person person = new Person(lambo);
            //person.Drive();


            ////LINQ
            //Hobbie[] hobbies = { new Hobbie(1, "Walking"), new Hobbie(2, "Swimming"), new Hobbie(3, "Bodybuilding") };

            ////Κρατάω σε λίστα τα δεδομένα που θέλω ανάλογα με τη συνθήκη
            //var hobbie = hobbies.Where(h => h.Name.Contains("Walking")).Select(h => h.Name);
            //var anotherHobbie = from h in hobbies where h.Name.Equals("Walking") select h;
            //var hobbieID = hobbies.Where(h => h.ID > 1);

            ////Κρατάω όλα τα στοιχεία απο το hobbies και κάνω skip το πρώτο
            //var everyHobbie = hobbies.Skip(1);
            ////Κρατάω μόνο το 2ο
            //var swimmingHobbie = hobbies.Skip(1).Take(2);


        }

        //class Hobbie
        //{
        //    public int ID { get; set; }
        //    public string Name { get; set; }

        //    public Hobbie(int id, string name)
        //    {
        //        ID = id;
        //        Name = name;

        //    }
        //}





    }
}


