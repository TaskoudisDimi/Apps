using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Data
{
    public class Store
    {
        public List<Books> books { get; set; }

        public List<Movie> movie { get; set; }

        public Store()
        {
            books = new List<Books>();
        }


    }
}
