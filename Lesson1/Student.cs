using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Student
    {
        public string name;
        public string major;
        public double gpa;


        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;

        }


        //Create method
        public bool HasHonor()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
