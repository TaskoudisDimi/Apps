using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Data
{
    public class Books
    {


        public string TitleBook { get; set; }
        public int AgeBook { get; set; }
        public bool Sold { get; set; }
        public double Price { get; set; }




        public string Display
        {
            get
            {
                return string.Format("{0} - {1} - {2}", TitleBook, AgeBook, Price);
            }

        }


    }
}
