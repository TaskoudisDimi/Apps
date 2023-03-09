using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class Movie
    {

        public string title;
        public string director;
        private string rating; 
        //To attribute rating που όρισα είναι private, άρα μπορεί να χρησιμοποιηθεί μονο σε αυτή τη Movie class.
        //Με τον ορισμό των getters - setters θα το περάσω σαν public στο main Program


        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;   
            Rating = aRating;

        }




        public string Rating
        {
            //Μας επιτρέπει να πάρουμε το rating (get rating)
            get
            {
                return rating;
            }

            //Μας επιτρέπει να ορίσουμε το rating και να ελέγξω αν ειναι κάποια απο αυτές τις τιμές
            set
            {
                if (value == "PG" || value == "PG-13" || value == "R" || value == "G")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }

    }
}
