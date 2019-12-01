using System;

namespace Annika_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            RightTriangle T1 = new RightTriangle(-3, -5); T1.W();
            RightTriangle T2 = new RightTriangle(6, 2); T2.W();
            RightTriangle T3 = new RightTriangle(); T3.W();
            Console.ReadLine();
        }
    }
}
