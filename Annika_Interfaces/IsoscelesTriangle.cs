using System;
using System.Collections.Generic;
using System.Text;

namespace Annika_Interfaces
{
    class IsoscelesTriangle : EquilateralTriangle
    {
        private double baselength { get; set; }

        public IsoscelesTriangle()
        {
            Console.WriteLine("Enter sideLength >");
            this.setSideLength(Math.Abs(Convert.ToDouble(Console.ReadLine())));
            Console.WriteLine("Enter baseLength >");
            this.baselength = Math.Abs(Convert.ToDouble(Console.ReadLine()));
        }

        public new double Area()
        {
            return (baselength * (1 / 4) * Math.Sqrt(4 * (4 * this.getSideLength() * this.getSideLength() - baselength * baselength)));
        }

        public new double Perimeter()
        {
            return baselength + 2 * this.getSideLength();
        }

        public new void W()
        {
            Console.WriteLine("IsoscelesTriangle sideLength is {0}", this.getSideLength());
            Console.WriteLine("IsoscelesTriangle baseLength is {0}", baselength);
            Console.WriteLine("IsoscelesTriangle area is {0}", Area());
            Console.WriteLine("IsoscelesTriangle Perimeter is {0}", Perimeter());
        }
    }
}
