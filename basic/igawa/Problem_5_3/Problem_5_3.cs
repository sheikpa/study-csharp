using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_5_3
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] data = new int[10];
            for (int i = 0; i < 10; i++)
            {
                data[i] = rnd.Next(1, 100);
                Console.Write("{0} ", data[i]);
            }
            Console.WriteLine();

            Console.Write("奇数：");
            foreach(int i in data)
            {
                if(i % 2 == 1)
                {
                    Console.Write("{0} ",i);
                }
            }
            Console.WriteLine();

            Console.Write("偶数：");
            foreach (int i in data)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}
