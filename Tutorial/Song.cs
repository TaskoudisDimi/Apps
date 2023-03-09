using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Song
    {

        // Attributes
        public string title;
        public string artist;
        public int duration;

        //Yπάρχουν και τα static attributes τα οποία είναι attributes για όλη τη class
        // Π.χ. το title ειναι διαφορετικό για κάθε object της main Class
        // Όμως μια static attribute εχει την ιδια τιμή σε όλα τα object της Class

        public static int songCount = 0;




        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++; //Κάθε φορά που δημιουργείται ένα object Song στη main Class, το songCount θα αυξάνεται

        }
        
        public int getSongCount()
        {
            return songCount;
        }
    }
}
