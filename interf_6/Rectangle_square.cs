using System;
using System.Collections.Generic;
using System.Text;

namespace Annika_Interfaces
{
    class Rectangle_square : Square
    {
        private double sideb { get; set; }


        public new double Perimeter()
        {
            return 2 * (sideb + getSide());
        }

        public void W()
        {
            Console.WriteLine("Rectangle sides are {0} and {1}", getSide(), sideb);
            Console.WriteLine("Rectangle Perimeter is {0}", Perimeter());
        }

    }
}
