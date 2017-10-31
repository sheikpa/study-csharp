using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_4_15
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (true)
            {
                Console.Write("{0} ", i);
                if(i % 10 == 0)
                {
                    Console.WriteLine();
                }
                if (i % 100 == 0)
                {
                    break;
                }
                i++;
            }

        }
    }
}
