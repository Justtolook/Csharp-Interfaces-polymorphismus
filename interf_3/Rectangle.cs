using System;
using System.Collections.Generic;
using System.Text;

namespace Annika_Interfaces
{
    class Rectangle : RightTriangle
    {
        public new double Area()
        {
            return getCatheti1() * getCatheti2();
        }


        public new void W()
        {
            Console.WriteLine("Rectangle sides are {0} and {1}", getCatheti1(), getCatheti2());
            Console.WriteLine("Rectangle area is {0}", Area());
        }
    }
}
