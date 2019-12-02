using System;
using System.Collections.Generic;
using System.Text;

namespace interf_0
{
    class Circle : IntegerNumber
    {
        private IntegerNumber radius;

        public Circle(int r)
        {
            this.radius = new IntegerNumber(r);
        }

        public double Circumfence()
        {
            
            return (double)Math.PI * radius.MultipliedBy2();
        }

        public void W()
        {
            Console.WriteLine("Circumfence: {0}", Circumfence());
        }
    }
}
