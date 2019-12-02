using System;
using System.Collections.Generic;
using System.Text;

namespace interf_0
{
    class IntegerNumber : InterfaceInt<IntegerNumber>
    {
        private int N;

        public IntegerNumber(int n)
        {
            this.N = n;
        }
        public int MultipliedBy2()
        {
            return 2 * N;
        }
    }
}
