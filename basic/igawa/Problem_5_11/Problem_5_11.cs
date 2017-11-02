using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    class Problem_5_11
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int sz = 5;
            int[] data = new int[sz];
            for (int i = 0; i < sz; i++)
            {
                data[i] = rnd.Next(1, 100);
                Console.Write("{0} ", data[i]);
            }
            Console.WriteLine();
            Console.Write("0以上60未満：");
            foreach (int i in data)
            {
                if (i < 60)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
            Console.Write("60以上80未満：");
            foreach (int i in data)
            {
                if (i >= 60 && i < 80)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
            Console.Write("80以上：");
            foreach (int i in data)
            {
                if (i >= 80)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}
