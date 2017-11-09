using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6_1
{
    //  最大値と最小値を求めるクラス
    class MinMax
    {
        //  最大値の取得
        public int Max(int n1, int n2, int n3)
        {
            if (n3 <= n1 && n2 <= n1)
            {
                return n1;
            }
            else if(n1 <= n3 && n2 <= n3)
            {
                return n3;
            }
            else
            {
                return n2;
            }
            
        }
        //  最大値の取得
        public int Min(int n1, int n2, int n3)
        {
            if (n1 <= n2 && n1 <= n3)
            {
                return n1;
            }
            else if (n3 <= n2 && n3 <= n1)
            {
                return n3;
            }
            else
            {
                return n2;
            }
        }
    }
}