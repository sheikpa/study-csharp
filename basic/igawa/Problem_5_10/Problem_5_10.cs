using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_5_10
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int sz = 7;

            int[] data = new int[sz];

            for (int i = 0; i < sz; i++)
            {
                data[i] = rnd.Next(1, 10);
                Console.Write("{0} ", data[i]);
            }
            Console.WriteLine();
            for (int j = 0; j < sz; j++)
            {
                for (int i = 0; i < data[j]; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
