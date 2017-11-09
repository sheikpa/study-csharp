using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            MinMax m = new MinMax();
            int rndmin = 0;
            int rndmax = 10;
            int a = rnd.Next(rndmin, rndmax);
            int b = rnd.Next(rndmin, rndmax);
            int c = rnd.Next(rndmin, rndmax);
            Console.WriteLine("{0}と{1}と{2}のうち、最大のものは{3}", a, b, c, m.Max(a, b, c));
            Console.WriteLine("{0}と{1}と{2}のうち、最小のものは{3}", a, b, c, m.Min(a, b, c));
        }
    }
}
