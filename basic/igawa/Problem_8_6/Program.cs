using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Yakubun ykb = new Yakubun();
            int bsi1 = rnd.Next(1, 11);
            int bbo1 = rnd.Next(2, 11);
            int bsi2 = rnd.Next(1, 11);
            int bbo2 = rnd.Next(2, 11);
            ykb.Bunsi = bsi1*bbo2 + bsi2*bbo1;
            ykb.Bunbo = bbo1 * bbo2;
            Console.Write("{0}/{1} + {2}/{3} = ", bsi1, bbo1, bsi2, bbo2);
            ykb.keisan();
        }
    }
}
