using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_5_5
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int sz = 10;
            int[] data = new int[sz];
            for (int i = 0; i < sz; i++)
            {
                data[i] = rnd.Next(1, 10);
                Console.Write("{0} ", data[i]);
            }
            Console.WriteLine();

            Console.Write("3の倍数：");
            foreach (int i in data)
            {
                if (i % 3 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();

            Console.Write("3の倍数以外：");
            foreach (int i in data)
            {
                if (i % 3 != 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();

        }
    }
}
