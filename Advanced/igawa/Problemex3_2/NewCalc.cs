using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemex3_2
{
    class NewCalc : FundCalc
    {
        public double Mul()
        {
            return number1 * number2; 
        }
        public double Div()
        {
            return number1 / number2;
        }
        //  二つの数の和を出力
        public override double Add()
        {
            return number1 + number2;
        }
        //  二つの数の差を出力
        public double Sub()
        {
            return number1 - number2;
        }
    }
}
