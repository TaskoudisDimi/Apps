using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Book
    {

        //Καλούνται class atributes
        public string title;
        public string author;
        public int pages;


        //Build constructor
        public Book(string aTitle, string aAthor, int aPages)
        {
            title = aTitle; //title = τίτλος του object θα ειναι ισος με τον aTitle που θα δωθει απο τον χρήστη ως παράμετρος στον constructor
            author = aAthor;
            pages = aPages;

        }


        //Μπορώ να φτιάξω constructor με το ίδιο όνομα
        public Book()
        {

        }

    }
}
