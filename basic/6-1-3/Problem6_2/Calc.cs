using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6_2
{
    //  和、差、積、商を求めるクラス
    class Calc
    {
        //  和の取得
        public double Add(double d1, double d2)
        {
            return d1 + d2;
        }
        //  差の取得
        public double Sub(double d1, double d2)
        {
            return d1 - d2;
        }
        //  積の取得
        public double Mul(double d1, double d2)
        {
            return d1 * d2;
        }
        //  商の取得
        public double Div(double d1, double d2)
        {
            return d1 / d2;
        }
    }
}