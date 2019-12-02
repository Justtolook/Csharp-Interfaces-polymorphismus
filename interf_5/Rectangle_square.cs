using System;
using System.Collections.Generic;
using System.Text;

namespace Annika_Interfaces
{
    class Rectangle_square : Square
    {
        private double sideb { get; set; }

        public new double Area()
        {
            return sideb * getSide();
        }


        public new void W()
        {
            Console.WriteLine("Rectangle sides are {0} and {1}", getSide(), sideb);
            Console.WriteLine("Rectangle area is {0}", Area());
        }

    }
}
