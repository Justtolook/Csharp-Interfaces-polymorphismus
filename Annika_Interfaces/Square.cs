using System;
using System.Collections.Generic;
using System.Text;

namespace Annika_Interfaces
{
    class Square : Interface1<Square>
    {
        private double side { get; set; }

        public Square()
        {
            Console.WriteLine("Enter side >");
            side = Math.Abs(Convert.ToDouble(Console.ReadLine()));
        }

        public Square(double side)
        {
            this.side = side;
        }

        public double getSide()
        {
            return side;
        }

        public double Area()
        {
            return side * side;
        }

        public double Perimeter()
        {
            return 4 * side;
        }

        public void W()
        {
            Console.WriteLine("Square side is {0}", side);
            Console.WriteLine("Square area is {0}", Area());
            Console.WriteLine("Square Perimeter is {0}", Perimeter());
        }
    }
}
