using System;

namespace interf_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            EquilateralTriangle et1 = new EquilateralTriangle();
            et1.W();
            IsoscelesTriangle it1 = new IsoscelesTriangle();
            it1.W();
        }
    }
}
