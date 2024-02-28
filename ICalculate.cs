using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    interface ICalculate
    {
        int Sum(int num01, int num02);
        int Minus(int num01, int num02);
        int Multiple(int num01, int num02);
        int Div(int num01, int num02);


    }
}
