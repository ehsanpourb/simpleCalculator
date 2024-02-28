using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Calculate : ICalculate
    {
        public int Div(int num01, int num02)
        {
            return num01 / num02;
        }

        public int Minus(int num01, int num02)
        {
            return num01 - num02;
        }

        public int Multiple(int num01, int num02)
        {
            return num01 * num02;
        }

        public int Sum(int num01, int num02)
        {
            return num01 + num02;
        }
    }
}
