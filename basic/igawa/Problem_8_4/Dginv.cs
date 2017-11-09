using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8_4
{
    class Dginv
    {
        private int n = 0;
        private int lv = 0;

        public int N
        {
            set { n = value; }
            get { return n; }
        }
        public int DigitInv()
        {
            if (n < 10)
            {
                return lv+=1;
            }
            else
            {
                n /= 10;
                lv += 1;
                return DigitInv();
            }
        }
    }
}
