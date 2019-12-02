using System;
using System.Collections.Generic;
using System.Text;

namespace interf_1
{
    class IsoscelesTriangle : EquilateralTriangle
    {
        private double baselength { get; set; }

        public IsoscelesTriangle()
        {
            Console.WriteLine("Enter baseLength >");
            this.baselength = Math.Abs(Convert.ToDouble(Console.ReadLine()));
        }

        public new double Area()
        {
            double sideLength = this.getSideLength();
            double a = ((double)1 / 4 * baselength * Math.Sqrt(4 * (4 * (sideLength * sideLength) - (baselength * baselength))));
            return a;
        }


        public new void W()
        {
            Console.WriteLine("IsoscelesTriangle sideLength is {0}", this.getSideLength());
            Console.WriteLine("IsoscelesTriangle baseLength is {0}", baselength);
            Console.WriteLine("IsoscelesTriangle area is {0}", this.Area());
        }
    }
}
