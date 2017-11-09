using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Yakubun ykb = new Yakubun();
            int bsi1 = rnd.Next(1, 11);
            int bbo1 = rnd.Next(1, 11);
            int bsi2 = rnd.Next(1, 11);
            int bbo2 = rnd.Next(1, 11);
            ykb.Bunsi = bsi1;
            ykb.Bunbo = bbo1;
            ykb.keisan();
            Console.Write(" + ");
            ykb.Bunsi = bsi2;
            ykb.Bunbo = bbo2;
            ykb.keisan();
            Console.Write(" = ");
            ykb.Bunsi = bsi1 * bbo2 + bsi2 * bbo1;
            ykb.Bunbo = bbo1 * bbo2;
            ykb.keisan();
            Console.WriteLine();
        }
    }
}
