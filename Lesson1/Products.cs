using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class Products
    {
        public int id { get; set; }
        public string Name { get; set; }
        public Categories Category { get; set; }

    }

    public enum Categories
    {
        Meat, Milk, Sugars
    }
}
