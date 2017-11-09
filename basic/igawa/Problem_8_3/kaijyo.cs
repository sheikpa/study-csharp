using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8_3
{
    class kaijyo
    {

        private long n = 0;

        public long N
        {
            set { n = value; }
            get { return n; }
        }
        public long KeisanKaijyo()
        {
            n -= 1;
            if(0 < n)
            {
                return (n+1) * this.KeisanKaijyo();
            }
            return 1;
        }
    }
}
