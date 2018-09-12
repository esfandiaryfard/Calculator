using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class calculate
    {
        public calculate(int a, int b)
        {
            add(a,b);
            subtract(a, b);
            multiple(a ,b);
            divide(a, b);

        }
        public int add(int a, int b)
        {
            return a + b;
        }
        public int subtract(int a, int b)
        {
            return a - b;
        }
        public int multiple(int a, int b)
        {
            return a * b;
        }
        public int divide(int a, int b)
        {
            return a / b;
        }
    }
}
