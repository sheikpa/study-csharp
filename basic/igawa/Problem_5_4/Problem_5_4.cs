﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_5_4
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int sz = 10;
            int[] data = new int[sz];
            for (int i = 0; i < sz; i++)
            {
                data[i] = rnd.Next(1, 100);
                Console.Write("{0} ", data[i]);
            }
            Console.WriteLine();

            Console.Write("50以上の数：");
            foreach (int i in data)
            {
                if (i >= 50)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();

            Console.Write("50未満の数：");
            foreach (int i in data)
            {
                if (i < 50)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}
