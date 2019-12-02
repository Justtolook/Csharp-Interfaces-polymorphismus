using System;
using System.Collections.Generic;
using System.Text;

namespace Annika_Interfaces
{
    class Triangle : RightTriangle
    {
        private double sidec { get; set; }

        public Triangle()
        {
            Console.WriteLine("Enter sidec >");
            sidec = Math.Abs(Convert.ToDouble(Console.ReadLine()));
        }

        public new double Perimeter()
        {
            return sidec + getCatheti1() + getCatheti2();
        }

        public new void W()
        {
            Console.WriteLine("Triangle sidea is {0} and sideb is {1}", getCatheti1(), getCatheti2());
            Console.WriteLine("Triangle side c is {0}", sidec);
            Console.WriteLine("Triangle Perimeter is {0}", Perimeter());
        }
    }
}
