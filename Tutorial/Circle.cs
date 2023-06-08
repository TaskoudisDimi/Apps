using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    public class Circle : Shape
    {
        private readonly double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        //Πρεπει να φτιάξω τις δυο method του Shape
        public override double CalculateArea()
        {
            return Math.PI*radius*radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }

    }
}
