﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class UsefulTools : TestInterface
    {
        public void test()
        {
            Console.WriteLine("Test");
        }
        public static void SayHi(string name)
        {
            Console.WriteLine("Hello " + name);    
        }

    }
}
