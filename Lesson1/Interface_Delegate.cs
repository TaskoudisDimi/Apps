using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class Interface_Delegate
    {
        public delegate void Calc(int x, int y);
        public int Calculate(int x1, int y1)
        {
            return x1 + y1;
        }


    }
}
