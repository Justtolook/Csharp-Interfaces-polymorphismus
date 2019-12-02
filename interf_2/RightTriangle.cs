using System;
using System.Collections.Generic;
using System.Text;

namespace Annika_Interfaces
{
    class RightTriangle : Interface1 <RightTriangle>
    {
        private double Catheti1 { get; set; }
        private double Catheti2 { get; set; }
        public RightTriangle()
        {
            Console.WriteLine("Enter Catheti1 >");
            Catheti1 = Math.Abs(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Enter Catheti2 >");
            Catheti2 = Math.Abs(Convert.ToDouble(Console.ReadLine()));
        }

        public RightTriangle(float c1, float c2)
        {
            Catheti1 = Math.Abs(c1);
            Catheti2 = Math.Abs(c2);
        }

        public double getCatheti1()
        {
            return Catheti1;
        }

        public double getCatheti2()
        {
            return Catheti2;
        }

        private double Hypothenuse()
        {
            return Math.Sqrt(Catheti1 * Catheti1 + Catheti2 * Catheti2);
        }

        public double Perimeter()
        {
            return Catheti1 + Catheti2 + Hypothenuse();
        }

        public void W()
        {
            Console.WriteLine("RightTriangle catheti are {0} and {1}", Catheti1, Catheti2);
            Console.WriteLine("RightTriangle Hypothenuse is {0}", Hypothenuse());
            Console.WriteLine("RightTriangle Perimeter is {0}", Perimeter());
        }
    }
}
