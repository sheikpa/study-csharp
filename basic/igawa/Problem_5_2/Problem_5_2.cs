using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_5_2
    {
        static void Main(string[] args)
        {
            double[] b = { 0.2,-5.1,3.2,1.8};
            for (int i = 0; i < 4; i++)
            {
                Console.Write("b[{0}]={1} ", i, b[i]);
            }
            Console.WriteLine();
        }
    }
}
