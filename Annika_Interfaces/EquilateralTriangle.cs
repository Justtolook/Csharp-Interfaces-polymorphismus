using System;
using System.Collections.Generic;
using System.Text;

namespace Annika_Interfaces
{
    class EquilateralTriangle : Interface1<EquilateralTriangle>
    {
        private double sideLength { get; set; }
        public EquilateralTriangle()
        {
            Console.WriteLine("Enter sideLength >");
            sideLength = Math.Abs(Convert.ToDouble(Console.ReadLine()));
        }

        public EquilateralTriangle(float c1)
        {
            sideLength = Math.Abs(c1);
        }

        public void setSideLength(double d)
        {
            sideLength = d;
        }

        public double getSideLength()
        {
            return sideLength;
        }

        public double Area()
        {
            return (sideLength * sideLength * Math.Sqrt(3)/4);
        }


        public double Perimeter()
        {
            return sideLength * 3;
        }

        public void W()
        {
            Console.WriteLine("EquilateralTriangle sideLength is {0}", sideLength);
            Console.WriteLine("EquilateralTriangle area is {0}", Area());
            Console.WriteLine("EquilateralTriangle Perimeter is {0}", Perimeter());
        }
    }
}
